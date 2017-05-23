using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ADONETDemo_DataCachingExample : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            UserDetails x = new UserDetails();
            DataSet dSet = new DataSet();


            if (Cache["ca_AllUsers"] == null) //la primera vez hace extrae de la base de datos
            {
                dSet = x.GetListOfAllUsers();
                Cache["ca_AllUsers"] = dSet;
            }
            else //las otras veces lo hace de lo que esta almacenado en la cache
            {
                dSet = (DataSet)Cache["ca_AllUsers"];
            }

            GridView1.DataSource = dSet;
            GridView1.DataBind();
        }
    }
}