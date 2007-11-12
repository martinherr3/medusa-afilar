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

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            HttpCookie objCookie = Request.Cookies["Usuario"];
            if (objCookie != null)
            {
                txtUsuario.Text = objCookie.Value.ToString();
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string encriptada;
        encriptada = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Text, "SHA1");
        //if (Usuario.IsValido(txtUsuario.Text, encriptada) != 0)
        if (Usuario.IsValido(txtUsuario.Text, txtPassword.Text) != 0)
        {
            HttpCookie objCookie = new HttpCookie("Usuario", txtUsuario.Text);
            Session["permisos"] = Usuario.IsValido(txtUsuario.Text, encriptada);
            objCookie.Expires = DateTime.Today.AddDays(300);
            Response.Cookies.Add(objCookie);
            FormsAuthentication.RedirectFromLoginPage(txtUsuario.Text, false);
        }
        else
        {
            Label4.Text = "Datos incorrectos!!!, intente de nuevo...";
        }
    }

}
