using System;
using System.Collections.Generic;

namespace Sales_Taxes
{
    public class Shared_Functions{
        public static List<string> selectedItems = new List<string>();
        public static List<Sale_Item> cart = new List<Sale_Item>();

        public static void PrintStock(Item[] StockList){
            System.Console.WriteLine("Items in stock");
            System.Console.WriteLine("-------------------------------");
            foreach(Item x in StockList){
                System.Console.WriteLine("{0}. {1}-------{2:0.00}", x.Id, x.Description, x.Price);
            }
        }
        public static Item[] createdItems(){
            Item Item1 = new Item(1,"Book", 12.49, "Book", false);
            Item Item2 = new Item(2,"Music", 14.99, "Music CD", false);
            Item Item3 = new Item(3,"Food", 0.85, "Chocolate bar", false);
            Item Item4 = new Item(4,"Food", 10.00, "Imported box of chocolates", true);
            Item Item5 = new Item(5,"Fashion", 47.50, "Imported bottle of perfume", true);
            Item Item6 = new Item(6,"Fashion", 18.99, "Bottle of perfume", false);
            Item Item7 = new Item(7,"Health", 9.75, "Paket of headache pills", false);
            Item[] stockList = new Item[]{Item1, Item2, Item3, Item4, Item5, Item6, Item7};
            return stockList;
        }

        public static void GetShoppingList(){
            System.Console.WriteLine ("Enter the number of the item to add to cart. Enter x to review cart");
            string userInput = System.Console.ReadLine();
            
            while (userInput != "x"){
                if (!userInput.Equals(string.Empty))  {
                    selectedItems.Add(userInput);
                    System.Console.WriteLine("Enter number corresponding to item");
                    userInput = System.Console.ReadLine();
                }
                else if (userInput.Equals("x"))
                break;
                else break;
            }
            System.Console.WriteLine(selectedItems.Count);
        }

        public static void Create_Cart(List<string> userSelections){
            Dictionary<int, int> itemCount = new Dictionary<int, int>();
            foreach(Item item in createdItems()){
                Sale_Item saleItem = new Sale_Item(item.Id, item.Type, item.Price, item.Description, item.Imported, 1);
                if (userSelections.Contains(item.Id.ToString())){
                    if (!cart.Contains(saleItem)){
                        cart.Add(saleItem);
                        itemCount.Add(item.Id, 1);
                    }
                    else{
                        itemCount[item.Id]++;
                    }
                }
            }
            foreach(Sale_Item item in cart){
                item.calculateSalePrice(item.Price, item.quantity);
                foreach(KeyValuePair<int,int> kvp in itemCount){
                    if (kvp.Key == item.Id){
                        System.Console.WriteLine("{0}  - {1} - {2}", kvp.Value, item.description, item.Price);
                    }    
                }
                
            }
            
        }


    }
}