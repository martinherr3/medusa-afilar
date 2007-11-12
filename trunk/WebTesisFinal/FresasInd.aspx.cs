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
using System.IO;
using System.Drawing;

public partial class FresasInd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["ModeloSel"].ToString() != "")
                {
                    BuscarFresasIndividuales(Convert.ToInt32(Request.QueryString["ModeloSel"].ToString()), null, null);
                }
            }
        }
        catch (Exception)
        {

        }
    }

    private void BuscarFresasIndividuales(Int32? pNroModelo, String pNombreFresa, Int32? pTipo)
    {
        FresasIndividualCollection wFresas = new FresasIndividualCollection();
        wFresas.Llenar(pNroModelo, pNombreFresa, pTipo);

        Repeater1.DataSource = wFresas;
        Repeater1.DataBind(); 
    
    }

    public System.Drawing.Image Bytes2Image(byte[] bytes)
    {
        if (bytes == null)
            return null;
        // 
        MemoryStream ms = new MemoryStream(bytes);
        Bitmap bm = null;
        try
        {
            bm = new Bitmap(ms);
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex.Message);
        }
        return bm;
    }
}
