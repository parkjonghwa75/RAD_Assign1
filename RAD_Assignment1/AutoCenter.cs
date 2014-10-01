using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAD_Assignment1
{
    public partial class AutoCenter : Form
    {
        //Radio Button handling
        private RadioButton selectedRadioButton = null;

        //Module level contants (Prices of items)
        const decimal STEREO_SYSTEM_Decimal = 425.76m;
        const decimal LEATHER_INTERIOR_Decimal = 987.41m;
        const decimal COMPUTER_NAVIGATION_Decimal = 1741.23m;
        const decimal STANDARD_Decimal = 0m;
        const decimal PEARLIZED_Decimal = 345.72m;
        const decimal CUSTOMIZED_DETAILING_Decimal = 599.99m;
        const decimal TAX_RATE_Decimal = 0.15m;
        const decimal ACCESSORIES_FINISH_INITIAL_Decimal = 0m;
        const decimal TRADEIN_INITIAL_decimal = 0m;

        public AutoCenter()
        {
            InitializeComponent();
        }

        private void AutoCenter_Load(object sender, EventArgs e)
        {
            //Initial settings when the form loads.
            standardRadio.Checked = true;
            accessoriesFinishTextBox.Text = ACCESSORIES_FINISH_INITIAL_Decimal.ToString("c");
            tradeinAllowanceTextBox.Text = TRADEIN_INITIAL_decimal.ToString("c");

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            carSalesPriceTextBox.Clear();
            tradeinAllowanceTextBox.Clear();
            accessoriesFinishTextBox.Clear();
            subTotalTextBox.Clear();
            salesTaxTextBox.Clear();
            totalTextBox.Clear();
            amountDueTextBox.Clear();
            stereoCheckBox.Checked = false;
            leatherCheckBox.Checked = false;
            navigationCheckBox.Checked = false;
            standardRadio.Checked = true;
        }

        private void Radio_CheckedChanged(object sender, EventArgs e)
        {
            //set the selectedRadioButton to the coffee radio button
            decimal exteriorPriceDecimal;
            selectedRadioButton = (RadioButton)sender;
            switch (selectedRadioButton.Name)
            {
                case "pearlizedRadio":
                    exteriorPriceDecimal = PEARLIZED_Decimal;
                    break;
                case "detailingRadio":
                    exteriorPriceDecimal = CUSTOMIZED_DETAILING_Decimal;
                    break;
                default:
                    exteriorPriceDecimal = STANDARD_Decimal;
                    break;
            }
            accessoriesFinishTextBox.Text = exteriorPriceDecimal.ToString("c");
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Calculate Amount due and related price information
          
            decimal exteriorPriceDecimal, taxDecimal, tradeInDecimal, totalBeforeTradeDecimal, totalAfterTradeDecimal, finalPriceDecimal, basePriceDecimal;

            //check if quantity provided is a whole number
            try
            {
                basePriceDecimal = decimal.Parse(carSalesPriceTextBox.Text);
                if (basePriceDecimal > 0)
                {

                    try
                    {
                        if (tradeinAllowanceTextBox.Text == "$0.00" || tradeinAllowanceTextBox.Text==String.Empty)
                        {
                            tradeInDecimal = TRADEIN_INITIAL_decimal;
                        }
                        else
                        {
                            tradeInDecimal = decimal.Parse(tradeinAllowanceTextBox.Text);
                        }
                        


                        if (tradeInDecimal >= 0)
                        {
                            //CHECK WHICH EXTERIOR FINISH SELECTED...
                            switch (selectedRadioButton.Name)
                            {
                                case "pearlizedRadio":
                                    exteriorPriceDecimal = PEARLIZED_Decimal;
                                    break;
                                case "detailingRadio":
                                    exteriorPriceDecimal = CUSTOMIZED_DETAILING_Decimal;
                                    break;
                                default:
                                    exteriorPriceDecimal = STANDARD_Decimal;
                                    break;
                            }
                            accessoriesFinishTextBox.Text = exteriorPriceDecimal.ToString("c");

                            basePriceDecimal += exteriorPriceDecimal;

                            //ADD ACCESSORIES PRICE
                            if (stereoCheckBox.Checked)
                            {
                                basePriceDecimal += STEREO_SYSTEM_Decimal;
                            }

                            if (leatherCheckBox.Checked)
                            {
                                basePriceDecimal += LEATHER_INTERIOR_Decimal;
                            }

                            if (navigationCheckBox.Checked)
                            {
                                basePriceDecimal += COMPUTER_NAVIGATION_Decimal;
                            }

                            // DISPLAYING SUB TOTAL (BASE PRICE + ACCESSORIES + EXTERIOR)
                            subTotalTextBox.Text = basePriceDecimal.ToString("c");

                            // CALCULATING TAX AND DISPLAY. 
                            taxDecimal = basePriceDecimal * TAX_RATE_Decimal;
                            salesTaxTextBox.Text = taxDecimal.ToString("c");

                            // CALCULATING TOTAL AND DISPLAY (BEFORE TRADE-IN)
                            totalBeforeTradeDecimal = basePriceDecimal + taxDecimal;
                            totalTextBox.Text = totalBeforeTradeDecimal.ToString("c");

                            // THE FINAL AMOUNT DUE CALCUATION AND DISPLAY
                            totalAfterTradeDecimal = totalBeforeTradeDecimal - tradeInDecimal;
                            amountDueTextBox.Text = totalAfterTradeDecimal.ToString("c");
                        }
                        else
                        {
                            MessageBox.Show("Trade-In value MUST be a positive number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tradeinAllowanceTextBox.SelectAll();
                            tradeinAllowanceTextBox.Focus();
                        }
                    }
                    catch (FormatException fe)
                    {
                        // Trade-In value format exception
                        MessageBox.Show("Trade-In value MUST be a number..", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tradeinAllowanceTextBox.SelectAll();
                        tradeinAllowanceTextBox.Focus();

                    }
                }
                else
                {
                    MessageBox.Show("Car sales price should be positive number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    carSalesPriceTextBox.SelectAll();
                    carSalesPriceTextBox.Focus();
                }
            }
            catch (FormatException fe)
            {
                // Car sales price format exception
                if (carSalesPriceTextBox.Text == String.Empty)
                {
                    MessageBox.Show("Car sales price should be provided.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    carSalesPriceTextBox.SelectAll();
                    carSalesPriceTextBox.Focus();

                }
                else
                {
                    MessageBox.Show("Car sales price value MUST be a number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    carSalesPriceTextBox.SelectAll();
                    carSalesPriceTextBox.Focus();
                }

            }
            catch (OverflowException oe)
            {
                MessageBox.Show("Invalid number, Please check the numbers you provided.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
