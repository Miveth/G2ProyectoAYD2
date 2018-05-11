using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pro_AYD2_1.Account
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        DBComun cn = new DBComun();
        string cadena;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["cuenta"] != null)
            {
                noCuenta.Text = Session["cuenta"].ToString();
                sesion.Text = Session["user"].ToString();
            }
            else
            {
                Response.Redirect("/");
            }

        }

        protected void logo_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("/");
        }


        protected void transferencia_Click(object sender, EventArgs e)
        {

            SqlDataAdapter sda = new SqlDataAdapter("select * from usuario where cuenta = '" + Session["cuenta"].ToString() + "' and saldoIni >= '" + monto.Text + "';", cn.conexion);
            DataTable dt = new DataTable();

            sda.Fill(dt);



            if (dt.Rows.Count.ToString() == "1")
            {
                cadena = "INSERT INTO transaccion ( monto, cuenta) values('" + monto.Text + "','" + cuenta.Text + "'); ";
                cn.insertardatos(cadena);
                mensaje.Text = "Transaccion Realizada con exito!!!";

                cadena = "update usuario set saldoIni = saldoIni - '" + monto.Text + "'from usuario u where u.cuenta = '" + Session["cuenta"].ToString() + "'; ";
                cn.insertardatos(cadena);

                cadena = "update usuario set saldoIni = saldoIni + '" + monto.Text + "'from usuario u where u.cuenta = '" + cuenta.Text + "'; ";
                cn.insertardatos(cadena);
            }

            else
            {
                mensaje.Text = "Lo sentimos, Compruebe si la cuenta existe o si tiene suficiente saldo para completar la transaccion";
                mensaje.Visible = true;

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Consultar.aspx");
        }
    }
}   