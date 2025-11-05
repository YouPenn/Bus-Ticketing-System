<%@ Page Language="C#" MasterPageFile="~/Nav.Master" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="Assignment.Payment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        body {
            font-family: 'Verdana', sans-serif;
            margin: 0;
            padding: 0;
        }

        h2 {
            color: #333;
        }

        .custom-label {
            font-size: 20px;
            color: #3498db;
            /* Add styles from your homepage here */
        }

        /* Apply styles to form elements */
        .custom-input,
        .dropdown-list,
        .custom-dropdown,
        .custom-date {
            width: auto;
            padding: 10px;
            margin-bottom: 10px;
            box-sizing: border-box;
            font-size: 16px;
            color: #333;
            border: 1px solid #3498db;
            border-radius: 5px;
        }

            .custom-input:focus,
            .dropdown-list:focus,
            .custom-dropdown:focus,
            .custom-date:focus {
                outline: none;
                box-shadow: 0 0 5px rgba(52, 152, 219, 0.8);
            }

        .error-message {
            color: #FF3300;
        }

        .btn-pay {
            background-color: #3498db;
            color: #fff;
            padding: 10px 15px;
            font-size: 16px;
            cursor: pointer;
            border: none;
            border-radius: 4px;
        }

            .btn-pay:hover {
                background-color: #45a049;
            }

        .auto-style1 {
            width: 411px;
        }

        .auto-style2 {
            width: 166px;
        }

        .auto-style3 {
            width: 383px;
        }

        .auto-style4 {
            width: 126px;
        }

        .auto-style5 {
            width: 37px;
        }
        .auto-style6 {
            height: 29px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="content1" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <form id="form1">
        <div>
            <br />

            <div>
                <a href="../Client/Homepage.aspx" style="text-decoration: none;">
                    <asp:Label ID="Home" runat="server" Text="Home" CssClass="custom-label"></asp:Label>
                    <asp:Image ID="Image4" runat="server" Height="20px" ImageUrl="~/image/Arrow.png" Width="20px" />
                </a>

                <a href="../Client/Seat.aspx" style="text-decoration: none;">
                    <asp:Label ID="Seat" runat="server" Text="Seat" CssClass="custom-label"></asp:Label>
                    <asp:Image ID="Image5" runat="server" Height="20px" ImageUrl="~/image/Arrow.png" Width="20px" />
                </a>

                <asp:Label ID="a" runat="server" Text="Payment" CssClass="custom-label" ForeColor="#ff8c00"></asp:Label>
            </div>

            <br />
            <asp:Label ID="PaymentPage" runat="server" CssClass="custom-label" Text="PAYMENT PAGE" ForeColor="Fuchsia"></asp:Label>
            <br />
            <br />
            <table style="width: 100%;">
                <tr>
                    <td colspan="3" class="auto-style6">
                        <asp:Label ID="TicketCollectorInformation" runat="server" CssClass="custom-label" Text="Ticket Collector Information"></asp:Label>
                        &nbsp;<asp:Label ID="lblCustomerID" runat="server"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Name" runat="server" CssClass="custom-label" Text="Name"></asp:Label>
                    </td>
                    <td class="auto-style5">:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtCustomerName" runat="server" CssClass="custom-input" OnTextChanged="txtCustomerName_TextChanged" ></asp:TextBox>
<asp:RequiredFieldValidator ID="rfvCustomerName" runat="server" ControlToValidate="txtCustomerName"
    Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtCustomerName"
    ValidationExpression="[a-zA-Z ]*$" ErrorMessage="Valid characters: Alphabets and space." Display="Dynamic" ForeColor="Red"/>
&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="ContectNo" runat="server" CssClass="custom-label" Text="ContectNo" AutoPostBack="true"></asp:Label>
                    </td>
                    <td class="auto-style5">:</td>
                    <td>
                        <asp:TextBox ID="txtContectNo" CssClass="custom-input" runat="server" OnTextChanged="txtContectNo_TextChanged" ></asp:TextBox>
<asp:RequiredFieldValidator ID="rfvContectNo" runat="server" ControlToValidate="txtContectNo"
    Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
<asp:RegularExpressionValidator ID="regexValidator" runat="server" ControlToValidate="txtContectNo" ValidationExpression="^\d{3}-\d{7}|\d{3}-\d{8}$" ErrorMessage="Invalid number format. Please use xxx-xxxxxxx or xxx-xxxxxxxx." Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                    </td>
                </tr>

            </table>
            <br />
            &nbsp;<br />
            <br />
            <asp:Label ID="TicketInformation" runat="server" CssClass="custom-label" Text="Ticket Information" ForeColor="Fuchsia"></asp:Label>
            <br />
            <table style="width: 100%;">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="label1" runat="server" CssClass="custom-label" Text="Schedule ID"></asp:Label>
                    </td>
                    <td class="auto-style6">:
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtScheduleID" CssClass="custom-input" runat="server" Enabled="False"></asp:TextBox>
                    </td>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style1">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="label2" runat="server" CssClass="custom-label" Text="Ticket ID"></asp:Label>
                    </td>
                    <td class="auto-style8">:
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtTicketID" CssClass="custom-input" runat="server" Enabled="False"></asp:TextBox>
                    </td>
                    <td class="auto-style11"></td>
                    <td class="auto-style8"></td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Date" runat="server" CssClass="custom-label" Text="Date"></asp:Label>
                    </td>
                    <td class="auto-style8">:
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtDate" runat="server" CssClass="custom-input" Enabled="False"></asp:TextBox>
                    </td>
                    <td class="auto-style11"></td>
                    <td class="auto-style8"></td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Time" runat="server" CssClass="custom-label" Text="Time"></asp:Label>
                    </td>
                    <td class="auto-style6">:
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtTime" runat="server" CssClass="custom-input" Enabled="False"></asp:TextBox>
                    </td>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style1">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Origin" runat="server" CssClass="custom-label" Text="Origin / Start"></asp:Label>
                    </td>
                    <td class="auto-style6">:
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtOrigin" runat="server" CssClass="custom-input" Enabled="False"></asp:TextBox>
                    </td>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Destination" runat="server" CssClass="custom-label" Text="Destination"></asp:Label>
                    </td>
                    <td class="auto-style8">:
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtDestination" runat="server" CssClass="custom-input" Enabled="False"></asp:TextBox>
                    </td>
                    <td class="auto-style11"></td>
                    <td class="auto-style8"></td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Bus" runat="server" CssClass="custom-label" Text="Bus Number"></asp:Label>
                    </td>
                    <td class="auto-style8">:
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtBusID" runat="server" CssClass="custom-input" Enabled="False"></asp:TextBox>
                    </td>
                    <td class="auto-style11"></td>
                    <td class="auto-style8"></td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="SeatNumber" runat="server" CssClass="custom-label" Text="Seat ID"></asp:Label>
                    </td>
                    <td class="auto-style8">:
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtSeatID" runat="server" CssClass="custom-input" Enabled="False"></asp:TextBox>
                    </td>
                    <td class="auto-style11"></td>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="SeatID" runat="server" CssClass="custom-label" Text="Seat Number"></asp:Label>
                    </td>
                    <td class="auto-style8">:
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtSeatNumber" runat="server" CssClass="custom-input" Enabled="False"></asp:TextBox>
                    </td>
                    <td class="auto-style11">
                        <asp:Label ID="TotalPrice" runat="server" CssClass="custom-label" Text="Total Price"></asp:Label>
                    </td>
                    <td class="auto-style8">:</td>
                    <td class="auto-style1">RM<asp:TextBox ID="txtPrice" runat="server" CssClass="custom-input" Enabled="False"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <br />
            <br />



            <asp:Label ID="PaymentMethod" runat="server" CssClass="custom-label" Text="Payment Method :" ForeColor="Fuchsia"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlPaymentMethod" runat="server" CssClass="custom-dropdown" OnChange="handlePaymentMethodChange()" OnSelectedIndexChanged="ddlPaymentMethod_SelectedIndexChanged">
                <asp:ListItem Text="- Select Payment Method -" Value="" />
                <asp:ListItem CssClass="custom-dropdown">Online Banking</asp:ListItem>
                <asp:ListItem CssClass="custom-dropdown">Credit/Debit Card</asp:ListItem>
                <asp:ListItem CssClass="custom-dropdown">Touch'n Go</asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="rfvPaymentMethod" runat="server" ControlToValidate="ddlPaymentMethod" InitialValue="" ErrorMessage="*" Display="Dynamic" SetFocusOnError="True" ForeColor="#FF3300"></asp:RequiredFieldValidator>


            <br />
            <br />

            <asp:Panel ID="pnlOnlineBanking" runat="server" Style="display: none;">
                <br />
                <asp:Label ID="lblBank" CssClass="custom-label" runat="server" Text="Select Bank:"></asp:Label>
                <asp:DropDownList ID="ddlBank" runat="server" CssClass="custom-dropdown">
                    <asp:ListItem Text="- Select Bank -" Value="" Disabled="true" />
                    <asp:ListItem CssClass="custom-dropdown">Public Bank</asp:ListItem>
                    <asp:ListItem CssClass="custom-dropdown">RHB Bank</asp:ListItem>
                    <asp:ListItem CssClass="custom-dropdown">Rob Bank</asp:ListItem>
                </asp:DropDownList>

                <asp:RequiredFieldValidator ID="rfvBank" runat="server" ControlToValidate="ddlBank" InitialValue="" ErrorMessage="*" Display="Dynamic" SetFocusOnError="True" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            </asp:Panel>

            <asp:Panel ID="pnlCreditCard" runat="server" Style="display: none;">
                <br />
                <asp:Label ID="lblCardNumber" CssClass="custom-label" runat="server" Text="Card Number:"></asp:Label>
                <asp:TextBox ID="txtCardNumber" CssClass="custom-input" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvCardNumber" runat="server" ControlToValidate="txtCardNumber" ErrorMessage="*" Display="Dynamic" SetFocusOnError="True" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revCardNumber" runat="server" ControlToValidate="txtCardNumber" ValidationExpression="\d{16}" ErrorMessage="Please enter a valid 16-digit card number" Display="Dynamic" SetFocusOnError="True" ForeColor="#FF3300"></asp:RegularExpressionValidator>
                <br />

                <asp:Label ID="lblExpDate" CssClass="custom-label" runat="server" Text="Expiration Date:"></asp:Label>
                <asp:TextBox ID="txtExpDate" CssClass="custom-input" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvExpDate" runat="server" ControlToValidate="txtExpDate" ErrorMessage="*" Display="Dynamic" SetFocusOnError="True" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revExpDate" runat="server" ControlToValidate="txtExpDate" ValidationExpression="^(0[1-9]|1[0-2])\/[0-9]{2}$" ErrorMessage="Please enter a valid expiration date (MM/YY)" Display="Dynamic" SetFocusOnError="True" ForeColor="#FF3300"></asp:RegularExpressionValidator>
                <br />

                <asp:Label ID="lblCVV" CssClass="custom-label" runat="server" Text="CVV:"></asp:Label>
                <asp:TextBox ID="txtCVV" CssClass="custom-input" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvCVV" runat="server" ControlToValidate="txtCVV" ErrorMessage="*" Display="Dynamic" SetFocusOnError="True" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revCVV" runat="server" ControlToValidate="txtCVV" ValidationExpression="^\d{3,4}$" ErrorMessage="Please enter a valid CVV (3 or 4 digits)" Display="Dynamic" SetFocusOnError="True" ForeColor="#FF3300"></asp:RegularExpressionValidator>
                <br />

            </asp:Panel>


            <script>
                function handlePaymentMethodChange() {
                    var selectedValue = document.getElementById('<%= ddlPaymentMethod.ClientID %>').value;

                    // Hide all panels initially
                    hideAllPanels();

                    // Disable validators for the previously selected payment method
                    if (selectedValue !== 'Credit/Debit Card') {
                        disableValidators('<%= pnlCreditCard.ClientID %>');
                    }
                    if (selectedValue !== 'Online Banking') {
                        disableValidators('<%= pnlOnlineBanking.ClientID %>');
                    }

                    // Show the selected panel based on the payment method
                    if (selectedValue === 'Online Banking') {
                        document.getElementById('<%= pnlOnlineBanking.ClientID %>').style.display = 'block';
                        enableValidators('<%= pnlOnlineBanking.ClientID %>');
                    } else if (selectedValue === 'Credit/Debit Card') {
                        document.getElementById('<%= pnlCreditCard.ClientID %>').style.display = 'block';
                        enableValidators('<%= pnlCreditCard.ClientID %>');
                    }

                    // Reset validation messages
                    document.getElementById('<%= lblMessage.ClientID %>').innerText = '';
                }


                function hideAllPanels() {
                    document.getElementById('<%= pnlOnlineBanking.ClientID %>').style.display = 'none';
        document.getElementById('<%= pnlCreditCard.ClientID %>').style.display = 'none';
                }

                function enableValidators(panelId) {
                    // Get all validators within the specified panel
                    var validators = document.querySelectorAll('#' + panelId + ' [id*="rfv"], [id*="rev"]');

                    // Enable each validator
                    validators.forEach(function (validator) {
                        ValidatorEnable(validator, true);
                    });
                }

                function disableValidators(panelId) {
                    // Get all validators within the specified panel
                    var validators = document.querySelectorAll('#' + panelId + ' [id*="rfv"], [id*="rev"]');

                    // Disable each validator
                    validators.forEach(function (validator) {
                        ValidatorEnable(validator, false);
                    });
                }

                // Call disableValidators for Credit/Debit Card initially
                document.addEventListener('DOMContentLoaded', function () {
                    disableValidators('<%= pnlCreditCard.ClientID %>');
                });
            </script>


            <br />
            <br />
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
            <asp:Button ID="BtnPay" runat="server" Text="Pay" CssClass="btn-pay" OnClick="PayButton_Click"/>
        </div>
    </form>


</asp:Content>