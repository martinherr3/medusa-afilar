<%@ Page Language="C#" Debug="true" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="Partes.aspx.cs" Inherits="Partes" Title="Untitled Page" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <table> 
        <tr>
            <td style="height: 555px">
            </td>
            <td style="width: 576px; background-color: transparent; height: 555px;" valign="top">
                <asp:Repeater ID="Repeater1" runat="server">
                    <HeaderTemplate>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <table style="width: 700px">
                            <tr>
                                <td style="width: 1916px">
                                <b>Nombre: </b> <%# DataBinder.Eval(Container.DataItem, "nombreparte") %></td>
                                <td style="width: 12px">
                                </td>
                                <td style="width: 876px">
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 1916px" align="left" valign="middle">
                                <b>Cantidad: </b> <%# DataBinder.Eval(Container.DataItem, "cantidad")%></td>
                                <td style="width: 12px" valign="middle">
                                </td>
                                <td style="width: 876px" valign="middle">
                                </td>
                            </tr>
                            <tr>
                                <td style="height: 41px">
                                </td>
                                <td style="width: 1916px; height: 41px">
                                </td>
                                <td style="width: 12px; height: 41px">
                                </td>
                                <td style="width: 876px; height: 41px">
                                </td>
                            </tr>
                        </table>
                        <hr />
                    </ItemTemplate>
                    <FooterTemplate>
                    </FooterTemplate>
                </asp:Repeater>
            </td>
        </tr>
    </table>
</asp:Content>

