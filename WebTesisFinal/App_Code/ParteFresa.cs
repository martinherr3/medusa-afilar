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
/// Descripción breve de ParteFresa
/// </summary>
public class ParteFresa
{
    Int32? _IdModelo = null;

    public Int32? IdModelo
    {
        get { return _IdModelo; }
        set { _IdModelo = value; }
    }

    Int32? _IdTipo = null;

    public Int32? IdTipo
    {
        get { return _IdTipo; }
        set { _IdTipo = value; }
    }

    Int32? _IdParte = null;

    public Int32? IdParte
    {
        get { return _IdParte; }
        set { _IdParte = value; }
    }

    String _NombreParte = null;

    public String NombreParte
    {
        get { return _NombreParte; }
        set { _NombreParte = value; }
    }

    Int32? _Cantidad = null;

    public Int32? Cantidad
    {
        get { return _Cantidad; }
        set { _Cantidad = value; }
    }

    public ParteFresa()
    {
    }

    public ParteFresa(Int32? pIdModelo, Int32? pIdTipo, Int32? pIdParte, String pNombreParte, Int32? pCantidad)
    {
        this.IdModelo = pIdModelo;
        this.IdTipo = pIdTipo;
        this.IdParte = pIdParte;
        this.NombreParte = pNombreParte;
        this.Cantidad = pCantidad;
    }
}

public class ParteFresaCollection : List<ParteFresa>
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
    public void Llenar(Int32? pNroModelo, String pNombreParte)
    {
        try
        {
            SQL MySQL = new SQL();
            String Consulta = "Select idmodelo, idtipofresa, idparte, nombre, cantidad From parte ";
            String Where = "where 1=@0";

            if (pNroModelo != null)
            {
                Where = Where + " and idmodelo=" + pNroModelo;
            }
            if (pNombreParte != null)
            {
                Where = Where + " and nombre='" + pNombreParte + "'";
            }

            MySQL.SqlString = Consulta + Where;
            SqlDataReader dr;
            dr = MySQL.GetDataReader(1);

            this.Clear();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ParteFresa c = new ParteFresa(Convert.ToInt32(dr["idmodelo"]), Convert.ToInt32(dr["idtipofresa"]), Convert.ToInt32(dr["idparte"]), Convert.ToString(dr["nombre"]), Convert.ToInt32(dr["cantidad"]));

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

