using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["id"]!=null)
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           DataTable dt= Grading_System_21.Classes.Authentication.login(TextBox1.Text,TextBox2.Text,"student");

            if(dt.Rows.Count>0)
            {
                Session["id"] = dt.Rows[0].ItemArray[0];
                Response.Redirect("Home.aspx");
            }
        }
    }
}