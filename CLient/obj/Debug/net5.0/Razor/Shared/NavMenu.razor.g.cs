#pragma checksum "C:\Users\HP\RiderProjects\Assignment3\CLient\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bb3dd5c8f85f3dbab219e49b12b9551820b3c17"
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
#nullable restore
#line 1 "C:\Users\HP\RiderProjects\Assignment3\CLient\Shared\NavMenu.razor"
using Client.Authentication;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar navbar-expand-lg");
            __builder.AddAttribute(2, "b-2sn0673dqz");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href b-2sn0673dqz></a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\HP\RiderProjects\Assignment3\CLient\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-2sn0673dqz");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-2sn0673dqz></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", (
#nullable restore
#line 10 "C:\Users\HP\RiderProjects\Assignment3\CLient\Shared\NavMenu.razor"
                 NavMenuCssClass

#line default
#line hidden
#nullable disable
            ) + " mr-auto");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\HP\RiderProjects\Assignment3\CLient\Shared\NavMenu.razor"
                                                    ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-2sn0673dqz");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "nav nav-tabs");
            __builder.AddAttribute(16, "b-2sn0673dqz");
            __builder.AddMarkupContent(17, "<a class=\"nav-item nav-link\" href b-2sn0673dqz>Home</a>\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(18);
            __builder.AddAttribute(19, "Policy", "AdminRole");
            __builder.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(21, "<a class=\"nav-item nav-link\" href=\"NewFamily\" b-2sn0673dqz>Register Family </a>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.AddMarkupContent(23, "<a class=\"nav-item nav-link\" href=\"ViewFamily\" b-2sn0673dqz>View Family</a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.OpenElement(25, "span");
            __builder.AddAttribute(26, "class", "navbar-text");
            __builder.AddAttribute(27, "b-2sn0673dqz");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(28);
            __builder.AddAttribute(29, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(30, "a");
                __builder2.AddAttribute(31, "href", "");
                __builder2.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\HP\RiderProjects\Assignment3\CLient\Shared\NavMenu.razor"
                                     PerformLogin

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "b-2sn0673dqz");
                __builder2.AddMarkupContent(34, "\r\n                    Login\r\n                ");
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(35, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(36, "a");
                __builder2.AddAttribute(37, "href", "");
                __builder2.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\HP\RiderProjects\Assignment3\CLient\Shared\NavMenu.razor"
                                     PerformLogout

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "b-2sn0673dqz");
                __builder2.AddMarkupContent(40, "\r\n                    Logout\r\n                ");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\HP\RiderProjects\Assignment3\CLient\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

    private void PerformLogin()
    {
        NavMgr.NavigateTo("/Login");
    }

    private void PerformLogout()
    {
        try
        {
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).Logout();
            NavMgr.NavigateTo("/Login");
        }
        catch (Exception e)
        {
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavMgr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591