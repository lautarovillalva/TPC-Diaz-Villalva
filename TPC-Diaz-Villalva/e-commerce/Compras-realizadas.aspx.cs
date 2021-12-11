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
    public partial class Compras_realizadas : System.Web.UI.Page
    {

        public Usuario usuario = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                Response.Redirect("login.aspx");
            }
            else
            {
                usuario = Session["usuario"] as Usuario;
                
            }

            List<Venta> comprasRealizadas = new List<Venta>();
            Venta_neg venta_Neg = new Venta_neg();

            foreach (Venta item in venta_Neg.listarVentas())
            {
                if (item.usuario.Mail == usuario.Mail)
                    comprasRealizadas.Add(item);
            }


            rpVentas.DataSource = comprasRealizadas;
            rpVentas.DataBind();

        }
    }
}