<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<timesheet.Models.TimeSheetCollection>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Feuilles de temps
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="text-center">
        <h2>Feuilles de temps</h2>
    </div>
    <div>
        <ul>
            <% foreach (var m in Model)
               { %>
                    <li>
                        <span><%= m.Date.ToString("d") %></span>
                        <span>Travail</span>
                        <span><%= m.HoursWorked %>h</span>
                    </li>
            <% } %>
        </ul>
    </div>
</asp:Content>