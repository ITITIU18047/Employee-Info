#pragma checksum "C:\Users\chova\source\repos\CRUDBlazor\CRUDBlazor\Pages\DeleteEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d9adf51b3691934baafe6c508b20157985cea85"
// <auto-generated/>
#pragma warning disable 1591
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
#line 3 "C:\Users\chova\source\repos\CRUDBlazor\CRUDBlazor\Pages\DeleteEmployee.razor"
using CRUDBlazor.Database;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\chova\source\repos\CRUDBlazor\CRUDBlazor\Pages\DeleteEmployee.razor"
using CRUDBlazor.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\chova\source\repos\CRUDBlazor\CRUDBlazor\Pages\DeleteEmployee.razor"
using CRUDBlazor.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/DeleteEmployee/{CurrentID}")]
    public partial class DeleteEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Delete Employee</h2>\r\n<hr>\r\n");
            __builder.AddMarkupContent(1, "<h3>R u sure want to Delete Employee ?</h3>\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-md-8");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "form-group");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.AddMarkupContent(11, "<label>Employee ID:</label>\r\n            ");
            __builder.OpenElement(12, "label");
            __builder.AddContent(13, 
#nullable restore
#line 15 "C:\Users\chova\source\repos\CRUDBlazor\CRUDBlazor\Pages\DeleteEmployee.razor"
                    objEmp.EmployeeID

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(14, ":");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "form-group");
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.AddMarkupContent(20, "<label>Employee Name:</label>\r\n            ");
            __builder.OpenElement(21, "label");
            __builder.AddContent(22, 
#nullable restore
#line 19 "C:\Users\chova\source\repos\CRUDBlazor\CRUDBlazor\Pages\DeleteEmployee.razor"
                    objEmp.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(23, ":");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "form-group");
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.AddMarkupContent(29, "<label>Employee Gender:</label>\r\n            ");
            __builder.OpenElement(30, "label");
            __builder.AddContent(31, 
#nullable restore
#line 23 "C:\Users\chova\source\repos\CRUDBlazor\CRUDBlazor\Pages\DeleteEmployee.razor"
                    objEmp.Gender

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(32, ":");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "form-group");
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.AddMarkupContent(38, "<label>Employee Country:</label>\r\n            ");
            __builder.OpenElement(39, "label");
            __builder.AddContent(40, 
#nullable restore
#line 27 "C:\Users\chova\source\repos\CRUDBlazor\CRUDBlazor\Pages\DeleteEmployee.razor"
                    objEmp.Country

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(41, ":");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "form-group");
            __builder.AddMarkupContent(46, "\r\n            ");
            __builder.AddMarkupContent(47, "<label>Employee City:</label>\r\n            ");
            __builder.OpenElement(48, "label");
            __builder.AddContent(49, 
#nullable restore
#line 31 "C:\Users\chova\source\repos\CRUDBlazor\CRUDBlazor\Pages\DeleteEmployee.razor"
                    objEmp.City

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(50, ":");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "row");
            __builder.AddMarkupContent(57, "\r\n    ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", " cold-md-4");
            __builder.AddMarkupContent(60, "\r\n        ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "form-group");
            __builder.AddMarkupContent(63, "\r\n            ");
            __builder.OpenElement(64, "input");
            __builder.AddAttribute(65, "type", "button");
            __builder.AddAttribute(66, "class", "btn btn-danger");
            __builder.AddAttribute(67, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\chova\source\repos\CRUDBlazor\CRUDBlazor\Pages\DeleteEmployee.razor"
                                                                   DeleteEmployees

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "value", "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n            ");
            __builder.OpenElement(70, "input");
            __builder.AddAttribute(71, "type", "button");
            __builder.AddAttribute(72, "class", "btn btn-primary");
            __builder.AddAttribute(73, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\chova\source\repos\CRUDBlazor\CRUDBlazor\Pages\DeleteEmployee.razor"
                                                                    Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(74, "value", "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\chova\source\repos\CRUDBlazor\CRUDBlazor\Pages\DeleteEmployee.razor"
       
    [Parameter]
    public string CurrentID { get; set; }

    EmployeeInfo objEmp = new EmployeeInfo();



    protected override async Task OnInitializedAsync()
    {
        objEmp = await Task.Run(() => objEmpServices.GetEmployeeByID(Convert.ToInt32(CurrentID)));
    }

    protected void DeleteEmployees()
    {
        objEmpServices.Delete(objEmp);
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
