<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminDriver.aspx.cs" Inherits="Assignment.AdminViewDriver" %>

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
            width: 500px;
        }
        .auto-style2 {
            width: 800px;
        }
        .auto-style3 {
            width: 50px;
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
            <asp:Label ID="Label2" runat="server" Text="Add Driver" Font-Size="36px" Font-Bold="true" ForeColor="#ff8c00"></asp:Label>
            </div>

            <br />
            <br />
            <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" Text="Back" CausesValidation="False" />
            <br />
            <br />
            <br />
            <table style="width:100%;">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label4" runat="server" Text="Driver ID (D001)"></asp:Label>
                    </td>
                    <td class="auto-style3">:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtDriverID" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style5">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtDriverID" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style1">
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtDriverID" ErrorMessage="Invalid Driver ID, please enter a valid Driver ID(e.g.D001)" ForeColor="Red" ValidationExpression="D\d{3}"></asp:RegularExpressionValidator>
                    </td>
                    <td class="auto-style5">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label5" runat="server" Text="Driver Name"></asp:Label>
                    </td>
                    <td class="auto-style3">:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtDriverName" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style5">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtDriverName" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style1">
                        <asp:Button ID="AddSave" runat="server" OnClick="AddSave_Click" Text="Save" />
                    </td>
                    <td class="auto-style5">
                        &nbsp;</td>
                </tr>
            </table>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Driver List" Font-Size="36px" Font-Bold="true" ForeColor="#FFC0CB"></asp:Label>
            <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="DriverID" DataSourceID="SqlDataSource1" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ControlStyle-CssClass="editButton"/>
                    <asp:BoundField DataField="DriverID" HeaderText="DriverID" ReadOnly="True" SortExpression="DriverID" />
                    <asp:BoundField DataField="DriverName" HeaderText="DriverName" SortExpression="DriverName" />
                </Columns>
                <HeaderStyle BackColor="#3498db" ForeColor="White" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [driver] WHERE [DriverID] = @DriverID" InsertCommand="INSERT INTO [driver] ([DriverID], [DriverName]) VALUES (@DriverID, @DriverName)" SelectCommand="SELECT * FROM [driver]" UpdateCommand="UPDATE [driver] SET [DriverName] = @DriverName WHERE [DriverID] = @DriverID">
                <DeleteParameters>
                    <asp:Parameter Name="DriverID" Type="String" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="DriverID" Type="String" />
                    <asp:Parameter Name="DriverName" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="DriverName" Type="String" />
                    <asp:Parameter Name="DriverID" Type="String" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
