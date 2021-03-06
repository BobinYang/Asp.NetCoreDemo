#pragma checksum "D:\repos\C#\Asp.NetCoreDemo\BlazorAppDemo\Components\DepartmentItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26c5af6359e36e2a97aadf9584deb8f801d32f54"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAppDemo.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\repos\C#\Asp.NetCoreDemo\BlazorAppDemo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\repos\C#\Asp.NetCoreDemo\BlazorAppDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\repos\C#\Asp.NetCoreDemo\BlazorAppDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\repos\C#\Asp.NetCoreDemo\BlazorAppDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\repos\C#\Asp.NetCoreDemo\BlazorAppDemo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\repos\C#\Asp.NetCoreDemo\BlazorAppDemo\_Imports.razor"
using BlazorAppDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\repos\C#\Asp.NetCoreDemo\BlazorAppDemo\_Imports.razor"
using BlazorAppDemo.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\repos\C#\Asp.NetCoreDemo\BlazorAppDemo\_Imports.razor"
using BlazorAppDemo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\repos\C#\Asp.NetCoreDemo\BlazorAppDemo\_Imports.razor"
using BlazorAppDemo.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\repos\C#\Asp.NetCoreDemo\BlazorAppDemo\Components\DepartmentItem.razor"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
    public partial class DepartmentItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "tr");
            __builder.AddMarkupContent(1, "\r\n");
#nullable restore
#line 5 "D:\repos\C#\Asp.NetCoreDemo\BlazorAppDemo\Components\DepartmentItem.razor"
     if (Department.EmployeeCount > options.Value.BoldDepartmentEmployeeCount)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "        ");
            __builder.OpenElement(3, "td");
            __builder.OpenElement(4, "strong");
            __builder.AddContent(5, 
#nullable restore
#line 7 "D:\repos\C#\Asp.NetCoreDemo\BlazorAppDemo\Components\DepartmentItem.razor"
                     Department.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 8 "D:\repos\C#\Asp.NetCoreDemo\BlazorAppDemo\Components\DepartmentItem.razor"
    }
    else 
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "        ");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 11 "D:\repos\C#\Asp.NetCoreDemo\BlazorAppDemo\Components\DepartmentItem.razor"
             Department.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 12 "D:\repos\C#\Asp.NetCoreDemo\BlazorAppDemo\Components\DepartmentItem.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "    ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 13 "D:\repos\C#\Asp.NetCoreDemo\BlazorAppDemo\Components\DepartmentItem.razor"
         Department.Location

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 14 "D:\repos\C#\Asp.NetCoreDemo\BlazorAppDemo\Components\DepartmentItem.razor"
         Department.EmployeeCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenElement(18, "td");
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "a");
            __builder.AddAttribute(21, "href", "/employee/" + (
#nullable restore
#line 16 "D:\repos\C#\Asp.NetCoreDemo\BlazorAppDemo\Components\DepartmentItem.razor"
                            Department.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(22, "\r\n            Employees\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "D:\repos\C#\Asp.NetCoreDemo\BlazorAppDemo\Components\DepartmentItem.razor"
       
    [Parameter]
    public Department Department { get; set; }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOptions<BlazorAppDemoOptions> options { get; set; }
    }
}
#pragma warning restore 1591
