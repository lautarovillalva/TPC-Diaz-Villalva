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
    public partial class Modificar_Categoria : System.Web.UI.Page
    {
        public Categoria anterior = new Categoria();
        public Categoria modificado = new Categoria();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("login.aspx");
            }
            var idcat = Request.QueryString["idcat"];
            Categoria_neg categoria_Neg = new Categoria_neg();
            List<Categoria> categorias = new List<Categoria>();
            categorias = categoria_Neg.ListarCategorias();

            anterior = categorias.Find(X => X.ID == int.Parse(idcat));

            if (!IsPostBack)
            {
                cargarFormulario();
            }

        }

        void cargarFormulario()
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
                    Categoria_neg categoria_Neg = new Categoria_neg();
                    categoria_Neg.modificarCategoria(modificado);
                    Response.Redirect("Categorias.aspx");
                }
            


        }

        protected void btnVisible_Click(object sender, EventArgs e)
        {
            modificado.ID = anterior.ID;

            modificado.Nombre = tbx_nombre.Text;
            if (modificado != anterior)
            {
                modificado.Visible =! anterior.Visible;

                Categoria_neg categoria_Neg = new Categoria_neg();
                categoria_Neg.modificarCategoria(modificado);
                Response.Redirect("Categorias.aspx");
            }
            else
            {
                anterior.Visible = !anterior.Visible;

                Categoria_neg categoria_Neg = new Categoria_neg();
                categoria_Neg.modificarCategoria(anterior);
                Response.Redirect("Categorias.aspx");
            }

        }
    }
}