using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Requerimientos
{
    public class Conexion_MSS
    {
       public String user;
       public  String pass;
       public  String nbase;
       public  SqlConnection conexion;
        public SqlCommand cmd;
        public SqlDataReader reader;

        public Conexion_MSS(String u,String pass,String bd,int tipo)
        {
            user = u;
            this.pass = pass;
            nbase = bd;
            if (tipo == 0)
            {
                conexion = new SqlConnection("Data Source=.;Initial Catalog=" + nbase + ";Integrated Security=True");
            }
            if (tipo == 1)
            {
                conexion = new SqlConnection("Data Source=.;Initial Catalog=" + nbase + ";user id=" + user + ";password=" + pass);
            }

            
        }

        public List<String> recoger_datos (String usuario)
        {
            List<String> datos = new List<string>();
            cmd = new SqlCommand("Select nombre,apellido,correo,telefono from persona where Usuario='"+usuario+"'", conexion);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                datos.Add(reader[0].ToString());
                datos.Add(reader[1].ToString());
                datos.Add(reader[2].ToString());
                datos.Add(reader[3].ToString());


            }
            reader.Close();
                return datos;
        }

        internal void actualizar(string usuario, string nombre,string campo)
        {
           
            cmd = new SqlCommand("update Persona set " +campo + " = '"+nombre + "' where usuario = '"+usuario+"'",conexion);
            cmd.ExecuteNonQuery();
            reader.Close();
        }
    }
}
