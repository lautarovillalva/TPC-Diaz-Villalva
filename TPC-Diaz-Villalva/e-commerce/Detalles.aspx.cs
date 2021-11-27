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
    public partial class Detalles : System.Web.UI.Page
    {

        public Articulo detalleArticulo;
        public Carrito carrito = new Carrito();

        protected void Page_Load(object sender, EventArgs e)
        {

            buscarArticulo(Convert.ToInt32(Request.QueryString["id"]));

            if (Session["lista"] != null)
            {
                carrito.articulos = Session["lista"] as List<Articulo>;
            }

        }

        public string BuscarDescripcion(int id)
        {
            Articulo_neg articulo_Neg = new Articulo_neg();
            return articulo_Neg.DescripcionArticulo(id);
        }

        public void buscarArticulo(int ID)
        {
            Articulo_neg neg = new Articulo_neg();
            List<Articulo> lista = neg.ListarArticulos();

            foreach(Articulo item in lista)
            {
                if(item.ID == ID)
                {
                    this.detalleArticulo = new Articulo();
                    this.detalleArticulo = item;
                }
            }
           
        }

        public bool ArticuloExistente(string id)
        {
            foreach(Articulo item in carrito.articulos)
            {
                if(item.ID.ToString() == id)
                {
                    return true;
                }
            }

            return false;
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Articulo aux = new Articulo();

            if (!ArticuloExistente(detalleArticulo.ID.ToString()))
            {
                aux = detalleArticulo;
                aux.Cantidad = 1;
                aux.Precio = detalleArticulo.Precio * 1;
                
                carrito.articulos.Add(aux);
            }
            else
            {
                foreach (Articulo item in carrito.articulos)
                {
                    if (item.ID == detalleArticulo.ID)
                    {
                        item.Cantidad++;
                        
                    }

                }
            }
            
            
            Session["lista"] = carrito.articulos;
            Response.Redirect("/default.aspx");
        }
    }
}