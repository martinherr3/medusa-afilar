<%@ Page Language="C#" Debug="true" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="Clientes.aspx.cs" Inherits="Clientes" Title="Untitled Page" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
     <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar Cliente"
        Width="120px" />
    <asp:Label ID="lblIdCliente" runat="server" Text="NroCliente"></asp:Label>
    <asp:TextBox ID="txtIdCliente" runat="server" Width="107px"></asp:TextBox>
    <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
    <asp:TextBox ID="txtNombre" runat="server" Width="107px"></asp:TextBox>
    <asp:Label ID="lblApellido" runat="server" Text="Apellido"></asp:Label>
    <asp:TextBox ID="txtApellido" runat="server" Width="107px"></asp:TextBox>
    <table style="width: 737px; height: 50px">
        <thead>
            <tr>
                <td width="10%" style="height: 42px; color: blue; font-weight: bold;">
                    NroCliente
                </td>
                <td width="20%" style="height: 42px; color: blue; font-weight: bold;">
                    Nombre
                </td>
                <td width="20%" style="height: 42px; color: blue; font-weight: bold;">
                    Apellido
                </td>
                <td width="20%" style="height: 42px; color: blue; font-weight: bold;">
                    Direccion
                </td>
                <td width="20%" style="height: 42px; color: blue; font-weight: bold;">
                    Telefono
                </td>
                <td style="height: 42px; color: blue; font-weight: bold; width: 6%;">
                    Pedidos
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
                            <td width="10%">
                                <%# DataBinder.Eval(Container.DataItem, "idcliente")%>
                            </td>
                            <td width="20%">
                                <%# DataBinder.Eval(Container.DataItem, "nombre")%>
                            </td>
                            <td width="20%">
                                <%# DataBinder.Eval(Container.DataItem, "apellido")%>
                            </td>
                            <td width="20%">
                                <%# DataBinder.Eval(Container.DataItem, "direccion")%>
                            </td>
                            <td width="20%">
                                <%# DataBinder.Eval(Container.DataItem, "telefono")%>
                            </td>
                            <td width="10%" style="height: 42px; color: blue; font-weight: bold;">
                                <a href="Default.aspx?ClienteSel=<%# DataBinder.Eval(Container.DataItem, "idcliente")%>">
                                        <img src="Images\Fresa.gif" style="width: 25px; height: 25px" /> </a>
                                
                            </td>
                        </tr>
                    </table> 
                </ItemTemplate> 
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
