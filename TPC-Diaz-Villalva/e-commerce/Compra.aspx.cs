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
    public partial class Compra : System.Web.UI.Page
    {
        public Carrito carrito = new Carrito();
        public Usuario usuario = new Usuario(); 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["lista"] != null)
            {
                carrito.articulos = Session["lista"] as List<Articulo>;

            }
            if (Session["usuario"] != null)
            {
                usuario = Session["usuario"] as Usuario;
            }

            rpCarrito.DataSource = carrito.articulos;
            rpCarrito.DataBind();
            lblTotal.Text ="TOTAL $"+ carrito.montoTotal().ToString();


        }

        protected void btnSumar_Command(object sender, CommandEventArgs e)
        {
            
                if (e.CommandName == "eventoSumar")
                {
                    foreach (Articulo item in carrito.articulos)
                    {
                        if (item.ID.ToString() == e.CommandArgument.ToString())
                        {
                            item.Cantidad++;
                        }
                    }
                    lblTotal.Text = "TOTAL $" + carrito.montoTotal().ToString();
                    rpCarrito.DataBind();
                }
            
        }

        protected void btnRestar_Command(object sender, CommandEventArgs e)
        {
            
                if (e.CommandName == "eventoRestar")
                {
                    foreach (Articulo item in carrito.articulos)
                    {
                        if (item.ID.ToString() == e.CommandArgument.ToString())
                        {
                            item.Cantidad--;
                        }
                    }
                    lblTotal.Text = "TOTAL $" + carrito.montoTotal().ToString();
                    rpCarrito.DataBind();
                }
            
        }

        protected void btnVaciarCarrito_Click(object sender, EventArgs e)
        {
            
                Session["lista"] = null;
                Response.Redirect("/Default.aspx");
            

        }

        protected void btnFinalizarCompra_Click(object sender, EventArgs e)
        {

        }
    }
}