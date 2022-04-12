using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VendingMachine.Classes
{
    public class Display
    {
        //Default: Insert Coins. 
        //Total Credit when coins added
        //Out of Stock:  when quantity of item = 0
        //Dispensing Item: where Item is name of the item
        //Not Enough Money: when credit amount isn't enough to cover the cost of the item

        public string ResetDisplay()
        {
            return "Insert Coins";
        }

        public string UpdateDisplay(string item, string creditVal)
        {
            //update display after selection
            string displayText = string.Empty;

            //check credit to determine if enough money
            displayText = CheckCredit(item, creditVal);

            if (displayText == string.Empty)
            {
                //check quantity
                displayText = CheckQuantity(item);
            }

            return displayText;
        }

        public string UpdateDisplay(int creditVal)
        {
            //update display after selecting coin
            string displayText = "Total Credit: " + creditVal + " cents";

            return displayText;
        }

        public string CheckQuantity(string item)
        {
            string displayText = string.Empty;

            Quantity qty = new Quantity();
            if (qty.UpdateQuantity(item))
            {
                Name itemName = new Name();
                displayText = "Dispensing " + itemName.GetName(item);
            }
            else
                displayText = "Out of Stock";

            return displayText;
        }

        public string CheckCredit(string item, string creditVal)
        {
            string displayText = string.Empty;

            Credit credit = new Credit();
            int remainder = credit.EnoughCredit(int.Parse(creditVal), item);
            if (remainder < 0)
                displayText = "Not Enough Money";

            return displayText;
        }
    }
}