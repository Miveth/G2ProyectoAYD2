using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using Pro_AYD2_1.Models;

namespace Pro_AYD2_1.Account
{
    public partial class Register : Page
    {
        DBComun cn = new DBComun();
        string cadenainsertar;

       
        protected void CreateUser_Click(object sender, EventArgs e)
        {
            
            registrar_usuario();
        }

        public void registrar_usuario()
        {

            
        }
    }
}
