using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Controles_Estandar_CheckBoxEjemplo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        Calcular("RENTA", CheckBox1.Checked);
    }

    protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
    {
        Calcular("SEGURO", CheckBox2.Checked);
    }

    protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
    {
        Calcular("PENSION", CheckBox3.Checked);
    }

    private void Calcular(string opcion, bool check)
    {
        double salNeto, salario, retenciones = 0;

        salario = Convert.ToDouble(TextBox1.Text);
        salNeto = Convert.ToDouble(TextBox2.Text);

        if (salNeto == 0)
            salNeto = salario;

        switch (opcion) {
            case "RENTA":
                retenciones = salario * 10 / 100;
                break;
            case "SEGURO":
                retenciones = salario * 20 / 100;
                break;
            case "PENSION":
                retenciones = salario * 15 / 100;
                break;
        }

        if (check == true)
            salNeto = salNeto - retenciones;
        else
            salNeto = salNeto + retenciones;

        TextBox2.Text = salNeto.ToString(); 

    }
}