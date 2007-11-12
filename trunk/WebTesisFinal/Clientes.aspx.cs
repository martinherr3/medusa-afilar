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

public partial class Clientes : System.Web.UI.Page
{
    private ClientesCollection wClientes = new ClientesCollection();

    protected void Page_Load(object sender, EventArgs e)
    {
        BuscarClientes(null, null, null);
    }
    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        if (txtIdCliente.Text != "")
        {
            if (IsNumeric(txtIdCliente.Text))
            {
                BuscarClientes(Convert.ToInt32(txtIdCliente.Text), txtNombre.Text, txtApellido.Text);
            }
            else
            {
                txtIdCliente.Text = "";
                MessageBox.Show("El Id debe ser Numerico");
            }
        }
        else
        {
            BuscarClientes(null, txtNombre.Text, txtApellido.Text);
        }
        
    }

    private void BuscarClientes(Int32? IdCliente, String Nombre, String Apellido)
    {
        if (Nombre == "")
        {
            Nombre = null;
        }
        if (Apellido == "")
        {
            Apellido = null;
        }
        wClientes.Llenar(IdCliente, Nombre, Apellido);

        Repeater1.DataSource = wClientes;
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
