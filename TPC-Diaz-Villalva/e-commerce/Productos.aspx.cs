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
            if (!Page.IsPostBack)
            {
            cargarCheckboxLists();
            mostrarArticulos();

            }
            
        }
        void cargarCheckboxLists()
        {
            Categoria_neg categoria = new Categoria_neg();
            cbl_categorias.DataSource = categoria.ListarCategorias();
            cbl_categorias.DataBind();

            Estilo_neg estilo_Neg = new Estilo_neg();
            cbl_estilos.DataSource = estilo_Neg.listarEstilos();
            cbl_estilos.DataBind();

            Medida_neg medida_Neg= new Medida_neg();
            cbl_medidas.DataSource = medida_Neg.ListarMedidas();
            cbl_medidas.DataBind();

        }
        public void mostrarArticulos()
        {
            
            Articulo_neg art = new Articulo_neg();
            rpArticulos.DataSource = art.ArticulosFiltrados(Request.QueryString["valor"]);
            rpArticulos.DataBind();
        }

        protected void btn_filtrar_Click(object sender, EventArgs e)
        {
            List<Articulo> articulos_filtrados = new List<Articulo>();
            Articulo_neg articulo_Neg = new Articulo_neg();

            for (int i = 0; i < cbl_categorias.Items.Count; i++)
            {
                if (cbl_categorias.Items[i].Selected==true)
                {
                    articulos_filtrados.AddRange(articulo_Neg.ArticulosFiltrados(cbl_categorias.Items[i].Text));
                }
            }
            for (int i = 0; i < cbl_estilos.Items.Count; i++)
            {
                if (cbl_estilos.Items[i].Selected == true)
                {
                    articulos_filtrados.AddRange(articulo_Neg.ArticulosFiltrados(cbl_estilos.Items[i].Text));
                }

            }
            for (int i = 0; i < cbl_medidas.Items.Count; i++)
            {
                if (cbl_medidas.Items[i].Selected == true)
                {
                    articulos_filtrados.AddRange(articulo_Neg.ArticulosFiltrados(cbl_medidas.Items[i].Text));
                }

            }
            if(articulos_filtrados.Count==0)
            {
                mostrarArticulos();
            }
            else
            {
                rpArticulos.DataSource = articulos_filtrados;
                rpArticulos.DataBind();
            }
        }
    }
}