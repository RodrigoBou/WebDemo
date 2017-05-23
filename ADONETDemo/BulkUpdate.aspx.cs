using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text;

public partial class CustomerDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            SqlConnection cn = new SqlConnection("data source=.;initial catalog=asptraining;integrated security=true;");
           
            SqlCommand cmd = new SqlCommand("select * from customer", cn);
            SqlDataAdapter sda=new SqlDataAdapter(cmd);
            DataSet dSet = new DataSet();
            sda.Fill(dSet);

            GridView1.DataSource = dSet;
            GridView1.DataBind();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        UpdateCustomer();
    }

    private void UpdateCustomer()
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
        SqlCommand cmd = new SqlCommand("UpdateCustomer", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@XMLCustomer", sb.ToString());

        try
        {
            using (con)
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            lblError.Text = "Record(s) Updated successfully";
            lblError.ForeColor = System.Drawing.Color.Green;
        }
        catch (Exception ex)
        {
            lblError.Text = "Error Occured: "+ex;
            lblError.ForeColor = System.Drawing.Color.Red;

        }
    }
}

/*
CREATE PROCEDURE [dbo].[UpdateCustomer]
(
 @XMLCustomer XML
)
AS
BEGIN
 

      UPDATE Customer
            SET 
                  CustPosition=TempCustomer.Item.value('@Position', 'VARCHAR(50)'),
                  CustCity=TempCustomer.Item.value('@City', 'VARCHAR(50)'),
                  CustState=TempCustomer.Item.value('@State', 'VARCHAR(50)')
      FROM @XMLCustomer.nodes('/root/row') AS TempCustomer(Item)
      WHERE CustName=TempCustomer.Item.value('@Name', 'VARCHAR(50)')
 

RETURN 0
END

*/