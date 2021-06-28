using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    class AccesoDatos
    {
        readonly String rutaDB = "Data Source=.\\sqlexpress;Initial Catalog=LUNARSOFT_DB;Integrated Security=True";

        public AccesoDatos() { }

        private SqlConnection ObtenerConexion()
        {
            SqlConnection cn = new SqlConnection(rutaDB);

            try
            {
                cn.Open();
                return cn;

            }

            catch (Exception ex)
            {

                return null;
            }

        }


        private SqlDataAdapter ObtenerAdaptador(String consultaSql, SqlConnection cn)
        {
            SqlDataAdapter adaptador;
            try
            {
                adaptador = new SqlDataAdapter(consultaSql, cn);
                return adaptador;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable ObtenerTabla(String NombreTabla, String Sql)
        {
            DataSet ds = new DataSet();
            SqlConnection Conexion = ObtenerConexion();
            SqlDataAdapter adp = ObtenerAdaptador(Sql, Conexion);
            adp.Fill(ds, NombreTabla);
            Conexion.Close();
            return ds.Tables[NombreTabla];
        }


        //Con esta funcion podes realizar cualquier consulta cotra la base de dato sea insert, delete o modificar. 
        // Te devuelve la cantida de filas afectadas.
        public int EjecutarConsulta(string consulta)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection Conexion = ObtenerConexion();
            cmd.Connection = Conexion;

            cmd.CommandText = consulta;
            cmd.CommandType = CommandType.Text;
            int filas = cmd.ExecuteNonQuery();

            Conexion.Close();
            return filas;
        }


    }
}
