using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace e_commerce
{
    public partial class Agregar_Categoria : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Categoria_neg categoria_Neg = new Categoria_neg();
            Categoria nuevo = new Categoria();
            nuevo.Nombre = tbx_nombre.Text;

            if (FileImg.HasFile)
            {
                FileImg.SaveAs(Server.MapPath("~/img/categorias/" + FileImg.FileName));
            }

            categoria_Neg.agregarCategoria(nuevo);
            Response.Redirect("Categorias.aspx");
        }


   

    }
}