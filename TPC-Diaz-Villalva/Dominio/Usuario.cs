using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Usuario
    {
        int ID { get; set; }
        string Mail { get; set; }
        string password { get; set; }
        string Nombre { get; set; }
        string Apellido { get; set; }
        DateTime FechaNacimiento { get; set; }


       public Usuario()
        {

        }


    }
}
