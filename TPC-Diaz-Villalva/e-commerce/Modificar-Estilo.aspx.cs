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
    public partial class Modificar_Estilo : System.Web.UI.Page
    {
        public Estilo anterior = new Estilo();
        public Estilo modificado = new Estilo();
        protected void Page_Load(object sender, EventArgs e)
        {
            var idest = Request.QueryString["idest"];
            Estilo_neg estilo_Neg = new Estilo_neg();
            List<Estilo> estilos = new List<Estilo>();
            estilos = estilo_Neg.listarEstilos();

            anterior = estilos.Find(X => X.ID == int.Parse(idest));

            if(!IsPostBack)
            {
                cargarFormulario();
            }

        }

        public void cargarFormulario()
        {
            tbx_nombre.Text = anterior.Nombre;
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            modificado.ID = anterior.ID;
            modificado.Nombre = tbx_nombre.Text;

            
            if (modificado != anterior)
            {
                Estilo_neg estilo_Neg = new Estilo_neg();
                estilo_Neg.modificarEstilo(modificado);
                Response.Redirect("Estilos.aspx");
            }
        }
    }
}