using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AjaxDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Calcular("+");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Calcular("-");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Calcular("*");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Calcular("/");
    }

    void Calcular(string op) {
        int c = 0;
        int a, b;

        a = Convert.ToInt32(TextBox1.Text);
        b = Convert.ToInt32(TextBox2.Text);

        switch (op) {
            case "+":
                c = a + b;
                break;
            case "-":
                c = a - b;
                break;
            case "*":
                c = a * b;
                break;
            case "/":
                c = a / b;
                break;
        }
        System.Threading.Thread.Sleep(5000);
        TextBox3.Text = c.ToString();
    }

    protected void Timer1_Tick(object sender, EventArgs e)
    {
        Label5.Text = DateTime.Now.ToString("hh:mm:ss");
    }
}