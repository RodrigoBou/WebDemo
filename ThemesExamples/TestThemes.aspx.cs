using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ThemesExamples_TestThemes : System.Web.UI.Page
{

    protected void Page_PreInit(object sender, EventArgs e)
    {
        switch (Request.QueryString["theme"])
        {
            case "Seasons":
                TextBox3.SkinID = "SkinDemo";
                Page.Theme = "Seasons";

                break;
            case "Weather":
                TextBox3.SkinID = "CloudySkinDemo";
                Page.Theme = "Weather";

                break;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
}