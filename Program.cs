using System;
using System.Collections.Generic;

namespace Sales_Taxes
{
    class Program
    {
        static void Main(string[] args)
        {
            Shared_Functions.PrintStock(Shared_Functions.createdItems());
            Shared_Functions.GetShoppingList();
            Shared_Functions.Create_Cart(Shared_Functions.selectedItems);

        }


    }
}
