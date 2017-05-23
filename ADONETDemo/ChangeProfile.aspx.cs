using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class ADONETDemo_ChangeProfile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            UserDetails x = new UserDetails();
            x.UserName = Session["sess_UserName"].ToString();
            DataSet dSet = x.GetUserInfo();

            TextBox1.Text = Session["sess_UserName"].ToString();
            TextBox2.Text = dSet.Tables[0].Rows[0]["Password"].ToString();
            TextBox4.Text = dSet.Tables[0].Rows[0]["Email"].ToString();

            string Country = dSet.Tables[0].Rows[0]["Country"].ToString();

            ListItem li = DropDownList1.Items.FindByText(Country);

            int Index = DropDownList1.Items.IndexOf(li);

            DropDownList1.SelectedIndex = Index;

        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        UserDetails x = new UserDetails();

        x.UserName = Session["sess_UserName"].ToString();
        x.Password = TextBox2.Text;
        x.Country = DropDownList1.SelectedItem.Text;
        x.Email = TextBox4.Text;

        int Counter = x.UpdateUser();

        if (Counter.Equals(1))
        {
            Label5.Text = "<h1>Datos actualizados correctamente...</h1>";
        }
    }
}