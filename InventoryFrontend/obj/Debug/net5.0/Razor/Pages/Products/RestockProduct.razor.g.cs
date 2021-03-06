#pragma checksum "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Products/RestockProduct.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32a4ef672eb5928abe67f0a5ffc16f98afba3b50"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/product/Restock/{id}")]
    public partial class RestockProduct : RestockProductBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page-content container-fluid");
#nullable restore
#line 5 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Products/RestockProduct.razor"
     if (product == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p>-- Loading --</p>");
#nullable restore
#line 8 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Products/RestockProduct.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Products/RestockProduct.razor"
                          product

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Products/RestockProduct.razor"
                                             HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "row");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "col-lg-6 p-1");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "card mb-3 h-100");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "card-body");
                __builder2.AddMarkupContent(15, "<h6 class=\"mb-3\">Restock</h6>\r\n\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(16);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n\r\n                            \r\n\r\n                            ");
                __builder2.OpenElement(18, "label");
                __builder2.AddAttribute(19, "class", "form-group has-float-label");
                __builder2.OpenElement(20, "input");
                __builder2.AddAttribute(21, "hidden");
                __builder2.AddAttribute(22, "class", "form-control");
                __builder2.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Products/RestockProduct.razor"
                                                    product.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => product.Id = __value, product.Id));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n                                ");
                __builder2.OpenElement(26, "input");
                __builder2.AddAttribute(27, "class", "form-control");
                __builder2.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Products/RestockProduct.razor"
                                                    product.Quantity

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => product.Quantity = __value, product.Quantity));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                                ");
                __builder2.OpenElement(31, "span");
                __builder2.AddAttribute(32, "class", "text-danger");
                __Blazor.InventoryFrontend.Pages.Products.RestockProduct.TypeInference.CreateValidationMessage_0(__builder2, 33, 34, 
#nullable restore
#line 26 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Products/RestockProduct.razor"
                                                              () => product.Quantity

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n                                ");
                __builder2.AddMarkupContent(36, "<span>Quantity</span>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n            ");
                __builder2.AddMarkupContent(38, "<div><button type=\"submit\" class=\"btn btn-primary mt-3 pl-5 pr-5 \">Submit</button></div>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 44 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Products/RestockProduct.razor"


    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.InventoryFrontend.Pages.Products.RestockProduct
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
