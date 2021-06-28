using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace e_commerce
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Categoria_neg categoria_Neg = new Categoria_neg();
            dgvCategorias.DataSource = categoria_Neg.ListarCategorias();
            dgvCategorias.DataBind();

        }
    }
}