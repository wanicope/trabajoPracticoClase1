<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formAltaPartidos.aspx.cs" Inherits="trabajoPracticoClase1.formAltaPartidos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<body>
    <form id="form1" runat="server">
        <div id="1" style="width: 323px; text-align: center">
            <strong style="text-align: center">Equipo A<br />
            </strong>Nombre: <asp:TextBox ID="txtNombreA" runat="server"></asp:TextBox>
            <br />
            Puntos: 
            <asp:TextBox ID="txtPuntosA" runat="server"></asp:TextBox>
            <br />
        </div>
        <div id="2" style="width: 323px; text-align: center">
    <strong style="text-align: center">Equipo B<br />
    </strong>Nombre: <asp:TextBox ID="txtNombreB" runat="server"></asp:TextBox>
    <br />
    Puntos: 
    <asp:TextBox ID="txtPuntosB" runat="server"></asp:TextBox>
    <br />
</div>
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem Value="mas">Gana equipo con mayor puntuacion</asp:ListItem>
            <asp:ListItem Value="menos">Gana equipo con menor puntuacion</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Button ID="botonEnviar" runat="server" BackColor="Black" ForeColor="White" Text="Enviar" OnClick="botonEnviar_Click" />
        <br /><br />
        <asp:Label ID="labelDatos" runat="server"></asp:Label>
    </form>
</body>
</html>
