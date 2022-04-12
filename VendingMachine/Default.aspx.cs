using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VendingMachine.Classes;

namespace VendingMachine
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!Page.IsPostBack)
            {
                //update cost for items
                UpdateCost();
            }

        }

        protected void UpdateCost()
        {
            //get cost for each item
            Item item = new Item();

            A1Cost.Text = item.itemArray[0, 4];
            A2Cost.Text = item.itemArray[1, 4];
            A3Cost.Text = item.itemArray[2, 4];
            B1Cost.Text = item.itemArray[3, 4];
            B2Cost.Text = item.itemArray[4, 4];
            B3Cost.Text = item.itemArray[5, 4];
            C1Cost.Text = item.itemArray[6, 4];
            C2Cost.Text = item.itemArray[7, 4];
            C3Cost.Text = item.itemArray[8, 4];
        }

        protected void ItemButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string text = btn.Text.ToString();

            string creditVal = hidCredit.Value;

            Display display = new Display();
            string displayMsg = display.UpdateDisplay(text, creditVal);

            DisplayMessage.Text = displayMsg;

            //update button to take item
            if (displayMsg.ToLower().Contains("dispensing"))
            {
                UpdateCreditValue(creditVal, text);

                TakeItemButton.Visible = true;
                NickelButton.Enabled = false;
                DimeButton.Enabled = false;
                QuarterButton.Enabled = false;
            }
        }

        protected void UpdateCreditValue(string creditVal, string location)
        {
            Credit credit = new Credit();
            int newCreditVal = 0;
            int remainder = credit.GetRemainder(int.Parse(creditVal), location);

            if (remainder > 0)
                newCreditVal = remainder;

            hidCredit.Value = newCreditVal.ToString();
        }

        protected void CoinButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string coin = btn.Text.ToString();

            string creditVal = hidCredit.Value;
            Credit credit = new Credit();
            int newCredit = credit.UpdateCredit(coin, creditVal);

            hidCredit.Value = newCredit.ToString();

            Display display = new Display();
            DisplayMessage.Text = display.UpdateDisplay(newCredit);
        }

        protected void TakeItemButton_Click(object sender, EventArgs e)
        {
            //reset machine display

            if (TakeItemButton.Text.Contains("Take"))
            {
                if (hidCredit.Value == "0")
                {
                    TakeItemButton.Visible = false;

                    Display display = new Display();
                    string displayMsg = display.ResetDisplay();
                    DisplayMessage.Text = displayMsg;

                    NickelButton.Enabled = true;
                    DimeButton.Enabled = true;
                    QuarterButton.Enabled = true;
                }
                else
                {
                    TakeItemButton.Text = "Return Change";
                    int creditVal = int.Parse(hidCredit.Value);
                    Display display = new Display();
                    DisplayMessage.Text = display.UpdateDisplay(creditVal);
                }
            }
            else
            {
                TakeItemButton.Text = "Take Item";
                TakeItemButton.Visible = false;

                hidCredit.Value = "0";

                Display display = new Display();
                string displayMsg = display.ResetDisplay();
                DisplayMessage.Text = displayMsg;

                NickelButton.Enabled = true;
                DimeButton.Enabled = true;
                QuarterButton.Enabled = true;
            }

        }

    }
}