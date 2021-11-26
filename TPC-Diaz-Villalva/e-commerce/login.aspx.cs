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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            if(txtMail.Text == "admin" && txtContraseña1.Text == "admin")
            {
                Session["admin"] = 1;
                Response.Redirect("admin.aspx");
            }


            Usuario usuario = new Usuario
            {
                Mail = txtMail.Text,
                password = txtContraseña1.Text
            };
            if (usuario.password == "" || usuario.Mail == "")
            {
                Response.Write("<script>alert('Completar campos!')</script>");
            }
            else if (Usuario_neg.existeUsuario(usuario))
            {
                if (Usuario_neg.buscarUsuario(txtMail.Text).password != txtContraseña1.Text)
                {
                    Response.Write("<script>alert('Contraseña incorrecta!')</script>");
                    Response.AddHeader("REFRESH", "0;URL=/login.aspx");

                }
                else
                {

                usuario = Usuario_neg.buscarUsuario(txtMail.Text);
                Session["usuario"] = usuario;

                Response.Write("<script>alert('Iniciaste sesión!')</script>");
                Response.AddHeader("REFRESH", "0;URL=/Default.aspx");
                }

            }
            else
            {
                Response.Write("<script>alert('Usuario no registrado!')</script>");
            }


        }

    }
}