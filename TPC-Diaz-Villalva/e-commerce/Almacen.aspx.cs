﻿using System;
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

        public List<Articulo> listaParaEliminar;
        private List<Articulo> listaVisibles;
        private List<Articulo> listaNoVisibles;


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
            listaVisibles = new List<Articulo>();
            listaNoVisibles = new List<Articulo>();



            foreach (Articulo item in lista)
            {
                if(item.visible == 1)
                {
                    listaVisibles.Add(item);
                }

                else
                {
                    listaNoVisibles.Add(item);
                }
            }

            rpAdminArticulo.DataSource = listaVisibles;
            rpAdminArticulo.DataBind();

            rpAdminArticuloPapelera.DataSource = listaNoVisibles;
            rpAdminArticuloPapelera.DataBind();


        }

        protected void btnEliminarProducto_Command(object sender, CommandEventArgs e)
        {
            Articulo_neg art = new Articulo_neg();

            if ( e.CommandName == "eventoEliminar")
            {
                art.bajaArticulo(e.CommandArgument.ToString(), true);
                mostrarArticulos();
            }
        }

        protected void btnSalvar_Command(object sender, CommandEventArgs e)
        {
            Articulo_neg art = new Articulo_neg();

            if (e.CommandName == "eventoEliminar")
            {
                art.bajaArticulo(e.CommandArgument.ToString(), false);
                mostrarArticulos();
            }
        }

     

        protected void btnEliminarSeleccion_Click(object sender, EventArgs e)
        {
                 listaParaEliminar = new List<Articulo>();
                 Articulo_neg art = new Articulo_neg();

                 int cont = 0;
                
                 foreach (RepeaterItem articulo in rpAdminArticuloPapelera.Items)
                 {
                     cont++;
                     CheckBox i = articulo.FindControl("chkSeleccion") as CheckBox;

                     if (Request.Form[i.UniqueID] != null && Request.Form[i.UniqueID] == "on")
                     {
                         listaParaEliminar.Add(listaNoVisibles[cont - 1]);
                    
                     }
                
                 }

                 Label1.Text = "";

                 foreach (Articulo item in listaParaEliminar)
                 { 
                     art.eliminarArticulo(item);
                 }

                 mostrarArticulos();

        }
    }
}