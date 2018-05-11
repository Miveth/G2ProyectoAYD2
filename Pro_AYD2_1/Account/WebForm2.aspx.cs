﻿using System;
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

           
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Consultar.aspx");
        }
    }
}   