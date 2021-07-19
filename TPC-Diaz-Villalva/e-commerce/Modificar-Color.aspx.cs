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
    public partial class Modificar_Color : System.Web.UI.Page
    {
        public Color anterior = new Color();
        public Color modificado = new Color();
        protected void Page_Load(object sender, EventArgs e)
        {
            var idest = Request.QueryString["idcol"];
            Color_neg color_Neg = new Color_neg();
            List<Color> colors = new List<Color>();
            colors = color_Neg.ListarColores();

            anterior = colors.Find(X => X.ID == int.Parse(idest));

            if (!IsPostBack)
            {
                cargarFormulario();
            }

        }
        public void cargarFormulario()
        {
            tbx_codigo.Text = anterior.Codigo;
            tbx_nombre.Text = anterior.Nombre;

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            modificado.ID = anterior.ID;
            modificado.Nombre = tbx_nombre.Text;
            modificado.Codigo = tbx_codigo.Text;

            if (modificado != anterior)
            {
                Color_neg color_Neg = new Color_neg();
                color_Neg.modificarColor(modificado);
                Response.Redirect("Colores.aspx");
            }

        }
    }
}