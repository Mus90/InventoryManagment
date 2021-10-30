#pragma checksum "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Products/ProductsList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "136f7b0c02704bcd08c31461a4d81e36261f754e"
// <auto-generated/>
#pragma warning disable 1591
namespace InventoryFrontend.Pages.Products
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/ProductsList")]
    public partial class ProductsList : ProductsListBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Products/ProductsList.razor"
 if (!isDataReady)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<span>Loading ...</span>");
#nullable restore
#line 7 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Products/ProductsList.razor"
}
else
{



#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "type", "button");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Products/ProductsList.razor"
                                      () => navManager.NavigateTo("/product/Create")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "class", "btn btn-primary mb-2");
            __builder.AddContent(5, "Create New");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
#nullable restore
#line 14 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Products/ProductsList.razor"
         foreach (var mList in products)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "pr-1 col-lg-3 pb-2");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card");
            __builder.AddAttribute(13, "style", "width: 18rem;");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "card-body");
            __builder.OpenElement(16, "h5");
            __builder.AddAttribute(17, "class", "card-title");
            __builder.AddContent(18, 
#nullable restore
#line 19 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Products/ProductsList.razor"
                                                mList.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.OpenElement(20, "h6");
            __builder.AddAttribute(21, "class", "card-subtitle mb-2 text-muted");
            __builder.AddContent(22, "Stock: ");
            __builder.AddContent(23, 
#nullable restore
#line 20 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Products/ProductsList.razor"
                                                                          mList.UnitsInStock

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.OpenElement(25, "h6");
            __builder.AddAttribute(26, "class", "card-subtitle mb-2 text-muted");
            __builder.AddContent(27, "Price: ");
            __builder.AddContent(28, 
#nullable restore
#line 21 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Products/ProductsList.razor"
                                                                          mList.SellingPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.OpenElement(30, "a");
            __builder.AddAttribute(31, "class", "card-link");
            __builder.AddAttribute(32, "style", "cursor:pointer");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Products/ProductsList.razor"
                                                                                () => navManager.NavigateTo($"/product/Update/{@mList.Id}")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(34, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                        ");
            __builder.OpenElement(36, "a");
            __builder.AddAttribute(37, "class", "card-link");
            __builder.AddAttribute(38, "style", "cursor:pointer");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Products/ProductsList.razor"
                                                                                () => navManager.NavigateTo($"/product/Restock/{@mList.Id}")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(40, "Restock");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                        ");
            __builder.OpenElement(42, "a");
            __builder.AddAttribute(43, "class", "card-link text-danger");
            __builder.AddAttribute(44, "style", "cursor:pointer");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Products/ProductsList.razor"
                                                                                            () => DeleteProduct(@mList.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(46, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 29 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Products/ProductsList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 31 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Products/ProductsList.razor"


}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591