#pragma checksum "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Reports/SummaryReport.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69fbde1093c1be791212490adeeaa348228fd667"
// <auto-generated/>
#pragma warning disable 1591
namespace InventoryFrontend.Pages.Reports
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/_Imports.razor"
using InventoryFrontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/_Imports.razor"
using InventoryFrontend.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/SummaryReport")]
    public partial class SummaryReport : SummaryReportBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Reports/SummaryReport.razor"
 if (!isDataReady)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<span>Loading ...</span>");
#nullable restore
#line 7 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Reports/SummaryReport.razor"
}
else
{



#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "pr-1 col-lg-3 pb-2");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card");
            __builder.AddAttribute(7, "style", "width: 18rem;");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card-body");
            __builder.AddMarkupContent(10, "<h5 class=\"card-title\">Products</h5>\r\n                    ");
            __builder.OpenElement(11, "h6");
            __builder.AddAttribute(12, "class", "card-subtitle mb-2 text-muted");
            __builder.AddContent(13, "Stock: ");
            __builder.AddContent(14, 
#nullable restore
#line 17 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Reports/SummaryReport.razor"
                                                                      product.Products

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n\r\n        ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "pr-1 col-lg-3 pb-2");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "card");
            __builder.AddAttribute(20, "style", "width: 18rem;");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "card-body");
            __builder.AddMarkupContent(23, "<h5 class=\"card-title\">Total In Stock</h5>\r\n                    ");
            __builder.OpenElement(24, "h6");
            __builder.AddAttribute(25, "class", "card-subtitle mb-2 text-muted");
            __builder.AddContent(26, "Stock: ");
            __builder.AddContent(27, 
#nullable restore
#line 27 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Reports/SummaryReport.razor"
                                                                      product.ProductsInStock

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\r\n        ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "pr-1 col-lg-3 pb-2");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "card");
            __builder.AddAttribute(33, "style", "width: 18rem;");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "card-body");
            __builder.AddMarkupContent(36, "<h5 class=\"card-title\">Total Sold</h5>\r\n                    ");
            __builder.OpenElement(37, "h6");
            __builder.AddAttribute(38, "class", "card-subtitle mb-2 text-muted");
            __builder.AddContent(39, "Stock: ");
            __builder.AddContent(40, 
#nullable restore
#line 36 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Reports/SummaryReport.razor"
                                                                      product.SoldItems

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 42 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Reports/SummaryReport.razor"


}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
