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
using System.Text;

/// <summary>
/// Descripción breve de Cliente
/// </summary>
public class Cliente
{
    Int32? _IdCliente=null;

    public Int32? IdCliente
    {
        get { return _IdCliente; }
        set { _IdCliente = value; }
    }

    String _Nombre = null;

    public String Nombre
    {
        get { return _Nombre; }
        set { _Nombre = value; }
    }

    String _Apellido = null;

    public String Apellido
    {
        get { return _Apellido; }
        set { _Apellido = value; }
    }

    String _Direccion = null;

    public String Direccion
    {
        get { return _Direccion; }
        set { _Direccion = value; }
    }

    String _Telefono = null;

    public String Telefono
    {
        get { return _Telefono; }
        set { _Telefono = value; }
    }


	public Cliente()
	{
	}

    public Cliente(Int32? pIdCliente, String pNombre, String pApellido, String pDireccion, String pTelefono)
    {
        this.IdCliente = pIdCliente;
        this.Nombre = pNombre;
        this.Apellido = pApellido;
        this.Direccion = pDireccion;
        this.Telefono = pTelefono;
    }
}

public class ClientesCollection : List<Cliente>
{
    public void Llenar()
    {
        Llenar(null, null, null);
    }
    /// <summary>
    /// Llena la coleccion de Clientes segun el criterio
    /// </summary>
    /// <param name="pNroCliente">Id del cliente a Buscar</param>
    /// <param name="pNombre">Nombre a buscar</param>
    /// <param name="pApellido">Apellido a buscar</param>

    public void Llenar(Int32? pNroCliente, String pNombre, String pApellido)
    {
        try
        {
            SQL MySQL = new SQL();
            String Consulta = "Select idcliente, nombre, apellido, direccion, telefono From Cliente ";
            String Where = "where 1=@0";

            if (pNroCliente != null)
            {
                Where = Where + " and idcliente=" + pNroCliente; 
            }
            if (pNombre != null)
            {
                Where = Where + " and nombre='" + pNombre + "'";
            }
            if (pApellido != null)
            {
                Where = Where + " and apellido='" + pApellido + "'";
            }

            MySQL.SqlString = Consulta + Where;
            SqlDataReader dr;
            dr = MySQL.GetDataReader(1);

            this.Clear();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Cliente c = new Cliente(Convert.ToInt32(dr["idcliente"]), Convert.ToString(dr["nombre"]), Convert.ToString(dr["apellido"]), Convert.ToString(dr["direccion"]), Convert.ToString(dr["telefono"]));

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