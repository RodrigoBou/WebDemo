using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ADONETDemo_BulkInsertDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            DataSet dSet = new DataSet();
            DataTable dTable = new DataTable();
            DataColumn dCol1 = new DataColumn("Name");
            DataColumn dCol2 = new DataColumn("Position");
            DataColumn dCol3 = new DataColumn("City");
            DataColumn dCol4 = new DataColumn("State");


            dTable.Columns.Add(dCol1);
            dTable.Columns.Add(dCol2);
            dTable.Columns.Add(dCol3);
            dTable.Columns.Add(dCol4);

            DataRow dRow;
            for (int i = 1; i <= 13; i++)
            {
                dRow = dTable.NewRow();
                dRow[0] = string.Empty;
                dRow[1] = string.Empty;
                dRow[2] = string.Empty;
                dRow[3] = string.Empty;
                dTable.Rows.Add(dRow);
            }
            dSet.Tables.Add(dTable);

            GridView1.DataSource = dSet;
            GridView1.DataBind();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("<root>");
        for (int i = 0; i < GridView1.Rows.Count; i++)
        {
            TextBox txtName = GridView1.Rows[i].FindControl("txtName") as TextBox;
            TextBox txtPosition = GridView1.Rows[i].FindControl("txtPosition") as TextBox;
            TextBox txtCity = GridView1.Rows[i].FindControl("txtCity") as TextBox;
            TextBox txtState = GridView1.Rows[i].FindControl("txtState") as TextBox;

            if (txtName.Text.Length != 0)
                sb.Append("<row Name='" + txtName.Text.Trim() + "' Position='" + txtPosition.Text.Trim() +
                    "' City='" + txtCity.Text.Trim() + "' State='" + txtState.Text.Trim() + "'/>");

        }
        sb.Append("</root>");

        string conStr = "data source=.;initial catalog=asptraining;integrated security=true;";
        SqlConnection con = new SqlConnection(conStr);

        SqlCommand cmd = new SqlCommand("InsertCustomer", con);

        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@XMLCustomer", sb.ToString());

        try
        {
            using (con)
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            Label1.Text = "Record(s) Inserted successfully";
            Label1.ForeColor = System.Drawing.Color.Green;
        }
        catch (Exception ex)
        {
            Label1.Text = "Error Occured: "+ex;
            Label1.ForeColor = System.Drawing.Color.Red;

        }
    }
}