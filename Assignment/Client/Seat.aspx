<%@ Page Language="C#" MasterPageFile="~/Nav.Master" AutoEventWireup="true" CodeBehind="Seat.aspx.cs" Inherits="Assignment.Seat" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        /* Common styles for labels and text boxes */
        .custom-label {
            font-size: 20px; /* Set the font size to your desired value */
            color: #3498db; /* Set the color to your desired value */
            font-weight: bold; /* Add bold style if needed */
        }

        .custom-textbox {
            width: 150px; /* Set the width to your desired value */
            padding: 10px;
            font-size: 16px;
            border: 1px solid #3498db;
            border-radius: 5px;
            background-color: #fff;
            color: #333;
            margin-bottom: 10px; /* Add margin-bottom for spacing */
        }

        /* Additional styles for specific elements */
        .custom-seat-label {
            font-size: 24px; /* Set the font size to your desired value */
            color: #3498db; /* Set the color to your desired value */
            font-weight: bold; /* Add bold style if needed */
        }

        .custom-seat-image {
            height: 50px;
            width: 50px;
        }

        .custom-seat-table {
            width: 45%;
            border: 2px solid #333;
            border-collapse: collapse;
            margin-left: 20px;
        }

        .auto-style2 {
            width: 155px;
        }

        .auto-style4 {
            width: 180px;
        }

        .auto-style5 {
            width: 110px;
        }

        /* Apply styles for SeatNumber, SeatID, and TicketID */
        .seat-table {
            width: 50%;
            border-collapse: collapse;
        }

            .seat-table td {
                padding: 10px;
            }

        .seat-label {
            font-size: 20px;
            color: #3498db;
            font-weight: bold;
        }

        .seat-textbox {
            width: 80%; /* Adjust the width as needed */
            padding: 10px;
            font-size: 16px;
            border: 1px solid;
            border-radius: 5px;
            margin-bottom: 10px;
        }

        .validation-error {
            color: red;
            font-size: 14px;
            margin-left: 10px; /* Adjust the margin as needed */
        }

        .form-view-container {
            margin: 0 auto;
            padding: 20px;
            border: 1px solid #ddd;
            border-radius: 5px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            background-color: #fff;
            margin-left: 5%;
        }

        .form-view-item {
            margin-bottom: 15px;
        }

        .form-view-label {
            font-size: 16px;
            color: #3498db;
            font-weight: bold;
            display: inline-block;
            /*width: 100%;  Adjust the width based on your preference */
            text-align: left; /* Align the text to the right */
            padding-right: 5%; /* Add some right padding for spacing */
        }

        .form-view-textbox {
            /*width: 50%; /* Adjust the width based on your preference */
            display: inline-block; /* Make the textbox inline with the label */
            box-sizing: border-box;
            padding: 10px;
            font-size: 14px;
            border: 1px solid #3498db;
            border-radius: 5px;
            text-align: right;
        }

        .form-view-button {
            padding: 10px;
            font-size: 16px;
            color: #fff;
            background-color: #3498db;
            border: none;
            border-radius: 5px;
            cursor: pointer;
        }

            .form-view-button:hover {
                background-color: #2980b9;
            }

        .custom-button, .form-view-button {
            padding: 10px;
            font-size: 16px;
            color: #fff;
            background-color: #3498db;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            display: inline-block;
            text-align: center;
            text-decoration: none;
        }

            .custom-button:hover, .form-view-button:hover {
                background-color: #2980b9;
            }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content1" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">

    <form id="form1">

        <div>
            <a href="../Client/Homepage.aspx" style="text-decoration: none;">
                <asp:Label ID="Home" runat="server" Text="Home" CssClass="custom-label"></asp:Label>
                <asp:Image ID="Image4" runat="server" Height="20px" ImageUrl="~/image/Arrow.png" Width="20px" />
            </a>
            <asp:Label ID="a" runat="server" Text="Seat" CssClass="custom-label" ForeColor="#ff8c00"></asp:Label>
        </div>

        <asp:HiddenField ID="SelectedSeatHiddenField" runat="server" />
        <div>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Schedule ID : " CssClass="custom-label"></asp:Label>
            &nbsp;<asp:TextBox ID="txtScheduleID" runat="server" AutoPostBack="True" Enabled="False" OnTextChanged="txtScheduleID_TextChanged" CssClass="custom-textbox"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:FormView ID="FormView1" runat="server" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" Width="40%" CssClass="form-view-container">
                <EditItemTemplate>
                    <div class="form-view-item">
                        <div class="form-view-label">BusID:</div>
                        <asp:TextBox ID="BusIDTextBox" runat="server" Text='<%# Bind("BusID") %>' CssClass="form-view-textbox" />
                    </div>
                    <div class="form-view-item">
                        <div class="form-view-label">Start:</div>
                        <asp:TextBox ID="StartCityNameTextBox" runat="server" Text='<%# Bind("StartCityName") %>' CssClass="form-view-textbox" />
                    </div>
                    <div class="form-view-item">
                        <div class="form-view-label">Destination:</div>
                        <asp:TextBox ID="DestinationCityNameTextBox" runat="server" Text='<%# Bind("DestinationCityName") %>' CssClass="form-view-textbox" />
                    </div>
                    <div class="form-view-item">
                        <div class="form-view-label">Time:</div>
                        <asp:TextBox ID="TimeTextBox" runat="server" Text='<%# Bind("Time") %>' CssClass="form-view-textbox" />
                    </div>
                    <div class="form-view-item">
                        <div class="form-view-label">Date:</div>
                        <asp:TextBox ID="DateTextBox" runat="server" Text='<%# Bind("Date", "{0:yyyy/MM/dd}") %>' CssClass="form-view-textbox" />
                    </div>
                    <div class="form-view-item">
                        <div class="form-view-label">Price:</div>
                        <asp:TextBox ID="PriceTextBox" runat="server" Text='<%# Bind("Price") %>' CssClass="form-view-textbox" />
                    </div>
                    <div class="form-view-item">
                        <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" CssClass="form-view-button" />
                        <asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" CssClass="form-view-button" />
                    </div>
                </EditItemTemplate>
                <InsertItemTemplate>
                    <div class="form-view-label">BusID:</div>
                    <asp:TextBox ID="BusIDTextBox" runat="server" Text='<%# Bind("BusID") %>' CssClass="form-view-textbox" />
                    <br />
                    <div class="form-view-label">Start:</div>
                    <asp:TextBox ID="StartCityNameTextBox" runat="server" Text='<%# Bind("StartCityName") %>' CssClass="form-view-textbox" />
                    <br />
                    <div class="form-view-label">Destination:</div>
                    <asp:TextBox ID="DestinationCityNameTextBox" runat="server" Text='<%# Bind("DestinationCityName") %>' CssClass="form-view-textbox" />
                    <br />
                    <div class="form-view-label">Time:</div>
                    <asp:TextBox ID="TimeTextBox" runat="server" Text='<%# Bind("Time") %>' CssClass="form-view-textbox" />
                    <br />
                    <div class="form-view-label">Date:</div>
                    <asp:TextBox ID="DateTextBox" runat="server" Text='<%# Bind("Date", "{0:yyyy/MM/dd}") %>' CssClass="form-view-textbox" />
                    <br />
                    <div class="form-view-label">Price:</div>
                    <asp:TextBox ID="PriceTextBox" runat="server" Text='<%# Bind("Price") %>' CssClass="form-view-textbox" />
                    <br />
                    <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" CssClass="form-view-linkbutton" />
                    &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" CssClass="form-view-linkbutton" />
                </InsertItemTemplate>
                <ItemTemplate>
                    <div class="form-view-label">BusID:</div>
                    <asp:Label ID="BusIDLabel" runat="server" Text='<%# Bind("BusID") %>' CssClass="form-view-label" />
                    <br />
                    <div class="form-view-label">Start:</div>
                    <asp:Label ID="StartCityNameLabel" runat="server" Text='<%# Bind("StartCityName") %>' CssClass="form-view-label" />
                    <br />
                    <div class="form-view-label">Destination:</div>
                    <asp:Label ID="DestinationCityNameLabel" runat="server" Text='<%# Bind("DestinationCityName") %>' CssClass="form-view-label" />
                    <br />
                    <div class="form-view-label">Time:</div>
                    <asp:Label ID="TimeLabel" runat="server" Text='<%# Bind("Time") %>' CssClass="form-view-label" />
                    <br />
                    <div class="form-view-label">Date:</div>
                    <asp:Label ID="DateLabel" runat="server" Text='<%# Bind("Date", "{0:yyyy/MM/dd}") %>' CssClass="form-view-label" />
                    <br />
                    <div class="form-view-label">Price:</div>
                    <asp:Label ID="PriceLabel" runat="server" Text='<%# Bind("Price") %>' CssClass="form-view-label" />
                    <br />
                </ItemTemplate>
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            </asp:FormView>







            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [BusID], [StartCityName], [DestinationCityName], [Time], [Date], [Price] FROM [schedule] WHERE ([ScheduleID] = @ScheduleID)">
                <SelectParameters>
                    <asp:ControlParameter ControlID="txtScheduleID" Name="ScheduleID" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />
            <br />
            <br />
            <asp:Label ID="SeatSelection" runat="server" Text="Seat Selection" CssClass="custom-seat-label"></asp:Label>


            <br />
            <br />
            <br />


            <div style="margin: 0px 0px 0px 115px">
                <asp:Label ID="FrontOfTheBus" runat="server" Text="Front of the bus" CssClass="custom-label"></asp:Label>
                <br />
                <br />
            </div>

            <table class="custom-seat-table">
                <tr>
                    <td class="auto-style4">
                        <asp:ImageButton ID="SeatNumber1" Height="50px" Width="50px" runat="server" OnClick="SeatNumber1_Click" ImageUrl="~/image/Bus seat (Black).png" CausesValidation="False" />&nbsp; 
                        <asp:ImageButton ID="SeatNumber2" Height="50px" Width="50px" runat="server" OnClick="SeatNumber2_Click" ImageUrl="~/image/Bus seat (Black).png" CausesValidation="False" />
                    </td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style2">
                        <asp:ImageButton ID="SeatNumber3" Height="50px" Width="50px" runat="server" OnClick="SeatNumber3_Click" ImageUrl="~/image/Bus seat (Black).png" CausesValidation="False" />
                        &nbsp;<asp:ImageButton ID="SeatNumber4" Height="50px" Width="50px" runat="server" OnClick="SeatNumber4_Click" ImageUrl="~/image/Bus seat (Black).png" CausesValidation="False" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:ImageButton ID="SeatNumber5" Height="50px" Width="50px" runat="server" OnClick="SeatNumber5_Click" ImageUrl="~/image/Bus seat (Black).png" CausesValidation="False" />
                        &nbsp;<asp:ImageButton ID="SeatNumber6" Height="50px" Width="50px" runat="server" OnClick="SeatNumber6_Click" ImageUrl="~/image/Bus seat (Black).png" CausesValidation="False" />
                    </td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style2">
                        <asp:ImageButton ID="SeatNumber7" Height="50px" Width="50px" runat="server" OnClick="SeatNumber7_Click" ImageUrl="~/image/Bus seat (Black).png" CausesValidation="False" />
                        &nbsp;<asp:ImageButton ID="SeatNumber8" Height="50px" Width="50px" runat="server" OnClick="SeatNumber8_Click" ImageUrl="~/image/Bus seat (Black).png" CausesValidation="False" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:ImageButton ID="SeatNumber9" Height="50px" Width="50px" runat="server" OnClick="SeatNumber9_Click" ImageUrl="~/image/Bus seat (Black).png" CausesValidation="False" />
                        &nbsp;<asp:ImageButton ID="SeatNumber10" Height="50px" Width="50px" runat="server" OnClick="SeatNumber10_Click" ImageUrl="~/image/Bus seat (Black).png" CausesValidation="False" />
                    </td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style2">
                        <asp:ImageButton ID="SeatNumber11" Height="50px" Width="50px" runat="server" OnClick="SeatNumber11_Click" ImageUrl="~/image/Bus seat (Black).png" CausesValidation="False" />
                        &nbsp;<asp:ImageButton ID="SeatNumber12" Height="50px" Width="50px" runat="server" OnClick="SeatNumber12_Click" ImageUrl="~/image/Bus seat (Black).png" CausesValidation="False" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:ImageButton ID="SeatNumber13" Height="50px" Width="50px" runat="server" OnClick="SeatNumber13_Click" ImageUrl="~/image/Bus seat (Black).png" CausesValidation="False" />
                        &nbsp;<asp:ImageButton ID="SeatNumber14" Height="50px" Width="50px" runat="server" OnClick="SeatNumber14_Click" ImageUrl="~/image/Bus seat (Black).png" CausesValidation="False" />
                    </td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style2">
                        <asp:ImageButton ID="SeatNumber15" Height="50px" Width="50px" runat="server" OnClick="SeatNumber15_Click" ImageUrl="~/image/Bus seat (Black).png" CausesValidation="False" />
                        &nbsp;<asp:ImageButton ID="SeatNumber16" Height="50px" Width="50px" runat="server" OnClick="SeatNumber16_Click" ImageUrl="~/image/Bus seat (Black).png" CausesValidation="False" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:ImageButton ID="SeatNumber17" Height="50px" Width="50px" runat="server" OnClick="SeatNumber17_Click" ImageUrl="~/image/Bus seat (Black).png" CausesValidation="False" />
                        &nbsp;<asp:ImageButton ID="SeatNumber18" Height="50px" Width="50px" runat="server" OnClick="SeatNumber18_Click" ImageUrl="~/image/Bus seat (Black).png" CausesValidation="False" />
                    </td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style2">
                        <asp:ImageButton ID="SeatNumber19" Height="50px" Width="50px" runat="server" OnClick="SeatNumber19_Click" ImageUrl="~/image/Bus seat (Black).png" CausesValidation="False" />
                        &nbsp;<asp:ImageButton ID="SeatNumber20" Height="50px" Width="50px" runat="server" OnClick="SeatNumber20_Click" ImageUrl="~/image/Bus seat (Black).png" CausesValidation="False" />
                    </td>
                </tr>
            </table>


            <br />
            <table style="width: 30%; border: 2px solid #333; border-collapse: collapse; margin-left: 70px;">
                <tr>
                    <td class="auto-style14">
                        <asp:Image ID="Image1" Height="50px" Width="50px" runat="server" ImageUrl="~/image/Bus seat (Black).png" />
                        <asp:Label ID="Label12" runat="server" Text="Available" Style="display: block; text-align: center; color: #3498db; font-weight: bold;"></asp:Label>
                    </td>
                    <td class="auto-style14">
                        <asp:Image ID="Image2" Height="50px" Width="50px" runat="server" ImageUrl="~/image/Bus seat (Green).png" />
                        <asp:Label ID="Label13" runat="server" Text="Selected" Style="display: block; text-align: center; color: #27ae60; font-weight: bold;"></asp:Label>
                    </td>
                    <td class="auto-style14">
                        <asp:Image ID="Image3" Height="50px" Width="50px" runat="server" ImageUrl="~/image/Bus seat (Red).png" />
                        <asp:Label ID="Label14" runat="server" Text="Booked" Style="display: block; text-align: center; color: #e74c3c; font-weight: bold;"></asp:Label>
                    </td>
                </tr>
            </table>

            <br />

            <br />
            <table class="seat-table">
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label8" runat="server" Text="SeatNumber : " CssClass="seat-label"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtSeatNumber" runat="server" AutoPostBack="True" Enabled="False" OnTextChanged="txtSeatNumber_TextChanged" CssClass="seat-textbox"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvSeatNumber" runat="server" ControlToValidate="txtSeatNumber" Display="Static" ErrorMessage="*" ForeColor="Red" CssClass="validation-error"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label5" runat="server" Text="SeatID : " CssClass="seat-label"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtSeatID" runat="server" AutoPostBack="True" Enabled="False" OnTextChanged="txtSeatID_TextChanged" CssClass="seat-textbox"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvSeatID" runat="server" ControlToValidate="txtSeatID" Display="Static" ErrorMessage="*" ForeColor="Red" CssClass="validation-error"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label6" runat="server" Text="TicketID : " CssClass="seat-label"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtTicketID" runat="server" AutoPostBack="True" Enabled="False" CssClass="seat-textbox"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvTicketID" runat="server" ControlToValidate="txtTicketID" Display="Static" ErrorMessage="*" ForeColor="Red" CssClass="validation-error"></asp:RequiredFieldValidator>
                    </td>
                </tr>
            </table>
            <br />

            <br />
            <asp:Button ID="ButtonBack" runat="server" Text="Back" CssClass="custom-button" OnClick="ButtonBack_Click" CausesValidation="False" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ConfirmButton" runat="server" Text="Confirm" OnClick="ConfirmButton_Click" CssClass="custom-button"/>
        </div>

    </form>


</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="Server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder4" runat="Server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
