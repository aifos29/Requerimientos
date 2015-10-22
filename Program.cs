using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Management;

namespace Requerimientos
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            DirectoryInfo currentDir = new DirectoryInfo(Environment.CurrentDirectory);
            string path = string.Format("win32_logicaldisk.deviceid=\"{0}\"",
                currentDir.Root.Name.Replace("\\", ""));
            ManagementObject disk = new ManagementObject(path);
            disk.Get();

            String serial = disk["VolumeSerialNumber"].ToString();
            Conexion_MSS conexion = new Conexion_MSS("null", "null", "Requerimientos", 0);
            conexion.conexion.Open();
            conexion.cmd = new System.Data.SqlClient.SqlCommand("Select usuario from Cuentas where ID='" + serial + "'", conexion.conexion);
            conexion.reader = conexion.cmd.ExecuteReader();
            List<String> cuentas = new List<string>();
            while (conexion.reader.Read())
            {
                cuentas.Add(conexion.reader[0].ToString());
            }
            conexion.reader.Close();
            conexion.conexion.Close();

            if (cuentas.Count() > 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Cuentas(serial,cuentas));


            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Login(serial));
            }
        }
    }
}
