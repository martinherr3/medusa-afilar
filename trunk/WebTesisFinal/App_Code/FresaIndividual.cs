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
/// Descripción breve de FresaIndividual
/// </summary>
public class FresaIndividual
{
    Int32? _IdTipo = null;

    public Int32? IdTipo
    {
        get { return _IdTipo; }
        set { _IdTipo = value; }
    }

    Int32? _IdModelo = null;

    public Int32? IdModelo
    {
        get { return _IdModelo; }
        set { _IdModelo = value; }
    }

    String _NombreFresa = null;

    public String NombreFresa
    {
        get { return _NombreFresa; }
        set { _NombreFresa = value; }
    }

    Int32? _CantidadDientes = null;

    public Int32? CantidadDientes
    {
        get { return _CantidadDientes; }
        set { _CantidadDientes = value; }
    }

    
    private Decimal? _Precio = null;

    public Decimal? Precio
    {
        get { return _Precio; }
        set { _Precio = value; }
    }

    private Byte[] _Imagen;

    public Byte[] Imagen
    {
        get { return _Imagen; }
        set { _Imagen = value; }
    }
 



    public FresaIndividual()
    {
    }

    public FresaIndividual(Int32? pIdTipo, Int32? pIdModelo, String pNombreFresa, Int32? pCantidadDientes, Decimal? pPrecio, Byte[] pImagen)
    {
        this.IdTipo = pIdTipo;
        this.IdModelo = pIdModelo;
        this.NombreFresa = pNombreFresa;
        this.CantidadDientes = pCantidadDientes;
        this.Precio = pPrecio;
        this.Imagen = pImagen;
    }
}

public class FresasIndividualCollection : List<FresaIndividual>
{
    public void Llenar()
    {
        Llenar(null, null, null);
    }
    /// <summary>
    /// Llena la coleccion de Clientes segun el criterio
    /// </summary>
    /// <param name="pNroModelo">Id del cliente a Buscar</param>
    /// <param name="pNombreModelo">Nombre a buscar</param>
    public void Llenar(Int32? pNroModelo, String pNombreFresa, Int32? pTipo)
    {
        try
        {
            SQL MySQL = new SQL();
            String Consulta = "Select idtipo, idmodelo, nombre, cantidaddientes, precio, imagen From tipofresa ";
            String Where = "where 1=@0";

            if (pNroModelo != null)
            {
                Where = Where + " and idmodelo=" + pNroModelo;
            }
            if (pNombreFresa != null)
            {
                Where = Where + " and nombre='" + pNombreFresa + "'";
            }
            if (pTipo != null)
            {
                Where = Where + " and idtipo=" + pTipo;
            }
            MySQL.SqlString = Consulta + Where;
            SqlDataReader dr;
            dr = MySQL.GetDataReader(1);

            this.Clear();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    FresaIndividual c = new FresaIndividual(Convert.ToInt32(dr["idtipo"]), Convert.ToInt32(dr["idmodelo"]), Convert.ToString(dr["nombre"]), Convert.ToInt32(dr["cantidaddientes"]), Convert.ToDecimal(dr["precio"]), (Byte[])dr["imagen"]);

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

