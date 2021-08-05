using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Mail { get; set; }
        public string password { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Dni { get; set; }

        public Usuario()
        {

        }
        public Usuario(int id)
        {
            this.ID = id;
        }
        public Usuario( int id, string mail)
        {
            this.ID = id;
            this.Mail = mail;
        }


    }
}
