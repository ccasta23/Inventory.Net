#pragma checksum "C:\Users\CARLOS CASTAÑEDA\source\repos\InventoryPruebas\InventoryPruebas\Components\Products\ListProductsComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f19843d559cad8e60d645f0968e93aeb41a85ab"
// <auto-generated/>
#pragma warning disable 1591
namespace InventoryPruebas.Components.Products
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\CARLOS CASTAÑEDA\source\repos\InventoryPruebas\InventoryPruebas\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CARLOS CASTAÑEDA\source\repos\InventoryPruebas\InventoryPruebas\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\CARLOS CASTAÑEDA\source\repos\InventoryPruebas\InventoryPruebas\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\CARLOS CASTAÑEDA\source\repos\InventoryPruebas\InventoryPruebas\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\CARLOS CASTAÑEDA\source\repos\InventoryPruebas\InventoryPruebas\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\CARLOS CASTAÑEDA\source\repos\InventoryPruebas\InventoryPruebas\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\CARLOS CASTAÑEDA\source\repos\InventoryPruebas\InventoryPruebas\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\CARLOS CASTAÑEDA\source\repos\InventoryPruebas\InventoryPruebas\_Imports.razor"
using InventoryPruebas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\CARLOS CASTAÑEDA\source\repos\InventoryPruebas\InventoryPruebas\_Imports.razor"
using InventoryPruebas.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\CARLOS CASTAÑEDA\source\repos\InventoryPruebas\InventoryPruebas\_Imports.razor"
using InventoryPruebas.Components.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\CARLOS CASTAÑEDA\source\repos\InventoryPruebas\InventoryPruebas\_Imports.razor"
using InventoryPruebas.Components.Categories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\CARLOS CASTAÑEDA\source\repos\InventoryPruebas\InventoryPruebas\_Imports.razor"
using InventoryPruebas.Components.WareHouses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\CARLOS CASTAÑEDA\source\repos\InventoryPruebas\InventoryPruebas\_Imports.razor"
using InventoryPruebas.Components.Storages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\CARLOS CASTAÑEDA\source\repos\InventoryPruebas\InventoryPruebas\_Imports.razor"
using InventoryPruebas.Components.Transactions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\CARLOS CASTAÑEDA\source\repos\InventoryPruebas\InventoryPruebas\Components\Products\ListProductsComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CARLOS CASTAÑEDA\source\repos\InventoryPruebas\InventoryPruebas\Components\Products\ListProductsComponent.razor"
using Bussiness;

#line default
#line hidden
#nullable disable
    public partial class ListProductsComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<hr>\r\n");
            __builder.AddMarkupContent(1, "<a href=\"products/create\">Crear Producto</a>\r\n<hr>\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "form-group");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.AddMarkupContent(5, "<label>Filtrar por Categoria:</label>\r\n    ");
            __builder.OpenElement(6, "select");
            __builder.AddAttribute(7, "class", "form-control");
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\CARLOS CASTAÑEDA\source\repos\InventoryPruebas\InventoryPruebas\Components\Products\ListProductsComponent.razor"
                                            CategoryChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "option");
            __builder.AddAttribute(11, "value", "all");
            __builder.AddContent(12, "Todas las categorias");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 11 "C:\Users\CARLOS CASTAÑEDA\source\repos\InventoryPruebas\InventoryPruebas\Components\Products\ListProductsComponent.razor"
         foreach (var category in categories)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "            ");
            __builder.OpenElement(15, "option");
            __builder.AddAttribute(16, "value", 
#nullable restore
#line 13 "C:\Users\CARLOS CASTAÑEDA\source\repos\InventoryPruebas\InventoryPruebas\Components\Products\ListProductsComponent.razor"
                            category.CategoryId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(17, 
#nullable restore
#line 13 "C:\Users\CARLOS CASTAÑEDA\source\repos\InventoryPruebas\InventoryPruebas\Components\Products\ListProductsComponent.razor"
                                                  category.CategoryName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 14 "C:\Users\CARLOS CASTAÑEDA\source\repos\InventoryPruebas\InventoryPruebas\Components\Products\ListProductsComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n");
            __builder.OpenElement(22, "table");
            __builder.AddAttribute(23, "class", "table table-striped table-bordered");
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.AddMarkupContent(25, @"<thead>
        <tr>
            <th scope=""col"">ID</th>
            <th scope=""col"">Nombre Producto</th>
            <th scope=""col"">Cantidad</th>
            <th scope=""col"">Categoria</th>
            <th scope=""col"">Editar</th>
        </tr>
    </thead>
    ");
            __builder.OpenElement(26, "tbody");
            __builder.AddMarkupContent(27, "\r\n");
#nullable restore
#line 29 "C:\Users\CARLOS CASTAÑEDA\source\repos\InventoryPruebas\InventoryPruebas\Components\Products\ListProductsComponent.razor"
         foreach (var product in filteredProducts)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(28, "        ");
            __builder.OpenElement(29, "tr");
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "th");
            __builder.AddAttribute(32, "scope", "row");
            __builder.AddContent(33, 
#nullable restore
#line 32 "C:\Users\CARLOS CASTAÑEDA\source\repos\InventoryPruebas\InventoryPruebas\Components\Products\ListProductsComponent.razor"
                             product.ProductId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 33 "C:\Users\CARLOS CASTAÑEDA\source\repos\InventoryPruebas\InventoryPruebas\Components\Products\ListProductsComponent.razor"
                 product.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 34 "C:\Users\CARLOS CASTAÑEDA\source\repos\InventoryPruebas\InventoryPruebas\Components\Products\ListProductsComponent.razor"
                 product.TotalQuantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, 
#nullable restore
#line 35 "C:\Users\CARLOS CASTAÑEDA\source\repos\InventoryPruebas\InventoryPruebas\Components\Products\ListProductsComponent.razor"
                 product.CategoryId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.OpenElement(44, "td");
            __builder.OpenElement(45, "a");
            __builder.AddAttribute(46, "href", "products/update/" + (
#nullable restore
#line 36 "C:\Users\CARLOS CASTAÑEDA\source\repos\InventoryPruebas\InventoryPruebas\Components\Products\ListProductsComponent.razor"
                                          product.ProductId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "class", "btn btn-success");
            __builder.AddContent(48, "Editar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
#nullable restore
#line 38 "C:\Users\CARLOS CASTAÑEDA\source\repos\InventoryPruebas\InventoryPruebas\Components\Products\ListProductsComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(51, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\CARLOS CASTAÑEDA\source\repos\InventoryPruebas\InventoryPruebas\Components\Products\ListProductsComponent.razor"
       

    List<ProductEntity> products = new List<ProductEntity>();
    List<ProductEntity> filteredProducts = new List<ProductEntity>();
    List<CategoryEntity> categories = new List<CategoryEntity>();

    protected override async Task OnInitializedAsync()
    {
        products = B_Product.ProductList();
        filteredProducts = products;
        categories = B_Category.CategoryList();
    }

    private void CategoryChanged(ChangeEventArgs e)
    {
        Console.WriteLine(e.Value.ToString());
        if (e.Value.ToString() == "all")
        {
            filteredProducts = products;
        } else
        {
            filteredProducts = products.Where(c => c.CategoryId == e.Value.ToString()).ToList();
        }

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
