#pragma checksum "C:\Users\Aestuo\source\repos\Rt21_Interface\Rt21_Interface\Pages\Count.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3bf53b782265a82bd608b4918143c24966e4552"
// <auto-generated/>
#pragma warning disable 1591
namespace Rt21_Interface.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Aestuo\source\repos\Rt21_Interface\Rt21_Interface\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aestuo\source\repos\Rt21_Interface\Rt21_Interface\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Aestuo\source\repos\Rt21_Interface\Rt21_Interface\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Aestuo\source\repos\Rt21_Interface\Rt21_Interface\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Aestuo\source\repos\Rt21_Interface\Rt21_Interface\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Aestuo\source\repos\Rt21_Interface\Rt21_Interface\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Aestuo\source\repos\Rt21_Interface\Rt21_Interface\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Aestuo\source\repos\Rt21_Interface\Rt21_Interface\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Aestuo\source\repos\Rt21_Interface\Rt21_Interface\_Imports.razor"
using Rt21_Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Aestuo\source\repos\Rt21_Interface\Rt21_Interface\_Imports.razor"
using Rt21_Interface.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Aestuo\source\repos\Rt21_Interface\Rt21_Interface\Pages\Count.razor"
using RaceTo21;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Game")]
    public partial class Count : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Player:</h2>");
#nullable restore
#line 7 "C:\Users\Aestuo\source\repos\Rt21_Interface\Rt21_Interface\Pages\Count.razor"
 if (Game.players.Count > 0)

{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "form");
#nullable restore
#line 11 "C:\Users\Aestuo\source\repos\Rt21_Interface\Rt21_Interface\Pages\Count.razor"
         foreach (var player in Game.players)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.OpenElement(6, "h5");
            __builder.AddAttribute(7, "class", "card-title");
            __builder.AddContent(8, "Player ");
            __builder.AddContent(9, 
#nullable restore
#line 15 "C:\Users\Aestuo\source\repos\Rt21_Interface\Rt21_Interface\Pages\Count.razor"
                                                    Game.players.IndexOf(player)+1

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "p");
            __builder.AddContent(12, "This is ");
            __builder.AddContent(13, 
#nullable restore
#line 16 "C:\Users\Aestuo\source\repos\Rt21_Interface\Rt21_Interface\Pages\Count.razor"
                                player.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "h6");
            __builder.AddContent(16, "Point: ");
            __builder.AddContent(17, 
#nullable restore
#line 17 "C:\Users\Aestuo\source\repos\Rt21_Interface\Rt21_Interface\Pages\Count.razor"
                                player.point

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n                    ");
            __builder.OpenElement(19, "p");
            __builder.AddContent(20, "Player Status: ");
            __builder.AddContent(21, 
#nullable restore
#line 19 "C:\Users\Aestuo\source\repos\Rt21_Interface\Rt21_Interface\Pages\Count.razor"
                                       player.status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\Aestuo\source\repos\Rt21_Interface\Rt21_Interface\Pages\Count.razor"
                     if (player.status == PlayerStatus.active)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(22, "<p>how many cards you want to draw?</p>\r\n                        ");
            __builder.OpenElement(23, "input");
            __builder.AddAttribute(24, "type", "text");
            __builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\Aestuo\source\repos\Rt21_Interface\Rt21_Interface\Pages\Count.razor"
                                                        player.NumOfCard

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => player.NumOfCard = __value, player.NumOfCard));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                        ");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "type", "button");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\Aestuo\source\repos\Rt21_Interface\Rt21_Interface\Pages\Count.razor"
                                                        () => DrawCards(player)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(31, "Draw");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                        ");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "type", "button");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\Aestuo\source\repos\Rt21_Interface\Rt21_Interface\Pages\Count.razor"
                                                        () => Stay(player)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(36, "Stay");
            __builder.CloseElement();
#nullable restore
#line 26 "C:\Users\Aestuo\source\repos\Rt21_Interface\Rt21_Interface\Pages\Count.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(37, "<p>Player\'s hand:</p>");
#nullable restore
#line 28 "C:\Users\Aestuo\source\repos\Rt21_Interface\Rt21_Interface\Pages\Count.razor"
                     foreach (var card in player.cards)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(38, "p");
            __builder.AddContent(39, 
#nullable restore
#line 30 "C:\Users\Aestuo\source\repos\Rt21_Interface\Rt21_Interface\Pages\Count.razor"
                            card.displayName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 31 "C:\Users\Aestuo\source\repos\Rt21_Interface\Rt21_Interface\Pages\Count.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(40, "p");
            __builder.AddContent(41, "Player\'s Score: ");
            __builder.AddContent(42, 
#nullable restore
#line 32 "C:\Users\Aestuo\source\repos\Rt21_Interface\Rt21_Interface\Pages\Count.razor"
                                        player.score

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "C:\Users\Aestuo\source\repos\Rt21_Interface\Rt21_Interface\Pages\Count.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\Aestuo\source\repos\Rt21_Interface\Rt21_Interface\Pages\Count.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\Aestuo\source\repos\Rt21_Interface\Rt21_Interface\Pages\Count.razor"
       

    public void DrawCards(Player player)
    {
        int numOfCards = player.NumOfCard;
        for (int i = 0; i < numOfCards; i++)
        {
            Card card = Game.deck.DealTopCard();//get the last card in the deck

            player.cards.Add(card);//add that card to player's hand
        }
        player.score = Game.ScoreHand(player);
        if (player.score > 21)
        {
            player.status = PlayerStatus.bust;
            CheckWinners();
        }
        else if (player.score == 21)
        {
            player.status = PlayerStatus.win;
            player.point += player.score;
            JSRuntime.InvokeVoidAsync("alert", "Player " + player.name + " has won the game!");
            NavigationManager.NavigateTo("/TakeARest"); //navigate to the next page
        }
        else
        {
            CheckWinners();
        }
    }

    public void Stay(Player player)
    {
        player.status = PlayerStatus.stay;
        CheckWinners();
    }

    private void CheckWinners()
    {
        bool allBust = true;
        bool allStay = true;
        Player winner = null;

        foreach (var player in Game.players)
        {
            if (player.status == PlayerStatus.active)
            {
                allStay = false;
            }

            if (player.status == PlayerStatus.bust)
            {
                continue;
            }

            if (player.score <= 21)
            {
                allBust = false;

                if (winner == null || player.score > winner.score)
                {
                    winner = player;
                }
            }
        }

        if (allBust)
        {
            JSRuntime.InvokeVoidAsync("alert", "All players have busted! There is no winner.");
            NavigationManager.NavigateTo("/TakeARest"); //navigate to the next page
        }
        else if (allStay)
        {
            winner.point += winner.score;
            JSRuntime.InvokeVoidAsync("alert", "Congratulation! The winner is Player " + (Game.players.IndexOf(winner) + 1) + " with a score of " + winner.score + "!");
            NavigationManager.NavigateTo("/TakeARest"); //navigate to the next page
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
