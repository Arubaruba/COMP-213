<%@ Page Title="" Language="C#" MasterPageFile="~/XtremeCinema.Master" AutoEventWireup="true" CodeBehind="RentMovies.aspx.cs" Inherits="HW5_Exercise9._4.RentMovies" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceholder" runat="server">
    <div class="callout" style="overflow: auto">
        <h3>Rent a Movie</h3>
        <form id="rentMovieForm" runat="server">
            <div class="row">
                <div class="large-6 columns">
                    <label>
                        Movie Title
                <input type="text" />
                    </label>
                </div>

                <div class="large-6 columns">
                    <label>&nbsp;</label>
                    <input type="checkbox" name="newRelease" id="isNewRelease" /><label for="isNewRelease">
                        New Release
                        <i class="success">($1 extra)</i>
                    </label>
                </div>
            </div>
            <div class="row">
                <div class="large-6 columns">
                    <label>Movie Format</label>
                    <asp:RadioButton ID="dvdFormat" runat="server" />
                        DVD
                        <i>($5.00)</i>
                    </label>
                    <asp:RadioButton ID="bluerayFormat" runat="server" />
                    <label for="bluerayFormat">
                        Blueray
                        <i>($4.50)</i>
                    </label>
                </div>

                <div class="large-6 columns">
                    <label>&nbsp;</label>
                    <input type="checkbox" name="membership" id="hasMembership" />
                    <label for="hasMembership">
                        Member
                        <i>(10% off)</i>
                    </label>
                </div>
            </div>
            <div class="row" style="margin: 30px 0">
                <b>
                    <asp:Label ID="totalCostLabel" runat="server"></asp:Label>
                </b>
            </div>
            <div class="row">
                <div class="large-9 columns">
                    <div class="button-group">
                        <asp:Button ID="calculateButton" runat="server" Text="Calculate" CssClass="button" OnClick="calculateButton_Click" />
                        <asp:Button ID="orderButton" runat="server" Text="Place Order" CssClass="button" OnClick="orderButton_Click" />
                    </div>
                </div>
                <div class="large-3 columns text-right">
                    <asp:Button ID="clearButton" runat="server" Text="Clear Form" CssClass="button" OnClick="clearButton_Click" />
                </div>
            </div>
        </form>
    </div>

</asp:Content>
