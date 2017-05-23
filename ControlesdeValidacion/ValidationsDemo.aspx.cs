using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Controles_de_Validacion_ValidationsDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

    }

    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        if (TextBox1.Text.Trim().Length >= 5)
            args.IsValid = true;
        else
            args.IsValid = false;
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        int a, b, c;

        a = 1;
        b = 2;
        c = a+b;

        Page.Validate("LoginGroup");

        if (Page.IsValid) {
            c = a - b;
            c = a * b;
            c = a / b;
        }

    }
}