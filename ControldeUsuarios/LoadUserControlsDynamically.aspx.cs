using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ControldeUsuarios_LoadUserControlsDynamically : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Control Header = LoadControl("Header.ascx");
        Control Footer = LoadControl("Footer.ascx");
        Control UsersList = LoadControl("ListaUsuarios.ascx");

        PlaceHolder1.Controls.Add(Header);
        PlaceHolder2.Controls.Add(UsersList);
        PlaceHolder3.Controls.Add(Footer);
    }
}