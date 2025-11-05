<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="Assignment.AdminHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin</title>
    <style type="text/css">
        .auto-style4 {
            width: 813px;
        }

        .auto-style6 {
            width: 813px;
            height: 204px;
        }

        .auto-style7 {
            width: 200px;
            height: 204px;
        }

        .auto-style8 {
            width: 200px;
        }

        .auto-style11 {
            margin-right: 0px;
        }

        .auto-style12 {
            width: 200px;
            height: 40px;
            text-align: center;
            font-size: 24px;
        }

            .auto-style12 label {
                display: inline-block;
                padding: 10px; /* Adjust as needed */
                font-size: 18px; /* Adjust as needed */
                color: blue;
            }

        table.center {
            margin: 0 auto;
            border: 2px solid #333; /* Darker outline color */
            border-collapse: collapse;
            width: 100%;
        }

            table.center td {
                width: 25%;
                padding: 10px;
                text-align: center;
            }

            table.center tr {
                border-bottom: 2px solid #333; /* Darker bottom border for each row */
            }

            table.center label {
                display: inline-block;
                padding: 10px;
                font-size: 16px;
                color: #3498db; /* Blue color */
                border-top: 2px solid #3498db; /* Blue top border */
                border-bottom: 2px solid #3498db; /* Blue bottom border */
                transition: border-color 0.3s ease-in-out; /* Smooth transition for border color */
            }

        .auto-style7 img,
        .auto-style8 img,
        .auto-style12 img {
            width: 100%;
            height: 100%;
            border: 2px solid #3498db; /* Blue border for image buttons */
            border-radius: 5px; /* Rounded corners */
            transition: border-color 0.3s ease-in-out, box-shadow 0.3s ease-in-out; /* Smooth transition for border color and box shadow */
        }

        .auto-style7:hover img,
        .auto-style8:hover img,
        .auto-style12:hover img {
            border: 2px solid #87CEFA; /* Light blue border on hover */
            box-shadow: 0 0 10px #87CEFA; /* Light blue box shadow on hover */
        }

        .table-cell-hover:hover {
    border: 2px solid #87CEFA; /* Light blue border on hover */
    border-radius: 5px; /* Rounded corners */
}

        td.label {
            width: 30%;
            text-align: right;
            padding-right: 15px;
            font-weight: bold;
            font-size: 36px;
            color: #3498db; /* Blue color */
        }

        td.input-field {
            width: 65%;
            padding-left: 15px;
        }

        td.separator {
            width: 5%;
            text-align: center;
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="AdminHomePage" runat="server" Text="Admin Home Page" Font-Size="36px" Font-Bold="true" ForeColor="#ff8c00"></asp:Label>
            <br />
            <br />
            <table style="width: 100%;">
                <tr>
                    <td class="label">
                        <asp:Label ID="AdminID" runat="server" Text="Admin ID"></asp:Label>
                    </td>
                    <td class="separator">:</td>
                    <td class="input-field">
                        <asp:TextBox ID="AdID" runat="server" Enabled="False" OnTextChanged="AdID_TextChanged" Style="padding: 15px; border: 1px solid #3498db; border-radius: 5px; box-sizing: border-box; margin-bottom: 15px; background-color: #fff; color: #3498db;"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="label">
                        <asp:Label ID="AdminName" runat="server" Text="Admin Name"></asp:Label>
                    </td>
                    <td class="separator">:</td>
                    <td class="input-field">
                        <asp:TextBox ID="AdName" runat="server" Enabled="False" OnTextChanged="AdName_TextChanged" Style="padding: 15px; border: 1px solid #3498db; border-radius: 5px; box-sizing: border-box; margin-bottom: 15px; background-color: #fff; color: #3498db;"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <br />
            <table style="width: 100%;" class="center">
                <tr>
                    <td class="auto-style7 table-cell-hover">
                        <asp:ImageButton ID="imgbtnToAdminSchedule" runat="server" Height="200px" Width="200px" OnClick="imgbtnToAdminSchedule_Click" ImageUrl="~/image/Add schedule.png" />
                    </td>
                    <td class="auto-style7 table-cell-hover">
                        <asp:ImageButton ID="imgbtnToAdminStart" runat="server" Height="200px" Width="200px" OnClick="imgbtnToAdminStart_Click" CssClass="auto-style11" ImageUrl="~/image/Start.png" />
                    </td>
                    <td class="auto-style7 table-cell-hover">

                        <asp:ImageButton ID="imgbtnToAdminEnd" runat="server" Width="200px" Height="200px" OnClick="imgbtnToAdminEnd_Click" ImageUrl="~/image/End.png" />

                    </td>
                    <td class="auto-style7 table-cell-hover">
                        <asp:ImageButton ID="imgbtnToAdminEditTicket" runat="server" Height="200px" Width="200px" OnClick="imgbtnToAdminEditTicket_Click" ImageUrl="~/image/Edit ticket.png" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12">
                        <asp:Label ID="Label1" runat="server" Text="Add Schedule"></asp:Label>
                    </td>
                    <td class="auto-style12">
                        <asp:Label ID="Label2" runat="server" Text="Add Start Point"></asp:Label>
                    </td>
                    <td class="auto-style12">

                        <asp:Label ID="Label3" runat="server" Text="Add End Point"></asp:Label>

                    </td>
                    <td class="auto-style12">
                        <asp:Label ID="Label4" runat="server" Text="Edit Ticket"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8 table-cell-hover">
                        <asp:ImageButton ID="imgbtnToAdminViewMember" runat="server" Height="200px" Width="200px" OnClick="imgbtnToAdminViewMember_Click" ImageUrl="~/image/Member list.png" />
                    </td>
                    <td class="auto-style8 table-cell-hover">

                        <asp:ImageButton ID="imgbtnToAdminViewCustomer" runat="server" Height="200px" Width="200px" OnClick="imgbtnToAdminViewCustomer_Click" ImageUrl="~/image/Customer list.png" />

                    </td>
                    <td class="auto-style8 table-cell-hover">

                        <asp:ImageButton ID="imgbtnToAdminViewPayment" runat="server" Height="200px" Width="200px" OnClick="imgbtnToAdminViewPayment_Click" ImageUrl="~/image/Payment list.png" />
                    </td>
                    <td class="auto-style7 table-cell-hover">

                        <asp:ImageButton ID="imgbtnToAdminViewComment" runat="server" Height="200px" Width="200px" OnClick="imgbtnToAdminViewComment_Click" ImageUrl="~/image/Feedback.png" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12">
                        <asp:Label ID="Label5" runat="server" Text="Member list"></asp:Label>
                    </td>
                    <td class="auto-style12">

                        <asp:Label ID="Label6" runat="server" Text="Customer list"></asp:Label>

                    </td>
                    <td class="auto-style12">

                        <asp:Label ID="Label7" runat="server" Text="Payment list"></asp:Label>
                    </td>
                    <td class="auto-style12">

                        <asp:Label ID="Label8" runat="server" Text="Feedback"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8 table-cell-hover">
                        <asp:ImageButton ID="imgbtnToAdminEditSeat" runat="server" Height="200px" Width="200px" OnClick="imgbtnToAdminEditSeat_Click" ImageUrl="~/image/Seat edit.png" />
                    </td>
                    <td class="auto-style8 table-cell-hover">

                        <asp:ImageButton ID="imgbtnToAdminBus" runat="server" Height="200px" Width="200px" OnClick="imgbtnToAdminBus_Click" ImageUrl="~/image/Add bus.png" />
                    </td>
                    <td class="auto-style8 table-cell-hover">

                        <asp:ImageButton ID="imgbtnToAdminDriver" runat="server" Height="200px" Width="200px" OnClick="imgbtnToAdminDriver_Click" ImageUrl="~/image/Add driver.png" />
                    </td>
                    <td class="auto-style7 table-cell-hover">

                        <asp:ImageButton ID="imgbtnToLogout" runat="server" Height="200px" Width="200px" OnClick="imgbtnToLogout_Click" ImageUrl="~/image/Logout.png" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12">
                        <asp:Label ID="Label9" runat="server" Text="Edit seat"></asp:Label>
                    </td>
                    <td class="auto-style12">

                        <asp:Label ID="Label10" runat="server" Text="Add bus"></asp:Label>
                    </td>
                    <td class="auto-style12">

                        <asp:Label ID="Label11" runat="server" Text="Add driver"></asp:Label>
                    </td>
                    <td class="auto-style12">

                        <asp:Label ID="Label12" runat="server" Text="Logout"></asp:Label>
                    </td>
                </tr>
            </table>
            <br />
        </div>
    </form>
</body>
</html>
