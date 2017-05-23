using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PersistenciadeDatos_TestSessionData : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack) {
            if (Session["sess_Usuario"] != null) {
                TextBox1.Text = Session["sess_Usuario"].ToString();
            }
        }

        if (Request.QueryString["Country"] != null) {
            TextBox2.Text = Request.QueryString["Country"];
        }

        if (Request.QueryString["Region"] != null)
        {
            TextBox3.Text = Request.QueryString["Region"];
        }

    }
}