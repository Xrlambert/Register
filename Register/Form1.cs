using System;
using System.Media; // for SoundPlayer
using Register.Properties; // accessing embedded sound resources
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace CashRegisterApp
{
    public partial class Burger_Town_Cash_Register : Form
    {
        // item prices
        double burgerPrice = 2.49;
        double friesPrice = 1.89;
        double drinkPrice = 0.99;

        // sound effects
        SoundPlayer crisp = new SoundPlayer(Resources.crispSfx); // plays on button clicks
        SoundPlayer print = new SoundPlayer(Resources.printSfx); // plays during receipt printing

        // item quantities
        int numBurgers = 0, numFries = 0, numDrinks = 0;

        // money stuff
        double subtotal = 0, taxRate = 0.13, taxAmount = 0, total = 0;
        double tendered = 0, change = 0;

        
        // fills tendered box with total, plays sound
        private void button1_Click(object sender, EventArgs e)
        {
            crisp.Play();
            tenderedBox.Text = $"{total:F2}";
        }

        //Order number tracker, active text file to track over multiple instances
        string orderFile = "order.txt";
        int orderNumber = 1001; // default if file missing

        

        private void Burger_Town_Cash_Register_Load(object sender, EventArgs e)
        {
            if (File.Exists(orderFile))
            {
                string content = File.ReadAllText(orderFile);
                int.TryParse(content, out orderNumber);
                //add to order number total
                orderNumber++;
                File.WriteAllText(orderFile, orderNumber.ToString());
            }
        }


        // constructor
        public Burger_Town_Cash_Register()
        {
            InitializeComponent();
        }

        // calculates subtotal, tax, total
        private void CalculateTotal_Click(object sender, EventArgs e)
        {
            crisp.Play();
            try
            {
                // grab quantities from input boxes
                numBurgers = int.Parse(burgerBox.Text);
                numFries = int.Parse(friesBox.Text);
                numDrinks = int.Parse(drinksBox.Text);

                // math time
                subtotal = (numBurgers * burgerPrice) + (numFries * friesPrice) + (numDrinks * drinkPrice);
                taxAmount = subtotal * taxRate;
                total = subtotal + taxAmount;

                // buffer to avoid rounding issues
                double paddedTotal = Math.Round(total, 2) + 0.009;
                double displayTotal = Math.Floor(paddedTotal * 100) / 100.0;

                // show results
                subtotalOutput.Text = $"${subtotal:F2}";
                taxOutput.Text = $"${taxAmount:F2}";
                totalOutput.Text = $"${displayTotal:F2}";

                // store clean total for later use
                total = displayTotal;

                // enable next steps
                changeButton.Enabled = true;
                card.Enabled = true;
            }
            catch
            {
                // bad input warning
                MessageBox.Show("Please enter valid quantities.");
            }
        }

        // calculates change
        private void CalculateChange_Click(object sender, EventArgs e)
        {
            crisp.Play();
            try
            {
                // get tendered amount
                tendered = double.Parse(tenderedBox.Text);

                // check if it's enough, with flotaing point catch
                if (tendered + 0.001 < total)
                {
                    MessageBox.Show("Insufficient amount tendered.");
                    return;
                }

                // calculate change
                change = tendered - total;
                changeOutput.Text = $"${change:F2}";

                // enable receipt button
                receiptButton.Enabled = true;
            }
            catch
            {
                // bad input warning
                MessageBox.Show("Please enter a valid tendered amount.");
            }
        }

        // prints receipt line by line with sound
        private async void PrintReceipt_Click(object sender, EventArgs e)
        {
            //int check;
            receiptBox.Clear();
            //push

            // build receipt content
            string[] lines = {
                "Burger Town Receipt",
                $"Order #{orderNumber}",
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

            // print each line with delay and sound
            foreach (string line in lines)
            {
                receiptBox.AppendText(line + "\n");
                print.Play(); // plays sound with each line
                await System.Threading.Tasks.Task.Delay(570); // delay between lines
                //int check++;
            }
            
            //Pass to check if print finished to validate the order finished
            //if (int check <= )

        }

        // resets everything for a new order
        private void NewOrder_Click(object sender, EventArgs e)
        {
            //add to order number total
            orderNumber++;
            File.WriteAllText(orderFile, orderNumber.ToString());

            // clear inputs
            burgerBox.Text = friesBox.Text = drinksBox.Text = tenderedBox.Text = "";

            // clear outputs
            subtotalOutput.Text = taxOutput.Text = totalOutput.Text = changeOutput.Text = "";
            receiptBox.Clear();

            // reset values
            subtotal = taxAmount = total = tendered = change = 0;
            numBurgers = numFries = numDrinks = 0;

            // disable buttons until next calculation
            changeButton.Enabled = false;
            receiptButton.Enabled = false;
        }
    }
}
