using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Projekt_Bank
{
    public partial class bankappForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=.;Initial Catalog=Bank;Integrated Security=True");
        private string logPath = @"D:\log.txt";
        Account User = new Account();
        List<Account> accountList = new List<Account>();
        List<Transfer> transferList = new List<Transfer>();

        internal bankappForm(Account receiveUser, List<Account> receiveAccountList, List<Transfer> receiveTransactionList)
        {
            InitializeComponent();
            User = receiveUser;
            accountList = receiveAccountList;
            transferList = receiveTransactionList;
        }
        private void bankappForm_Load(object sender, EventArgs e)
        {
            timer.Start();
            showUserPanel();
            currentlypinInput.MaxLength = 4;
            currentlypinInput.PasswordChar = '*';

            changepinInput.MaxLength = 4;
            changepinInput.PasswordChar = '*';

            payinInput.MaxLength = 5;
            payoutInput.MaxLength = 5;
            

            pinSendMoneyInput.PasswordChar = '*';
            pinSendMoneyInput.MaxLength = 4;

            banknumberInput.MaxLength = 26;
            moneySendInput.MaxLength = 5;
        }
        private void informationClick(object sender, EventArgs e)
        {
            showLastTransactions();
            showinformationPanel();
        }

        private void payinClick(object sender, EventArgs e)
        {
            string amount = payinInput.Text;
            if (MessageBox.Show("Are you sure that you want to pay in " + amount + " PLN?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(payinInput.Text.ToString()))
                    {
                        clearPayInOut();
                        throw new Exception("Invalid input!");
                    }
                    User.PayIn(decimal.Parse(payinInput.Text), User.PIN);
                    createLog_PayIn(decimal.Parse(payinInput.Text));
                    clearPayInOut();
                    updateDataBase();
                    MessageBox.Show("Succesful operation!");
                }
                catch (Exception ex)
                {
                    clearPayInOut();
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                clearPayInOut();
            }
        }

        private void payoutClick(object sender, EventArgs e)
        {
            string amount = payoutInput.Text;
            if (MessageBox.Show("Are you sure that you want to pay out " + amount + " PLN?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(payoutInput.Text.ToString()))
                    {
                        clearPayInOut();
                        throw new Exception("Invalid input!");
                    }
                    User.PayOut(decimal.Parse(payoutInput.Text), User.PIN);
                    createLog_PayOut(decimal.Parse(payoutInput.Text));
                    clearPayInOut();
                    updateDataBase();
                    MessageBox.Show("Succesful operation!");
                }
                catch (Exception ex)
                {
                    clearPayInOut();
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                clearPayInOut();
            }
        }

        private void changepinClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure that you want to change your PIN?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(currentlypinInput.Text.ToString()) || string.IsNullOrWhiteSpace(changepinInput.Text.ToString()))
                    {
                        clearChangePIN();
                        throw new Exception("Invalid input!");
                    }
                    User.ChangePIN(int.Parse(changepinInput.Text), int.Parse(currentlypinInput.Text));
                    createLog_ChangePIN();
                    clearChangePIN();
                    updateDataBase();
                    MessageBox.Show("Succesful operation!");
                }
                catch (Exception ex)
                {
                    clearChangePIN();
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                clearChangePIN();
            }
        }
        private void makeTransferClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure that you want to send money?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(banknumberInput.Text.ToString()) || string.IsNullOrWhiteSpace(firstLastNameReceiverInput.Text.ToString())
                        || string.IsNullOrWhiteSpace(moneySendInput.Text.ToString()) || string.IsNullOrWhiteSpace(pinSendMoneyInput.Text.ToString()))
                    {
                        clearMakeTransfer();
                        throw new Exception("Invalid input!");
                    }
                    if(banknumberInput.Text == User.BankNumber)
                    {
                        clearMakeTransfer();
                        throw new Exception("You cannot send money to yourself!");
                    }
                    string name = firstLastNameReceiverInput.Text.Trim();
                    string[] firstLastName = name.Split(' ');
                    string firstname = firstLastName[0];
                    string lastname = firstLastName[1];
                    if (!(accountList.Exists(item => (item.BankNumber == banknumberInput.Text.ToString()) && (item.FirstName == firstname) && (item.LastName == lastname))))
                    {
                        clearMakeTransfer();
                        throw new Exception("Invalid user data!");
                    }
                    Account userReceiver = accountList.Find(item => (item.BankNumber == banknumberInput.Text.ToString() && (item.FirstName == firstname) && (item.LastName == lastname)));
                    User.SendMoney(userReceiver, decimal.Parse(moneySendInput.Text), int.Parse(pinSendMoneyInput.Text));
                    Transfer transfer = new Transfer(User, userReceiver, decimal.Parse(moneySendInput.Text), DateTime.Now);
                    transferList.Add(transfer);
                    saveToDataBase_Transfer(userReceiver, decimal.Parse(moneySendInput.Text));
                    createLog_MakeTransfer(userReceiver, decimal.Parse(moneySendInput.Text));
                    updateDataBase_makeTransfer(userReceiver);
                    clearMakeTransfer();
                    MessageBox.Show("Succesful operation!");
                }
                catch (Exception ex)
                {
                    clearMakeTransfer();
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                clearMakeTransfer();
            }
        }
        private void exitButtonClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutButtonClick(object sender, EventArgs e)
        {
            createLog_Logout();
            loginForm loginForm = new loginForm(accountList, transferList);
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

        private void timerTick(object sender, EventArgs e)
        {
            showLastTransactions();
            showBalancePanel();
            labelDate.Text = DateTime.Now.ToShortDateString();
            labelTime.Text = DateTime.Now.ToLongTimeString();
        }
        private void saveToDataBase_Transfer(Account userReceiver, decimal money)
        {
            try
            {
                connect.Open();
                SqlCommand insert = new SqlCommand("INSERT INTO [Transfers] VALUES (@SenderFirstName, @SenderLastName, @ReceiverFirstName, @ReceiverLastName, @Money, @Date)", connect);
                insert.Parameters.AddWithValue("@SenderFirstName",User.FirstName);
                insert.Parameters.AddWithValue("@SenderLastName",User.LastName);
                insert.Parameters.AddWithValue("@ReceiverFirstName",userReceiver.FirstName);
                insert.Parameters.AddWithValue("@ReceiverLastName",userReceiver.LastName);
                insert.Parameters.AddWithValue("@Money",money);
                insert.Parameters.AddWithValue("@Date",DateTime.Now);
                insert.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }
        private void updateDataBase_makeTransfer(Account userReceiver)
        {
            try
            {
                connect.Open();
                SqlCommand updateUser = new SqlCommand("UPDATE [Users] SET Money = @Money WHERE AccountID = @AccountID", connect);
                updateUser.Parameters.AddWithValue("@AccountID", User.ID);
                updateUser.Parameters.AddWithValue("@Money", User.Money);
                updateUser.ExecuteNonQuery();

                SqlCommand updateUserReceiver = new SqlCommand("UPDATE [Users] SET Money = @Money WHERE AccountID = @AccountID", connect);
                updateUserReceiver.Parameters.AddWithValue("@AccountID", userReceiver.ID);
                updateUserReceiver.Parameters.AddWithValue("@Money", userReceiver.Money);
                updateUserReceiver.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }
        private void updateDataBase()
        {
            try
            {
                connect.Open();
                SqlCommand update = new SqlCommand("UPDATE [Users] SET Money = @Money, PIN = @PIN WHERE AccountID = @AccountID", connect);
                update.Parameters.AddWithValue("@AccountID", User.ID);
                update.Parameters.AddWithValue("@Money", User.Money);
                update.Parameters.AddWithValue("@PIN", User.PIN);
                update.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }
        private void showBalancePanel()
        {
            labelBalanceMoney.Text = User.Money.ToString() + " PLN";
            labelBalanceAccountNumber.Text = User.BankNumber;
        }
        private void showUserPanel()
        {
            labelUserName.Text = User.FirstName + " " + User.LastName;
        }
        private void showLastTransactions()
        {
            try
            {                                         
                List<Transfer> tempTransactionList = transferList.FindAll(item => (item.SenderFirstName == User.FirstName && item.SenderLastName == User.LastName)
                  || (item.ReceiverFirstName == User.FirstName && item.ReceiverLastName == User.LastName));
                tempTransactionList.Reverse();
                if (tempTransactionList.Count == 0)
                {
                    labelTransactionsSender1.Visible = false; labelTransactionsReceiver1.Visible = false; labelTransactionsMoney1.Visible = false; labelTransactionsDate1.Visible = false;
                    labelTransactionsSender2.Visible = false; labelTransactionsReceiver2.Visible = false; labelTransactionsMoney2.Visible = false; labelTransactionsDate2.Visible = false;
                    labelNoTransactions.Visible = true;
                }             
                else if (tempTransactionList.Count == 1)
                {
                    labelTransactionsSender1.Visible = true; labelTransactionsReceiver1.Visible = true; labelTransactionsMoney1.Visible = true; labelTransactionsDate1.Visible = true;
                    labelTransactionsSender2.Visible = false; labelTransactionsReceiver2.Visible = false; labelTransactionsMoney2.Visible = false; labelTransactionsDate2.Visible = false;
                    labelNoTransactions.Visible = false;
                    labelTransactionsSender1.Text = "Sender Name: " + tempTransactionList[0].SenderFirstName + " " + tempTransactionList[0].SenderLastName;
                    labelTransactionsReceiver1.Text = "Receiver Name: " + tempTransactionList[0].ReceiverFirstName + " " + tempTransactionList[0].ReceiverLastName;
                    labelTransactionsMoney1.Text = "Money sent: " + tempTransactionList[0].Sendmoney.ToString() + " PLN";
                    labelTransactionsDate1.Text = "Date: " + tempTransactionList[0].Date.ToString();
                }
                else
                {
                    labelTransactionsSender1.Visible = true; labelTransactionsReceiver1.Visible = true; labelTransactionsMoney1.Visible = true; labelTransactionsDate1.Visible = true;
                    labelTransactionsSender2.Visible = true; labelTransactionsReceiver2.Visible = true; labelTransactionsMoney2.Visible = true; labelTransactionsDate2.Visible = true;
                    labelNoTransactions.Visible = false;

                    labelTransactionsSender1.Text = "Sender Name: " + tempTransactionList[0].SenderFirstName + " " + tempTransactionList[0].SenderLastName;
                    labelTransactionsReceiver1.Text = "Receiver Name: " + tempTransactionList[0].ReceiverFirstName + " " + tempTransactionList[0].ReceiverLastName;
                    labelTransactionsMoney1.Text = "Money sent: " + tempTransactionList[0].Sendmoney.ToString() + " PLN";
                    labelTransactionsDate1.Text = "Date: " + tempTransactionList[0].Date.ToString();

                    labelTransactionsSender2.Text = "Sender Name: " + tempTransactionList[1].SenderFirstName + " " + tempTransactionList[1].SenderLastName;
                    labelTransactionsReceiver2.Text = "Receiver Name: " + tempTransactionList[1].ReceiverFirstName + " " + tempTransactionList[1].ReceiverLastName;
                    labelTransactionsMoney2.Text = "Money sent: " + tempTransactionList[1].Sendmoney.ToString() + " PLN";
                    labelTransactionsDate2.Text = "Date: " + tempTransactionList[1].Date.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void createLog_PayIn(decimal Money)
        {
            string money = Money.ToString();
            string raport = "[" + DateTime.Now + "] " + User.FirstName + " " + User.LastName + " payed in " + money + " PLN.";
            using (StreamWriter log = new StreamWriter(logPath, true))
            {
                log.WriteLine(raport);
            }
        }
        private void createLog_PayOut(decimal money)
        {
            string raport = "[" + DateTime.Now + "] " + User.FirstName + " " + User.LastName + " payed out " + money + " PLN.";
            using (StreamWriter log = new StreamWriter(logPath, true))
            {
                log.WriteLine(raport);
            }
        }
        private void createLog_ChangePIN()
        {
            string raport = "[" + DateTime.Now + "] " + User.FirstName + " " + User.LastName + " changed PIN.";
            using (StreamWriter log = new StreamWriter(logPath, true))
            {
                log.WriteLine(raport);
            }
        }
        private void createLog_MakeTransfer(Account userReceiver, decimal money)
        {       
            string raport = "[" + DateTime.Now + "] " + User.FirstName + " " + User.LastName + " sent to " + userReceiver.FirstName + " " + userReceiver.LastName + " (" + money + " PLN).";
            using (StreamWriter log = new StreamWriter(logPath, true))
            {
                log.WriteLine(raport);
            }
        }
        private void createLog_Logout()
        {
            string raport = "[" + DateTime.Now + "] " + User.FirstName + " " + User.LastName + " logged out.";
            using (StreamWriter log = new StreamWriter(logPath, true))
            {
                log.WriteLine(raport);
            }
        }

        private void showinformationPanel()
        {          
            //labelInfoFirstName.Text = User.firstName.ToString();
            //labelInfoLastName.Text = User.lastName.ToString();
            //labelInfoAge.Text = User.Age.ToString();
            //labelInfoGender.Text = User.Gender.ToString();
            //labelInfoId.Text = "ID: " + User.ID.ToString();
            //labelInfoMoney.Text = "Money: " + User.money.ToString() + " PLN";
            //labelInfoBankNumber.Text = "Bank Account Number: " + User.bankNumber;
            //labelInfoPIN.Text = "PIN: " + User.PIN.ToString();
        }
        private void clearPayInOut()
        {
            payinInput.Clear();
            payoutInput.Clear();
        }
        private void clearChangePIN()
        {
            currentlypinInput.Clear();
            changepinInput.Clear();
        }
        private void clearMakeTransfer()
        {
            firstLastNameReceiverInput.Clear();
            banknumberInput.Clear();
            moneySendInput.Clear();
            pinSendMoneyInput.Clear();
        }
    }
    }

