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
/// Descripción breve de Pedido
/// </summary>
public class Pedido
{
    private Int32? _IdPedido=null;

    public Int32? IdPedido
    {
        get { return _IdPedido; }
        set { _IdPedido = value; }
    }
    
    private String _Estado=null;

    public String Estado
    {
        get { return _Estado; }
        set { _Estado = value; }
    }

    private DateTime? _FechaRealizacion = null;

    public DateTime? FechaRealizacion
    {
        get { return _FechaRealizacion; }
        set { _FechaRealizacion = value; }
    }

    private Int32? _IdCliente = null;

    public Int32? IdCliente
    {
        get { return _IdCliente; }
        set { _IdCliente = value; }
    }

    private String _ApellidoCliente = null;

    public String ApellidoCliente
    {
        get { return _ApellidoCliente; }
        set { _ApellidoCliente = value; }
    }

    private String _EstadoPedido = null;

    public String EstadoPedido
    {
        get { return _EstadoPedido; }
        set { _EstadoPedido = value; }
    }

	public Pedido()
	{

	}
    public Pedido(Int32? pId, String pIdEstado, DateTime? pFechaRea, Int32? pIdCliente, String pApellido, String pEstado)
    {
        this.IdPedido = pId;
        this.Estado = pIdEstado;
        this.FechaRealizacion = pFechaRea;
        this.IdCliente = pIdCliente;
        this.ApellidoCliente = pApellido;
        this.EstadoPedido = pEstado;
    }
}

public class PedidosCollection: List<Pedido>
{
    public void Llenar()
    {
        Llenar(null, null);
    }
    /// <summary>
    /// Llena la coleccion de pedidos segun el criterio
    /// </summary>
    /// <param name="pTipo">El valor 1 indica que busca por IdPedido, 2 por estado de Pedido</param>
    /// <param name="pValor">El Id o Estado a buscar</param>


    public void Llenar(Int32? pTipo, Int32? pValor)
    {
        try
        {
            SQL MySQL = new SQL();
            String Consulta = "Select idpedido, fecharealizacion, Pedido.idestado as IdEstado, prioridad, Pedido.idcliente, Cliente.Apellido as Apellido, Estado.Nombre as NombreEstado From Pedido inner join Cliente on Pedido.idcliente=Cliente.idcliente inner join Estado on Pedido.idestado=Estado.idestado";

            switch (pTipo)
            { 
                case 1: //Por IdPedido
                    Consulta = Consulta + " where Pedido.idpedido=@0";
                    break;
                
                case 2: //Por Estado
                    Consulta = Consulta + " where Pedido.idestado=@0";
                    break;

                case 3: //Por IdCliente
                    Consulta = Consulta + " where Pedido.idcliente=@0";
                    break;
               default:
                   Consulta = Consulta + " where 1=@0";
                   break;
            }

            MySQL.SqlString = Consulta;
            SqlDataReader dr;
            if (pValor == null)
            {
                dr = MySQL.GetDataReader(1);
            }
            else
            {
                dr = MySQL.GetDataReader(pValor);
            }

            this.Clear();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Pedido p = new Pedido(Convert.ToInt32(dr["idpedido"]), Convert.ToString(dr["idestado"]), Convert.ToDateTime(dr["fecharealizacion"]), Convert.ToInt32(dr["idcliente"]), Convert.ToString(dr["Apellido"]), Convert.ToString(dr["NombreEstado"]));
                                                                                                 
                    this.Add(p);
                }
            }
        }
        catch (Exception ex)
        {

            throw ex;
        }
        
    }

}