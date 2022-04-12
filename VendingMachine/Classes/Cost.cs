using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VendingMachine.Classes
{
    public class Cost
    {

        public string GetCost(string Location)
        {
            //get cost for each item
            Item item = new Item();
            
            switch(Location)
            {
                case "A1":
                    return item.itemArray[0, 4];
                case "A2":
                    return item.itemArray[1, 4];
                case "A3":
                    return item.itemArray[2, 4];
                case "B1":
                    return item.itemArray[3, 4];
                case "B2":
                    return item.itemArray[4, 4];
                case "B3":
                    return item.itemArray[5, 4];
                case "C1":
                    return item.itemArray[6, 4];
                case "C2":
                    return item.itemArray[7, 4];
                case "C3":
                    return item.itemArray[8, 4];
                default:
                    break;
            }

            return string.Empty;
        }

    }
}