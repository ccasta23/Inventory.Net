#pragma checksum "C:\Users\CARLOS CASTAÑEDA\source\repos\InventoryPruebas\InventoryPruebas\Components\Categories\ListCategoriesComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be51f0cd6b7279954a051340d74bbc99c4c673aa"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace InventoryPruebas.Components.Categories
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
#line 1 "C:\Users\CARLOS CASTAÑEDA\source\repos\InventoryPruebas\InventoryPruebas\Components\Categories\ListCategoriesComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CARLOS CASTAÑEDA\source\repos\InventoryPruebas\InventoryPruebas\Components\Categories\ListCategoriesComponent.razor"
using Bussiness;

#line default
#line hidden
#nullable disable
    public partial class ListCategoriesComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\CARLOS CASTAÑEDA\source\repos\InventoryPruebas\InventoryPruebas\Components\Categories\ListCategoriesComponent.razor"
       

    List<CategoryEntity> categories = new List<CategoryEntity>();

    protected override async Task OnInitializedAsync()
    {
        categories = B_Category.CategoryList();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
