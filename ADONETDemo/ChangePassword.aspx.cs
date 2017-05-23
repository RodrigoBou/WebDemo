using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ADONETDemo_ChangePassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string oldPassword = Session["sess_Password"].ToString();
        string Password = TextBox1.Text;
        UserDetails x = new UserDetails();

        if (Password.Equals(oldPassword)) {
            x.UserName = Session["sess_UserName"].ToString();
            x.Password = TextBox2.Text;

            int counter = x.ChangePassword();
            if (counter.Equals(1))
            {
                Session.Abandon();
                Response.Redirect("Login.aspx");
            }
            else {
                Label3.Text = "<h1>Contraseña no pudo ser actualizada!!!</h1>";
            }
        }
        else {
           Label3.Text = "<h1>Debe ingresar una contraseña correcta!!!</h1>";
        }
    }
}