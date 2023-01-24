<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.14.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    </div>
    <table>
        <tr>
            <td>
                <dx:ASPxListBox ID="lbOptions" runat="server" Width="100" Height="220" SelectionMode="Multiple">
                    <Items>
                        <dx:ListEditItem Text="Option 1" Value="1" />
                        <dx:ListEditItem Text="Option 2" Value="2" />
                        <dx:ListEditItem Text="Option 3" Value="3" />
                        <dx:ListEditItem Text="Option 4" Value="4" />
                        <dx:ListEditItem Text="Option 5" Value="5" />
                        <dx:ListEditItem Text="Option 6" Value="6" />
                        <dx:ListEditItem Text="Option 7" Value="7" />
                        <dx:ListEditItem Text="Option 8" Value="8" />
                        <dx:ListEditItem Text="Option 9" Value="9" />
                        <dx:ListEditItem Text="Option 10" Value="10" />
                    </Items>
                </dx:ASPxListBox>
            </td>
            <td>
                <dx:ASPxButton ID="bntMoveOne" runat="server" Text=">" OnClick="bntMoveOne_Click">
                </dx:ASPxButton>
                <dx:ASPxButton ID="btnMoveAll" runat="server" Text=">>" OnClick="btnMoveAll_Click">
                </dx:ASPxButton>
                <dx:ASPxButton ID="btnReturnOne" runat="server" Text="<" OnClick="bntReturnOne_Click">
                </dx:ASPxButton>
                <dx:ASPxButton ID="btnReturnAll" runat="server" Text="<<" OnClick="btnReturnAll_Click">
                </dx:ASPxButton>
            </td>
            <td>
                <dx:ASPxListBox ID="lbSelectedOptions" runat="server" Width="100" Height="220" SelectionMode="Multiple">
                </dx:ASPxListBox>
                
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
