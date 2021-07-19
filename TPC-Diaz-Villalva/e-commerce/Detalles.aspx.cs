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
        public List<Carrito> carrito = new List<Carrito>();

        protected void Page_Load(object sender, EventArgs e)
        {

            buscarArticulo(Convert.ToInt32(Request.QueryString["id"]));

            if (Session["lista"] != null)
            {
                carrito = Session["lista"] as List<Carrito>;
            }

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
            foreach(Carrito item in carrito)
            {
                if(item.Articulo.ID.ToString() == id)
                {
                    return true;
                }
            }

            return false;
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {

            if (!ArticuloExistente(detalleArticulo.ID.ToString()))
            {
                Carrito aux = new Carrito
                {
                    Articulo = detalleArticulo,
                    Cantidad = 1,
                    Total = detalleArticulo.Precio * 1
                    
                };

                carrito.Add(aux);
            }


            Session["lista"] = carrito;
        }
    }
}