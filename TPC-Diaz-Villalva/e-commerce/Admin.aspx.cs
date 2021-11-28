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
    public partial class Admin : System.Web.UI.Page
    {
        public int CantArticulos;
        public int CantUsuarios;
        public string graficoCircular = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            
                if (Session["admin"] == null)
                {
                    Response.Redirect("login.aspx");
                }


                totalArticulos();
                totalUsuarios();

                Categoria_neg cat = new Categoria_neg();
                graficoCircular = cat.getTotal();
            

        }


        //Pendiente de hacer igual que los demas para eso tenes que terminar de DAO la clase de ventas y mostrar la ganacia total en $
        public void totalVentas()
        {
            
        }

        public void totalArticulos() {

            Articulo_neg art = new Articulo_neg();
            List<Articulo> lista = art.ListarArticulos();

            CantArticulos = lista.Count();
        }

        public void totalUsuarios() {
            Usuario_neg us = new Usuario_neg();
            List<Usuario> lista = us.ListarUsuarios();

            CantUsuarios = lista.Count();
        }

    }
}