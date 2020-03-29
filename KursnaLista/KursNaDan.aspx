<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KursNaDan.aspx.cs" Inherits="KursnaLista.KursnaListaForma" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: 48px; font-style: italic; font-weight: bold; background-color: #66CCFF; color: #FFFFFF;">
            Курс на дан</div>

        <p>
            Унеси датум:</p>
        <p>
            <asp:TextBox ID="tbDatum" runat="server" type="date"></asp:TextBox>
        </p>
        <p>
            Одреди валуту:</p>
        <asp:DropDownList ID="dplValuta1" runat="server">
            <asp:ListItem Value="Dinar">Dinar (RSD)</asp:ListItem>
            <asp:ListItem Value="Evro">Evro (EUR)</asp:ListItem>
            <asp:ListItem>Dolar (USD)</asp:ListItem>
        </asp:DropDownList>
        <p>
            <asp:Button ID="btPrikazi" runat="server" Text="Прикажи курс" OnClick="btPrikazi_Click" />
        </p>
        <asp:TextBox ID="tbKurs" runat="server" type="number" ReadOnly="True"></asp:TextBox>
        </form>
    </body>
</html>
