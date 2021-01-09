using System.Diagnostics;


namespace Sales_Taxes
{
    public class Item{
        public Item(int id, string type,double price,string description, bool imported){
            Id = id;
            Type = type;
            Price = price;
            Description = description;
            Imported = imported;
        }

        public int Id{get; set;}
        public string Type{get; set;}
        public double Price{get; set;}
        public string Description{get; set;}
        public bool Imported{get; set;}
    }


}
