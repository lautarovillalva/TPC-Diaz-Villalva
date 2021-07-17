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
    public partial class Categorias : System.Web.UI.Page
    {
        private int admin = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] != null)
            {
                this.admin = Convert.ToInt32(Session["admin"]);

                if (admin == 1)
                {
                    mostrarCategorias();
                }

            }

            else
            {
                Response.Redirect("login.aspx");
            }

            void mostrarCategorias()
            {
                Categoria_neg categoria_Neg = new Categoria_neg();
                rpCategorias.DataSource = categoria_Neg.ListarCategorias();
                rpCategorias.DataBind();

            }

        }
    }
}