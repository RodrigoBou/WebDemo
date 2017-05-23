using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ManejodeDatos_GridViewEjemplo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow grv = GridView1.SelectedRow;
       TextBox1.Text = grv.Cells[1].Text;
       TextBox2.Text = grv.Cells[2].Text;
       TextBox3.Text = grv.Cells[3].Text;
       TextBox4.Text = grv.Cells[4].Text;
    }
}