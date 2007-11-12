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

public partial class Partes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["ModeloSel"].ToString() != "")
                {
                    BuscarPartes(Convert.ToInt32(Request.QueryString["ModeloSel"].ToString()), null);
                }
            }
        }
        catch (Exception)
        {

        }
    }

    private void BuscarPartes(Int32? pNroModelo, String pNombreParte)
    {
        ParteFresaCollection wPartes = new ParteFresaCollection();
        wPartes.Llenar(pNroModelo, pNombreParte);

        Repeater1.DataSource = wPartes;
        Repeater1.DataBind();


    }
}
