using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class ADONETDemo_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        UserDetails x = new UserDetails();

        int counter = 0;

        try
        {
            x.UserName = TextBox1.Text;
            x.Password = TextBox2.Text;
            x.Country = DropDownList1.SelectedItem.Text;
            x.Email = TextBox4.Text;

            counter = x.CreateUser();

            if (counter.Equals(1)) {
                Label5.Text = "<h1>Felicidades ha podido registrarse correctamente!!";
                Response.Redirect("Login.aspx");
            }
        }
        catch (Exception ex) {
            if (ex.Message.StartsWith("Violation of PRIMARY KEY")) {
                Label5.Text = "<h1>Usuario Ya Existe!!!";
            }
            else {
                Label5.Text = ex.Message;
            }
            
        }
    }
}