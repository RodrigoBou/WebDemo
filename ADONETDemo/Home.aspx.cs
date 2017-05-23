using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ADONETDemo_Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {
            if (Session["sess_UserName"] != null) {
                Label1.Text = "<h1>Hola de Nuevo!! " + Session["sess_UserName"].ToString()+"</h1>";
            }
            else {
                Response.Redirect("Login.aspx");
            }
        }
    }

    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("Login.aspx");
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("ChangePassword.aspx");
    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {

        UserDetails x = new UserDetails();
        x.UserName = Session["sess_UserName"].ToString();

        int counter = x.DeleteUser();

        if (counter.Equals(1))
        {
            Session.Abandon();
            Response.Redirect("SignUp.aspx");
        }
        else {
            Label1.Text = "<h1> Usuario no se pudo eliminar!!!";
        }
    }

    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Response.Redirect("ChangeProfile.aspx");
    }
}