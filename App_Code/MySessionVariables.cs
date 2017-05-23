using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de MySessionVariables
/// </summary>
public class MySessionVariables
{
    private string m_Usuario;

    public MySessionVariables()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public string Usuario
    {
        get
        {
            if (HttpContext.Current.Session["sess_Usuario"] != null)
            {
                return HttpContext.Current.Session["sess_Usuario"].ToString();
            }
            else {
                return string.Empty;
            }
            
        }

        set
        {
            HttpContext.Current.Session["sess_Usuario"] = value;
        }
    }
}