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
    public partial class Productos : System.Web.UI.Page
    {

      
        protected void Page_Load(object sender, EventArgs e)
        {
                if (!IsPostBack)
                {
                    mostrarArticulos();
                    CargarDropbox();
                }

        }


        public void CargarDropbox()
        {

            //Categoria_neg categoria_Neg = new Categoria_neg();
            //drpCategorias.DataSource = categoria_Neg.ListarCategorias();
            //drpCategorias.DataBind();

         
        }

        public void mostrarArticulos()
        {

            try
            {
                List<Articulo> articulosVisibles = new List<Articulo>();
                Articulo_neg art = new Articulo_neg();
                foreach (Articulo item in art.ArticulosFiltrados(Request.QueryString["valor"], true))
                {
                    if (item.visible == true)
                        articulosVisibles.Add(item);

                }


                rpArticulos.DataSource = articulosVisibles;
                rpArticulos.DataBind();
            }
            catch (Exception ex)
            {

                string error = ex.ToString();
                Session["error"] = error;
                Response.Redirect("/Error.aspx");
            }
        }

        //protected void btn_filtrar_Click(object sender, EventArgs e)
        //{


        //    Articulo_neg art = new Articulo_neg();

        //    string categoria = drpCategorias.SelectedItem.Text;
        //    rpArticulos.DataSource = art.armarFiltro(categoria, drpEstilos.SelectedItem.Text, drpCompsiciones.SelectedItem.Text, drpMedidas.SelectedItem.Text);
        //    rpArticulos.DataBind();
        //}


    }
}