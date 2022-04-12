using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VendingMachine.Classes
{
    public class Quantity
    {
        public bool UpdateQuantity(string selectedItem)
        {
            //update quantity on item dispensed
            Item item = new Item();

            int newQty = 0;

            switch (selectedItem)
            {
                case "A1":
                    newQty = int.Parse(item.itemArray[0, 3]);
                    if (newQty > 0)
                    {
                        newQty = --newQty;
                        item.itemArray[0, 3] = newQty.ToString();
                        return true;
                    }
                    else return false;
                case "A2":

                    newQty = int.Parse(item.itemArray[1, 3]);
                    if (newQty > 0)
                    {
                        newQty = --newQty;
                        item.itemArray[1, 3] = newQty.ToString();
                        return true;
                    }
                    else return false;
                case "A3":
                    newQty = int.Parse(item.itemArray[2, 3]);
                    if (newQty > 0)
                    {
                        newQty = --newQty;
                        item.itemArray[2, 3] = newQty.ToString();
                        return true;
                    }
                    else return false;
                case "B1":
                    newQty = int.Parse(item.itemArray[3, 3]);
                    if (newQty > 0)
                    {
                        newQty = --newQty;
                        item.itemArray[3, 3] = newQty.ToString();
                        return true;
                    }
                    else return false;
                case "B2":
                    newQty = int.Parse(item.itemArray[4, 3]);
                    if (newQty > 0)
                    {
                        newQty = --newQty;
                        item.itemArray[4, 3] = newQty.ToString();
                        return true;
                    }
                    else return false;
                case "B3":
                    newQty = int.Parse(item.itemArray[5, 3]);
                    if (newQty > 0)
                    {
                        newQty = --newQty;
                        item.itemArray[5, 3] = newQty.ToString();
                        return true;
                    }
                    else return false;
                case "C1":
                    newQty = int.Parse(item.itemArray[6, 3]);
                    if (newQty > 0)
                    {
                        newQty = --newQty;
                        item.itemArray[6, 3] = newQty.ToString();
                        return true;
                    }
                    else return false;
                case "C2":
                    newQty = int.Parse(item.itemArray[7, 3]);
                    if (newQty > 0)
                    {
                        newQty = --newQty;
                        item.itemArray[7, 3] = newQty.ToString();
                        return true;
                    }
                    else return false;
                case "C3":
                    newQty = int.Parse(item.itemArray[8, 3]);
                    if (newQty > 0)
                    {
                        newQty = --newQty;
                        item.itemArray[8, 3] = newQty.ToString();
                        return true;
                    }
                    else return false;
                default:
                    return false;
            }

        }
    }

}