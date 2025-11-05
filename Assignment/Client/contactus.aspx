<%@ Page Language="C#" MasterPageFile="~/Nav.Master" AutoEventWireup="true" CodeBehind="contactus.aspx.cs" Inherits="Assignment.contactus" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .style1
        {
            height: 40px;
        }
    .auto-style1 {
        width: 35%;
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
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="Server">
    <div id="right">
   <%--   //  <div class="leftcol610">--%>
            <div id="innertitle">
                <table align="center">
                    <tr align="left">
                        <td align="left" class="style1">
                            <strong>
                                <asp:Label ID="lblheat" runat="server" Text="Contact Us" Font-Size="X-Large" ForeColor="#F7990D"></asp:Label></strong>
                            <br />
                        </td>
                    </tr>
                </table>
            </div>
            <%-- <h3>
                Contas Us For
            </h3>--%>
            <table style="background-position: 50% bottom; background-repeat: repeat-x" cellspacing="0"
                cellpadding="4" width="100%" border="0">
                <tbody>
                    <tr>
                        <td align="center">
                            <table cellspacing="0" cellpadding="0" width="97%" align="center" border="0">
                                <tbody>
                                    <tr valign="top" align="center">
                                        <td valign="middle" colspan="4" height="40">
                                            <table cellspacing="0" cellpadding="2" width="93%" border="0">
                                                <tbody>
                                                    <tr valign="top" align="left">
                                                        <td colspan="3">
                                                            <table style="font-size: 11px; font-family: Verdana, Arial, Helvetica, sans-serif"
                                                                cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                <tbody>
                                                                    <tr>
                                                                        <td colspan="2" height="5">
                                                                            <p style="font-weight: bold; font-size: 18px; font-family: Verdana, Arial, Helvetica, sans-serif"
                                                                                align="center">
                                                                                Dial Customer Care:
                                                                                <br />
                                                                                <br />
                                                                                <span style="font-weight: bold; font-size: 24px; color: #990000; font-family: Verdana, Arial, Helvetica, sans-serif">
                                                                                    +60 1234567890
                                                                                    <br />
                                                                                    <br />
                                                                                    +60 1234567891<br />
                                                                                </span><span style="font-size: 18px; font-family: Verdana, Arial, Helvetica, sans-serif">
                                                                                    <span style="font-weight: normal; font-size: 11px; line-height: 7mm; font-family: Verdana, Arial, Helvetica, sans-serif">
                                                                                        (Timing: 10:00 am - 10:00 pm, Mon-Sun)</span> </span>
                                                                            </p>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td colspan="2" height="5">
                                                                            <span style="font-size: 11px; font-family: Verdana, Arial, Helvetica, sans-serif">
                                                                                <marquee></marquee>
                                                                            </span>
                                                                        </td>
                                                                    </tr>
                                                                </tbody>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr valign="top" align="left">
                                                        <td>
                                                            <font size="3" color="#0066ff"><strong>Peter</strong> </font>
                                                        </td>
                                                        <td class="auto-style1">
                                                            &nbsp;
                                                        </td>
                                                        <td>
                                                            <font size="3" color="#0066ff"><strong>Sushi</strong> </font>
                                                        </td>
                                                    </tr>
                                                    <tr valign="top" align="left">
                                                        <td width="45%" background="images/reddot.gif" height="1">
                                                        </td>
                                                        <td height="1" class="auto-style1">
                                                        </td>
                                                        <td width="45%" background="images/reddot.gif" height="1">
                                                        </td>
                                                    </tr>
                                                    <tr valign="top" align="left">
                                                        <td>
                                                            
                                                                <strong>Hi, I'm Peter,
                                                                    <br />
                                                                    I&#39;m not the Spider Man
                                                                    <br/>                                                                 
                                                                    I just a normal people
                                                                    <br />                                                                
                                                                </strong>
                                                            
                                                        </td>
                                                        <td class="auto-style1">
                                                            &nbsp;
                                                        </td>
                                                        <td>
                                                            
                                                                <strong>Hi, I'm a Sushi,
                                                                <br />
                                                                I love to be eaten,
                                                                <br />
                                                                I'm very delicious
                                                                <br />
                                                            </strong>
                                                        </td>
                                                    </tr>
                                                    <tr valign="top" align="left">
                                                        <td height="1">
                                                            &nbsp;
                                                        </td>
                                                        <td height="1" class="auto-style1">
                                                        </td>
                                                        <td height="1">
                                                        </td>
                                                    </tr>
                                                    <tr valign="top" align="left">
                                                        <td background="images/reddot.gif" height="1">
                                                        </td>
                                                        <td background="images/reddot.gif" height="1" class="auto-style1">
                                                        </td>
                                                        <td background="images/reddot.gif" height="1">
                                                        </td>
                                                    </tr>
                                                    <tr valign="top" align="center">
                                                        <td colspan="3" height="1">
                                                            or <strong>Email</strong> us at: <a href="#">
                                                                <br />
                                                                ourbus2003@gmail.com<br />
                                                               </a>
                                                        </td>
                                                    </tr>
                                                    <br />
                                                    <br>
                                                    <tr valign="top" align="center">
                                                        <td colspan="3" height="1">
                                                            <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" CausesValidation="False" CssClass="formButton" />

                                                        </td>
                                                    </tr>
                                                </tbody>
                                            </table>
                                            <br />
                                            <br>
                                            <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                <tbody>
                                                    <tr>
                                                        <td background="images/reddot.gif" height="1">
                                                        </td>
                                                    </tr>
                                                </tbody>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr valign="top" align="center">
                                        <td colspan="4">
                                        </td>
                                    </tr>
                                    <tr valign="top" align="center">
                                        <td style="background-position: center 50%; background-repeat: repeat-x" valign="bottom"
                                            colspan="6" height="1">
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </td>
                    </tr>
                </tbody>
            </table>
       <%-- </div>--%>
    </div>
</asp:Content>
