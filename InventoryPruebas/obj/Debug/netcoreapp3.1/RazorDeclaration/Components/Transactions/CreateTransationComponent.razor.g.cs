#pragma checksum "C:\Users\CARLOS CASTAÑEDA\source\repos\InventoryPruebas\InventoryPruebas\Components\Transactions\CreateTransationComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e89febdfde8ccda3bc0bd4bcbf3333d68368fc7"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace InventoryPruebas.Components.Transactions
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
#line 1 "C:\Users\CARLOS CASTAÑEDA\source\repos\InventoryPruebas\InventoryPruebas\Components\Transactions\CreateTransationComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CARLOS CASTAÑEDA\source\repos\InventoryPruebas\InventoryPruebas\Components\Transactions\CreateTransationComponent.razor"
using Bussiness;

#line default
#line hidden
#nullable disable
    public partial class CreateTransationComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\CARLOS CASTAÑEDA\source\repos\InventoryPruebas\InventoryPruebas\Components\Transactions\CreateTransationComponent.razor"
 
    string message = "";
    string bootstrapClass = "";



    TransactionEntity oTransaction = new TransactionEntity();

    List<WareHouseEntity> warehouses = new List<WareHouseEntity>();
    List<StorageEntity> storages = new List<StorageEntity>();

    string buttonValue => oTransaction.IsInput ? "Registrar Entrada" : "Registrar Salida";

    ProductEntity oProduct = new ProductEntity();
    StorageEntity oStorage = new StorageEntity();

    int cantidadDisponible = 0;

    protected override async Task OnInitializedAsync()
    {
        warehouses = B_Warehouse.WareHouseList();
        //No se cargan los storages porque serán dinámicos de acuerdo a la bodega seleccionada

    }

    private void OnChangedWarehouse(ChangeEventArgs e)
    {
        //Obtener el ID la bodega seleccionada
        var WarehouseId = e.Value.ToString();
        //Consultar los productos relacionados a la bodega en los almacenamientos
        storages = B_Storage.StorageListInWarehouse(WarehouseId);
    }

    private void OnChangedProduct(ChangeEventArgs e)
    {
        oStorage = storages.LastOrDefault(s => s.StorageId == oTransaction.StorageId);
        oProduct = oStorage.Product;

        cantidadDisponible = oStorage.PartialQuantity;
    }

    private void SaveTransaction()
    {
        //Se debe consultar el producto y el storage para cambiar sus respectivas cantidades
        oStorage = storages.LastOrDefault(s => s.StorageId == oTransaction.StorageId);
        oProduct = oStorage.Product;

        oTransaction.TransactionId = Guid.NewGuid().ToString();
        oTransaction.TransactionDate = DateTime.Now;

        if (oTransaction.IsInput)
        {
            //Si es una entrada, se suma y ya está
            oStorage.PartialQuantity = oStorage.PartialQuantity + oTransaction.Quantity;
            B_Storage.UpdateStorage(oStorage);

            oProduct.TotalQuantity = oProduct.TotalQuantity + oTransaction.Quantity;
            B_Product.UpdateProduct(oProduct);

            B_Transaction.CreateTransaction(oTransaction);
            bootstrapClass = "alert-success";
            message = "Transacción creada con éxito";
            cantidadDisponible += oTransaction.Quantity;
        }
        else
        {
            //Si es una salida, restar (Se debe validar que si se tengan unidades suficientes)
            if(IsBiggerThanZero(oTransaction.Quantity, oStorage.PartialQuantity))
            {
                oStorage.PartialQuantity = oStorage.PartialQuantity - oTransaction.Quantity;
                B_Storage.UpdateStorage(oStorage);

                oProduct.TotalQuantity = oProduct.TotalQuantity - oTransaction.Quantity;
                B_Product.UpdateProduct(oProduct);


                B_Transaction.CreateTransaction(oTransaction);
                bootstrapClass = "alert-success";
                message = "Transacción creada con éxito";
                cantidadDisponible -= oTransaction.Quantity;
            } else
            {
                bootstrapClass = "alert-danger";
                message = "No existe la cantidad suficiente en bodega";
            }
        }
    }

    private bool IsBiggerThanZero(int Quantity, int storageQuantity)
    {
        if (storageQuantity >= Quantity)
        {
            return true;
        }

        return false;

    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591