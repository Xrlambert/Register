using System;
using System.Drawing;
using System.Windows.Forms;

namespace CashRegisterApp
{
    partial class Burger_Town_Cash_Register
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Burger_Town_Cash_Register));
            this.titleLabel = new System.Windows.Forms.Label();
            this.burgerLabel = new System.Windows.Forms.Label();
            this.friesLabel = new System.Windows.Forms.Label();
            this.drinksLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.burgerBox = new System.Windows.Forms.TextBox();
            this.friesBox = new System.Windows.Forms.TextBox();
            this.drinksBox = new System.Windows.Forms.TextBox();
            this.tenderedBox = new System.Windows.Forms.TextBox();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.receiptButton = new System.Windows.Forms.Button();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.receiptBox = new System.Windows.Forms.RichTextBox();
            this.card = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(271, 23);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(291, 30);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Burger Town Cash Register";
            // 
            // burgerLabel
            // 
            this.burgerLabel.Location = new System.Drawing.Point(50, 80);
            this.burgerLabel.Name = "burgerLabel";
            this.burgerLabel.Size = new System.Drawing.Size(144, 23);
            this.burgerLabel.TabIndex = 1;
            this.burgerLabel.Text = "Number of Burgers:";
            // 
            // friesLabel
            // 
            this.friesLabel.Location = new System.Drawing.Point(50, 120);
            this.friesLabel.Name = "friesLabel";
            this.friesLabel.Size = new System.Drawing.Size(144, 23);
            this.friesLabel.TabIndex = 2;
            this.friesLabel.Text = "Number of Fries:";
            // 
            // drinksLabel
            // 
            this.drinksLabel.Location = new System.Drawing.Point(50, 160);
            this.drinksLabel.Name = "drinksLabel";
            this.drinksLabel.Size = new System.Drawing.Size(144, 23);
            this.drinksLabel.TabIndex = 3;
            this.drinksLabel.Text = "Number of Drinks:";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.Location = new System.Drawing.Point(50, 200);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(144, 23);
            this.tenderedLabel.TabIndex = 4;
            this.tenderedLabel.Text = "Amount Tendered:";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.Location = new System.Drawing.Point(50, 280);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(100, 23);
            this.subtotalLabel.TabIndex = 5;
            this.subtotalLabel.Text = "Subtotal:";
            // 
            // taxLabel
            // 
            this.taxLabel.Location = new System.Drawing.Point(50, 310);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(100, 23);
            this.taxLabel.TabIndex = 6;
            this.taxLabel.Text = "Tax:";
            // 
            // totalLabel
            // 
            this.totalLabel.Location = new System.Drawing.Point(50, 340);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(100, 23);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.Text = "Total:";
            // 
            // changeLabel
            // 
            this.changeLabel.Location = new System.Drawing.Point(50, 370);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(100, 23);
            this.changeLabel.TabIndex = 8;
            this.changeLabel.Text = "Change:";
            // 
            // burgerBox
            // 
            this.burgerBox.Location = new System.Drawing.Point(200, 80);
            this.burgerBox.Name = "burgerBox";
            this.burgerBox.Size = new System.Drawing.Size(100, 25);
            this.burgerBox.TabIndex = 9;
            // 
            // friesBox
            // 
            this.friesBox.Location = new System.Drawing.Point(200, 120);
            this.friesBox.Name = "friesBox";
            this.friesBox.Size = new System.Drawing.Size(100, 25);
            this.friesBox.TabIndex = 10;
            // 
            // drinksBox
            // 
            this.drinksBox.Location = new System.Drawing.Point(200, 160);
            this.drinksBox.Name = "drinksBox";
            this.drinksBox.Size = new System.Drawing.Size(100, 25);
            this.drinksBox.TabIndex = 11;
            // 
            // tenderedBox
            // 
            this.tenderedBox.Location = new System.Drawing.Point(200, 200);
            this.tenderedBox.Name = "tenderedBox";
            this.tenderedBox.Size = new System.Drawing.Size(100, 25);
            this.tenderedBox.TabIndex = 12;
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.Location = new System.Drawing.Point(200, 280);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(100, 23);
            this.subtotalOutput.TabIndex = 13;
            // 
            // taxOutput
            // 
            this.taxOutput.Location = new System.Drawing.Point(200, 310);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(100, 23);
            this.taxOutput.TabIndex = 14;
            // 
            // totalOutput
            // 
            this.totalOutput.Location = new System.Drawing.Point(200, 340);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(100, 23);
            this.totalOutput.TabIndex = 15;
            // 
            // changeOutput
            // 
            this.changeOutput.Location = new System.Drawing.Point(200, 370);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(100, 23);
            this.changeOutput.TabIndex = 16;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(50, 420);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(128, 28);
            this.calculateButton.TabIndex = 17;
            this.calculateButton.Text = "Calculate Total";
            this.calculateButton.Click += new System.EventHandler(this.CalculateTotal_Click);
            // 
            // changeButton
            // 
            this.changeButton.Enabled = false;
            this.changeButton.Location = new System.Drawing.Point(200, 420);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(128, 28);
            this.changeButton.TabIndex = 18;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.Click += new System.EventHandler(this.CalculateChange_Click);
            // 
            // receiptButton
            // 
            this.receiptButton.Enabled = false;
            this.receiptButton.Location = new System.Drawing.Point(350, 420);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(119, 28);
            this.receiptButton.TabIndex = 19;
            this.receiptButton.Text = "Print Receipt";
            this.receiptButton.Click += new System.EventHandler(this.PrintReceipt_Click);
            // 
            // newOrderButton
            // 
            this.newOrderButton.Location = new System.Drawing.Point(50, 470);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(75, 28);
            this.newOrderButton.TabIndex = 20;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.Click += new System.EventHandler(this.NewOrder_Click);
            // 
            // receiptBox
            // 
            this.receiptBox.Font = new System.Drawing.Font("Consolas", 10F);
            this.receiptBox.Location = new System.Drawing.Point(517, 79);
            this.receiptBox.Margin = new System.Windows.Forms.Padding(4);
            this.receiptBox.Name = "receiptBox";
            this.receiptBox.Size = new System.Drawing.Size(295, 450);
            this.receiptBox.TabIndex = 21;
            this.receiptBox.Text = "";
            this.receiptBox.TextChanged += new System.EventHandler(this.receiptBox_TextChanged);
            // 
            // card
            // 
            this.card.Enabled = false;
            this.card.Location = new System.Drawing.Point(318, 200);
            this.card.Name = "card";
            this.card.Size = new System.Drawing.Size(100, 25);
            this.card.TabIndex = 22;
            this.card.Text = "Credit/Debit";
            this.card.Click += new System.EventHandler(this.button1_Click);
            // 
            // Burger_Town_Cash_Register
            // 
            this.ClientSize = new System.Drawing.Size(846, 560);
            this.Controls.Add(this.card);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.burgerLabel);
            this.Controls.Add(this.friesLabel);
            this.Controls.Add(this.drinksLabel);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.burgerBox);
            this.Controls.Add(this.friesBox);
            this.Controls.Add(this.drinksBox);
            this.Controls.Add(this.tenderedBox);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.receiptBox);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Burger_Town_Cash_Register";
            this.Text = "Burger Town Cash Register";
            this.Load += new System.EventHandler(this.Burger_Town_Cash_Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void receiptBox_TextChanged(object sender, System.EventArgs e)
        {

        }

        // Controls
        private Label titleLabel, burgerLabel, friesLabel, drinksLabel, tenderedLabel;
        private Label subtotalLabel, taxLabel, totalLabel, changeLabel;
        private TextBox burgerBox, friesBox, drinksBox, tenderedBox;
        private Label subtotalOutput, taxOutput, totalOutput, changeOutput;
        private Button calculateButton, changeButton, receiptButton, newOrderButton;
        private RichTextBox receiptBox;
        private Button card;
    }
}