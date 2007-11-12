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

public partial class Fresas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        BuscarModelos(null, null);
    }

    private void BuscarModelos(Int32? pNroModelo, String pNombreModelo)
    {
        try
        {
            FresasCollection wFresas = new FresasCollection();
            wFresas.Llenar(pNroModelo, pNombreModelo);

            Repeater1.DataSource = wFresas;
            Repeater1.DataBind();
        }
        catch (Exception ex)
        {

            MessageBox.Show(ex.Message);
        }
    }
}
