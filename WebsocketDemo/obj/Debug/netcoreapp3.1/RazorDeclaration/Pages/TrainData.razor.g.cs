#pragma checksum "C:\Users\Jiang Zhipeng\Desktop\GIS_Developments\Demo\WebsocketDemo\WebsocketDemo\Pages\TrainData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f5b814f4761f77d63adee0705d73637a26bf9a5"
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
#line 10 "C:\Users\Jiang Zhipeng\Desktop\GIS_Developments\Demo\WebsocketDemo\WebsocketDemo\_Imports.razor"
using WebsocketDemo.Data;

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/traindata")]
    public partial class TrainData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\Jiang Zhipeng\Desktop\GIS_Developments\Demo\WebsocketDemo\WebsocketDemo\Pages\TrainData.razor"
       
    List<Juna> train = new List<Juna>();

    protected override async Task OnInitializedAsync()
    {
        APIClient client = new APIClient();
        train = await client.GetJunaAsync();

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
