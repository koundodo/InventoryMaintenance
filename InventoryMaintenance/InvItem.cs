using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{ 
    //It demonstrates encapsulation by grouping data and methods of inventory item in one class
    public class InvItem
    {
        //This is the default constructor of InvItem that allows users not store no values
        public InvItem() { }

        //The constructor InvItem allows users to create an InvItem object that takes the three parameters below
        public InvItem(int itemNo, string description, decimal price) 
        {
            ItemNo = itemNo;
            Description = description;
            Price = price;
        } 
        public int ItemNo { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        //Dado Koundoul
        public string GetDisplayText()
        {
            string sep = " , ";
            return $"{ItemNo}{sep}{Description}{sep}{Price.ToString("c")}";
        }
     

    }
}
