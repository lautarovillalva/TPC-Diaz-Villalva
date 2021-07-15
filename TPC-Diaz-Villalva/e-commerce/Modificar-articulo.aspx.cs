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
    public partial class Modificar_articulo : System.Web.UI.Page
    {
        public Articulo anterior = new Articulo();
        public Articulo modificado = new Articulo();

        protected void Page_Load(object sender, EventArgs e)
        {
            var idprod = Request.QueryString["idprod"];

            Articulo_neg articulo_Neg = new Articulo_neg();
            List<Articulo> articulos = articulo_Neg.ListarArticulos();

            anterior = articulos.Find(X => X.ID == int.Parse(idprod));

            if (!IsPostBack)
            {
                cargarformulario();
            }

        }
        void cargarformulario()
        {
            lbl_id.Text = anterior.ID.ToString();
            tbx_nombre.Text = anterior.Nombre;
            tbx_precio.Text = anterior.Precio.ToString();
            tbx_cantidad.Text = anterior.Cantidad.ToString();
            tbx_imagen.Text = anterior.Imagen.ToString();

            cargarDropdownlists();

            ddl_categorias.SelectedValue = anterior.categoria.ToString();
            ddl_estilos.SelectedValue = anterior.estilo.ToString();
            ddl_colores.SelectedValue = anterior.color.ToString();
            ddl_composiciones.SelectedValue = anterior.composicion.ToString();
            ddl_medidas.SelectedValue = anterior.medida.ToString();

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

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            cargarModificado();
            if (modificado != anterior)
            {
                Articulo_neg articulo_Neg = new Articulo_neg();
                articulo_Neg.modificarArticulo(modificado);

                Response.Redirect("Almacen.aspx");
            }


            
        }

        void cargarModificado()
        {
            List<Categoria> categorias = new List<Categoria>();
            Categoria_neg categoria_Neg = new Categoria_neg();
            categorias = categoria_Neg.ListarCategorias();
            Categoria categoria_modificado = new Categoria();
            categoria_modificado = categorias.Find(X => X.Nombre == ddl_categorias.SelectedItem.Text);

            List<Color> colors = new List<Color>();
            Color_neg color_Neg = new Color_neg();
            colors = color_Neg.ListarColores();
            Color color_modificado = new Color();
            color_modificado = colors.Find(X => X.Codigo == ddl_colores.SelectedItem.Text);

            List<Composicion> composiciones = new List<Composicion>();
            Composicion_neg composicion_Neg = new Composicion_neg();
            composiciones = composicion_Neg.ListarComposiciones();
            Composicion composicion_modificado = new Composicion();
            composicion_modificado = composiciones.Find(X => X.Nombre == ddl_composiciones.SelectedItem.Text);

            List<Estilo> estilos = new List<Estilo>();
            Estilo_neg estilo_Neg = new Estilo_neg();
            estilos = estilo_Neg.listarEstilos();
            Estilo estilo_modificado = new Estilo();
            estilo_modificado = estilos.Find(X => X.Nombre == ddl_estilos.SelectedItem.Text);

            List<Medida> medidas = new List<Medida>();
            Medida_neg medida_Neg = new Medida_neg();
            medidas = medida_Neg.ListarMedidas();
            Medida medida_modificado = new Medida();
            medida_modificado = medidas.Find(X => X.Nombre == ddl_medidas.SelectedItem.Text);

            modificado.ID = Convert.ToInt32(lbl_id.Text);
            modificado.Nombre = tbx_nombre.Text;
            modificado.Imagen = tbx_imagen.Text;
            modificado.Precio =Convert.ToDouble(tbx_precio.Text);
            modificado.Cantidad = Convert.ToInt32(tbx_cantidad.Text);
            modificado.categoria = categoria_modificado;
            modificado.color = color_modificado;
            modificado.composicion = composicion_modificado;
            modificado.estilo = estilo_modificado;
            modificado.medida = medida_modificado;

        }
    }
}