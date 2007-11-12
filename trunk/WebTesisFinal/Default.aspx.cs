using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page 
{
    private PedidosCollection wPedidos = new PedidosCollection();

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["ClienteSel"].ToString() != "")
                {
                    BuscarPedidos(3, Convert.ToInt32(Request.QueryString["ClienteSel"].ToString()));
                }
            }
        }
        catch (Exception)
        {
           
        }
        
        //BuscarPedidos(null, null);
        
    }
    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        if (IsNumeric(txtIdPedido.Text))
        {
            BuscarPedidos(1, Convert.ToInt32(txtIdPedido.Text));
        }
        else
        {
            txtIdPedido.Text = "";
        }
    }

    private void BuscarPedidos(Int32? Criterio, Int32? Id)
    {
        wPedidos.Llenar(Criterio, Id);

        Repeater1.DataSource = wPedidos;
        Repeater1.DataBind();
    }

    public bool IsNumeric(object Expression)
    {
        bool isNum;
        double retNum;

        isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
        return isNum;
    }

}