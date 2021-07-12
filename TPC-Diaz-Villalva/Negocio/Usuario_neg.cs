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

        public List<Usuario> ListarUsuarios()
        {
            Usuario_dao us = new Usuario_dao();
            return us.GetUsuarios();
        }

    }
}
