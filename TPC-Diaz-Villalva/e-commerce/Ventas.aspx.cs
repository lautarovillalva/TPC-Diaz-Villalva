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
    public partial class Ventas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Venta_neg venta_Neg = new Venta_neg();
            dgv_ventas.DataSource = venta_Neg.listarVentas();
            dgv_ventas.DataBind();


        }
    }
}