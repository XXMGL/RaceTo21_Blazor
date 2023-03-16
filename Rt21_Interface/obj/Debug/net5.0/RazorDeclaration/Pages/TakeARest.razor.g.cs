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
#line 1 "C:\Users\Aestuo\Desktop\RaceTo21_Blazor\Rt21_Interface\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aestuo\Desktop\RaceTo21_Blazor\Rt21_Interface\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Aestuo\Desktop\RaceTo21_Blazor\Rt21_Interface\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Aestuo\Desktop\RaceTo21_Blazor\Rt21_Interface\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Aestuo\Desktop\RaceTo21_Blazor\Rt21_Interface\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Aestuo\Desktop\RaceTo21_Blazor\Rt21_Interface\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Aestuo\Desktop\RaceTo21_Blazor\Rt21_Interface\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Aestuo\Desktop\RaceTo21_Blazor\Rt21_Interface\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Aestuo\Desktop\RaceTo21_Blazor\Rt21_Interface\_Imports.razor"
using Rt21_Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Aestuo\Desktop\RaceTo21_Blazor\Rt21_Interface\_Imports.razor"
using Rt21_Interface.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Aestuo\Desktop\RaceTo21_Blazor\Rt21_Interface\Pages\TakeARest.razor"
using RaceTo21;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/TakeARest")]
    public partial class TakeARest : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\Aestuo\Desktop\RaceTo21_Blazor\Rt21_Interface\Pages\TakeARest.razor"
       
    public void UpdatePlayerStatus(Player player, PlayerStatus status) // Updates a player's status
    {
        player.status = status; // Sets the player's status to the new status
        if (status == PlayerStatus.quit) // If the new status is "quit"
        {
            Game.players.Remove(player); // Remove the player from the Game.players list
        }
    }

    public void StartNewRound() // Starts a new round
    {
        // Remove players who have quit
        Game.players.RemoveAll(p => p.status == PlayerStatus.quit); // Remove all players whose status is "quit"

        // Reset game status for active players
        foreach (var player in Game.players.Where(p => p.status == PlayerStatus.active)) // Loops through all active players
        {
            player.score = 0; // Resets the player's score to 0
            player.cards.Clear(); // Clears the player's cards list
            player.status = PlayerStatus.active; // Sets the player's status to "active"
        }

        // Start new round
        NavigationManager.NavigateTo("/Game"); // Navigates to the "/Game" page
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591