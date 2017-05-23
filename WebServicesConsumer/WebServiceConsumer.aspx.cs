using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebServicesConsumer_WebServiceConsumer : System.Web.UI.Page
{

    localhost.Service x = new localhost.Service();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int a, b, c;

        a = Convert.ToInt32(TextBox1.Text);
        b = Convert.ToInt32(TextBox2.Text);

        c = x.Add(a, b);

        TextBox3.Text = c.ToString();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        int a, b, c;

        a = Convert.ToInt32(TextBox1.Text);
        b = Convert.ToInt32(TextBox2.Text);

        c = x.Substract(a, b);

        TextBox3.Text = c.ToString();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        DataSet dSet = x.GetListOfAllUsers();
        GridView1.DataSource = dSet;
        GridView1.DataBind();
    }
}