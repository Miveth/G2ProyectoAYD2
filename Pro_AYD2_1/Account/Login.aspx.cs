using System;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using Pro_AYD2_1.Models;
using System.Data.SqlClient;
using System.Data;
using System.Web.Providers.Entities;

namespace Pro_AYD2_1.Account
{
    public partial class Login : Page
    {
        DBComun cn = new DBComun();
        static public Boolean logeado = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterHyperLink.NavigateUrl = "Register";
            // Habilite esta opción una vez tenga la confirmación de la cuenta habilitada para la funcionalidad de restablecimiento de contraseña
            //ForgotPasswordHyperLink.NavigateUrl = "Forgot";
            OpenAuthLogin.ReturnUrl = Request.QueryString["ReturnUrl"];
            var returnUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            if (!String.IsNullOrEmpty(returnUrl))
            {
                RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
            }
        }

        public Boolean logg() {

            return logeado;
        }

        protected void LogIn(object sender, EventArgs e)
        {


            SqlDataAdapter sda = new SqlDataAdapter("select * from usuario where cuenta = '" + Email.Text + "' and pass = '" + Password.Text + "';", cn.conexion);
            DataTable dt = new DataTable();

            sda.Fill(dt);



            if (dt.Rows.Count.ToString() == "1")
            {
                DataRow row = dt.Rows[0];
                Session["user"] = row["nombre"].ToString();
                Session["cuenta"] = Email.Text;
                Response.Redirect("MENU.aspx");
                logeado = true;
            }

            else
            {
                FailureText.Text = "Intento de inicio de sesión no válido";
                ErrorMessage.Visible = true;
                logeado = true;

            }

        }
        
    }
}