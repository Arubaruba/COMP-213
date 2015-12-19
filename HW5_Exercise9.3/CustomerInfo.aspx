<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerInfo.aspx.cs" Inherits="HW5_Exercise9._3.CustomerInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Customer</title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/foundation/6.0.5/css/foundation.min.css" />
    <style type="text/css">
        .auto-style2 {
            width: 231px;
            line-height: 20px !important;
        }
        .main-title {
            margin: 30px 0;
        }
        .auto-style3 tr {
            line-height: 40px;
        }
        .validator {
            font-size: 14px;
            font-weight: bold;
            color: #ff0000;
            margin-bottom: 20px;
        }
    </style>
</head>
<body>
    <div class="row">
        <h2 class="main-title">Customer Information</h2>
        <form id="form1" runat="server">
            <table class="auto-style3">
                <tr>
                    <td class="auto-style2">Name
                        <span class="validator">
                            <asp:RequiredFieldValidator ID="nameRequiredFieldValidator" runat="server" ControlToValidate="nameTextBox" ErrorMessage="(Required)"></asp:RequiredFieldValidator>
                        </span>
                    </td>
                    <td>
                        <asp:TextBox ID="nameTextBox" runat="server" Width="204px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Email
                        <span class="validator">
                            <asp:RequiredFieldValidator ID="emailRequiredFieldValidator" runat="server" ControlToValidate="emailTextBox" ErrorMessage="(Required)"></asp:RequiredFieldValidator>
                        </span>
                    </td>
                    <td>
                        <asp:TextBox ID="emailTextBox" runat="server" Width="204px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Username
                        <span class="validator">
                            <asp:RequiredFieldValidator ID="usernameRequiredFieldValidator" runat="server" ControlToValidate="usernameTextBox" ErrorMessage="(Required)"></asp:RequiredFieldValidator>
                        </span>
                    </td>
                    <td>
                        <asp:TextBox ID="usernameTextBox" runat="server" Width="204px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Password
                        <span class="validator">
                            <asp:RequiredFieldValidator ID="passwordRequiredFieldValidator" runat="server" ControlToValidate="passwordTextBox" ErrorMessage="(Required)"></asp:RequiredFieldValidator>
                        </span>
                    </td>
                    <td>
                        <asp:TextBox ID="passwordTextBox" runat="server" Width="204px" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Repeat Password
                    </td>
                    <td>
                        <asp:TextBox ID="repeatPasswordTextBox" runat="server" Width="204px" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <div class="validator">
                <asp:Label ID="passwordsNotMatchingLabel" runat="server" Text="Passwords do not match. Please input again." Visible="False"></asp:Label>
            </div>
            &nbsp;<asp:Button ID="addCustomerButton" runat="server" CssClass="button" Text="Add Customer" OnClick="addCustomerButton_Click" ValidateRequestMode="Enabled" />
        </form>
    </div>
</body>
</html>
