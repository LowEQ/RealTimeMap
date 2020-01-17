#pragma checksum "C:\Users\Jiang Zhipeng\Desktop\GIS_Developments\Demo\WebsocketDemo\WebsocketDemo\Pages\Map.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62159b49ec700ebad42c7b41f74bef118e55bede"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebsocketDemo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Jiang Zhipeng\Desktop\GIS_Developments\Demo\WebsocketDemo\WebsocketDemo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jiang Zhipeng\Desktop\GIS_Developments\Demo\WebsocketDemo\WebsocketDemo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jiang Zhipeng\Desktop\GIS_Developments\Demo\WebsocketDemo\WebsocketDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Jiang Zhipeng\Desktop\GIS_Developments\Demo\WebsocketDemo\WebsocketDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Jiang Zhipeng\Desktop\GIS_Developments\Demo\WebsocketDemo\WebsocketDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Jiang Zhipeng\Desktop\GIS_Developments\Demo\WebsocketDemo\WebsocketDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Jiang Zhipeng\Desktop\GIS_Developments\Demo\WebsocketDemo\WebsocketDemo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Jiang Zhipeng\Desktop\GIS_Developments\Demo\WebsocketDemo\WebsocketDemo\_Imports.razor"
using WebsocketDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Jiang Zhipeng\Desktop\GIS_Developments\Demo\WebsocketDemo\WebsocketDemo\_Imports.razor"
using WebsocketDemo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Jiang Zhipeng\Desktop\GIS_Developments\Demo\WebsocketDemo\WebsocketDemo\_Imports.razor"
using WebsocketDemo.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Jiang Zhipeng\Desktop\GIS_Developments\Demo\WebsocketDemo\WebsocketDemo\_Imports.razor"
using Syncfusion.EJ2.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Jiang Zhipeng\Desktop\GIS_Developments\Demo\WebsocketDemo\WebsocketDemo\_Imports.razor"
using Syncfusion.EJ2.Blazor.Maps;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jiang Zhipeng\Desktop\GIS_Developments\Demo\WebsocketDemo\WebsocketDemo\Pages\Map.razor"
using WebsocketDemo.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/map")]
    public partial class Map : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\Jiang Zhipeng\Desktop\GIS_Developments\Demo\WebsocketDemo\WebsocketDemo\Pages\Map.razor"
       
    //APIClient client = new APIClient();
    //MQTTClient client = new MQTTClient();
    static List<Juna> train = new List<Juna>();
    TrainData test = new TrainData();
    UpdateService mapUpdater = new UpdateService();

    private (Juna juna, Juna currentJuna) lastJuna;

    protected override async Task OnInitializedAsync()
    {
        train = await WebsocketDemo.Data.TrainData.GetList();
        mapUpdater.UpdateAction = UpdateMap;
        //Update the data:
        //this.StateHasChanged();
    }

    public async void UpdateMap(Juna juna, Juna currentJuna)
    {
        await InvokeAsync(() =>{
            lastJuna = (juna, currentJuna);
            StateHasChanged();
        });

    }
    public void StartTimer()
    {
        mapUpdater.StartTimer();
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591