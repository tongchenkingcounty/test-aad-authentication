<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="TestADFS.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
    <table border="1">
        <tr>
            <td>IsAuthenticated</td>
            <td><%= HttpContext.Current.User.Identity.IsAuthenticated %></td>
        </tr>
        <tr>
            <td>AuthenticationType</td>
            <td><%= HttpContext.Current.User.Identity.AuthenticationType %></td>
        </tr>
        <tr>
            <td>Name</td>
            <td><%= HttpContext.Current.User.Identity.Name %></td>
        </tr>
        <tr>
            <td>Is in "group1"</td>
            <td><%= HttpContext.Current.User.IsInRole("yourgroup1here") %></td>
        </tr>
        <tr>
            <td>Is in "group2"</td>
            <td><%= HttpContext.Current.User.IsInRole("yourgroup2here") %></td>
        </tr>
    </table>
    <br />
    <h3>Main Claims:</h3>
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    <br />
    <h3>All Claims:</h3>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</asp:Content>
