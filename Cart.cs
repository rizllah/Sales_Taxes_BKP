using System.Collections.Generic;
using System.Diagnostics;


namespace Sales_Taxes
{
    public class Cart {
        public List<Sale_Item> sales {get;set;}
        public double total{get; set;}
        public double salesTax{get; set;}
        public double importTax{get; set;}

        public Cart(List<Sale_Item> sales) 
        {
            this.total = calculateTotal();
            this.salesTax = calculateSalesTax();
            this.importTax = calculateImportTax(); //optional
        }

        public double calculateTotal(){
            double totalSales = 0;
            foreach(Sale_Item sold in sales){
                 totalSales = sold.sale_price ++;
            }
            return totalSales;
        }

        public double calculateSalesTax(){
            List<string> taxableTypes = new List<string>(){"Book", "Food", "Health"};
            double tax=0;
            foreach(Sale_Item sold in sales){
                if(!taxableTypes.Contains(sold.description)){
                    tax = 0.1 * sold.sale_price;
                }
                else{
                    tax = 0.05 * sold.sale_price;
                }
            }
            return tax;
        }

        public double calculateImportTax(){
            double tax=0;
            foreach(Sale_Item sold in sales){
                if(sold.imported){
                    tax = 0.05 * sold.sale_price;
                }
                else{
                    tax = 0.01 * sold.sale_price;
                }
            }
            return tax;
        }


    }


}
