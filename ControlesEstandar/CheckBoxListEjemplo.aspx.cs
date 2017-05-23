using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Controles_Estandar_CheckBoxListEjemplo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int salario;
        double retenciones = 0, salNeto = 0;

        salario = Convert.ToInt32(TextBox1.Text);

        foreach (ListItem li in CheckBoxList1.Items)
        {
            if (li.Selected)
            {
                switch (li.Text)
                {
                    case "renta":
                        retenciones += salario * 10 / 100;
                        break;
                    case "seguro":
                        retenciones += salario * 20 / 100;
                        break;
                    case "pension":
                        retenciones += salario * 15 / 100;
                        break;
                    case "insaforp":
                        retenciones += salario * 1 / 100;
                        break;
                }//SWITCH
            }//IF
        }//FOREACH
        salNeto = salario - retenciones;
        TextBox2.Text = salNeto.ToString();
    }
}