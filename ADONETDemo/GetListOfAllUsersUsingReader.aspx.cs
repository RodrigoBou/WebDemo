using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ADONETDemo_GetListOfAllUsersUsingReader : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            UserDetails x = new UserDetails();
            SqlDataReader sdr = x.GetListOfAllUsersUsigReader();

            GridView1.DataSource = sdr;
            GridView1.DataBind();

            //GridView2.DataSource = sdr;
            //GridView2.DataBind();
            //solo hacia adelante!!
            //solo puede ser usado una vez!!

            sdr.Close();
            sdr.Dispose();
            sdr = null;
        }
    }
}