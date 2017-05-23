using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

[Serializable]
class Employee
{
    public int Ecode { get; set; }
}

public partial class PersistenciadeDatos_DPEjemplo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack) {
            TextBox3.Text = Session.SessionID.ToString();
            TextBox4.Text = Session.Timeout.ToString();
            Session.Timeout = 2;
            TextBox4.Text = Session.Timeout.ToString();

            int Counter = Convert.ToInt32(Application["Counter"].ToString());

            Counter++;

            Label3.Text = "<h1> Visitante N°: " + Counter.ToString();

            Application.Lock();
            Application["Counter"] = Counter;
            Application.UnLock();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string str = TextBox1.Text;
        ViewState["vs_Usuario"] = str;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        if (ViewState["vs_Usuario"] != null) {
            TextBox2.Text = ViewState["vs_Usuario"].ToString();
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        //Session["sess_Usuario"] = TextBox1.Text;
        MySessionVariables s = new MySessionVariables();
        s.Usuario = TextBox1.Text;

        Employee y = new Employee();
        y.Ecode = 101;
        Session["Sess_Employee"] = y;
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        //if (Session["sess_Usuario"] != null)
        //TextBox2.Text = Session["sess_Usuario"].ToString();
        MySessionVariables s = new MySessionVariables();
        TextBox2.Text = s.Usuario;
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        Session["sess_Usuario"] = TextBox1.Text;
        Response.Redirect("TestSessionData.aspx?Country=SV&Region=SON");
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        Session.Abandon();
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        HttpCookie ck1 = new HttpCookie("ck_Usuario", TextBox1.Text);
        ck1.Expires = DateTime.Today.AddDays(2);
        Response.Cookies.Add(ck1);
    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        string str = Request.Cookies["ck_Usuario"].Value.ToString();
        TextBox2.Text = str;
    }
}