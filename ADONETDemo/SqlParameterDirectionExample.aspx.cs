using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ADONETDemo_SqlParameterDirectionExample : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        UserDetails x = new UserDetails();
        int a, b, c, d, i, f;

        a = Convert.ToInt32(TextBox1.Text);
        b = Convert.ToInt32(TextBox2.Text);

        x.Calculate(a, b, out c, out d, out i, out f);

        TextBox3.Text = c.ToString();
        TextBox4.Text = d.ToString();
        TextBox5.Text = i.ToString();
        TextBox6.Text = f.ToString();
    }
}