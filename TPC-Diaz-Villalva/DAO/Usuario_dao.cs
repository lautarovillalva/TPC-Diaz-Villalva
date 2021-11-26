using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data;

namespace DAO
{
    public class Usuario_dao
    {
        AccesoDatos accesoDatos = new AccesoDatos();
        public List<Usuario> GetUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();
            string consulta = "SELECT USUARIOS.ID, USUARIOS.MAIL, USUARIOS.CONTRASEÑA, USUARIOS.NOMBRE, USUARIOS.APELLIDO FROM USUARIOS";
            DataTable tabla = accesoDatos.ObtenerTabla("Usuarios", consulta);
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Usuario usuario= new Usuario
                {
                    ID = Convert.ToInt32(tabla.Rows[i][0]),
                    Mail = tabla.Rows[i][1].ToString(),
                    password = tabla.Rows[i][2].ToString(),
                    Nombre = tabla.Rows[i][3].ToString(),
                    Apellido = tabla.Rows[i][4].ToString(),
                    
                };


                lista.Add(usuario);
            }

            return lista;
        }

        public bool setUsuario(Usuario usuario)
        {
            string consulta = "insert into USUARIOS(MAIL, CONTRASEÑA, NOMBRE, APELLIDO) values ('"+usuario.Mail+"', '"+usuario.password+"', '"+usuario.Nombre+"', '"+usuario.Apellido+"')";
            int filas = accesoDatos.EjecutarConsulta(consulta);

            if (filas > 0)
            {
                return true;
            }

            return false;
        }
        public static bool existeUsuario(Usuario usuario)
        {
            string consulta = "select * from USUARIOS where USUARIOS.MAIL='" + usuario.Mail + "'";
            AccesoDatos accesoDatos = new AccesoDatos();
            DataTable tabla = accesoDatos.ObtenerTabla("tabla", consulta);
            if (tabla.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Usuario buscarUsuario(string mail)
        {
            Usuario encontrado = new Usuario();
            AccesoDatos accesoDatos = new AccesoDatos();
            string consulta = "select USUARIOS.ID, USUARIOS.MAIL, USUARIOS.CONTRASEÑA, USUARIOS.NOMBRE, USUARIOS.APELLIDO from USUARIOS where USUARIOS.MAIL='" + mail + "'";
            DataTable tabla = accesoDatos.ObtenerTabla("Usuario", consulta);
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Usuario usuario = new Usuario
                {
                    ID = Convert.ToInt32(tabla.Rows[i][0]),
                    Mail = tabla.Rows[i][1].ToString(),
                    password = tabla.Rows[i][2].ToString(),
                    Nombre = tabla.Rows[i][3].ToString(),
                    Apellido = tabla.Rows[i][4].ToString(),

                };


                encontrado = usuario;
            }

            return encontrado;

        }
    }
}
