using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace e_commerce
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            if(txtUsuario.Text == "admin" && txtPassword.Text == "admin")
            {
                Session["admin"] = 1;
                Response.Redirect("admin.aspx");
            }

           
        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {

        }
    }
}