<%@ Page Language="C#" MasterPageFile="~/Nav.Master" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="Assignment.Homepage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <%--<title>Home Page</title>--%>
    <style type="text/css">
        body {
            font-family: 'Verdana', sans-serif;
            margin: 0;
            padding: 0;
        }

        .auto-style1 {
            height: 18px;
        }

        .auto-style4 {
            width: 100%;
            height: 150px;
        }

        .auto-style7 {
            height: 18px;
            width: 334px;
        }

        .auto-style8 {
            width: 334px;
            height: 17px;
        }

        .auto-style9 {
            height: 17px;
        }

        .auto-style10 {
            height: 18px;
            width: 333px;
        }

        .auto-style11 {
            width: 333px;
            height: 17px;
        }

        /* New styles for dropdown lists */
        .custom-dropdown {
            width: 200px;
            padding: 10px;
            font-size: 16px;
            border: 1px solid #3498db;
            border-radius: 5px;
            background-color: #fff;
            color: #333;
        }

            .custom-dropdown:focus {
                outline: none;
                box-shadow: 0 0 5px rgba(52, 152, 219, 0.8);
            }

        .custom-date {
            width: 500px;
            padding: 10px;
            font-size: 16px;
            border: 1px solid #3498db;
            border-radius: 5px;
            background-color: #fff;
            color: #333;
        }

            .custom-date:focus {
                outline: none;
                box-shadow: 0 0 5px rgba(52, 152, 219, 0.8);
            }

        .custom-button {
            padding: 10px;
            font-size: 16px;
            border: 1px solid #3498db;
            border-radius: 5px;
            background-color: #3498db;
            color: #fff;
        }

            .custom-button:hover {
                background-color: #2980b9;
            }

        .custom-select-button {
            background-color: #3498db;
            color: #fff;
            padding: 5px 10px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
        }

            .custom-select-button:hover {
                background-color: #2980b9;
            }

        .custom-gridview {
            width: 100%;
            margin-top: 20px;
            border-collapse: collapse;
        }

            .custom-gridview th, .custom-gridview td {
                padding: 15px;
                text-align: center;
                border: 1px solid #3498db;
            }

            .custom-gridview th {
                background-color: #3498db;
                color: #fff;
            }

            .custom-gridview tr:nth-child(even) {
                background-color: #f2f2f2;
            }

        .custom-select-button {
            background-color: orange;
            color: #fff;
            padding: 5px 10px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
        }

            .custom-select-button:hover {
                background-color: orange;
            }

        .custom-logout-button {
            padding: 10px;
            font-size: 16px;
            color: #3498db;
            background-color: #ffffff;
            border: 1px solid #3498db;
            border-radius: 5px;
            cursor: pointer;
        }

            .custom-logout-button:hover {
                background-color: #3498db;
                color: #ffffff;
            }

        .custom-label {
            font-size: 20px; /* Set the font size to your desired value */
            color: #3498db; /* Set the color to your desired value */
        }

        /* Style for the Select button */
        .custom-gridview .select-button {
            background-color: orange; /* Set the background color to orange */
            color: #fff; /* Set the text color to white or another contrasting color */
            padding: 5px 10px; /* Adjust the padding as needed */
            border: 1px solid orange; /* Set the border color to match the background color */
            border-radius: 3px; /* Add border-radius for slightly rounded corners */
            cursor: pointer;
        }

            .custom-gridview .select-button:hover {
                background-color: #ff8c00; /* Set a darker shade for hover effect */
                border-color: #ff8c00; /* Set the border color for hover effect */
            }
             .noticeable-label {
        font-size: 24px;
        font-weight: bold;
        color: #3498db;
    }
    </style>


    <script type="text/javascript">
        function validateDate(source, args) {
            var selectedDate = document.getElementById('<%= CurrentDateTextBox.ClientID %>').value;
            var currentDate = new Date();
            var selectedDateObj = new Date(selectedDate);

            if (selectedDateObj < currentDate) {
                args.IsValid = false;
            } else {
                args.IsValid = true;
            }
        }
    </script>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="content1" runat="Server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">

    <form id="form1">
        <div>
            <table class="auto-style4">
                <tr>
                    <asp:Label ID="Label2" runat="server" Text="Welcome, " Style="font-size: 20px; color:#3498db;"></asp:Label><asp:Label ID="txtUser" runat="server" style="font-size: 24px; color: #FFB52E;"></asp:Label>
                    <br/><br/>
                    <td class="auto-style11">
                        <asp:Label ID="Home" runat="server" Text="Home" CssClass="custom-label"></asp:Label>
                    </td>
                    <td class="auto-style8">
                    </td>
                    <td class="auto-style9">
                        <asp:Button ID="Logout" runat="server" OnClick="Logout_Click" Text="Logout" CausesValidation="False" CssClass="custom-button" Style="margin-left: 50%;"/>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11"></td>
                    <td class="auto-style8"></td>
                    <td class="auto-style9">
                        
                    </td>
                </tr>
                
                <tr>
                    <td class="auto-style10">
                        <asp:Label ID="Origin" runat="server" Text="Origin / Start  :" CssClass="custom-label"></asp:Label>
                        <br />
                        <asp:DropDownList ID="ddlStart" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="StartCityName" DataValueField="StartCityName" CssClass="custom-dropdown">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [StartCityName] FROM [start]"></asp:SqlDataSource>
                        <br />
                    </td>
                    <td class="auto-style7">
                        <asp:Label ID="Destination" runat="server" Text="Destination :" CssClass="custom-label"></asp:Label>
                        <br />
                        <asp:DropDownList ID="ddlDestination" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="DestinationCityName" DataValueField="DestinationCityName" CssClass="custom-dropdown">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [DestinationCityName] FROM [destination]"></asp:SqlDataSource>
                        <br />
                    </td>
                    <td class="auto-style1">
                        <asp:Label ID="DateLabel" runat="server" Text="Date :" CssClass="custom-label"></asp:Label>
                        <br />
