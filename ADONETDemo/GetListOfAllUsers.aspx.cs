using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class ADONETDemo_GetListOfAllUsers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack) {
            UserDetails x = new UserDetails();
            DataSet dSet = x.GetListOfAllUsers();

            GridView1.DataSource = dSet.Tables[0].DefaultView; // selecciona la tabla que retorna el SP
            GridView1.DataBind();

            dSet.WriteXml(@"C:\curso\Players.xml");

            BulletedList1.DataSource = dSet;
            BulletedList1.DataTextField = "UserName";
            BulletedList1.DataValueField = "UserName";
            BulletedList1.DataBind();

            CheckBoxList1.DataSource = dSet;
            CheckBoxList1.DataTextField = "UserName";
            CheckBoxList1.DataValueField = "UserName";
            CheckBoxList1.DataBind();

            DropDownList1.DataSource = dSet;
            DropDownList1.DataTextField = "UserName";
            DropDownList1.DataValueField = "UserName";
            DropDownList1.DataBind();

            ListBox1.DataSource = dSet;
            ListBox1.DataTextField = "UserName";
            ListBox1.DataValueField = "UserName";
            ListBox1.DataBind();

            RadioButtonList1.DataSource = dSet;
            RadioButtonList1.DataTextField = "UserName";
            RadioButtonList1.DataValueField = "UserName";
            RadioButtonList1.DataBind();

        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DataSet dSet = new DataSet();
        dSet.ReadXml(@"C:\curso\Players.xml");
        GridView2.DataSource = dSet;
        GridView2.DataBind();
    }
}