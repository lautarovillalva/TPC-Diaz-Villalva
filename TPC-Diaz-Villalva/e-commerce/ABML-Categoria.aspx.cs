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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarDgvCategoria();
        }
        public void cargarDgvCategoria()
        {
            Categoria_neg categoria_Neg = new Categoria_neg();
            dgv_Categoria.DataSource = categoria_Neg.ListarCategorias();
            dgv_Categoria.DataBind();
        }

        protected void dgv_Categoria_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            string id = ((Label)dgv_Categoria.Rows[e.NewSelectedIndex].FindControl("lbl_it_Id")).Text;
            string nombre = ((Label)dgv_Categoria.Rows[e.NewSelectedIndex].FindControl("lbl_it_Nombre")).Text;

            lbl_Mensaje.Text = "SELECCIONADO: " + id + " " + nombre;
        }

        protected void dgv_Categoria_RowEditing(object sender, GridViewEditEventArgs e)
        {

            dgv_Categoria.EditIndex = e.NewEditIndex;
            cargarDgvCategoria();
        }

        protected void dgv_Categoria_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            dgv_Categoria.EditIndex = -1;
            cargarDgvCategoria();
        }

        protected void dgv_Categoria_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string id = ((Label)dgv_Categoria.Rows[e.RowIndex].FindControl("lbl_eit_Id")).Text;
            string nombre = ((TextBox)dgv_Categoria.Rows[e.RowIndex].FindControl("tbx_Nombre")).Text;

            Categoria actualizado = new Categoria
            {
                ID = Convert.ToInt32(id),
                Nombre = nombre
            };

            Categoria_neg categoria_Neg = new Categoria_neg();
            categoria_Neg.modificarCategoria(actualizado);
            dgv_Categoria.EditIndex = -1;
            cargarDgvCategoria();
        }

        protected void dgv_Categoria_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string id = ((Label)dgv_Categoria.Rows[e.RowIndex].FindControl("lbl_it_Id")).Text;

            Categoria categoria = new Categoria();
            categoria.ID = Convert.ToInt32(id);


            // no va a dejar eliminarlo porque la bbd toma las categorias en ARTICULOS
            
            Categoria_neg categoria_Neg = new Categoria_neg();
            categoria_Neg.eliminarCategoria(categoria);

            cargarDgvCategoria();
        }
    }
}