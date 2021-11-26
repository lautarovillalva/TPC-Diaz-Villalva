using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Dominio;

namespace Negocio
{
    public class Usuario_neg
    {
        private Usuario_dao aux = new Usuario_dao();
        public List<Usuario> ListarUsuarios()
        {
            return aux.GetUsuarios();
        }
        public bool agregarUsuario(Usuario usuario)
        {
            return aux.setUsuario(usuario);
        }
        public static bool existeUsuario(Usuario usuario)
        {
            return Usuario_dao.existeUsuario(usuario);
        }
        public static Usuario buscarUsuario(string mail)
        {
            return Usuario_dao.buscarUsuario(mail);
        }

    }
}
