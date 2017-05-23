using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class ADONETDemo_FillDataSetManually : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ShowData();
        }
    }

    private void ShowData()
    {
        DataSet dSet = new DataSet();
        DataTable dTable = new DataTable();
        DataColumn dCol1 = new DataColumn("Ecode");
        DataColumn dCol2 = new DataColumn("Ename");
        DataColumn dCol3 = new DataColumn("Salary");

        DataRow dRow;

        dTable.Columns.Add(dCol1);
        dTable.Columns.Add(dCol2);
        dTable.Columns.Add(dCol3);
        //ASCII : 65 TO 90
        for (int i = 65; i <= 90; i++)
        {
            dRow = dTable.NewRow();

            dRow[0] = i.ToString();
            dRow[1] = ((char)i).ToString();
            dRow["Salary"] = i * 1000;

            dTable.Rows.Add(dRow);
        }
        dSet.Tables.Add(dTable);
        GridView1.DataSource = dSet;
        GridView1.DataBind();
    }
}