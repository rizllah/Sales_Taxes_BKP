namespace Sales_Taxes
{
    public class Sale_Item : Item {
        public int id {get; set;}
        
        public string type {get; set;}
        public double unit_price {get; set;}
        public string description {get; set;}
        public bool imported {get; set;}
        public int quantity {get; set;}
        public double sale_price {get; set;}
        
       
        public Sale_Item(int id, string type,double price,string description, bool imported,int quantity) 
        : base(id, type, price, description, imported) {
            this.id = id;
            this.type = type;
            this.unit_price = price; //check for rounding up
            this.description = description;
            this.imported = imported;
            this.quantity = quantity;
            sale_price = calculateSalePrice(unit_price, quantity);
        }

        public double calculateSalePrice(double itemPrice, int itemCount){
            return itemPrice * itemCount;
        }
    }

}