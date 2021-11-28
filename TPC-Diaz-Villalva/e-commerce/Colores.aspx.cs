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
    public partial class Colores : System.Web.UI.Page
    {
        private int admin = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("login.aspx");
            }
            else
            {
                this.admin = Convert.ToInt32(Session["admin"]);

                if (admin == 1)
                {
                    mostrarColores();
                }


            }

        }
        public void mostrarColores()
        {
            try
            {
                Color_neg color_Neg = new Color_neg();
                rpColores.DataSource = color_Neg.ListarColores();
                rpColores.DataBind();
            }
            catch (Exception ex)
            {

                string error = ex.ToString();
                Session["error"] = error;
                Response.Redirect("/Error.aspx");
            }

        }
    }
}