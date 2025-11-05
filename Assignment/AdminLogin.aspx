<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="Assignment.AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Login</title>
    <style type="text/css">
        body {
            background-color: #fff; /* White color */
            color: #3498db; /* Blue color */
            font-family: 'Verdana', sans-serif;
            margin: 0;
        }

        #container {
            display: flex;
            align-items: center;
            justify-content: center;
            height: 100vh;
        }

        #login-form {
            width: 50%;
        }

        table {
            width: 100%;
            font-size: 24px; /* Increased font size */
        }

        td.label {
            width: 30%;
            text-align: right;
            padding-right: 15px;
            font-weight: bold;
            color: #3498db; /* Blue color */
        }

        td.separator {
            width: 5%;
            text-align: center;
            font-weight: bold;
        }

        td.input-field {
            width: 65%;
            padding-left: 15px;
        }

        .action-button {
            width: 100%;
            padding: 20px; /* Increased padding */
            font-size: 28px; /* Increased font size */
            cursor: pointer;
            background-color: #3498db; /* Blue color */
            color: #fff; /* White color */
            border: none;
            border-radius: 5px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.3);
            margin-top: 20px; /* Increased margin-top */
        }

        #LoginStatus {
            display: block;
            margin-top: 20px; /* Increased margin-top */
            text-align: center;
            font-size: 20px; /* Increased font size */
            color: #3498db; /* Blue color */
        }

        td.input-field input {
            vertical-align: middle;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="container">
            <div id="login-form">
                <asp:Label ID="Label1" runat="server" Text="Admin Login" Font-Size="36px" Font-Bold="true" ForeColor="#ff8c00"></asp:Label>

                <br />
                <br />
                <table>
                    <tr>
                        <td class="label">
                            <asp:Label ID="ID" runat="server" Text="Admin ID"></asp:Label>
                        </td>
                        <td class="separator">:</td>
                        <td class="input-field">
                            <br/>
                            <br/>
                            <asp:TextBox ID="InputID" runat="server" Style="width: calc(100% - 30px); padding: 15px; border: 1px solid #3498db; border-radius: 5px; box-sizing: border-box; margin-bottom: 15px; background-color: #fff; color: #3498db;"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="AdminIDRequiredValidator" runat="server" ControlToValidate="InputID" ErrorMessage="*" ForeColor="Red">*</asp:RequiredFieldValidator>
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td class="label">
                            <asp:Label ID="AdminPassword" runat="server" Text="Password"></asp:Label>
                        </td>
                        <td class="separator">:</td>
                        <td class="input-field">
                            <br/>
                            <br/>
                            <asp:TextBox ID="InputPassword" runat="server" TextMode="Password" Style="width: calc(100% - 30px); padding: 15px; border: 1px solid #3498db; border-radius: 5px; box-sizing: border-box; margin-bottom: 15px; background-color: #fff; color: #3498db;"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="InputPassword" ErrorMessage="*" ForeColor="Red">*</asp:RequiredFieldValidator>
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:Button ID="AdLogin" runat="server" OnClick="AdLogin_Click" Text="Login" CssClass="action-button" />
                            <asp:Button ID="Button1" runat="server" OnClick="Back_Click" Text="Back" CssClass="action-button" CausesValidation="false" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:Label ID="LoginStatus" runat="server" Text="" ForeColor="Red"></asp:Label>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </form>
</body>
</html>
