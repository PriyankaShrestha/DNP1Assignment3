// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CLient.Pages
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
#line 3 "C:\Users\HP\RiderProjects\Assignment3\CLient\Pages\AddMember.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\RiderProjects\Assignment3\CLient\Pages\AddMember.razor"
using Client.Data.ChildrenService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\RiderProjects\Assignment3\CLient\Pages\AddMember.razor"
using Client.Data.AdultService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP\RiderProjects\Assignment3\CLient\Pages\AddMember.razor"
using Client.Data.FamilyService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\RiderProjects\Assignment3\CLient\Pages\AddMember.razor"
           [Authorize(Policy = "AdminRole")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddMember/{Address}")]
    public partial class AddMember : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "C:\Users\HP\RiderProjects\Assignment3\CLient\Pages\AddMember.razor"
       
    [Parameter] public string Address { get; set; }
    private Person newPerson = new();
    private string e;
    private Family family;

    protected override async Task OnInitializedAsync()
    {
        family = await FamilyFile.GetFamilyAsync(Address);
    }
    
    private void AddNewAdult()
    {
       AdultFile.AddAdultAsync((Adult)newPerson, Address);
        Console.WriteLine(newPerson);
    }
    
    private void AddNewChild()
    {
        ChildrenFile.AddChildAsync((Child)newPerson, Address);
    }

    private void AddSelected(ChangeEventArgs evt)
    {
        e = evt.Value.ToString();
        if (e.Equals("Child"))
        {
            newPerson = new Child();
        }
        else
        {
            newPerson = new Adult();
        }
    }

    private void Execute()
    {
        if(e.Equals("Child"))
        {
            AddNewChild();
        }
        else
        {
            AddNewAdult();
        }
        NavMgr.NavigateTo("/ViewFamily");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavMgr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyService FamilyFile { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultService AdultFile { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IChildrenService ChildrenFile { get; set; }
    }
}
#pragma warning restore 1591
