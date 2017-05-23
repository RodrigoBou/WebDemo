using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ADONETDemo_AutogenerateColumnsDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Disconnected oriented architecture
        UserDetails x = new UserDetails();
        DataSet dSet = x.GetListOfAllUsers();
        GridView1.DataSource = dSet;
        GridView1.DataBind();
    }
}