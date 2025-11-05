<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaymentSuccessful.aspx.cs" Inherits="Assignment.Client.PaymentSuccessful" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Payment Successful</title>
    <style type="text/css">
        body {
            display: flex;
            align-items: center;
            justify-content: center;
            height: 100vh;
            margin: 0;
            overflow: hidden;
        }

        .image-container {
            position: relative;
        }

        .gif-image {
            position: absolute;
            top: 50%;
            left: 50%;
            transform: translate(-50%, -50%);
            width: 250px; /* Set the width */
            height: 250px; /* Set the height */
            object-fit: cover;
            opacity: 0;
            transition: opacity 1s ease-in-out;
        }


            .gif-image.active {
                opacity: 1;
            }
    </style>
    <script type="text/javascript">
        function load() {
            var processingImage = document.getElementById('<%= Image1.ClientID %>');
            var successImage = document.getElementById('<%= Image2.ClientID %>');

            // Display the initial processing image for about 1 seconds
            setTimeout(function () {
                processingImage.classList.add('active');

                // Wait for 2.3 seconds and then change the image to the successful one
                setTimeout(function () {
                    processingImage.classList.remove('active');
                    successImage.classList.add('active');

                    // Wait for 1.8 seconds and then redirect to Complete.aspx
                    setTimeout(function () {
                        window.location.href = 'Complete.aspx';
                    }, 1800);
                }, 1500);
            }, 1600);
        }
    </script>
</head>
<body onload="load()">
    <form id="form1" runat="server">
        <div class="image-container">
            <asp:Image ID="Image1" runat="server" CssClass="gif-image" ImageUrl="~/image/Processing Payment.gif" />
            <asp:Image ID="Image2" runat="server" CssClass="gif-image" ImageUrl="~/image/Successful Payment.gif" />

            <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
            
            <table style="width: 100%; ">
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="lblError" runat="server"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>


        </div>
        <p>
            &nbsp;
        </p>
    </form>
</body>
</html>
