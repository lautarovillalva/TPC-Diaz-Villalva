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
    public partial class Almacen : System.Web.UI.Page
    {
        public int id_aux;
        private int admin = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
           

            if (Session["admin"] != null)
            {
                this.admin = Convert.ToInt32(Session["admin"]);

                if (admin == 1)
                {
                    mostrarArticulos();
                }

            }

            else
            {
                Response.Redirect("login.aspx");
            }

        }

        public void mostrarArticulos()
        {

            Articulo_neg art = new Articulo_neg();
            List<Articulo> lista = art.ListarArticulos();
            List<Articulo> listaVisibles = new List<Articulo>();

            foreach(Articulo item in lista)
            {
                if(item.visible == 1)
                {
                    listaVisibles.Add(item);
                }
            }

            rpAdminArticulo.DataSource = listaVisibles;
            rpAdminArticulo.DataBind();
           
        }

        protected void btnEliminarProducto_Command(object sender, CommandEventArgs e)
        {
            Articulo_neg art = new Articulo_neg();

            if ( e.CommandName == "eventoEliminar")
            {
                art.bajaArticulo(e.CommandArgument.ToString());
                mostrarArticulos();
            }
        }
    }
}