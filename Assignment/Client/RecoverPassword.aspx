<%@ Page Language="C#" MasterPageFile="~/Nav.Master" AutoEventWireup="true" CodeBehind="RecoverPassword.aspx.cs" Inherits="Assignment.Client.RecoveryPassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <title></title>
    <style type="text/css">
        body {
            font-family: 'Verdana', sans-serif;
            margin: 0;
            padding: 0;
        }

        table {
            width: auto;
            margin: 0 auto;
            border-collapse: collapse;
            margin-top: 20px;
        }

            table td {
                padding: 10px;
            }

        .auto-style3 {
            width: 30%;
            text-align: right;
            padding-right: 10px;
            font-weight: bold;
            color: #333;
        }

        .auto-style4 {
            width: 5%;
            text-align: center;
            font-weight: bold;
            color: #333;
        }

        .auto-style5 {
            width: 65%;
            padding-left: 10px;
        }

        .input-field {
            width: 100%;
            padding: 8px;
            border: 1px solid #ccc;
            border-radius: 5px;
            box-sizing: border-box;
            margin-bottom: 10px;
        }

        .action-button {
            width: 100%;
            padding: 10px;
            font-size: 16px;
            cursor: pointer;
            background-color: #007BFF;
            color: #fff;
            border: none;
            border-radius: 5px;
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
        }

            .action-button:hover {
                background-color: #0056b3;
            }

            .action-button:active {
                background-color: #0056b3;
                box-shadow: 0 1px 2px rgba(0, 0, 0, 0.1);
                transform: translateY(2px);
            }

        #lblMessage {
            display: block;
            margin-top: 10px;
            text-align: center;
        }

        .auto-style9 {
            width: 30%;
            text-align: right;
            padding-right: 10px;
            font-weight: bold;
            color: #333;
            height: 49px;
        }
        .auto-style10 {
            width: 5%;
            text-align: center;
            font-weight: bold;
            color: #333;
            height: 49px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <form id="form1">
        <div id="login-container" style="text-align: center; margin: 5px auto; width: 60%;">
            <h1 style="color: #007BFF; font-size: 2em; font-weight: bold; text-align: center; background-color: #f2f2f2; padding: 20px; border-radius: 10px;">Enter the new Password</h1>
            <div style="width: 100%; background-color: #f5f5f5; border-radius: 10px; box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);">
            <table style="width: 100%;">
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
                    </td>
                    <td class="auto-style4">:</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtEmail" runat="server" Enabled="False"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail"
                            Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator><br/>
                        <asp:RegularExpressionValidator ID="revEmailFormat" runat="server" ControlToValidate="txtEmail"
                            Display="Dynamic" ErrorMessage="Invalid email format" ValidationExpression="^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"
                            ForeColor="Red"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        <asp:Label ID="Label3" runat="server" Text="New Password"></asp:Label>
                    </td>
                    <td class="auto-style10">:</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword"
                            Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator><br/>
                        <asp:RegularExpressionValidator ID="revPassword" runat="server" ControlToValidate="txtPassword"
                            Display="Dynamic" ErrorMessage="Password must be at least 8 characters and contain both letters and numbers"
                            ValidationExpression="^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$" ForeColor="Red"></asp:RegularExpressionValidator>
                    </td>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label4" runat="server" Text="Confirm Password"></asp:Label>
                    </td>
                    <td class="auto-style4">:</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvConfirmPassword" runat="server" ControlToValidate="txtConfirmPassword"
                            Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator><br/>
                        <asp:CompareValidator ID="cvPasswordMatch" runat="server" ControlToValidate="txtConfirmPassword"
                            ControlToCompare="txtPassword" Operator="Equal" Type="String" Display="Dynamic"
                            ErrorMessage="Passwords do not match" ForeColor="Red"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2"></td>
                    <td class="auto-style4"></td>
                    <td class="auto-style1">

<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" OnClientClick="if (Page_ClientValidate()) { showAlert(); return true; } else return false;" Text="Submit" CssClass="action-button"/>

                        <script type="text/javascript">
    function showAlert() {
        alert('Password recovery successful.');
    }
                        </script>
                    </td>
                </tr>
            </table>
            </div>
            <br />
                    <div style="font-size: 1.2em; color: #333; padding: 15px; margin-top: 15px;">
            <a href="Login.aspx" style="color: #007BFF; text-decoration: none; font-weight: bold;">Back To Login</a>
            If you remember your account
        </div>
            <br />
        </div>
    </form>
</asp:Content>
