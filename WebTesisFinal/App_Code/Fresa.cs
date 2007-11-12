using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;
using SQLManager;
using System.Data.SqlClient; 

/// <summary>
/// Descripción breve de Fresa
/// </summary>
public class Fresa
{
	Int32? _IdModelo=null;

    public Int32? IdModelo
    {
        get { return _IdModelo; }
        set { _IdModelo = value; }
    }

    String _NombreModelo = null;

    public String NombreModelo
    {
        get { return _NombreModelo; }
        set { _NombreModelo = value; }
    }

    String _TipoModelo = null;

    public String TipoModelo
    {
        get { return _TipoModelo; }
        set { _TipoModelo = value; }
    }

    private Decimal? _Precio=null;

    public Decimal? Precio
    {
      get { return _Precio; }
      set { _Precio = value; }
    }
 


	public Fresa()
	{
	}

    public Fresa(Int32? pIdModelo, String pNombreModelo, String pTipoModelo, Decimal? pPrecio)
    {
        this.IdModelo = pIdModelo;
        this.NombreModelo = pNombreModelo;
        this.TipoModelo = pTipoModelo;
        this.Precio = pPrecio;
    }
}

public class FresasCollection : List<Fresa>
{
    public void Llenar()
    {
        Llenar(null, null);
    }
    /// <summary>
    /// Llena la coleccion de Clientes segun el criterio
    /// </summary>
    /// <param name="pNroModelo">Id del cliente a Buscar</param>
    /// <param name="pNombreModelo">Nombre a buscar</param>
    public void Llenar(Int32? pNroModelo, String pNombreModelo)
    {
        try
        {
            SQL MySQL = new SQL();
            String Consulta = "Select idmodelo, nombre, tipomodelo, precio From modelofresa ";
            String Where = "where 1=@0";

            if (pNroModelo != null)
            {
                Where = Where + " and idmodelo=" + pNroModelo; 
            }
            if (pNombreModelo != null)
            {
                Where = Where + " and nombre='" + pNombreModelo + "'";
            }
            
            MySQL.SqlString = Consulta + Where;
            SqlDataReader dr;
            dr = MySQL.GetDataReader(1);

            this.Clear();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Fresa c = new Fresa(Convert.ToInt32(dr["idmodelo"]), Convert.ToString(dr["nombre"]), Convert.ToString(dr["tipomodelo"]), Convert.ToDecimal(dr["precio"]));

                    this.Add(c);
                }
            }
        }
        catch (Exception ex)
        {

            throw ex;
        }

    }
}
