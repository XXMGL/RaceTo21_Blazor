// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 4 "C:\Users\Aestuo\source\repos\Rt21_Interface\Rt21_Interface\Pages\Game.razor"
using RaceTo21;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Game")]
    public partial class Game : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\Aestuo\source\repos\Rt21_Interface\Rt21_Interface\Pages\Game.razor"
       

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
        }
        else if (player.score == 21)
        {
            player.status = PlayerStatus.win;
            JSRuntime.InvokeVoidAsync("alert", "Player " + player.name + " has won the game!");
            NavigationManager.NavigateTo("/TakeARest"); //navigate to the next page
        }
    }
    public void Stay(Player player)
    {
        player.status = PlayerStatus.stay;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591