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
    public partial class Agregar_Articulo : System.Web.UI.Page
    {
        Articulo nuevo = new Articulo();
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarDropdownlists();

        }
        void cargarDropdownlists()
        {
            Categoria_neg categoria_Neg = new Categoria_neg();
            Estilo_neg estilo_Neg = new Estilo_neg();
            Color_neg color_Neg = new Color_neg();
            Composicion_neg composicion_Neg = new Composicion_neg();
            Medida_neg medida_Neg = new Medida_neg();

            ddl_medidas.DataSource = medida_Neg.ListarMedidas();
            ddl_medidas.DataBind();
            ddl_composiciones.DataSource = composicion_Neg.ListarComposiciones();
            ddl_composiciones.DataBind();
            ddl_categorias.DataSource = categoria_Neg.ListarCategorias();
            ddl_categorias.DataBind();
            ddl_estilos.DataSource = estilo_Neg.listarEstilos();
            ddl_estilos.DataBind();
            ddl_colores.DataSource = color_Neg.ListarColores();
            ddl_colores.DataBind();

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            List<Categoria> categorias = new List<Categoria>();
            Categoria_neg categoria_Neg = new Categoria_neg();
            categorias = categoria_Neg.ListarCategorias();
            Categoria categoria_nuevo = new Categoria();
            categoria_nuevo = categorias.Find(X => X.Nombre == ddl_categorias.SelectedValue);

            List<Color> colors = new List<Color>();
            Color_neg color_Neg = new Color_neg();
            colors = color_Neg.ListarColores();
            Color color_nuevo = new Color();
            color_nuevo = colors.Find(X => X.Codigo == ddl_colores.SelectedValue);

            List<Composicion> composiciones = new List<Composicion>();
            Composicion_neg composicion_Neg = new Composicion_neg();
            composiciones = composicion_Neg.ListarComposiciones();
            Composicion composicion_nuevo = new Composicion();
            composicion_nuevo = composiciones.Find(X => X.Nombre == ddl_composiciones.SelectedValue);

            List<Estilo> estilos = new List<Estilo>();
            Estilo_neg estilo_Neg = new Estilo_neg();
            estilos = estilo_Neg.listarEstilos();
            Estilo estilo_nuevo = new Estilo();
            estilo_nuevo = estilos.Find(X => X.Nombre == ddl_estilos.SelectedValue);

            List<Medida> medidas = new List<Medida>();
            Medida_neg medida_Neg = new Medida_neg();
            medidas = medida_Neg.ListarMedidas();
            Medida medida_nuevo = new Medida();
            medida_nuevo = medidas.Find(X => X.Nombre == ddl_medidas.SelectedValue);

            nuevo.Nombre = tbx_nombre.Text;
            nuevo.Imagen = tbx_imagen.Text;
            nuevo.Precio = Convert.ToDouble(tbx_precio.Text);
            nuevo.Cantidad = Convert.ToInt32(tbx_cantidad.Text);
            nuevo.categoria = categoria_nuevo;
            nuevo.color = color_nuevo;
            nuevo.composicion = composicion_nuevo;
            nuevo.estilo = estilo_nuevo;
            nuevo.medida = medida_nuevo;

            Articulo_neg articulo_Neg = new Articulo_neg();
            articulo_Neg.agregarArticulo(nuevo);

            Response.Redirect("Almacen.aspx");
        }
    }
}