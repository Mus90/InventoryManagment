#pragma checksum "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Invoices/CreateInvoice.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1420e5205a7b976f0abaa7b4f17e4124f665b098"
// <auto-generated/>
#pragma warning disable 1591
namespace InventoryFrontend.Pages.Invoices
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/invoice/Create")]
    public partial class CreateInvoice : CreateInvoiceBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page-content container-fluid");
#nullable restore
#line 5 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Invoices/CreateInvoice.razor"
     if (!isDataReady)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p>-- Loading --</p>");
#nullable restore
#line 8 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Invoices/CreateInvoice.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Invoices/CreateInvoice.razor"
                          Currentitem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Invoices/CreateInvoice.razor"
                                                 HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "row");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "col-lg-8 p-1");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "card mb-3 h-100");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "card-body");
                __builder2.OpenElement(15, "h6");
                __builder2.AddAttribute(16, "class", "mb-3");
                __builder2.AddContent(17, "Total: ");
                __builder2.AddContent(18, 
#nullable restore
#line 16 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Invoices/CreateInvoice.razor"
                                                     totalSelectedItems

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(20);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n\r\n                            ");
                __builder2.OpenElement(22, "label");
                __builder2.AddAttribute(23, "class", "form-group has-float-label");
                __builder2.AddMarkupContent(24, "<span>Product</span>\r\n                                ");
                __Blazor.InventoryFrontend.Pages.Invoices.CreateInvoice.TypeInference.CreateInputSelect_0(__builder2, 25, 26, "form-control", 27, 
#nullable restore
#line 22 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Invoices/CreateInvoice.razor"
                                                                                     () => @Currentitem.ProductId

#line default
#line hidden
#nullable disable
                , 28, 
#nullable restore
#line 23 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Invoices/CreateInvoice.razor"
                                                     Currentitem.ProductId

#line default
#line hidden
#nullable disable
                , 29, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 24 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Invoices/CreateInvoice.razor"
                                                             async (int args) => { @Currentitem.ProductId = args; getTotalPrice(); }

#line default
#line hidden
#nullable disable
                ), 30, (__builder3) => {
                    __builder3.AddMarkupContent(31, "<option value>**Choose Product**</option>");
#nullable restore
#line 26 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Invoices/CreateInvoice.razor"
                                     foreach (var product in products)
                                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(32, "option");
                    __builder3.AddAttribute(33, "value", 
#nullable restore
#line 28 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Invoices/CreateInvoice.razor"
                                                        product.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(34, 
#nullable restore
#line 28 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Invoices/CreateInvoice.razor"
                                                                     product.ProductName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 29 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Invoices/CreateInvoice.razor"
                                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(35, "\r\n                                \r\n                                \r\n                                ");
                __builder2.OpenElement(36, "span");
                __builder2.AddAttribute(37, "class", "text-danger");
                __Blazor.InventoryFrontend.Pages.Invoices.CreateInvoice.TypeInference.CreateValidationMessage_1(__builder2, 38, 39, 
#nullable restore
#line 34 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Invoices/CreateInvoice.razor"
                                                              () => Currentitem.ProductId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n\r\n                            ");
                __builder2.OpenElement(41, "label");
                __builder2.AddAttribute(42, "class", "form-group has-float-label");
                __builder2.AddMarkupContent(43, "<span>Quantity</span>\r\n                                ");
                __builder2.OpenElement(44, "input");
                __builder2.AddAttribute(45, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 41 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Invoices/CreateInvoice.razor"
                                                    (e) => { Currentitem.Quantity = int.Parse(e.Value.ToString());getTotalPrice(); }

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                                \r\n                                ");
                __builder2.OpenElement(47, "span");
                __builder2.AddAttribute(48, "class", "text-danger");
                __Blazor.InventoryFrontend.Pages.Invoices.CreateInvoice.TypeInference.CreateValidationMessage_2(__builder2, 49, 50, 
#nullable restore
#line 44 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Invoices/CreateInvoice.razor"
                                                              () => Currentitem.Quantity

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 48 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Invoices/CreateInvoice.razor"
                             foreach(var item in items)
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "row");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "col-6");
                __builder2.AddContent(55, 
#nullable restore
#line 51 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Invoices/CreateInvoice.razor"
                                                        products.Find(x=>x.Id == @item.ProductId).ProductName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n                                    ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "col-6");
                __builder2.AddContent(59, 
#nullable restore
#line 52 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Invoices/CreateInvoice.razor"
                                                        item.Quantity

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 54 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Invoices/CreateInvoice.razor"
                            }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(60, "button");
                __builder2.AddAttribute(61, "type", "button");
                __builder2.AddAttribute(62, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Invoices/CreateInvoice.razor"
                                                              ()=>AddItemToCart()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "class", "btn btn-primary ml-2 ");
                __builder2.AddContent(64, "Add to cart");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n            ");
                __builder2.AddMarkupContent(66, "<div><button type=\"submit\" class=\"btn btn-primary mt-3 pl-5 pr-5 \">Submit</button></div>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 68 "/Users/mustafa/Desktop/Inventory/InventoryFrontend/Pages/Invoices/CreateInvoice.razor"


    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.InventoryFrontend.Pages.Invoices.CreateInvoice
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "ValueExpression", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
