<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminEditTicket.aspx.cs" Inherits="Assignment.AdminEditTicket" %>

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
            <asp:Label ID="Label1" runat="server" Text="Edit Ticket" Font-Size="36px" Font-Bold="true" ForeColor="#ff8c00"></asp:Label>
            </div>
            <br />
            <br />
            <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" Text="Back" />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Filter" Font-Size="36px" Font-Bold="true" ForeColor="#FFC0CB"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="ScheduleID" DataValueField="ScheduleID">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [ScheduleID] FROM [schedule]"></asp:SqlDataSource>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="TicketID" DataSourceID="SqlDataSource1" Width="357px" AllowSorting="True">
                <Columns>
                    <asp:CommandField ShowEditButton="True" ControlStyle-CssClass="editButton"/>
                    <asp:BoundField DataField="TicketID" HeaderText="TicketID" ReadOnly="True" SortExpression="TicketID" InsertVisible="False" />
                    <asp:BoundField DataField="SeatID" HeaderText="SeatID" SortExpression="SeatID" />
                    <asp:BoundField DataField="ScheduleID" HeaderText="ScheduleID" SortExpression="ScheduleID" />
                    <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" SortExpression="CustomerID" />
                </Columns>
                 <HeaderStyle BackColor="#3498db" ForeColor="White" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [ticket] WHERE ([ScheduleID] = @ScheduleID)" DeleteCommand="DELETE FROM [ticket] WHERE [TicketID] = @TicketID" InsertCommand="INSERT INTO [ticket] ([SeatID], [ScheduleID], [CustomerID]) VALUES (@SeatID, @ScheduleID, @CustomerID)" UpdateCommand="UPDATE [ticket] SET [SeatID] = @SeatID, [ScheduleID] = @ScheduleID, [CustomerID] = @CustomerID WHERE [TicketID] = @TicketID">
                <DeleteParameters>
                    <asp:Parameter Name="TicketID" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="SeatID" Type="Int32" />
                    <asp:Parameter Name="ScheduleID" Type="String" />
                    <asp:Parameter Name="CustomerID" Type="Int32" />
                </InsertParameters>
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList1" Name="ScheduleID" PropertyName="SelectedValue" Type="String" />
                </SelectParameters>
                <UpdateParameters>
                    <asp:Parameter Name="SeatID" Type="Int32" />
                    <asp:Parameter Name="ScheduleID" Type="String" />
                    <asp:Parameter Name="CustomerID" Type="Int32" />
                    <asp:Parameter Name="TicketID" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <br />
        </div>
    </form>
</body>
</html>