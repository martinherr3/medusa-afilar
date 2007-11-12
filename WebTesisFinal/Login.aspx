<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Página sin título</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div style="text-align: center">
            <table border="0" cellpadding="0" cellspacing="0" style="width: 100%; height: 100%">
                <tr>
                    <td style="width: 202px; height: 100px">
                    </td>
                    <td style="width: 351px; height: 100px">
                    </td>
                    <td style="height: 100px">
                    </td>
                </tr>
                <tr>
                    <td style="width: 202px; height: 200px">
                    </td>
                    <td style="width: 351px; height: 200px" align="left">
                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                        <asp:Label ID="Label3" runat="server" Text="Ingrese su nombre de usuario y contraseña"></asp:Label><br />
                        <br />
                        <asp:Label ID="Label1" runat="server" Text="Nombre de Usuario:"></asp:Label>&nbsp;
                        <asp:TextBox
                            ID="txtUsuario" runat="server"></asp:TextBox><br />
                        <asp:Label ID="Label2" runat="server" Text="Contraseña:"></asp:Label>
                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                        <asp:TextBox
                            ID="txtPassword" runat="server" TextMode="Password"
                            Width="149px"></asp:TextBox><br />
                        <br />
                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                        &nbsp; &nbsp; &nbsp;&nbsp;
                        <asp:Button ID="Button1" runat="server" Text="Aceptar" OnClick="Button1_Click" /><br />
                        <br />
                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                        &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                        <br />
                        <asp:Label ID="Label4" runat="server" ForeColor="Red"></asp:Label></td>
                    <td style="height: 200px">
                    </td>
                </tr>
                <tr>
                    <td style="width: 202px">
                    </td>
                    <td style="width: 351px">
                    </td>
                    <td>
                    </td>
                </tr>
            </table>
        </div>
    
    </div>
    </form>
</body>
</html>
