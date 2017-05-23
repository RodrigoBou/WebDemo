using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class ADONETDemo_LoopThroughDataSetManually : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!Page.IsPostBack)
        {
            UserDetails x = new UserDetails();
            DataSet dSet = new DataSet();
            dSet = x.GetListOfAllUsers();

            ShowData(dSet);
        }
    }


    private void ShowData(DataSet dSet)
    {

        for (int k = 0; k < dSet.Tables.Count; k++)
        {
            Response.Write("<table border='5' bgColor='aqua'>");

            Response.Write("<tr>");

            for (int i = 0; i < dSet.Tables[k].Columns.Count; i++)
            {
                Response.Write("<td>");
                Response.Write(dSet.Tables[k].Columns[i].Caption);
                Response.Write("</td>");
            }

            Response.Write("</tr>");


            for (int j = 0; j < dSet.Tables[k].Rows.Count; j++)
            {

                if (dSet.Tables[k].Rows[j]["Country"].ToString().Equals("El Salvador"))
                {
                    Response.Write("<tr bgColor='gray'>");
                }
                else
                {
                    Response.Write("<tr>");
                }

                for (int i = 0; i < dSet.Tables[k].Columns.Count; i++)
                {
                    Response.Write("<td>");
                    Response.Write(dSet.Tables[k].Rows[j][i].ToString());
                    Response.Write("</td>");
                }

                Response.Write("</tr>");


            }



            Response.Write("</table>");
        }

    }
}