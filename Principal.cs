using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics;

namespace Requerimientos
{
    public partial class Principal : Form
    {
        String Usuario;
        List<String> datos;
        Conexion_MSS conexion;
        public Principal(String u, Conexion_MSS conexion)
        {
            Usuario = u;
            this.conexion = conexion;
            conexion.reader.Close();
            InitializeComponent();
            llenardatos();
            permisos();
        }

        private void llenardatos()
        {
            datos = conexion.recoger_datos(Usuario);
            this.lblInicio.Text = "Bienvenido " + " " + datos[0] + " " + datos[1];
            this.txtnombre.Text = datos[0];
            this.txtapellido.Text = datos[1];
            this.txtcorreo.Text = datos[2];
            this.txttelefono.Text = datos[3];

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {


        }

        private void permisos()
        {
            conexion.cmd = new System.Data.SqlClient.SqlCommand("Select OfficeProducts.ID from OfficeProducts inner join ProductosXUsuarios on OfficeProducts.ID=ProductosXUsuarios.Productos inner join Usuario on Usuario.Usuario= ProductosXUsuarios.Usuario and Usuario.Usuario='" + Usuario+"'", conexion.conexion);
            conexion.reader = conexion.cmd.ExecuteReader();
            List <int> programas = new List <int>();

            while (conexion.reader.Read())
            {
                String dato = conexion.reader[0].ToString();
                programas.Add(Int32.Parse(dato));
            }

            conexion.reader.Close();

            foreach (int x in programas)
            {
                if (x == 1)
                {
                    this.btnWord.Enabled = true;
                }
                if (x == 3)
                {
                    this.btnExcel.Enabled = true;
                }
                if (x == 2)
                {
                    this.btnpowerpoint.Enabled = true;
                }
                if (x == 6)
                {
                    this.btnPublisher.Enabled = true;
                }
                if (x == 4)
                {
                    this.btnOnenote.Enabled = true;
                }
                if (x == 7)
                {
                    this.btnAcces.Enabled = true;
                }
                if (x == 5)
                {
                    this.btnoutlook.Enabled = true;
                }

            }


        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            String nombre = txtnombre.Text;
            String apellido = txtapellido.Text;
            String correo = txtcorreo.Text;
            String telefono = txttelefono.Text;

            if (nombre != datos[0] && nombre!=String.Empty)
            {
                conexion.actualizar(Usuario, nombre,"nombre");
            }

            if (apellido != datos[1] && apellido!= String.Empty)
            {
                conexion.actualizar(Usuario,apellido,"apellido");
            }
            if (correo!= datos[2] && correo != String.Empty)
            {
                conexion.actualizar(Usuario, correo,"correo");
            }

            if (telefono!= datos[3] && telefono != String.Empty)
            {
                conexion.actualizar(Usuario, telefono,"telefono");
            }

            llenardatos();
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            ejecutar("C:\\Program Files\\Microsoft Office\\Office15\\WINWORD.exe");

        }
        private void ejecutar(String proceso)
        {
            Process myProcess;
            myProcess = Process.Start(proceso);

            while (!myProcess.HasExited)
            {

                this.Visible = false;
            }

            this.Visible = true;
                       
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

            ejecutar("C:\\Program Files\\Microsoft Office\\Office15\\EXCEL.exe");
        }

        private void btnpowerpoint_Click(object sender, EventArgs e)
        {
            ejecutar("C:\\Program Files\\Microsoft Office\\Office15\\POWERPNT.exe");
        }

        private void btnoutlook_Click(object sender, EventArgs e)
        {
            ejecutar("C:\\Program Files\\Microsoft Office\\Office15\\OUTLOOK.exe");
        }

        private void btnPublisher_Click(object sender, EventArgs e)
        {
            ejecutar("C:\\Program Files\\Microsoft Office\\Office15\\MSPUB.exe");
        }

        private void btnOnenote_Click(object sender, EventArgs e)
        {
            ejecutar("C:\\Program Files\\Microsoft Office\\Office15\\ONENOTE.exe");
        }

        private void btnAcces_Click(object sender, EventArgs e)
        {
            ejecutar("C:\\Program Files\\Microsoft Office\\Office15\\MSACCESS.exe");
        }
    }
    }

