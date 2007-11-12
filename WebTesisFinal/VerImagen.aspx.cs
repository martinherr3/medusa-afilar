using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class VerImagen : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["ModeloSel"].ToString() != "" && Request.QueryString["TipoSel"].ToString() != "")
                {
                    MostrarImagen(Convert.ToInt32(Request.QueryString["ModeloSel"].ToString()), Convert.ToInt32(Request.QueryString["TipoSel"].ToString()));
                }
            }
        }
        catch (Exception)
        {

        }
    }

    private void MostrarImagen(Int32? Modelo, Int32? Tipo)
    {
        FresasIndividualCollection wFresas = new FresasIndividualCollection();
        wFresas.Llenar(Modelo, null, Tipo);

        if (wFresas.Count > 0)
        {
            Response.BinaryWrite(wFresas[0].Imagen);
        }
    }
}
