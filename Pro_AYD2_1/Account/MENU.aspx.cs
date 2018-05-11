using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pro_AYD2_1.Account
{
    public partial class MENU : System.Web.UI.Page
    {
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

        protected void Button2_Click(object sender, EventArgs e)
        {

         //transaccion 


        }

        protected void logo_Click(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
