using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ADONETDemo_DataRelationsExample : System.Web.UI.Page
{
    DataSet dSet;
    DataRelation UserContacts;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //Disconnected oriented architecture
            UserDetails x = new UserDetails();
            dSet = x.GetListOfAllUsers();

            ViewState["Rel"] = dSet;

            UserContacts = dSet.Relations.Add("UserContacts",
                dSet.Tables[0].Columns["UserID"],
                dSet.Tables[1].Columns["UserID"]);

            GridView1.DataSource = dSet;
            GridView1.DataBind();
        }
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow gvr = GridView1.SelectedRow;
        dSet = (DataSet)ViewState["Rel"];

        DataColumn[] dcPk = new DataColumn[1];

        // Set Primary Key
        dcPk[0] = dSet.Tables[0].Columns["UserID"];
        dSet.Tables[0].PrimaryKey = dcPk;

        DataRow drFound;


        drFound = dSet.Tables[0].Rows.Find(gvr.Cells[5].Text);

        DataRow[] ChildRows = drFound.GetChildRows("UserContacts");

        DataTable FilteredTable = new DataTable();
        DataColumn dCol1 = new DataColumn("UserID");
        DataColumn dCol2 = new DataColumn("ContactID");
        DataColumn dCol3 = new DataColumn("PhoneNumber");
        DataColumn dCol4 = new DataColumn("LandLine");
        DataColumn dCol5 = new DataColumn("Fax");
        FilteredTable.Columns.Add(dCol1);
        FilteredTable.Columns.Add(dCol2);
        FilteredTable.Columns.Add(dCol3);
        FilteredTable.Columns.Add(dCol4);
        FilteredTable.Columns.Add(dCol5);

        foreach (DataRow dr in ChildRows)
        {
            FilteredTable.ImportRow(dr);
        }


        GridView2.DataSource = FilteredTable;
        GridView2.DataBind();
    }
}