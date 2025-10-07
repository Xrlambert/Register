using System;
using System.Windows.Forms;

namespace CashRegisterApp
{
    public partial class Burger_Town_Cash_Register : Form
    {
        // Prices
        double burgerPrice = 2.49;
        double friesPrice = 1.89;
        double drinkPrice = 0.99;

        // Quantities
        int numBurgers = 0, numFries = 0, numDrinks = 0;

        // Totals
        double subtotal = 0, taxRate = 0.13, taxAmount = 0, total = 0;
        double tendered = 0, change = 0;

        private void receiptBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Burger_Town_Cash_Register_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tenderedBox.Text = $"{total:F2}";
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        public Burger_Town_Cash_Register()
        {
            InitializeComponent();
        }

        private void CalculateTotal_Click(object sender, EventArgs e)
        {
            try
            {
                numBurgers = int.Parse(burgerBox.Text);
                numFries = int.Parse(friesBox.Text);
                numDrinks = int.Parse(drinksBox.Text);

                subtotal = (numBurgers * burgerPrice) + (numFries * friesPrice) + (numDrinks * drinkPrice);
                taxAmount = subtotal * taxRate;
                total = subtotal + taxAmount;

                // Add buffer and round down for display
                double paddedTotal = Math.Round(total, 2) + 0.009;
                double displayTotal = Math.Floor(paddedTotal * 100) / 100.0;

                subtotalOutput.Text = $"${subtotal:F2}";
                taxOutput.Text = $"${taxAmount:F2}";
                totalOutput.Text = $"${displayTotal:F2}";

                // Store displayTotal for later use
                total = displayTotal;

                changeButton.Enabled = true;
                card.Enabled = true;

            }
            catch
            {
                MessageBox.Show("Please enter valid quantities.");
            }
        }

        private void CalculateChange_Click(object sender, EventArgs e)
        {
            try
            {
                tendered = double.Parse(tenderedBox.Text);
                if (tendered + 0.001 < total)
                {
                    MessageBox.Show("Insufficient amount tendered.");
                    return;
                }

                change = tendered - total;
                changeOutput.Text = $"${change:F2}";

                receiptButton.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Please enter a valid tendered amount.");
            }
        }

        private async void PrintReceipt_Click(object sender, EventArgs e)
        {
            receiptBox.Clear();
            string[] lines = {
                "Burger Town Receipt",
                "----------------------------",
                $"Burgers x{numBurgers} @ ${burgerPrice:F2}",
                $"Fries x{numFries} @ ${friesPrice:F2}",
                $"Drinks x{numDrinks} @ ${drinkPrice:F2}",
                "----------------------------",
                $"Subtotal: ${subtotal:F2}",
                $"Tax: ${taxAmount:F2}",
                $"Total: ${total:F2}", // already using the padded display version
                "----------------------------",
                $"Tendered: ${tendered:F2}",
                $"Change: ${change:F2}",
                "Have a Nice Day!"
            };

            foreach (string line in lines)
            {
                receiptBox.AppendText(line + "\n");
                await System.Threading.Tasks.Task.Delay(240);
            }
        }

        private void NewOrder_Click(object sender, EventArgs e)
        {
            burgerBox.Text = friesBox.Text = drinksBox.Text = tenderedBox.Text = "";
            subtotalOutput.Text = taxOutput.Text = totalOutput.Text = changeOutput.Text = "";
            receiptBox.Clear();

            subtotal = taxAmount = total = tendered = change = 0;
            numBurgers = numFries = numDrinks = 0;

            changeButton.Enabled = false;
            receiptButton.Enabled = false;
        }
    }
}