<%--                        <asp:TextBox ID="CurrentDateTextBox" runat="server" Width="150px" OnTextChanged="CurrentDateTextBox_TextChanged" AutoPostBack="True" TextMode="Date" CssClass="custom-date"></asp:TextBox>--%>
                        <asp:TextBox ID="CurrentDateTextBox" runat="server" Width="150px" OnTextChanged="CurrentDateTextBox_TextChanged" AutoPostBack="True" TextMode="Date" CssClass="custom-date"></asp:TextBox>
                        <asp:CustomValidator ID="cvDateValidation" runat="server" ControlToValidate="CurrentDateTextBox" ClientValidationFunction="validateDate" ErrorMessage="Selected date has passed" Display="Dynamic" ForeColor="#FF3300" OnServerValidate="cvDateValidation_ServerValidate"></asp:CustomValidator>

                    </td>
                </tr>
            </table>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Schedule:" CssClass="custom-label"></asp:Label>

            <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="ScheduleID" DataSourceID="SqlDataSource3" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" CssClass="custom-gridview">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="ScheduleID" HeaderText="ScheduleID" ReadOnly="True" SortExpression="ScheduleID" />
                    <asp:BoundField DataField="BusID" HeaderText="BusID" SortExpression="BusID" />
                    <asp:BoundField DataField="StartCityName" HeaderText="StartCityName" SortExpression="StartCityName" />
                    <asp:BoundField DataField="DestinationCityName" HeaderText="DestinationCityName" SortExpression="DestinationCityName" />
                    <asp:BoundField DataField="Time" HeaderText="Time" SortExpression="Time" />
                    <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" DataFormatString="{0:yyyy-MM-dd}" />
                    <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                </Columns>
                <HeaderStyle BackColor="#3498db" ForeColor="White" />
                <RowStyle CssClass="custom-grid-row" />
                <SelectedRowStyle BackColor="#FFD580" ForeColor="black" />
            </asp:GridView>


            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [schedule] WHERE (([Date] = @Date) AND ([DestinationCityName] = @DestinationCityName) AND ([StartCityName] = @StartCityName))">
                <SelectParameters>
                    <asp:ControlParameter ControlID="CurrentDateTextBox" Name="Date" PropertyName="Text" DbType="Date" />
                    <asp:ControlParameter ControlID="ddlDestination" Name="DestinationCityName" PropertyName="SelectedValue" Type="String" />
                    <asp:ControlParameter ControlID="ddlStart" Name="StartCityName" PropertyName="SelectedValue" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />


            <asp:TextBox ID="txtSelect" runat="server" Enabled="False" AutoPostBack="True" OnTextChanged="txtSelect_TextChanged" CssClass="custom-dropdown"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtSelect" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>

            <br />
            <br />
            <asp:Button ID="btnGoSelectSeat" runat="server" OnClick="btnGoSelectSeat_Click" Text="Select Seat" CssClass="custom-logout-button" />
            <br />
        </div>
    </form>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="Server">
</asp:Content>

<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder4" runat="Server">
</asp:Content>

<asp:Content ID="Content6" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
