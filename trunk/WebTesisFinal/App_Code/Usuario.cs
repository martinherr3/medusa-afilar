using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using SQLManager;
using System.Data.SqlClient;
using Microsoft.VisualBasic; 

/// <summary>
/// Descripción breve de Usuario
/// </summary>
public class Usuario
{
    private String _usuario;
    public String usuario
    {
        set { _usuario = value; }
        get { return _usuario; }
    }

    private String _password;
    public String password
    {
        set { _password = value; }
        get { return _password; }
    }

    private String _legajo;
    public String legajo
    {
        set { _legajo = value; }
        get { return _legajo; }
    }

    public Usuario()
    { 
    }
    
    public Usuario(String pusuario, String ppassword, String plegajo)
    {
        usuario = pusuario;
        password = ppassword;
        legajo = plegajo;
    }

    public static Int32 IsValido(string usu, string pass)
    {
        SQL clsSql = new SQL();
        try
        {

            object[] args = new object[2];
            args[0] = usu;
            args[1] = EncriptarTexto(pass, usu, true);
            string strSql = "select * from cuentausuario where usuario like @0 and contraseña like @1";
            clsSql.SqlString = strSql;
            SqlDataReader dr = clsSql.GetDataReader(args);
            if (dr.HasRows)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        catch
        {
            return 0;
        }
        finally
        {
            clsSql.Close();
        }
    }

    public static string EncriptarTexto(string CadenaAEncriptar, string Clave, bool MantenerMayusculas)
    {


        int i;
        int C;

        string CadenaEncriptada;
        CadenaEncriptada = "";

        if (MantenerMayusculas == false)
        {

            Clave = Clave.ToUpper();

            CadenaAEncriptar = CadenaAEncriptar.ToUpper();

        }

        if (Strings.Len(Clave)>0)
        {

            for (i = 1; i <= Strings.Len(CadenaAEncriptar); i++)
            {

                C = Strings.Asc(Strings.Mid(CadenaAEncriptar, i, 1));

                C = C + Strings.Asc(Strings.Mid(Clave, (i % Strings.Len(Clave)) + 1, 1));

                CadenaEncriptada = CadenaEncriptada + Strings.Chr(C & 255);

            }
        }

        else
        {

            CadenaEncriptada = CadenaAEncriptar;

        }

        return CadenaEncriptada;

    } 

}
