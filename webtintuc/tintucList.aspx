<%@ Page Title="tintuc" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="tintucList.aspx.cs" Inherits="webtintuc.tintucList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section>
        <div>
            <hgroup>
                <h2><%: Page.Title %></h2>
                </hgroup>
                <asp:ListView ID="tacgiaList" runat="server" DataKeyNames="TinID"
                                GroupItemCount="4"
                    ItemType="webtintuc.Models.tintuc" SelectMethod="Gettintuc">
                    <EmptyDataTemplate>
                        <table >
                        <tr>
                        <td>No data was returned.</td>
                        </tr>
                        </table>
                        </EmptyDataTemplate>
                    <EmptyItemTemplate>
                    <td/>
                </EmptyItemTemplate>
                <GroupTemplate>
                <tr id="itemPlaceholderContainer" runat="server">
                <td id="itemPlaceholder" runat="server"></td>
                </tr>
                </GroupTemplate>
                    <ItemTemplate>
                <td runat="server">
                    <table>
                    <tr>
                    <td>
                <a href="tintucDetails.aspx?TinID=<%#:Item.TinID%>">
                <img src ="/Images/<%#:Item.Anh%>"
                width="150" height="225"
                    style="border:solid" /></a>
                </td>
                </tr>
                <tr>
                <td>
                <a href="tintucDetails.aspx?TinID=<%#:Item.TinID%>">
                <span>
                <%#:Item.TinID%>
                </span>
                </a>
                <br />
                <span>
            <b>Price:
           
        </span>
            <br />
        </td>
            </tr>
            <tr>
            <td>&nbsp;</td>
            </tr>
            </table>
            </p>
            </td>
        </ItemTemplate>
                    <LayoutTemplate>
        <table style="width:100%;">
    <tbody>
    <tr>
        <td>
        <table id="groupPlaceholderContainer" runat="server"
        style="width:100%">
        <tr id="groupPlaceholder"></tr>
        </table>
        </td>
        </tr>
        <tr>
        <td></td>
            </tr>
        <tr></tr>
        </tbody>
        </table>
        </LayoutTemplate>
                    </asp:ListView>
            </div>
        </section>
</asp:Content>
