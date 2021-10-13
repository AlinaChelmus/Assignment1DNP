// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Assignment1DNP.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\alina\RiderProjects\Assignment1DNP\Assignment1DNP\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alina\RiderProjects\Assignment1DNP\Assignment1DNP\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\alina\RiderProjects\Assignment1DNP\Assignment1DNP\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\alina\RiderProjects\Assignment1DNP\Assignment1DNP\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\alina\RiderProjects\Assignment1DNP\Assignment1DNP\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\alina\RiderProjects\Assignment1DNP\Assignment1DNP\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\alina\RiderProjects\Assignment1DNP\Assignment1DNP\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\alina\RiderProjects\Assignment1DNP\Assignment1DNP\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\alina\RiderProjects\Assignment1DNP\Assignment1DNP\_Imports.razor"
using Assignment1DNP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\alina\RiderProjects\Assignment1DNP\Assignment1DNP\_Imports.razor"
using Assignment1DNP.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alina\RiderProjects\Assignment1DNP\Assignment1DNP\Pages\AllAdult.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\alina\RiderProjects\Assignment1DNP\Assignment1DNP\Pages\AllAdult.razor"
using Assignment1DNP.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\alina\RiderProjects\Assignment1DNP\Assignment1DNP\Pages\AllAdult.razor"
using Assignment1DNP.Persistance;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AllAdult")]
    public partial class AllAdult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "C:\Users\alina\RiderProjects\Assignment1DNP\Assignment1DNP\Pages\AllAdult.razor"
       
    private IList<Adult> adults;
    private IList<Adult> adultsToShow;
    
    
    private void Filter(ChangeEventArgs changeEventArgs)
    {
        string filterByName = null;
        try
        {
            filterByName = changeEventArgs.Value?.ToString();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        if (filterByName != null && !filterByName.Equals(""))
        {
            adultsToShow =adults.Where(t => t.FirstName.Contains(filterByName)).ToList();
        }
        else
        {
            adultsToShow = adults;
        }
    }

    /*private void Filter(ChangeEventArgs changeEventArgs)
    {
        string filterByName = changeEventArgs.Value.ToString();
        if (filterByName != "")
        {
            adultToShow = adults.Where(t => t.FirstName.ToLower().StartsWith(filterByName.ToLower())
                                                || t.LastName.ToLower().StartsWith(filterByName.ToLower())).ToList();
        }
        else
        {
            adultToShow = adults;
        }
    }*/

    protected override async Task OnInitializedAsync()
    {
        adults = AdultData.getAdults();
        adultsToShow = adults;
    }
    private void RemoveAdult(int adultId)
    {
        Adult adultToRemove = adults.First(t => t.Id == adultId);
        //FileContext.RemoveAdult(adultId);
        adults.Remove(adultToRemove);
        adultsToShow.Remove(adultToRemove);
    }

    private void EditAdult(int Id)
    {
        NavigationManager.NavigateTo($"EditAdult/{Id}");
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultData AdultData { get; set; }
    }
}
#pragma warning restore 1591