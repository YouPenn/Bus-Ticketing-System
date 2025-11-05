<%@ Page Language="C#" MasterPageFile="~/Nav.Master" AutoEventWireup="true" CodeBehind="Comment.aspx.cs" Inherits="Assignment.Comment" %>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <style type="text/css">
        #formContainer {
            text-align: center;
            margin-top: 50px; /* Adjust the top margin as needed */
        }

        .formLabel {
            color: #3498db; /* Blue color */
            font-size: 24px; /* Bigger font size */
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
    </style>

    <form id="form1">
        <div id="formContainer">
            <asp:Label ID="Label1" runat="server" CssClass="formLabel" Text="Comment / FeedBack"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" CssClass="formLabel" Text="Leave your anonymous comment here!"></asp:Label>
            <br />
            <asp:TextBox ID="txtComment" runat="server" CssClass="formTextBox"></asp:TextBox><br />
            <asp:RequiredFieldValidator ID="rfvComment" runat="server" ControlToValidate="txtComment"
                Display="Dynamic" ErrorMessage="Please enter a comment" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" CssClass="formButton" OnClientClick="return showSuccessAlert();" />
            
            <script type="text/javascript">
                function showSuccessAlert() {
                    var txtComment = document.getElementById('<%=txtComment.ClientID%>');
                    if (txtComment.value.trim() !== '') {
                        alert('Your feedback has been sent successfully.');
                        return true;  // Allow postback
                    } else {
                        alert('Please enter a comment before submitting.');
                        return false;  // Prevent postback
                    }
                }
            </script>
 
            &nbsp;
            <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" CausesValidation="False" CssClass="formButton" />
        </div>
    </form>
</asp:Content>