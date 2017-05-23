using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Controles_Estandar_CalendarControlEjemplo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack) {
            DateTime dtDOB = new DateTime(1995,11,13);
            DateTime dtToday = DateTime.Today.Date;

            Calendar1.TodaysDate = dtDOB; 
        }
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        TextBox1.Text = Calendar1.SelectedDate.ToString();
        TextBox2.Text = Calendar1.SelectedDate.ToShortDateString();
        TextBox3.Text = Calendar1.SelectedDate.ToLongDateString();

        DateTime dt = Calendar1.SelectedDate;

        TextBox4.Text = dt.AddDays(3).ToString();
        TextBox5.Text = dt.AddMonths(3).ToString();
        TextBox6.Text = dt.AddYears(3).ToString();

        TextBox7.Text = Calendar1.SelectedDate.ToString("yyyy/MM/dd");
    }
}