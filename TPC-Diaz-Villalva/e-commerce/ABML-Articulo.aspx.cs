using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace e_commerce
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                cargarDgvArticulos();
                
            }

        }

        public void cargarDgvArticulos()
        {
            Articulo_neg articulo_Neg = new Articulo_neg();
            dgvArticulos.DataSource = articulo_Neg.ListarArticulos();
            dgvArticulos.DataBind();

        }

        protected void dgvArticulos_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            string id = ((Label)dgvArticulos.Rows[e.NewSelectedIndex].FindControl("lbl_it_Id")).Text;
            string nombre = ((Label)dgvArticulos.Rows[e.NewSelectedIndex].FindControl("lbl_it_Nombre")).Text;
            string precio = ((Label)dgvArticulos.Rows[e.NewSelectedIndex].FindControl("lbl_it_Precio")).Text;
            string cantidad = ((Label)dgvArticulos.Rows[e.NewSelectedIndex].FindControl("lbl_it_Cantidad")).Text;
            string imagen = ((Label)dgvArticulos.Rows[e.NewSelectedIndex].FindControl("lbl_it_Imagen")).Text;
            string categoria = ((Label)dgvArticulos.Rows[e.NewSelectedIndex].FindControl("lbl_it_Categoria")).Text;
            string composicion = ((Label)dgvArticulos.Rows[e.NewSelectedIndex].FindControl("lbl_it_Composicion")).Text;
            string medida = ((Label)dgvArticulos.Rows[e.NewSelectedIndex].FindControl("lbl_it_Medida")).Text;
            string estilo = ((Label)dgvArticulos.Rows[e.NewSelectedIndex].FindControl("lbl_it_Estilo")).Text;
            string color = ((Label)dgvArticulos.Rows[e.NewSelectedIndex].FindControl("lbl_it_Color")).Text;

            lblMensaje.Text = "SELECCIONADO: "+ id+" "+ nombre;
        }

        protected void dgvArticulos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string id = ((Label)dgvArticulos.Rows[e.RowIndex].FindControl("lbl_it_Id")).Text;

            Articulo articulo = new Articulo();
            articulo.ID = Convert.ToInt32(id);


            // no va a dejar eliminarlo porque la bbd toma los articulos para ARTICULOS_X_VENTA
            // podriamos hacer una baja logica articulos.cantidad()=0 y listar solo articulos.cantidad()>0
            Articulo_neg articulo_Neg = new Articulo_neg();
            articulo_Neg.eliminarArticulo(articulo);

            cargarDgvArticulos();
        }

        protected void dgvArticulos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            
            dgvArticulos.EditIndex = e.NewEditIndex;
            cargarDgvArticulos();
            
        }

        protected void dgvArticulos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            dgvArticulos.EditIndex = -1;
            cargarDgvArticulos();
        }

        protected void dgvArticulos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string id = ((Label)dgvArticulos.Rows[e.RowIndex].FindControl("lbl_eit_Id")).Text;
            string nombre = ((TextBox)dgvArticulos.Rows[e.RowIndex].FindControl("tbx_Nombre")).Text;
            string precio = ((TextBox)dgvArticulos.Rows[e.RowIndex].FindControl("tbx_eit_Precio")).Text;
            string cantidad = ((TextBox)dgvArticulos.Rows[e.RowIndex].FindControl("tbx_eit_Cantidad")).Text;
            string imagen = ((TextBox)dgvArticulos.Rows[e.RowIndex].FindControl("tbx_eit_Imagen")).Text;
            string categoria = ((DropDownList)dgvArticulos.Rows[e.RowIndex].FindControl("ddl_eit_Categoria")).Text;
            string composicion = ((DropDownList)dgvArticulos.Rows[e.RowIndex].FindControl("ddl_eit_Composicion")).Text;
            string medida = ((DropDownList)dgvArticulos.Rows[e.RowIndex].FindControl("ddl_eit_Medida")).Text;
            string estilo = ((DropDownList)dgvArticulos.Rows[e.RowIndex].FindControl("ddl_eit_Estilo")).Text;
            string color = ((DropDownList)dgvArticulos.Rows[e.RowIndex].FindControl("ddl_eit_Color")).Text;

            Articulo actualizado = new Articulo();

            Categoria cat = new Categoria();
            cat.ID = Convert.ToInt32(categoria);
            Composicion comp = new Composicion();
            comp.ID = Convert.ToInt32(composicion);
            Medida med = new Medida();
            med.ID = Convert.ToInt32(medida);
            Estilo est = new Estilo();
            est.ID = Convert.ToInt32(estilo);
            Color col = new Color();
            col.ID = Convert.ToInt32(color);

            actualizado.ID = Convert.ToInt32(id);
            actualizado.Nombre = nombre;
            actualizado.Precio = Convert.ToDouble(precio);
            actualizado.Cantidad = Convert.ToInt32(cantidad);
            actualizado.Imagen = imagen;
            actualizado.categoria = cat;
            actualizado.composicion = comp;
            actualizado.medida =med ;
            actualizado.estilo = est;
            actualizado.color =col ;

            Articulo_neg articulo_Neg = new Articulo_neg();
            articulo_Neg.modificarArticulo(actualizado);
            dgvArticulos.EditIndex = -1;
            cargarDgvArticulos();
        }
    }
}