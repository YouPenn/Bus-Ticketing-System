<%@ Page Language="C#" MasterPageFile="~/Nav.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Assignment.Registration.register" %>

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
                height: 60px; /* Set a fixed height for each row */
            }

        .auto-style9 {
            width: 30%;
            text-align: right;
            padding-right: 10px;
            font-weight: bold;
            color: #333;
            vertical-align: top; /* Align content to the top */
        }

        .auto-style11 {
            width: 65%;
            padding-left: 10px;
            vertical-align: top; /* Align content to the top */
        }

        .auto-style13 {
            text-align: center;
            height: 60px;
        }

        .input-field {
            width: 60%;
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

        .auto-style14 {
            text-align: center;
            height: 60px;
            width: 30%;
        }

        .auto-style16 {
            width: 65%;
            padding-left: 10px;
            vertical-align: top;
            height: 60px;
        }
        </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="content1" runat="Server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <div id="register-container" style="text-align: center; margin: 5px auto; width: 60%;">
        <div>
            <h1 style="color: #007BFF; font-size: 2em; font-weight: bold; text-align: center; background-color: #f2f2f2; padding: 20px; border-radius: 10px; margin-top: -20%;">Registration Form</h1>
            <div style="width: 100%; background-color: #f5f5f5; border-radius: 10px; box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);">
                <table style="width: 100%;">
                    <tr>
                        <td class="auto-style9">
                            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                        </td>
                        <td class="auto-style11">
                            <asp:TextBox ID="txtName" runat="server" CssClass="input-field"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName"
                                Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator><br />
                            <asp:RegularExpressionValidator ID="revName" runat="server" ControlToValidate="txtName"
                                Display="Dynamic" ErrorMessage="Invalid format (only characters allowed)" ValidationExpression="^[a-zA-Z\s]+$"
                                ForeColor="Red"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style9">
                            <asp:Label ID="Label4" runat="server" Text="Email"></asp:Label>
                        </td>
                        <td class="auto-style11">
                            <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" CssClass="input-field"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail"
                                Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator><br />
                            <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail"
                                Display="Dynamic" ErrorMessage="Invalid email format" ValidationExpression="^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"
                                ForeColor="Red"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style9">
                            <asp:Label ID="Label5" runat="server" Text="Security Questions"></asp:Label>
                        </td>
                        <td class="auto-style16">
                            <asp:RadioButton ID="radioBtnPetName" runat="server" GroupName="SecurityQuestions" OnCheckedChanged="radioBtnPetName_CheckedChanged" Text="Pet Name" AutoPostBack="True" />
                            <asp:RadioButton ID="radioBtnPrimarySchool" runat="server" GroupName="SecurityQuestions" OnCheckedChanged="radioBtnPrimarySchool_CheckedChanged" Text="Primary School" AutoPostBack="True" />
                            <asp:RadioButton ID="radioBtnFavoriteMovie" runat="server" GroupName="SecurityQuestions" OnCheckedChanged="radioBtnFavoriteMovie_CheckedChanged" Text="Favorite Movie" AutoPostBack="True" />

                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style9">Security Answer</td>
                        <td class="auto-style11">
                            <asp:TextBox ID="txtSecurityAns" runat="server" CssClass="input-field" Enabled="False"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvSecurityAns" runat="server" ControlToValidate="txtSecurityAns"
                                ErrorMessage="*" Display="Dynamic" SetFocusOnError="True" ForeColor="Red">
                            </asp:RequiredFieldValidator><br />
                            <asp:CustomValidator ID="cvNoSpacesSpecialChars" runat="server" ControlToValidate="txtSecurityAns"
                                ClientValidationFunction="validateNoSpacesSpecialChars" ErrorMessage="Special characters and spaces are not allowed"
                                ForeColor="Red" Display="Dynamic"></asp:CustomValidator>

                            <script type="text/javascript">
                                function validateNoSpacesSpecialChars(sender, args) {
                                    var value = args.Value;
                                    // Regular expression to allow only letters and numbers
                                    var regex = /^[a-zA-Z0-9]+$/;
                                    if (!regex.test(value)) {
                                        args.IsValid = false;
                                    } else {
                                        args.IsValid = true;
                                    }
                                }
                            </script>

                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style9">
                            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                        </td>
                        <td class="auto-style11">
                            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="input-field"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword"
                                Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator><br />
                            <asp:RegularExpressionValidator ID="revPassword" runat="server" ControlToValidate="txtPassword"
                                Display="Dynamic" ErrorMessage="Password must be at least 8 characters and contain both letters and numbers"
                                ValidationExpression="^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$" ForeColor="Red"></asp:RegularExpressionValidator>

                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style9">
                            <asp:Label ID="Label3" runat="server" Text="Confirm Password"></asp:Label>
                        </td>
                        <td class="auto-style11">
                            <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" CssClass="input-field"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvConfirmPassword" runat="server" ControlToValidate="txtConfirmPassword"
                                Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator><br />
                            <asp:CompareValidator ID="cvConfirmPassword" runat="server" ControlToCompare="txtPassword"
                                ControlToValidate="txtConfirmPassword" Display="Dynamic" ErrorMessage="Passwords do not match" ForeColor="Red"></asp:CompareValidator>
                        </td>
                    </tr>

                    <tr>
                        <td class="auto-style14"></td>
                        <td class="auto-style13">
                            <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="Register" CssClass="action-button" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="4">
                            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
        <div style="font-size: 1.2em; color: #333; padding: 15px; margin-top: 15px;">
            <a href="Login.aspx" style="color: #007BFF; text-decoration: none; font-weight: bold;">Back To Login</a>
            If you already have an account
        </div>
    </div>
</asp:Content>
