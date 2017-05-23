using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ControldeUsuarios_ListaUsuarios : System.Web.UI.UserControl
{
    public string Country { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //Disconnected oriented architecture
            UserDetails x = new UserDetails();
            DataSet dSet = x.GetListOfAllUsers();
            DataView dv = dSet.Tables[0].DefaultView;

            if (Country != null)
            {
                dv.RowFilter = "Country='" + Country + "'";
            }

            GridView1.DataSource = dv;
            GridView1.DataBind();
        }
    }
}