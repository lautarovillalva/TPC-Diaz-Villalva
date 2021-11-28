using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace e_commerce
{
    public partial class Crear_cuenta : System.Web.UI.Page
    {
        private Usuario usuario = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            
                usuario.Nombre = txtNombre.Text;
                usuario.Apellido = txtApellido.Text;
                usuario.Mail = txtMail.Text;

                if (txtContraseña1.Text == "" || txtContraseña2.Text == "" || txtApellido.Text == "" || txtMail.Text == "" || txtNombre.Text == "")
                {
                    //txtMail.Text = "";
                    //txtNombre.Text = "";
                    //txtApellido.Text = "";
                    //txtContraseña1.Text = "";
                    //txtContraseña2.Text = "";
                    Response.Write("<script>alert('Completar campos!')</script>");
                }
                else if (txtContraseña1.Text != txtContraseña2.Text)
                {
                    txtContraseña1.Text = "";
                    txtContraseña2.Text = "";
                    Response.Write("<script>alert('Contraseña incorrecta!')</script>");
                }
                else if (Usuario_neg.existeUsuario(usuario) == true)
                {
                    txtMail.Text = "";
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtContraseña1.Text = "";
                    txtContraseña2.Text = "";
                    Response.Write("<script>alert('El usuario ya existe!')</script>");
                }
                else
                {
                    usuario.password = txtContraseña1.Text;
                    Usuario_neg usuario_Neg = new Usuario_neg();
                    usuario_Neg.agregarUsuario(usuario);
                    Session["usuario"] = usuario;
                    Response.Write("<script>alert('Usuario registrado!')</script>");
                    Response.AddHeader("REFRESH", "0;URL=/inicio.aspx");
                }
            


        }
    }

}