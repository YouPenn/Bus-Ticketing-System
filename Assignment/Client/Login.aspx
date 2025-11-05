<%@ Page Language="C#" MasterPageFile="~/Nav.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Assignment.Login" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
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

        .auto-style1 {
            text-align: center;
            height: 33px;
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
        .auto-style6 {
            text-align: center;
            height: 33px;
            font-weight: bold;
            color: #007BFF;
        }
        .auto-style7 {
            text-decoration: none;
        }
        .auto-style8 {
            color: #007BFF;
        }
        .auto-style9 {
            text-align: center;
            height: 33px;
            width: 5%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content1" runat="Server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <div id="login-container" style="text-align: center; margin: 5px auto; width: 60%;">
        <div>
            <h1 style="color: #007BFF; font-size: 2em; font-weight: bold; text-align: center; background-color: #f2f2f2; padding: 20px; border-radius: 10px;">Log In</h1>
            <div style="width: 100%; background-color: #f5f5f5; border-radius: 10px; box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);">
                <table style="width: 100%;">
                    <tr>
                        <td class="auto-style3">
                            <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
                        </td>
                        <td class="auto-style4">:</td>
                        <td class="auto-style5" colspan="2">
                            <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" CssClass="input-field" style="width: 80%;" AutoPostBack="True" OnTextChanged="txtEmail_TextChanged1"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail"
                                Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Login"></asp:RequiredFieldValidator><br />
                            <asp:RegularExpressionValidator ID="revEmailFormat" runat="server" ControlToValidate="txtEmail"
                                Display="Dynamic" ErrorMessage="Invalid email format" ValidationExpression="^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"
                                ForeColor="Red" ValidationGroup="Login"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">
                            <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label>
                        </td>
                        <td class="auto-style4">:</td>
                        <td class="auto-style5" colspan="2">
                            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="input-field" style="width: 80%;"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword"
                                Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="Login"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6"><a class="auto-style7" href="ForgotPassword.aspx"><span class="auto-style8">Forgot Password?</span></a></td>
                        <td class="auto-style9"></td>
                        <td class="auto-style1">
                            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" CssClass="action-button" ValidationGroup="Login" />
                        </td>
                        <td class="auto-style1">
                            <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click1" Text="Back" CssClass="action-button" CausesValidation="False" ValidationGroup="Login" />
                        </td>
                    </tr>

                    <tr>
                        <td colspan="4">
                            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
                        </td>
                    </tr>
                </table>
            </div>
            <br />
        </div>
        <br />
        <div style="font-size: 1.2em; color: #333; padding: 15px; margin-top: 15px;">
            <a href="Register.aspx" style="color: #007BFF; text-decoration: none; font-weight: bold;">Click here to Register</a>
            If you do not have an account before
        </div>
    </div>
</asp:Content>



<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="Server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder4" runat="Server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
