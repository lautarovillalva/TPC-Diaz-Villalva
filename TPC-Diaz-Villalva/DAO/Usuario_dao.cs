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
    }
}
