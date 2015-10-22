using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.IO;

namespace Requerimientos
{
    public partial class Login : Form
    {
        String serial;
        public Login(String serial)
        {
            this.serial = serial;
            
                
                InitializeComponent();
            
        }

        

        private void Login_Load(object sender, EventArgs e)
        {
            if (txtUsuario.Text == String.Empty) 
            {
                txtUsuario.Text = "Usuario";
            }
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            Conexion_MSS conexion = new Conexion_MSS("null", "null", "Requerimientos", 0);
            try
            {
                conexion.conexion.Open();
                conexion.cmd = new System.Data.SqlClient.SqlCommand("Select Password from Usuario where Usuario ='" + txtUsuario.Text + "'", conexion.conexion);
             
                conexion.reader = conexion.cmd.ExecuteReader();
                String pass="";
                while (conexion.reader.Read())
                {
                    pass = conexion.reader[0].ToString();
                }
                conexion.reader.Close();
                if (pass == txtpass.Text)
                {
                    conexion.cmd = new System.Data.SqlClient.SqlCommand("Insert into Cuentas(Usuario,ID) values ('" + this.txtUsuario.Text + "','" + serial + "')", conexion.conexion);
                    conexion.cmd.ExecuteNonQuery();               
                            Principal x = new Principal(this.txtUsuario.Text,conexion);
                            x.Visible = true;
                        this.Visible = false;
                        
                            
                    }
                    else
                    {
                        MessageBox.Show("Auntentificación Incorrecta");
                    }
                
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Problemas");
            }
           
          
        }
    }
}
