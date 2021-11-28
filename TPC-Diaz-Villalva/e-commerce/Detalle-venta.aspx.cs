using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace e_commerce
{
    public partial class Detalle_venta : System.Web.UI.Page
    {
        public Venta venta = new Venta();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("login.aspx");
            }
            var idventa = Request.QueryString["idventa"];

            Venta_neg venta_Neg = new Venta_neg();
            List<Venta> ventas = venta_Neg.listarVentas();

            venta = ventas.Find(X => X.ID == int.Parse(idventa));

            if (!IsPostBack)
            {
                cargarFormulario();
            }

        }

        void cargarFormulario()
        {
            try
            {
                lbl_idventa.Text = venta.ID.ToString();
                lbl_fecha.Text = venta.Fecha.ToString();
                lbl_usuario.Text = venta.usuario.ToString();
                rpArticulos.DataSource = venta.lista;
                rpArticulos.DataBind();

                Estado_neg estado_Neg = new Estado_neg();
                //ddl_estado.DataSource = estado_Neg.ListarEstados();
                //ddl_estado.DataBind();

                ddl_estado.SelectedValue = venta.estado.ID.ToString();
            }
            catch (Exception ex)
            {

                string error = ex.ToString();
                Session["error"] = error;
                Response.Redirect("/Error.aspx");
            }



        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            
                if (venta.estado.ID.ToString() != ddl_estado.SelectedValue)
                {
                    Venta_neg venta_Neg = new Venta_neg();
                    venta_Neg.modifcarEstado_venta(venta.ID, Convert.ToInt32(ddl_estado.SelectedValue));

                    Response.Redirect("Ventas.aspx");

                }
            

        }
    }
}