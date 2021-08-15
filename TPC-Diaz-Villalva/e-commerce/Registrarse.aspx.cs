using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
namespace e_commerce
{
    public partial class Registrarse : System.Web.UI.Page
    {
        Usuario nuevo_usuario = new Usuario();
        List<Usuario> usuarios = new List<Usuario>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private bool CargarUsuario()
        {
            bool nuevo = true;
            nuevo_usuario.Apellido = txtApellido.Text;
            nuevo_usuario.Nombre = txtNombre.Text;
            nuevo_usuario.Mail = txtUsuario.Text;

            Usuario_neg usuario_Neg = new Usuario_neg();
            usuarios = usuario_Neg.ListarUsuarios();

            foreach (Usuario item in usuarios)
            {
                if (item.Mail == nuevo_usuario.Mail)
                {
                    txtApellido.Text = "";
                    txtNombre.Text = "";
                    txtPassword.Text = "";
                    txtUsuario.Text = "USUARIO YA REGISTRADO.";

                    nuevo = false;
                }
            }

            return nuevo;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (CargarUsuario())
            {
                Usuario_neg usuario_Neg = new Usuario_neg();

                if (usuario_Neg.agregarUsuario(nuevo_usuario))
                {
                    Response.Redirect("Productos.aspx");
                }

            }
            
        }
    }
}