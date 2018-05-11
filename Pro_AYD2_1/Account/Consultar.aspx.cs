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
    public partial class Consultar : System.Web.UI.Page
    {

        DBComun cn = new DBComun();

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

        public int vacio(string cadena)
        {
            if (cadena == "")
            {
                return 1;
            }
            return 0;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from usuario where cuenta = '" + Session["cuenta"].ToString()+ "';", cn.conexion);
            DataTable dt = new DataTable();

            sda.Fill(dt);



            if (dt.Rows.Count.ToString() == "1")
            {
                DataRow row = dt.Rows[0];
                cuenta.Text = Session["cuenta"].ToString();
                nombre.Text = Session["user"].ToString();
                monto.Text = row["saldoIni"].ToString();
                apellido.Text = row["apellido"].ToString();
                mensaje.Text = "Consulta realizada con exito!!!";

            }

            else
            {
                mensaje.Text = "Intento Fallido";
                mensaje.Visible = true;

            }
            
        }

        protected void logo_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("/");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("MENU.aspx");
        }
    }
}
