<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="БИПиТ2._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
            <asp:Label id="label1" 
                AssociatedControlId="N" 
                Text="Число разбиения:" 
                runat="server" />
            <asp:TextBox id="N" 
                TextMode="Number"
                runat="server" 
                min="-10" max="10000000" step="1"/>
            <asp:CustomValidator ID="CustomValidator2" runat="server" ControlToValidate="N" ErrorMessage="Число должно быть положительным" ForeColor="Red" OnServerValidate="CustomValidator2_ServerValidate"></asp:CustomValidator>
            <asp:RequiredFieldValidator id="RequiredFieldValidator_N"
                ControlToValidate="N"
                Display="Static"
                ErrorMessage="Поле не должно быть пустым"
                ForeColor ="Red"
                runat="server">
            </asp:RequiredFieldValidator></p><p>
            <asp:Label id="label2" 
                AssociatedControlId="M" 
                Text="Количество потоков:" 
                runat="server" />
            <asp:TextBox id="M" 
                TextMode="Number"
                runat="server" 
                min="-10" max="10" step="1"/>
            <asp:CustomValidator ID="CustomValidator3" runat="server" ControlToValidate="M" ErrorMessage="Число должно быть положительным" ForeColor="Red" OnServerValidate="CustomValidator3_ServerValidate"></asp:CustomValidator>
            <asp:RequiredFieldValidator id="RequiredFieldValidator_M"
                ControlToValidate="M"
                Display="Static"
                ErrorMessage="Поле не должно быть пустым"
                ForeColor ="Red"
                runat="server">
            </asp:RequiredFieldValidator></p>
            <asp:Button ID="Button1" runat="server" Text="Вычислить" OnClick="Button1_Click" />
            <p>
               <asp:label runat="server" id="total"></asp:label>
            </p>
        </div>
    </form>
</body>
</html>
