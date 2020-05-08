<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TestADFS._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    You got luck today!
    <asp:Button ID="LogOutBtn" runat="server" Text="Log out" OnClick="LogoutBtn_Click" />
</asp:Content>
