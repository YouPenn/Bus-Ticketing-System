<%@ Page Language="C#" MasterPageFile="~/Nav.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="Assignment.SearchHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        #formContainer {
            text-align: center;
            margin-top: 50px; /* Adjust the top margin as needed */
        }

        .formLabel {
            color: #3498db; /* Blue color */
            font-size: 24px; /* Bigger font size */
            display: block;
            margin-bottom: 5px;
        }

        .formTextBox {
            width: 600px; /* Adjust the width of the text box */
            padding: 10px;
            box-sizing: border-box;
        }

        .formButton {
            background-color: #3498db; /* Blue color */
            color: #fff; /* White text color */
            padding: 10px 20px; /* Adjust padding as needed */
            font-size: 18px; /* Button text size */
            border: none;
            cursor: pointer;
            border-radius: 5px;
        }
        .auto-style1 {
            width: 199px;
        }

         /* Customize GridView styles */
        .custom-gridview {
            width: 100%; /* Set the desired width */
            border-collapse: collapse; /* Collapse borders for better styling */
        }

        .custom-gridview th, .custom-gridview td {
            padding: 15px; /* Set the desired padding for cells */
            text-align: left; /* Set text alignment */
            border: 1px solid #3498db; /* Border color */
        }

        .custom-gridview th {
            background-color: #3498db; /* Blue background for header */
            color: #fff; /* White font color for header */
        }

        .custom-gridview tr.selected-row {
            background-color: #FFD580; /* Light orange background for selected row */
        }

    </style>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <form id="form1">
        <div id="formContainer">
            <asp:Label ID="Label1" runat="server" CssClass="formLabel" Text="Enter Your Customer Name and Contact Number to Search Your Ticket Information"></asp:Label>
            <br />
            <table style="width: 100%;">
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label2" runat="server" CssClass="formLabel" Text="Customer Name"></asp:Label>
                    </td>
                    <td class="auto-style4">:</td>
                    <td>
                        <asp:TextBox ID="txtCustomerName" runat="server" CssClass="formTextBox"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvCustomerName" runat="server" ControlToValidate="txtCustomerName"
    Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="SearchGroup"></asp:RequiredFieldValidator><br/>
                        <asp:RegularExpressionValidator ID="revCustomerName" runat="server" ControlToValidate="txtCustomerName"
                            Display="Dynamic" ErrorMessage="Only characters are allowed" ForeColor="Red"
                            ValidationExpression="^[a-zA-Z\s]+$"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label3" runat="server" CssClass="formLabel" Text="Contact Number"></asp:Label>
                    </td>
                    <td class="auto-style4">:</td>
                    <td>
                        <asp:TextBox ID="txtCustomerPhoneNumber" runat="server" CssClass="formTextBox"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvCustomerPhoneNumber" runat="server" ControlToValidate="txtCustomerPhoneNumber"
                            Display="Dynamic" ErrorMessage="*" ForeColor="Red" ValidationGroup="SearchGroup"></asp:RequiredFieldValidator><br/>
                        <asp:RegularExpressionValidator ID="revCustomerPhoneNumber" runat="server" ControlToValidate="txtCustomerPhoneNumber"
                            Display="Dynamic" ErrorMessage="Invalid. Use the number you entered when you buying ticket" ForeColor="Red"
                            ValidationExpression="^\d{3}-\d{7}|\d{3}-\d{8}$"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>
                        <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search ID" CssClass="formButton" ValidationGroup="SearchGroup"/>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label4" runat="server" CssClass="formLabel" Text="Customer ID"></asp:Label>
                    </td>
                    <td class="auto-style4">:</td>
                    <td>
                        <asp:TextBox ID="txtCustomerID" runat="server" CssClass="formTextBox" AutoPostBack="True" Enabled="False"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="TicketID" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CssClass="custom-gridview">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="TicketID" HeaderText="TicketID" InsertVisible="False" ReadOnly="True" SortExpression="TicketID" />
                    <asp:BoundField DataField="SeatID" HeaderText="SeatID" SortExpression="SeatID" />
                    <asp:BoundField DataField="ScheduleID" HeaderText="ScheduleID" SortExpression="ScheduleID" />
                    <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" SortExpression="CustomerID" />
                </Columns>
            </asp:GridView>
            <br/>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [ticket] WHERE ([CustomerID] = @CustomerID)">
                <SelectParameters>
                    <asp:ControlParameter ControlID="txtCustomerID" Name="CustomerID" PropertyName="Text" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
            <table style="width: 100%;">
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label5" runat="server" CssClass="formLabel" Text="Ticket ID" Width="200px"></asp:Label>
                    </td>
                    <td class="auto-style4">:</td>
                    <td>
                        <asp:TextBox ID="txtSelection" runat="server" CssClass="formTextBox" AutoPostBack="True" Enabled="False"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtSelection" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>
                        <asp:Button ID="btnSearch2" runat="server" OnClick="btnSearch_Click2" Text="Search" CssClass="formButton" />

                    &nbsp;<asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" CausesValidation="False" CssClass="formButton" />

                    </td>
                </tr>
            </table>
            <br />
            <br />
            <br />
        </div>
    </form>
</asp:Content>
