<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WhoRU.aspx.cs" Inherits="Assignment.WhoRU" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body {
            display: flex;
            align-items: center;
            justify-content: center;
            height: 100vh;
            margin: 0;
            background-image: url('../image/BusDonut.gif');
            background-size: cover;
        }

        #container {
            text-align: center;
            z-index: 1;
            position: relative;
        }

        #container h1 {
            font-size: 36px;
            font-weight: bold;
            margin-bottom: 20px;
        }

        #container table {
            width: 100%;
        }

        #container table td {
            padding: 10px;
        }

        .button {
            width: 50%;
            padding: 15px 25px;
            font-size: 24px;
            text-align: center;
            cursor: pointer;
            outline: none;
            color: #fff;
            background-color: #007BFF; /* Blue color */
            border: none;
            border-radius: 15px;
            box-shadow: 0 9px #666;
        }

        .button:hover {
            background-color: #0056b3; /* Darker blue on hover */
        }

        .button:active {
            background-color: #0056b3;
            box-shadow: 0 5px #333;
            transform: translateY(4px);
        }

        /* Style to make 'or' text bigger */
        #container #orText {
            font-size: 35px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="container">
            <h1>
                <asp:Label ID="Label1" runat="server" Text="Online Bus Ticketing System"></asp:Label>
            </h1>
            <br />
            <br />
            <table>
                <tr>
                    <td>
                        <asp:Button ID="Customer" runat="server" OnClick="Customer_Click" Text="Customer" CssClass="button" />
                    </td>
                </tr>
                <tr>
                    <td id="orText">or</td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Admin" runat="server" OnClick="Admin_Click" Text="Admin" CssClass="button" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
