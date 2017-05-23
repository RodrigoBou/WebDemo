using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class ADONETDemo_ShowCountryWiseUsers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack) {
            UserDetails x = new UserDetails();
            DataSet dSet = x.GetListOfAllCountries();

            DropDownList1.DataSource = dSet;
            DropDownList1.DataTextField = "Country";
            DropDownList1.DataValueField = "Country";
            DropDownList1.DataBind();

            ListItem li = new ListItem("All Users","All Users");
            DropDownList1.Items.Insert(0, li);

            DataSet dSet2 = x.GetListOfAllCountries();
            ViewState["vw_AllUsers"] = dSet2;
            GridView1.DataSource = dSet2;
            GridView1.DataBind();

        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string str = DropDownList1.SelectedItem.Text;

        DataSet dSet = (DataSet)ViewState["vw_AllUsers"];
        DataView dv =dSet.Tables[0].DefaultView;



        if (str.ToUpper() != "ALL USERS")
        {
            dv.RowFilter = "Country='" + str + "'";
            dv.Sort = "UserName desc";
        }

        GridView1.DataSource = dv;
        GridView1.DataBind();




        //UserDetails x = new UserDetails();
        //x.Country = str;

        //DataSet dSet;
        //if (str.ToUpper() != "ALL USERS")
        //{
        //    dSet = x.GetCountryWiseUsers();
        //}
        //else
        //{
        //    dSet = x.GetListOfAllUsers();
        //}
        //GridView1.DataSource = dSet;
        //GridView1.DataBind();

    }
}