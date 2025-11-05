<%@ Page Language="C#" MasterPageFile="~/Nav.Master" AutoEventWireup="true" CodeBehind="Complete.aspx.cs" Inherits="Assignment.Complete" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        body {
            font-family: 'Verdana', sans-serif;
            margin: 0;
            padding: 0;
        }

        .custom-label {
            font-size: 20px;
            color: #3498db;
            /* Add styles from your homepage here */
        }

        /* Apply styles to form elements */
        .custom-input,
        .custom-dropdown,
        .custom-date {
            width: 300px; /* Adjust width as needed */
            padding: 10px;
            margin-bottom: 10px;
            box-sizing: border-box;
            font-size: 16px;
            color: #333;
            border: 1px solid #3498db;
            border-radius: 5px;
        }

            .custom-input:focus,
            .custom-dropdown:focus,
            .custom-date:focus {
                outline: none;
                box-shadow: 0 0 5px rgba(52, 152, 219, 0.8);
            }

        .error-message {
            color: #FF3300;
        }

        .btn {
            background-color: #3498db;
            color: #fff;
            padding: 10px 15px;
            font-size: 16px;
            cursor: pointer;
            border: none;
            border-radius: 4px;
        }

            .btn:hover {
                background-color: #45a049;
            }

        /* Additional styles for specific elements in Complete.aspx */
        .auto-style1 {
            width: 168px;
        }

        .auto-style2 {
            width: 300px;
        }

        .auto-style3 {
            width: 250px;
            height: 29px;
        }

        .auto-style4 {
            height: 29px;
        }

        .auto-style5 {
            width: 168px;
            height: 29px;
        }

        .auto-style6 {
            width: 91px;
        }

        .auto-style7 {
            width: 250px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content1" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <div id="contentToPrint">
        <form id="form1">
            <div>
                <div id="navigationElements">
                <a href="../Client/Homepage.aspx" style="text-decoration: none;">
                    <asp:Label ID="Home" runat="server" Text="Home" CssClass="custom-label"></asp:Label>
                    <asp:Image ID="Image4" runat="server" Height="20px" ImageUrl="~/image/Arrow.png" Width="20px" />
                </a>

                <%--<a href="../Client/Seat.aspx" style="text-decoration: none;">--%>
                    <asp:Label ID="Seat" runat="server" Text="Seat" CssClass="custom-label"></asp:Label>
                    <asp:Image ID="Image5" runat="server" Height="20px" ImageUrl="~/image/Arrow.png" Width="20px" />
                <%--</a>--%>

                    <%--<a href="../Client/Payment.aspx" style="text-decoration: none;">--%>
                    <asp:Label ID="Label3" runat="server" Text="Payment" CssClass="custom-label"></asp:Label>
                    <asp:Image ID="Image1" runat="server" Height="20px" ImageUrl="~/image/Arrow.png" Width="20px" />
                <%--</a>--%>

                <asp:Label ID="a" runat="server" Text="Complete" CssClass="custom-label" ForeColor="#ff8c00"></asp:Label>
            </div>
                <br />
                <br />
                <asp:Label ID="PaymentCompletePage" runat="server" Text="Your Ticket :" Font-Size="Large" CssClass="custom-label" ForeColor="Fuchsia"></asp:Label>
                <br />
                <br />
                <table class="auto-style2">
                    <tr>
                        <td class="auto-style7">
                            <asp:Label ID="Name" runat="server" CssClass="custom-label" Text="Name"></asp:Label>
                        </td>
                        <td class="auto-style5">:
                        </td>
                        <td class="auto-style1">
                            <asp:TextBox ID="txtCustomerName" runat="server" CssClass="custom-input" Enabled="False"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">
                            <asp:Label ID="ContectNo" runat="server" CssClass="custom-label" Text="Contect No"></asp:Label>
                        </td>
                        <td class="auto-style5">:
                        </td>
                        <td class="auto-style5">
                            <asp:TextBox ID="txtContectNo" runat="server" CssClass="custom-input" Enabled="False"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style7">
                            <asp:Label ID="Label1" runat="server" CssClass="custom-label" Text="Date"></asp:Label>
                        </td>
                        <td class="auto-style5">:</td>
                        <td class="auto-style1">
                            <asp:TextBox ID="txtDate" runat="server" CssClass="custom-input" Enabled="False" Text='<%# DateTime.Now.ToString("yyyy/MM/dd") %>' OnTextChanged="txtDate_TextChanged"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style7">
                            <asp:Label ID="Label2" runat="server" CssClass="custom-label" Text="Time"></asp:Label>
                        </td>
                        <td class="auto-style5">:</td>
                        <td class="auto-style1">
                            <asp:TextBox ID="txtTime" runat="server" CssClass="custom-input" Enabled="False"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style7">
                            <asp:Label ID="Origin" runat="server" CssClass="custom-label" Text="Origin"></asp:Label>
                        </td>
                        <td class="auto-style5">:
                        </td>
                        <td class="auto-style1">
                            <asp:TextBox ID="txtOrigin" runat="server" CssClass="custom-input" Enabled="False"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style7">
                            <asp:Label ID="Destination" runat="server" CssClass="custom-label" Text="Destination"></asp:Label>
                        </td>
                        <td class="auto-style6">:
                        </td>
                        <td class="auto-style1">
                            <asp:TextBox ID="txtDestination" runat="server" CssClass="custom-input" Enabled="False"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">
                            <asp:Label ID="TicketID" runat="server" CssClass="custom-label" Text="Ticket ID"></asp:Label>
                        </td>
                        <td class="auto-style4">:
                        </td>
                        <td class="auto-style5">
                            <asp:TextBox ID="txtTicketID" runat="server" CssClass="custom-input" Enabled="False"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style7">
                            <asp:Label ID="TicketID0" runat="server" CssClass="custom-label" Text="Bus"></asp:Label>
                        </td>
                        <td class="auto-style5">:</td>
                        <td class="auto-style1">
                            <asp:TextBox ID="txtBusID" runat="server" CssClass="custom-input" Enabled="False"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style7">
                            <asp:Label ID="SeatNumber" runat="server" CssClass="custom-label" Text="Seat Number"></asp:Label>
                        </td>
                        <td class="auto-style6">: </td>
                        <td class="auto-style1">
                            <asp:TextBox ID="txtSeatNumber" runat="server" CssClass="custom-input" Enabled="False"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style7">
                            <asp:Label ID="PaymentID" runat="server" CssClass="custom-label" Text="Payment ID"></asp:Label>
                        </td>
                        <td class="auto-style5">:
                        </td>
                        <td class="auto-style1">
                            <asp:TextBox ID="txtPaymentID" runat="server" CssClass="custom-input" Enabled="False"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style7">
                            <asp:Label ID="DatePayment" runat="server" CssClass="custom-label" Text="Date Payment"></asp:Label>
                        </td>
                        <td class="auto-style5">:
                        </td>
                        <td class="auto-style1">
                            <asp:TextBox ID="CompleteDatePayment" runat="server" Enabled="False" CssClass="custom-input"
                                Text='<%# DateTime.Now.ToString("yyyy/MM/d hh:mm tt") %>'></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">
                            <asp:Label ID="Price" runat="server" CssClass="custom-label" Text="Price"></asp:Label>
                        </td>
                        <td class="auto-style5">:
                        </td>
                        <td class="auto-style5">
                            <asp:TextBox ID="txtPrice" runat="server" CssClass="custom-input" Enabled="False"></asp:TextBox>
                        </td>
                    </tr>
                </table>
                <br />
            </div>
        </form>
    </div>
    <%--    <asp:Button ID="btnPrint" runat="server" CssClass="btn" OnClientClick="javascript:window.print();" Text="Print"/>--%>

    <asp:Button ID="btnPrint" runat="server" CssClass="btn" OnClientClick="printContent(); return false;" Text="Print" />


    <script type="text/javascript">
        function printContent() {
            // Hide or remove the navigation elements before printing
            var navigationElements = document.getElementById('navigationElements');
            if (navigationElements) {
                navigationElements.style.display = 'none'; // or navigationElements.remove();
            }

            var contentToPrint = document.getElementById('contentToPrint').innerHTML;
            var printWindow = window.open('', '_blank');

            printWindow.document.open();
            printWindow.document.write('<html><head><title>Print</title></head><body>' + contentToPrint + '</body></html>');
            printWindow.document.close();

            printWindow.print();
            printWindow.onafterprint = function () {
                // Show or restore the navigation elements after printing
                if (navigationElements) {
                    navigationElements.style.display = 'block'; // or navigationElements.restore();
                }
                printWindow.close();
            };
        }
    </script>

    <%--<script type="text/javascript">
        function printContent() {
            var contentToPrint = document.getElementById('contentToPrint').innerHTML;
            var printWindow = window.open('', '_blank');

            printWindow.document.open();
            printWindow.document.write('<html><head><title>Print</title></head><body>' + contentToPrint + '</body></html>');
            printWindow.document.close();

            printWindow.print();
            printWindow.onafterprint = function () {
                printWindow.close();
            };
        }
    </script>--%>


    &nbsp;<asp:Button ID="HomeButton" runat="server" Text="Continue Booking Next Ticket" CssClass="btn" OnClick="HomeButton_Click" Width="245px" />

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="Server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder4" runat="Server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
