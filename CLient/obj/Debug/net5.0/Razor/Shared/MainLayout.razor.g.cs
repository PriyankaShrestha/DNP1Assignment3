#pragma checksum "C:\Users\HP\RiderProjects\Assignment3\CLient\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54500bbf024d60af0ee00ca156e65d78fc86e94f"
// <auto-generated/>
#pragma warning disable 1591
namespace CLient.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\HP\RiderProjects\Assignment3\CLient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\RiderProjects\Assignment3\CLient\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\RiderProjects\Assignment3\CLient\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\RiderProjects\Assignment3\CLient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\RiderProjects\Assignment3\CLient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP\RiderProjects\Assignment3\CLient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HP\RiderProjects\Assignment3\CLient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HP\RiderProjects\Assignment3\CLient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\HP\RiderProjects\Assignment3\CLient\_Imports.razor"
using CLient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\HP\RiderProjects\Assignment3\CLient\_Imports.razor"
using CLient.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.AddAttribute(2, "b-8rg1gvkt2i");
            __builder.OpenComponent<CLient.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "content px-4");
            __builder.AddAttribute(7, "b-8rg1gvkt2i");
            __builder.AddContent(8, 
#nullable restore
#line 7 "C:\Users\HP\RiderProjects\Assignment3\CLient\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\HP\RiderProjects\Assignment3\CLient\Shared\MainLayout.razor"
      

    [CascadingParameter] protected Task<AuthenticationState> AuthStat { get; set; }

    protected async override Task OnInitializedAsync()
    {
        base.OnInitialized();
        var user = (await AuthStat).User;
        if (!user.Identity.IsAuthenticated)
        {
            NavMgr.NavigateTo($"/Login");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavMgr { get; set; }
    }
}
#pragma warning restore 1591
