<%@ Page Language="C#" MasterPageFile="~/Nav.Master" AutoEventWireup="true" CodeBehind="Faq.aspx.cs" Inherits="Assignment.Faq" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .style1
        {
            height: 40px;
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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content1" runat="Server">
    <%--<div id="innertitle">
<h3>FAQ</h3></div>--%>
<div id="innertitle">
    <table align="center" >
        <tr align="left">
            <td align="left" class="style1" >
                <strong><asp:Label ID="lblheat" runat="server" Text="FAQ" Font-Size="X-Large"  
                    ForeColor="#F7990D"></asp:Label></strong>
           <br /> </td>
        </tr>
    </table>
    </div>
    <div id="rightContent">
        <div class="mainText" id="maintextBox">
            <!-- Body Content Starts -->
            <div id="fromtitle">
                <h3 id="top">
                    Frequently asked questions</h3>
            </div>
            <div id="formBody">
                <div id="contentBox" style="margin: 0px 0px 20px 0px">
                    <ul>
                        <li><a href="#q1">Can I buy multiple ticket?</a> </li>
                        <br/>
                        <li><a href="#q2">Can I cancel the ticket? </a></li>
                        <br/>
                        <li><a href="#q3">I don't have a credit cart can I still buy tickets at OurBus? </a></li>
                        <br/>
                        <li><a href="#q4">What credit/debit cards do you accept? </a></li>
                        <br/>
                        <li><a href="#q5">What payment options do i have? </a></li>
                        <br/>
                    </ul>
                </div>
                <ul>
                    <li><a id="q1" name="q1"></a><span class="orange11"><b>Can I buy multiple ticket?</b></span><br />
                        Yes, you can absolutely purchase multiple tickets through OurBus. To ensure a smooth transaction,
                        please note that when buying multiple tickets, it's advisable to avoid using the same receiver name 
                        and contact number for each ticket. This helps in better management of bookings and facilitates 
                        a hassle-free experience for each passenger. </li>
                    <br/>
                    <br/>
                    <li><a id="q2" name="q2"></a><span class="orange11"><b>Can I cancel the ticket?</b></span><br />
                        Unfortunately, ticket cancellation is not possible after purchase. It's crucial to review your 
                        selections and ensure the accuracy of your choices before confirming the purchase. Take your time 
                        during the booking process to avoid any inconveniences later. Responsibility for ticket selection 
                        accuracy lies with the purchaser, so please double-check the details before finalizing your booking.</li>
                    <br/>
                    <br/>
                    <li><a id="q3" name="q3"></a><span class="orange11"><b>I don't have a credit cart can I still buy tickets at OurBus?</b></span><br />
                        Absolutely! OurBus offers alternative payment methods apart from credit cards. You can conveniently 
                        make your purchase using online banking services or through the Touch and Go eWallet. These options 
                        are available to accommodate various preferences and ensure a seamless booking experience for all passengers.</li>
                    <br/>
                    <br/>
                    <li><a id="q4" name="q4"></a><span class="orange11"><b>What credit/debit cards do you accept?</b></span><br />
                        We accept payments from all major credit and debit cards. Regardless of the type of card you 
                        possess, you can confidently proceed with your transaction knowing that it will be accepted 
                        without any issues.</li>
                    <br/>
                    <br/>
                    <li><a id="q5" name="q5"></a><span class="orange11"><b>What payment options do i have?</b></span><br />
                        OurBus strives to provide diverse payment options to suit different preferences. Alongside credit 
                        and debit cards, you can complete your purchase using online banking services or the Touch and Go eWallet. 
                        These varied payment methods are in place to offer flexibility and convenience, ensuring a hassle-free
                        booking process for our valued customers.</li>
                    <li>
                        <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" CausesValidation="False" CssClass="formButton" />
                    </li>
                     
                </ul>
                <p style="float: right">
                    <a href="#top">Top</a></p>
            </div>
        </div>
    </div>
</asp:Content>
