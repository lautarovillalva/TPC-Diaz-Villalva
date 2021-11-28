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
    public partial class Agregar_Color : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("login.aspx");
            }

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            if(tbx_nombre.Text=="" || tbx_codigo.Text == "")
            {
                Response.Write("<script>alert('Completar campos!')</script>");
            }
            else
            {

                Color_neg color_Neg = new Color_neg();
                Color color = new Color
                {
                    Nombre = tbx_nombre.Text,
                    Codigo = tbx_codigo.Text
                };


                color_Neg.agregarColor(color);
                Response.Redirect("Colores.aspx");
            }
            
            
        }
    }
}