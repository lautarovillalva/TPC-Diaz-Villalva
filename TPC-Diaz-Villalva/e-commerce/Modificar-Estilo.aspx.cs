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
            if (Session["admin"] == null)
            {
                Response.Redirect("login.aspx");
            }
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
            try
            {
                tbx_nombre.Text = anterior.Nombre;
            }
            catch (Exception ex)
            {

                string error = ex.ToString();
                Session["error"] = error;
                Response.Redirect("/Error.aspx");
            }
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

        protected void btnVisible_Click(object sender, EventArgs e)
        {
            modificado.ID = anterior.ID;

            modificado.Nombre = tbx_nombre.Text;
            if (modificado != anterior)
            {
                modificado.Visible = !anterior.Visible;

                Estilo_neg estilo_Neg= new Estilo_neg();
                estilo_Neg.modificarEstilo(modificado);
                Response.Redirect("Estilos.aspx");
            }
            else
            {
                anterior.Visible = !anterior.Visible;

                Estilo_neg estilo_Neg= new Estilo_neg();
                estilo_Neg.modificarEstilo(anterior);
                Response.Redirect("Estilos.aspx");
            }
        }
    }
}