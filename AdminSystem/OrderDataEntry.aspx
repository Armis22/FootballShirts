<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 539px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblOrderID" runat="server" Text="Order ID" width="121px"></asp:Label>
        <asp:TextBox ID="txtOrderID" runat="server" style="margin-left: 15px"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" />
        <br />
        <asp:Label ID="lblCustomerNo" runat="server" Text="CustomerNo" width="121px"></asp:Label>
        <asp:TextBox ID="txtCustomerNo" runat="server" style="margin-left: 15px"></asp:TextBox>
        <br />
        <asp:Label ID="lblTeamName" runat="server" Text="TeamName"></asp:Label>
        <asp:TextBox ID="txtTeamName" runat="server" style="margin-left: 8px"></asp:TextBox>
        <br />
        <asp:Label ID="lblAddress" runat="server" Text="Address" width="121px"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server" style="margin-left: 15px" ></asp:TextBox>
        <br />
        <asp:Label ID="lblDate" runat="server" Text="Date" width="121px"></asp:Label>
        <asp:TextBox ID="txtDate" runat="server" style="margin-left: 15px" ></asp:TextBox>
        <br />
        <asp:Label ID="lblrice" runat="server" Text="Price" width="121px"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server" style="margin-left: 15px"></asp:TextBox>
        <br />
        <asp:Label ID="lblShirtColour" runat="server" Text="ShirtColour" width="121px"></asp:Label>
        <asp:TextBox ID="txtShirtColour" runat="server" style="margin-left: 15px"></asp:TextBox>
        <br />
         <asp:Label ID="lblStaffID" runat="server" Text="StaffID" width="121px"></asp:Label>
        <asp:TextBox ID="txtStaffID" runat="server" style="margin-left: 15px"></asp:TextBox>
        <br />
        <asp:CheckBox ID="chkAvailability" runat="server" Text="Availability" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click"/>&nbsp;&nbsp;
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>