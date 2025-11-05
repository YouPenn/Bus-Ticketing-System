<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminBus.aspx.cs" Inherits="Assignment.AdminBus" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin</title>
    <style>
        /* Add your custom CSS styles for the top navigation bar here */
        .top-navigation {
            position: fixed;
            top: 0;
            right: 0;
            padding: 10px;
            z-index: 1000;
            margin-top: 3%;
            margin-right: 3%;
            background-color: darkgrey;
            border-radius: 16px;
        }

        .dropdown {
            display: inline-block;
            margin-right: 20px;
        }

            .dropdown select {
                padding: 5px;
            }

        .custom-dropdown {
            padding: 8px;
            font-size: 14px;
            border: 1px solid #3498db;
            border-radius: 5px;
            background-color: #ecf0f1;
            color: #2c3e50;
            width: 150px; /* Adjust width as needed */
        }

            .custom-dropdown option {
                background-color: #ecf0f1;
                color: #2c3e50;
            }

        .disabled-option {
            color: #95a5a6;
        }
    </style>
    <link rel="stylesheet" type="text/css" href="~/css/AdminStyle.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <div class="top-navigation">
                <div class="dropdown" style="margin-top:1%; margin-left:5px;">
                    <asp:DropDownList ID="ddlNavigation1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlNavigation1_SelectedIndexChanged" CssClass="custom-dropdown">
                        <asp:ListItem Value="" Text="Add" Disabled="true"/>
                        <asp:ListItem Value="AdminSchedule.aspx" Text="Add Schedule" />
                        <asp:ListItem Value="AdminStart.aspx" Text="Add Start Point" />
                        <asp:ListItem Value="AdminDestination.aspx" Text="Add Destination point" />
                        <asp:ListItem Value="AdminBus.aspx" Text="Add Bus" />
                        <asp:ListItem Value="AdminDriver.aspx" Text="Add Driver" />
                    </asp:DropDownList>
                </div>
                <div class="dropdown" style="margin-top:1%; margin-left:5px;">
                    <asp:DropDownList ID="ddlNavigation2" runat="server"  AutoPostBack="true" OnSelectedIndexChanged="ddlNavigation2_SelectedIndexChanged" CssClass="custom-dropdown">
                        <asp:ListItem Value="" Text="Lists" Disabled="true"/>
                        <asp:ListItem Value="AdminViewCustomer.aspx" Text="Customer List" />
                        <asp:ListItem Value="AdminViewMember.aspx" Text="Member List" />
                        <asp:ListItem Value="AdminViewPayment.aspx" Text="Payment List" />
                        <asp:ListItem Value="AdminViewComment.aspx" Text="Comment" />
                    </asp:DropDownList>
                </div>
                <div class="dropdown" style="margin-top:1%;">
                    <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlNavigation3_SelectedIndexChanged" CssClass="custom-dropdown">
                        <asp:ListItem Value="" Text="Edit" Disabled="true"/>
                        <asp:ListItem Value="AdminEditTicket.aspx" Text="Edit Ticket" />
                        <asp:ListItem Value="AdminEditSeat.aspx" Text="Edit Seat" />
                    </asp:DropDownList>
                </div>
            </div>

            <div>
                <a href="AdminHome.aspx" style="text-decoration: none;">
                    <asp:Label ID="Home" runat="server" Text="Home" CssClass="custom-label" Font-Size="36px" Font-Bold="true" ForeColor="#7EC8E3"></asp:Label>
                    <asp:Image ID="Image4" runat="server" Height="30px" ImageUrl="~/image/Arrow.png" Width="30px" />
                </a>
            <asp:Label ID="Label1" runat="server" Text="Add Bus" Font-Size="36px" Font-Bold="true" ForeColor="#ff8c00"></asp:Label>
            </div>
            <br />
            <br />
            <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" Text="Back" CausesValidation="False" />
            <br />
            <br />
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label3" runat="server" Text="Bus ID"></asp:Label>
                    </td>
                    <td class="auto-style2">:</td>
                    <td>
                        <asp:TextBox ID="txtBusID" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtBusID" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        &nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtBusID" ErrorMessage="Enter a valid car number (e.g., ABC1234 or W7895M)" ForeColor="Red" ValidationExpression="[A-Z]{1,3}\d*[A-Z]*"></asp:RegularExpressionValidator>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label4" runat="server" Text="Driver ID"></asp:Label>
                    </td>
                    <td class="auto-style2">:</td>
                    <td>
                        <asp:DropDownList ID="ddlDriverID" runat="server" DataSourceID="SqlDataSource2" DataTextField="DriverID" DataValueField="DriverID">
                        </asp:DropDownList>
&nbsp;<asp:Button ID="btnEditDriver" runat="server" OnClick="btnEditDriver_Click" Text="Edit Driver" CausesValidation="False" Width="100px" />
                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [DriverID] FROM [driver]"></asp:SqlDataSource>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label5" runat="server" Text="Bus Name"></asp:Label>
                    </td>
                    <td class="auto-style2">:</td>
                    <td>
                        <asp:TextBox ID="txtBusName" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtBusName" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label6" runat="server" Text="Total Seat"></asp:Label>
                    </td>
                    <td class="auto-style2">:</td>
                    <td>
                        <asp:Label ID="lblTotalSeat" runat="server" Text="20"></asp:Label>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        &nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="AddSave" runat="server" OnClick="AddSave_Click" Text="Save" />
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Bus List" Font-Size="36px" Font-Bold="true" ForeColor="#FFC0CB"></asp:Label>
            <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="BusID" DataSourceID="SqlDataSource1" OnRowDeleted="GridView1_RowDeleted" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ControlStyle-CssClass="editButton"/>
                    <asp:BoundField DataField="BusID" HeaderText="BusID" ReadOnly="True" SortExpression="BusID" />
                    <asp:BoundField DataField="DriverID" HeaderText="DriverID" SortExpression="DriverID" />
                    <asp:BoundField DataField="BusName" HeaderText="BusName" SortExpression="BusName" />
                    <asp:BoundField DataField="TotalSeat" HeaderText="TotalSeat" SortExpression="TotalSeat" />
                </Columns>
                <HeaderStyle BackColor="#3498db" ForeColor="White" />
            </asp:GridView>


            <script type="text/javascript">
    function confirmDelete() {
        return confirm("Are you sure you want to delete this record?");
    }
            </script>



            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [bus] WHERE [BusID] = @BusID" InsertCommand="INSERT INTO [bus] ([BusID], [DriverID], [BusName], [TotalSeat]) VALUES (@BusID, @DriverID, @BusName, @TotalSeat)" SelectCommand="SELECT * FROM [bus]" UpdateCommand="UPDATE [bus] SET [DriverID] = @DriverID, [BusName] = @BusName, [TotalSeat] = @TotalSeat WHERE [BusID] = @BusID">
                <DeleteParameters>
                    <asp:Parameter Name="BusID" Type="String" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="BusID" Type="String" />
                    <asp:Parameter Name="DriverID" Type="String" />
                    <asp:Parameter Name="BusName" Type="String" />
                    <asp:Parameter Name="TotalSeat" Type="Int32" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="DriverID" Type="String" />
                    <asp:Parameter Name="BusName" Type="String" />
                    <asp:Parameter Name="TotalSeat" Type="Int32" />
                    <asp:Parameter Name="BusID" Type="String" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
