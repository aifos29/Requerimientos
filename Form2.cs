using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Requerimientos
{
    public partial class Cuentas : Form
    {
        String serial;
        Conexion_MSS conexion;
        public Cuentas(String serial, List<String> cuentas)
        {
            InitializeComponent();
            this.serial = serial;
            conexion = new Conexion_MSS("null", "null", "Requerimientos", 0);
            conexion.conexion.Open();
            this.listcuentas.View = View.Details;
            foreach (String x in cuentas)
            {
                listcuentas.Items.Add(x);
            }

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void listcuentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem x in listcuentas.Items) {
                this.lblCuenta.Text = x.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                conexion.cmd = new System.Data.SqlClient.SqlCommand("Select Password from Usuario where Usuario ='" + lblCuenta.Text + "'", conexion.conexion);

                conexion.reader = conexion.cmd.ExecuteReader();
                String pass = "";
                while (conexion.reader.Read())
                {
                    pass = conexion.reader[0].ToString();
                }
                conexion.reader.Close();
                if (pass == txtpass.Text)
                {
                    
                    Principal x = new Principal(this.lblCuenta.Text, conexion);
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
                MessageBox.Show("Problemas"+ex.ToString());
            }

        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
           
           
            foreach (ListViewItem x in listcuentas.Items)
            {   
                
                listcuentas.Items.Remove(x);
                conexion.cmd = new System.Data.SqlClient.SqlCommand("Delete from Cuentas where Usuario='" + x.Text + "'", conexion.conexion);
                conexion.cmd.ExecuteNonQuery();
            }
            this.lblCuenta.Text = "Seleccione una cuenta";
            if (listcuentas.Items.Count == 0)
            {
                conexion.conexion.Close();
                Login l = new Login(serial);
                l.Visible = true;
                this.Visible = false;
                

            }
        }
    }
}
