<%@ import Namespace="RSVP_L3" %>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Summary_Partial.aspx.cs" Inherits="RSVP_L3.Summary_Partial" %>

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
        </div>
    </form>
</body>
</html>
