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
    public partial class Agregar_Estilos : System.Web.UI.Page
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
            if (tbx_nombre.Text == "")
            {
                Response.Write("<script>alert('Completar campos!')</script>");
            }
            else
            {

            
                Estilo_neg estilo_Neg = new Estilo_neg();
                Estilo nuevo = new Estilo();

                nuevo.Nombre = tbx_nombre.Text;

                estilo_Neg.agregarEstilo(nuevo);
                Response.Redirect("Estilos.aspx");
           
            }
         
        }
    }
}