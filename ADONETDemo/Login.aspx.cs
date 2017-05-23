using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class ADONETDemo_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        UserDetails x = new UserDetails();
        x.UserName = TextBox1.Text;
        x.Password = TextBox2.Text;

        DataSet dSet = x.CheckCredentials();

        int status = Convert.ToInt32(dSet.Tables[0].Rows[0]["Status"].ToString());

        switch (status) {
            case 1:
                Session["sess_UserName"] = TextBox1.Text;
                Session["sess_Password"] = TextBox2.Text;
                Response.Redirect("Home.aspx");
                break;
            case -1:
                Label3.Text = "<h1>Usuario No Existe!!";
                break;
            case -2:
                Label3.Text = "<h1>Usuario Eliminado Anteriormente!!";
                break;
            case -3:
                Label3.Text = "<h1>Usuario Bloqueado... Demasiados Intentos Erroneos!!";
                break;
            case 0:
                int NOFA = Convert.ToInt32(dSet.Tables[0].Rows[0]["NOFA"].ToString());

                if (NOFA.Equals(5)) {
                    Label3.Text = "<h1>Has exedido los intentos maximos tu usuario ha sido bloqueado!!";
                }
                else {
                    Label3.Text = "<h1> Contraseña Erronea!!! Te quedan " + (5 - NOFA) + " intentos...</h1>";
                }
                break;
        }
    }
}