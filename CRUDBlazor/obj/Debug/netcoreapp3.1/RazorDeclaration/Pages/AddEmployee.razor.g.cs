#pragma checksum "C:\Users\chova\source\repos\CRUDBlazor\CRUDBlazor\Pages\AddEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbc54dc16fcddcdd498c35b63f3034912a2c800d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CRUDBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\chova\source\repos\CRUDBlazor\CRUDBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\chova\source\repos\CRUDBlazor\CRUDBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\chova\source\repos\CRUDBlazor\CRUDBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\chova\source\repos\CRUDBlazor\CRUDBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\chova\source\repos\CRUDBlazor\CRUDBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\chova\source\repos\CRUDBlazor\CRUDBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\chova\source\repos\CRUDBlazor\CRUDBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\chova\source\repos\CRUDBlazor\CRUDBlazor\_Imports.razor"
using CRUDBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\chova\source\repos\CRUDBlazor\CRUDBlazor\_Imports.razor"
using CRUDBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\chova\source\repos\CRUDBlazor\CRUDBlazor\Pages\AddEmployee.razor"
using CRUDBlazor.Database;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\chova\source\repos\CRUDBlazor\CRUDBlazor\Pages\AddEmployee.razor"
using CRUDBlazor.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\chova\source\repos\CRUDBlazor\CRUDBlazor\Pages\AddEmployee.razor"
using CRUDBlazor.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddEmployee")]
    public partial class AddEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\chova\source\repos\CRUDBlazor\CRUDBlazor\Pages\AddEmployee.razor"
       
    EmployeeInfo objEmp = new EmployeeInfo();

    protected void CreateEmployee()
    {
        objEmpServices.Create(objEmp);
        NavigationManager.NavigateTo("Employee");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("Employee");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EmployeeServices objEmpServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
