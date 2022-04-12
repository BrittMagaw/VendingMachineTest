using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VendingMachine.Classes
{
    public class Credit
    {
        public int UpdateCredit(string coin, string credit)
        {
            //update credit
            int newCoin = ConvertCoin(coin);
            int newCredit = int.Parse(credit);

            return newCredit + newCoin;
        }

        public int EnoughCredit(int credit, string location)
        {
            //get cost 
            int remainder = GetRemainder(credit, location);

            return remainder;
        }

        public int ConvertCoin(string coin)
        {
            //change text to value
            if (coin.ToLower().Contains("nickel"))
                return 5;
            if (coin.ToLower().Contains("dime"))
                return 10;
            if (coin.ToLower().Contains("quarter"))
                return 25;

            return 0;
        }

        public int GetRemainder(int credit, string location)
        {
            //get cost 
            Cost itemCost = new Cost();
            string cost = itemCost.GetCost(location);
            int costVal = int.Parse(cost);

            //subtract cost from credit
            return credit - costVal;

        }
    }
}