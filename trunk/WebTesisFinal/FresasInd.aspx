<%@ Page Language="C#" Debug="true" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="FresasInd.aspx.cs" Inherits="FresasInd" Title="Untitled Page" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <table> 
        <tr>
            <td style="height: 549px">
            </td>
            <td style="width: 576px; background-color: transparent; height: 549px;" valign="top">
                <asp:Repeater ID="Repeater1" runat="server">
                    <HeaderTemplate>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <table style="width: 700px">
                            <tr>
                                <td style="width: 1916px">
                                <b>Nombre: </b> <%# DataBinder.Eval(Container.DataItem, "nombrefresa") %></td>
                                <td style="width: 12px">
                                </td>
                                <td style="width: 876px">
                                    <a href="VerImagen.aspx?ModeloSel=<%# DataBinder.Eval(Container.DataItem, "IdModelo")%>&TipoSel=<%# DataBinder.Eval(Container.DataItem, "IdTipo")%>">
                                        Ver Imagen </a>
                                    <!--<asp:Image ID="Image1" runat="server" Height="130px" Width="148px" ImageUrl="images/afilar.jpg" BackColor="White" />-->
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 1916px" align="left" valign="middle">
                                <b>Cantidad Dientes: </b> <%# DataBinder.Eval(Container.DataItem, "cantidaddientes")%></td>
                                <td style="width: 12px" valign="middle">
                                </td>
                                <td style="width: 876px" valign="middle">
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 1916px" align="left" valign="middle">
                                <b>Precio: </b>$ <%# DataBinder.Eval(Container.DataItem, "precio")%></td>
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
