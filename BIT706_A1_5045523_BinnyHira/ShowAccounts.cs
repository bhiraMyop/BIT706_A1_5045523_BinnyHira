using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace BIT706_A1_5045523_BinnyHira
{
    [Serializable]
    public partial class ShowAccounts : ParentForm
    {
        List<string> transactions = new List<string>();
        public ShowAccounts()
        {
            InitializeComponent();
            updateLabel();
            DisplayCustomersAccounts();
            amountLabel.Hide();
            textBoxAmount.Hide();
        }
        public void updateLabel()
        {
            string labelTxt = ($"ID - {SelectedCust.PersonID.ToString()} Name - " +
                $"{SelectedCust.Name}");
            customerLabel.Text = labelTxt;
        }

        public void DisplayCustomersAccounts()
        {
            //make sure listbox is empty
            lstAccounts.Items.Clear();
            //Add the book titles to the listBox
            foreach (AAccounts acc in AllAccounts)
            {
                if (acc.Customer.PersonID == SelectedCust.PersonID)
                {
                    lstAccounts.Items.Add(acc);
                }
            }

            //Select the first item
            lstAccounts.SelectedIndex = 0;
        }

        private void btnGetAccount_Click(object sender, EventArgs e)
        {
            SelectedAcc = (AAccounts)lstAccounts.SelectedItem;
            lstAccInfo.Text = SelectedAcc.toStringListAccounts();
            amountLabel.Show();
            textBoxAmount.Show();
        }

        private void btnRefresh2_Click(object sender, EventArgs e)
        {
            DisplayCustomersAccounts();
            SelectedAcc = null;
            lstAccInfo.Text = "";
            amountLabel.Hide();
            textBoxAmount.Clear();
            textBoxAmount.Hide();
        }
        private void withdrawButton_Click(object sender, EventArgs e)
        {
            double dollarAmount;
            try
            {
                //object.ReferenceEquals(null, selectedAcc);
                if(SelectedAcc == null)
                {
                    throw new NoAccountSelectedException("ERROR! - No Account Selected.");
                }
                else if (string.IsNullOrEmpty(textBoxAmount.Text.ToString()) || textBoxAmount.Text.ToString() == " ")
                {
                    throw new NoAmountEnteredException("ERROR! - No amount Entered.");
                }
                else if (double.TryParse($"{textBoxAmount.Text.ToString()}", out dollarAmount) != true)
                {
                    throw new StringEnteredException("ERROR! - Cannot Enter Characters in Amount Box." +
                        " Please only enter numbers.");
                }
                else
                {
                    double.TryParse(dollarAmount.ToString("N2"), out dollarAmount); //convert to 2 decimal places
                    string str = SelectedAcc.withdrawal(SelectedAcc, dollarAmount);
                    transactions.Add(str);
                    WriteBinaryData();
                    MessageBox.Show(str);
                    btnRefresh2.PerformClick();
                }
            }
            catch (NoAccountSelectedException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(NoAmountEnteredException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (StringEnteredException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (WithdrawalAmountIs0OrLessExpection ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NotEnoughMoneyInAccountException ex)
            {
                MessageBox.Show(ex.Message);
            }
            /*
            if (SelectedAcc == null)
            {
                MessageBox.Show("ERROR! - No Account Selected.");
            }
            else if (string.IsNullOrEmpty(textBoxAmount.Text.ToString()) || textBoxAmount.Text.ToString() == " ")
            {
                MessageBox.Show("ERROR! - No Amount Entered.");
            }
            else
            {

            dollarAmount = 0.0;

            if (double.TryParse($"{textBoxAmount.Text.ToString()}", out dollarAmount))
            {
                double.TryParse(dollarAmount.ToString("N2"), out dollarAmount); //convert to 2 decimal places
                string str = SelectedAcc.Withdrawl(SelectedAcc, dollarAmount);
                transactions.Add(str);
                // WriteBinaryData();
                MessageBox.Show(str);
                btnRefresh2.PerformClick();
            }
            */
        }
    

        private void depositButton_Click(object sender, EventArgs e)
        {
            if (SelectedAcc == null)
            {
                MessageBox.Show("ERROR! - No Account Selected.");
            }
            else if (string.IsNullOrEmpty(textBoxAmount.Text.ToString()) || textBoxAmount.Text.ToString() == " " )
            {
                MessageBox.Show("ERROR! - No Amount Entered.");
            }
            else
            {
                double dollarAmount = 0.0;

                if (double.TryParse($"{textBoxAmount.Text.ToString()}", out dollarAmount))
                {
                    double.TryParse(dollarAmount.ToString("N2"), out dollarAmount); //convert to 2 decimal places
                    string str = SelectedAcc.deposit(SelectedAcc, dollarAmount);
                    transactions.Add(str);
                    WriteBinaryData(); 
                    MessageBox.Show(str);
                    btnRefresh2.PerformClick();
                }
            }
        }

        private void buttonInterest_Click(object sender, EventArgs e)
        {
            if (SelectedAcc == null)
            {
                MessageBox.Show("ERROR! - No Account Selected.");
            }
            else
            {
                string str = SelectedAcc.calculateInterest(SelectedAcc);
                transactions.Add(str);
                WriteBinaryData();
                MessageBox.Show(str);
                btnRefresh2.PerformClick();
            }
        }

        public void WriteBinaryData()
        {
            //create a formatting object
            IFormatter formatter = new BinaryFormatter();

            //Create a new IO stream to write to the file Objects.bin
            Stream stream = new FileStream("objects.bin", FileMode.Create,
            FileAccess.Write, FileShare.None);

            //use the formatter to serialize the collection and send it to the filestream
            formatter.Serialize(stream, transactions);

            //close the file
            stream.Close();
        }

        public void ReadBinaryData()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Objects.bin", FileMode.Open, FileAccess.Read,
            FileShare.Read);
            transactions = (List<string>)formatter.Deserialize(stream);
            stream.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Read Binary Data
            transactionsLabel.Text = string.Empty;
            ReadBinaryData();
            showBinaryData();
        }

        private void showBinaryData()
        {
            foreach(string str in transactions)
            {
                transactionsLabel.Text += str;
                transactionsLabel.Text += "\n------------------------------------------------------------\n";
            }
        }

    }

}
