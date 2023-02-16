<%@ import Namespace="RSVP_L4" %>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Summary_Partial.aspx.cs" Inherits="RSVP_L4.Summary_Partial" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Участники семинара</title>
    <link rel="stylesheet" href="Style.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Приглашения</h2>
            <h3>слушатели без доклада: </h3>
            <table>
                <thead>
                    <tr>
                        <th>Имя</th>
                        <th>Email</th>
                        <th>Телефон</th>
                    </tr>
                </thead>
                <tbody>
                    <%= GetNoShowHtml() %>
                </tbody>
                
            </table>
            
            <h3>слушатели с докладом: </h3>
            <table>
                <thead>
                    <tr>
                        <th>Имя</th>
                        <th>Email</th>
                        <th>Телефон</th>
                    </tr>
                </thead>
                <tbody>
                    <%= GetShowHtml() %>
                </tbody>
                
            </table>
        </div>
    </form>
</body>
</html>
