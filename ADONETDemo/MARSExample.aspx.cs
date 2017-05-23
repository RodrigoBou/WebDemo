using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ADONETDemo_MARSExample : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            GetUserInfo();
        }
    }

    public void GetUserInfo()
    {
        SqlConnection connection = new SqlConnection(@"Data Source=.; Initial Catalog=asptraining; Integrated Security=True;MultipleActiveResultsets=true;");//MARS=TRUE
        connection.Open();

        SqlCommand command1 = new SqlCommand();
        command1.Connection = connection;
        command1.CommandType = CommandType.Text;
        command1.CommandText = "SELECT * FROM UserDetails ORDER BY UserID";
        SqlDataReader reader1 = command1.ExecuteReader(CommandBehavior.CloseConnection);

        while (reader1.Read())
        {
            Response.Write(reader1["UserName"] + " ");


            SqlCommand command2 = new SqlCommand();
            command2.Connection = connection;
            command2.CommandText = "SELECT * FROM Contacts WHERE UserID=" + reader1["UserID"];
            SqlDataReader reader2 = command2.ExecuteReader(CommandBehavior.CloseConnection);

            while (reader2.Read())
            {
                Response.Write("<br>" + reader2["Fax"] + "," + reader2["PhoneNumber"] + "," + reader2["LandLine"]);
            }
            Response.Write("<hr>");
        }


        reader1.Close();
        reader1.Dispose();
        reader1 = null;

    }
}