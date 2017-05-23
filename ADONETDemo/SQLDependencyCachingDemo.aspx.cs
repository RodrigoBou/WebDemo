using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ADONETDemo_SQLDependencyCachingDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = DateTime.Now.ToString();
        if (!IsPostBack)
        {
            GetData();
        }
    }
    private void GetData()
    {
        DataTable table = new DataTable();
        string _connStr = System.Configuration.ConfigurationManager.ConnectionStrings["MyCS"].ConnectionString;

        if (Cache["UserDetailData"] != null)
        {
            table = (DataTable)Cache["UserDetailData"];
            Label1.Text += "<br />Got data from the Cache";
        }
        else
        {

            using (SqlConnection conn = new SqlConnection(_connStr))
            {

                string sql = "SELECT * FROM UserDetails ORDER By UserID";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {

                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {

                        ad.Fill(table);
                    }


                }
                SqlCacheDependency dependency = new SqlCacheDependency("ASPTraining", "UserDetails");

                Cache.Insert("UserDetailData", table, dependency);
                Label1.Text += "<br />Got data from the database";
            }
        }

        GridView1.DataSource = table;
        GridView1.DataBind();
    }
}