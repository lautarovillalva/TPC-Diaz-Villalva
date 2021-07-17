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
            tbx_nombre.Text = anterior.Nombre;
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            modificado.ID = anterior.ID;

            modificado.Nombre = tbx_nombre.Text;
            if(modificado!=anterior)
            {
                Categoria_neg categoria_Neg = new Categoria_neg();
                categoria_Neg.modificarCategoria(modificado);
                Response.Redirect("Categorias.aspx");
            }


        }
    }
}