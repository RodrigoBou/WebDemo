using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Controles_Estandar_FileUploadEjemplo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            FileUpload1.SaveAs(@"C:\CV\" + FileUpload1.PostedFile.FileName);
            Label4.Text = "<h2>Archivo Subido Correctamente!</h2>";

            Label2.Text = FileUpload1.PostedFile.ContentType.ToString();
            Label3.Text = FileUpload1.PostedFile.ContentLength.ToString();
        }
        else {
            Label4.Text = "<h2>Porfavor Seleccione un Archivo</h2>";
        }
    }
}