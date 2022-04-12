using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VendingMachine.Classes
{
    public class Item
    {
        //set item information
        //9 items
        //Location, Name, Type, Quantity, Cost
        public string[,] itemArray = new string[9, 5] { {"A1", "Blue Gum", "Gum", "2", "20" },
            {"A2","Pink Gum","Gum","3","25"},
            {"A3","Green Gum","Gum","4","30"},
            {"B1","Plain Chips","Chips","2","45"},
            {"B2","BBQ Chips","Chips","0","50"},
            {"B3","Cheesy Chips","Chips","1","55"},
            {"C1","Chocolate Bar","CandyBar","4","75"},
            {"C2","Carmel Bar","CandyBar","2","85"},
            {"C3","Nutty Bar","CandyBar","3","95"} };

    }
}