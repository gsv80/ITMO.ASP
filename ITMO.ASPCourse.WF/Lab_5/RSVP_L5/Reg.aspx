<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reg.aspx.cs" Inherits="RSVP_L5.Reg" UnobtrusiveValidationMode="None" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>RSVP-Регистрация</title>
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
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ErrorMessage="Заполните поле 'Имя'" 
                    ControlToValidate="name" 
                    ForeColor="Red"> 
                        Не оставляйте пустым
                </asp:RequiredFieldValidator>
            </div>
            <div>
                <label>Ваш email:</label>
                <asp:TextBox ID="email" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ErrorMessage="Заполните поле 'Email'" 
                    ControlToValidate="email" 
                    ForeColor="Red"> 
                        Не оставляйте пустым
                </asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator runat="server" ControlToValidate="email"
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                    ErrorMessage="E-mail is not in a valid format" 
                    Display="Dynamic"
                    ForeColor="Red">
                        Адрес введен неверно!!!
                </asp:RegularExpressionValidator>

            </div>
            <div>
                <label>Ваш телефон:</label>
                <asp:TextBox ID="phone" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ErrorMessage="Заполните поле 'Телефон'" 
                    ControlToValidate="phone" 
                    ForeColor="Red"> 
                        Не оставляйте пустым
                </asp:RequiredFieldValidator>
            </div>
            <div>
                 <label>Вы будете делать доклад?</label>
                 <asp:CheckBox ID="CheckBoxYN" runat="server" />
            </div>
            <div>
                <asp:ValidationSummary ID="validationSummary" runat="server" ShowModelStateErrors="true" />
            </div>
            <div>
                <button type="submit">Отправить ответ на приглашение RSVP </button>
            </div>
        </div>
    </form>
</body>
</html>
