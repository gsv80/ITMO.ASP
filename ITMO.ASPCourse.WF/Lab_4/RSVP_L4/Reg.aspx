<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reg.aspx.cs" Inherits="RSVP_L4.Reg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Приглашаем на семинар</h1>
            <br />
            <div>
                <label>Ваше имя:</label>
                <asp:TextBox ID="name" runat="server"></asp:TextBox>
            </div>
            <div>
                <label>Ваш email:</label>
                <asp:TextBox ID="email" runat="server"></asp:TextBox>
            </div>
            <div>
                <label>Ваш телефон:</label>
                <asp:TextBox ID="phone" runat="server"></asp:TextBox>
            </div>
            <div>
                 <label>Вы будете делать доклад?</label>
                 <asp:CheckBox ID="CheckBoxYN" runat="server" />
            </div>
            <div>
                <button type="submit">Отправить ответ на приглашение RSVP </button>
            </div>
        </div>
    </form>
</body>
</html>
