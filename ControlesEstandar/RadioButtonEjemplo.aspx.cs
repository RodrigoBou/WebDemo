using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Controles_Estandar_RadioButtonEjemplo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string str = RadioButtonList1.SelectedItem.Value.ToUpper();
        Calcular(str);
    }

    private void Calcular(string opcion) {
        double salario, salNeto, retenciones=0;
        salario = Convert.ToDouble(TextBox1.Text);

        switch (opcion) {
            case "SEGURO":
                retenciones = salario * 10 / 100;
                break;
            case "RENTA":
                retenciones = salario * 20 / 100;
                break;
            case "INSAFORP":
                retenciones = salario * 1 / 100;
                break;
            case "PENSION":
                retenciones = salario * 15 / 100;
                break;
        }
        salNeto = salario - retenciones;
        TextBox2.Text = salNeto.ToString();
    }
}