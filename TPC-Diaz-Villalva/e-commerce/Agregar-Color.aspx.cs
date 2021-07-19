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

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Color_neg color_Neg = new Color_neg();
            Color nuevo = new Color();

            nuevo.Nombre = tbx_nombre.Text;

            color_Neg.agregarColor(nuevo);
            Response.Redirect("Estilos.aspx");
        }
    }
}