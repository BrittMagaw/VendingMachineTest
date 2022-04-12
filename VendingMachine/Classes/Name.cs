using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VendingMachine.Classes
{
    public class Name
    {

        public string GetName(string Location)
        {
            //get cost for each item
            Item item = new Item();
            
            switch(Location)
            {
                case "A1":
                    return item.itemArray[0, 1];
                case "A2":
                    return item.itemArray[1, 1];
                case "A3":
                    return item.itemArray[2, 1];
                case "B1":
                    return item.itemArray[3, 1];
                case "B2":
                    return item.itemArray[4, 1];
                case "B3":
                    return item.itemArray[5, 1];
                case "C1":
                    return item.itemArray[6, 1];
                case "C2":
                    return item.itemArray[7, 1];
                case "C3":
                    return item.itemArray[8, 1];
                default:
                    break;
            }

            return string.Empty;
        }

    }
}