<%@ Page Language="C#" Debug="true" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" Title="Untitled Page" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
     <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar Pedido"
        Width="120px" />
    <asp:Label ID="lblIdPedido" runat="server" Text="Nro de Pedido "></asp:Label>
    <asp:TextBox ID="txtIdPedido" runat="server" Width="107px"></asp:TextBox>
    <table style="width: 737px; height: 50px">
        <thead>
            <tr>
                <td width="15%" style="height: 42px; color: blue; font-weight: bold;">
                    NroPedido
                </td>
                <td width="25%" style="height: 42px; color: blue; font-weight: bold;">
                    Estado
                </td>
                <td width="30%" style="height: 42px; color: blue; font-weight: bold;">
                    FechaRealizacion
                </td>
                <td width="30%" style="height: 42px; color: blue; font-weight: bold;">
                    Cliente
                </td>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate>
            </HeaderTemplate>
                <ItemTemplate>
                    <table style="width: 700px" border="0">
                        <tr>
                            <td width="05%">
                                <%# DataBinder.Eval(Container.DataItem, "idpedido")%>
                            </td>
                            <td width="15%">
                                <%# DataBinder.Eval(Container.DataItem, "EstadoPedido")%>
                            </td>
                            <td width="15%">
                                <%# DataBinder.Eval(Container.DataItem, "FechaRealizacion")%>
                            </td>
                            <td width="15%">
                                <%# DataBinder.Eval(Container.DataItem, "ApellidoCliente")%>
                            </td>
                        </tr>
                    </table> 
                </ItemTemplate> 
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
