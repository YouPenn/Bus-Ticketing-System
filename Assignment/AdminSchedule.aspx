<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminSchedule.aspx.cs" Inherits="Assignment.AdminAdd" %>

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
        .auto-style1 {
            width: 300px;
        }
        .auto-style2 {
            width: 50px;
        }
        .auto-style4 {
            width: 30px;
        }
        .auto-style5 {
            width: 600px;
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
                <asp:Label ID="AddSchedule" runat="server" Text="Add Schedule" Font-Size="36px" Font-Bold="true" ForeColor="#ff8c00"></asp:Label>
            </div>

            <br />
            <br />
                        <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" CausesValidation="False" />
                    <br />
            <br />
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="AddScheduleID" runat="server" Text="Schedule ID"></asp:Label>
                    </td>
                    <td class="auto-style2">:</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtAddScheduleID" runat="server" Enabled="True"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtAddScheduleID" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        &nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtAddScheduleID" ErrorMessage="Invalid Schedule ID, please enter a valid Schedule ID(e.g.S001)" ForeColor="Red" ValidationExpression="S\d{3}"></asp:RegularExpressionValidator>
                    </td>
                    <td class="auto-style4">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="AddBusID" runat="server" Text="Bus ID"></asp:Label>
                    </td>
                    <td class="auto-style2">:</td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="ddlAddBusID" runat="server" OnSelectedIndexChanged="DropDownAddBusID_SelectedIndexChanged" DataSourceID="SqlDataSource2" DataTextField="BusID" DataValueField="BusID">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [BusID] FROM [bus]"></asp:SqlDataSource>
                    </td>
                    <td class="auto-style4">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="AddFromCity" runat="server" Text="From City"></asp:Label>
                    </td>
                    <td class="auto-style2">:</td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="ddlAddFromCity" runat="server" OnSelectedIndexChanged="DropDownAddFromCity_SelectedIndexChanged" DataSourceID="SqlDataSource3" DataTextField="StartCityName" DataValueField="StartCityName">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [StartCityName] FROM [start]"></asp:SqlDataSource>
                    </td>
                    <td class="auto-style4">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="AddToCity" runat="server" Text="To City"></asp:Label>
                    </td>
                    <td class="auto-style2">:</td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="ddlAddToCity" runat="server" DataSourceID="SqlDataSource4" DataTextField="DestinationCityName" DataValueField="DestinationCityName">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [DestinationCityName] FROM [destination]"></asp:SqlDataSource>
                    </td>
                    <td class="auto-style4">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="AddTime" runat="server" Text="Time"></asp:Label>
                    </td>
                    <td class="auto-style2">:</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtAddTime" runat="server" TextMode="Time"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtAddTime" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="AddDate" runat="server" Text="Date"></asp:Label>
                    </td>
                    <td class="auto-style2">:</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtAddDate" runat="server" TextMode="Date"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtAddDate" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="AddPrice" runat="server" Text="Price (RM)"></asp:Label>
                    </td>
                    <td class="auto-style2">:</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtAddPrice" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtAddPrice" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style1">
                        &nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtAddPrice" ErrorMessage="Input must be number and Can't more than RM99" ForeColor="Red" ValidationExpression="\d\d|\d"></asp:RegularExpressionValidator>
                    </td>
                    <td class="auto-style4">
                        &nbsp;</td>
                </tr>

                <tr>
                    <td class="auto-style1">
                        &nbsp;</td>
                    <td class="auto-style2"></td>
                    <td class="auto-style5">
                        <asp:Button ID="AddSave" runat="server" Text="Save" OnClick="AddSave_Click" />
                    </td>
                    <td class="auto-style4">
                        &nbsp;</td>
                </tr>

                </table>
          
        <div>
            <br />
            <asp:Label ID="label" runat="server" Text="Schedule List" Font-Size="36px" Font-Bold="true" ForeColor="#FFC0CB"></asp:Label>
            <br />
            <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="ScheduleID" DataSourceID="SqlDataSource1" CssClass="custom-gridview" CausesValidation="False" OnRowEditing="OnGV1Update" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" OnRowUpdated="GridView1_RowUpdated" OnRowUpdating="GridView1_RowUpdating">
                <Columns>
                    <asp:CommandField ShowEditButton="True" ControlStyle-CssClass="editButton"/>
                    <asp:BoundField DataField="ScheduleID" HeaderText="ScheduleID" ReadOnly="True" SortExpression="ScheduleID" />
                    <asp:BoundField DataField="BusID" HeaderText="BusID" SortExpression="BusID" />
                    <asp:BoundField DataField="StartCityName" HeaderText="StartCityName" SortExpression="StartCityName" />
                    <asp:BoundField DataField="DestinationCityName" HeaderText="DestinationCityName" SortExpression="DestinationCityName" />
                    <asp:BoundField DataField="Time" HeaderText="Time" SortExpression="Time" />
                    <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" DataFormatString="{0:yyyy-MM-dd}"/>
                    <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                </Columns>
                <HeaderStyle BackColor="#3498db" ForeColor="White" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [schedule] WHERE [ScheduleID] = @ScheduleID" InsertCommand="INSERT INTO [schedule] ([ScheduleID], [BusID], [StartCityName], [DestinationCityName], [Time], [Date], [Price]) VALUES (@ScheduleID, @BusID, @StartCityName, @DestinationCityName, @Time, @Date, @Price)" SelectCommand="SELECT * FROM [schedule]" UpdateCommand="UPDATE [schedule] SET [BusID] = @BusID, [StartCityName] = @StartCityName, [DestinationCityName] = @DestinationCityName, [Time] = @Time, [Date] = @Date, [Price] = @Price WHERE [ScheduleID] = @ScheduleID">
                <DeleteParameters>
                    <asp:Parameter Name="ScheduleID" Type="String" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="ScheduleID" Type="String" />
                    <asp:Parameter Name="BusID" Type="String" />
                    <asp:Parameter Name="StartCityName" Type="String" />
                    <asp:Parameter Name="DestinationCityName" Type="String" />
                    <asp:Parameter DbType="Time" Name="Time" />
                    <asp:Parameter DbType="Date" Name="Date" />
                    <asp:Parameter Name="Price" Type="Decimal" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="BusID" Type="String" />
                    <asp:Parameter Name="StartCityName" Type="String" />
                    <asp:Parameter Name="DestinationCityName" Type="String" />
                    <asp:Parameter DbType="Time" Name="Time" />
                    <asp:Parameter DbType="Date" Name="Date" />
                    <asp:Parameter Name="Price" Type="Decimal" />
                    <asp:Parameter Name="ScheduleID" Type="String" />
                </UpdateParameters>
            </asp:SqlDataSource>
          
        </div>
    </form>
</body>
</html>
