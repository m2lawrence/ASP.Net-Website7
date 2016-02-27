<%@ Page Title="Booking Form" Language="VB" MasterPageFile="MasterPage2.master" AutoEventWireup="false" CodeFile="bookingForm.aspx.vb" Inherits="bookingForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
    <link href="home1.css" rel="stylesheet" />
   
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p ="yellow">
   
        <br />
&nbsp;<asp:Label ID="Label1" runat="server" Text="First Name:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;Last Name:&nbsp;
        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="email address:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtEmailAddress" runat="server" Width="369px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Mobile:"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtMobileNo" runat="server" style="margin-left: 17px" Width="381px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="Home Address:"></asp:Label>
    &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtHomeAddress" runat="server" Width="377px"></asp:TextBox>
    </p>
    <p>
        <asp:DropDownList ID="DropDownProducts" runat="server" AutoPostBack="True">
            <asp:ListItem Value="1">Flowers</asp:ListItem>
            <asp:ListItem Value="2">Seeds</asp:ListItem>
            <asp:ListItem Value="3">Bug</asp:ListItem>
            <asp:ListItem Value="4">Grass Lawn square</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Text="Unit price: "></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtUnitPrice" runat="server" Enabled="False"></asp:TextBox>
&nbsp;&nbsp;&nbsp;</p>
    <p style="margin-left: 40px">
        &nbsp;<asp:DropDownList ID="DropDownListQuantity" runat="server" AutoPostBack="True">
            <asp:ListItem Value="1">1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxSummary" runat="server" Enabled="False" ReadOnly="True"></asp:TextBox>
    </p>
    <p>
       
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
    <p>
       
        <asp:TextBox ID="txtSummary" runat="server" Height="166px" TextMode="MultiLine" Width="619px"></asp:TextBox>
    
       
</asp:Content>

