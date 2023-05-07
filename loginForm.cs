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
    public partial class loginForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=.;Initial Catalog=Bank;Integrated Security=True");
        List<Account> accountList = new List<Account>();
        List <Transfer> transferList = new List<Transfer>();
        private string logPath = @"D:\log.txt";
        public loginForm()
        {
            InitializeComponent();
        }
        internal loginForm(List<Account> receiveAccountList, List<Transfer>receiveTransactionList)
        {
            InitializeComponent();
        }
        private void loginForm_Load(object sender, EventArgs e)
        {          
            timer.Start();
            pinTextBox.MaxLength = 4;
            pinTextBox.PasswordChar = '*';
            idTextBox.MaxLength = 6;
            loadDataFromDataBase(ref accountList, ref transferList);
        }
        private void loginButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(idTextBox.Text.ToString()) || string.IsNullOrWhiteSpace(pinTextBox.Text.ToString()))
                {
                    clearInputs();
                    MessageBox.Show("Invalid input!");
                    return;
                }
                if (!(accountList.Count != 0))
                {
                    clearInputs();
                    throw new Exception("You have not registered account yet!");
                }
                if (!(accountList.Exists(item => (item.ID == double.Parse(idTextBox.Text) && (item.PIN == int.Parse(pinTextBox.Text))))))
                {
                    clearInputs();
                    MessageBox.Show("Invalid ID or PIN!");
                    return;
                }
                Account user = accountList.Find(item => (item.ID == double.Parse(idTextBox.Text) && (item.PIN == int.Parse(pinTextBox.Text))));
                createLog_Login(user);
                bankappForm form2 = new bankappForm(user, accountList, transferList);
                this.Hide();
                form2.ShowDialog();
                this.Close();                                                                              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void exitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerClick(object sender, EventArgs e)
        {
            this.Hide();
            registerForm registerForm = new registerForm(accountList);
            registerForm.ShowDialog();
            this.Close();
        }

        private void timerTick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToShortDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }
        private void clearInputs()
        {
            idTextBox.Clear();
            pinTextBox.Clear();
        }
        private void loadDataFromDataBase(ref List<Account> accountList, ref List<Transfer> transferList)
        {
            try
            {
                connect.Open();
                SqlCommand selectUsers = new SqlCommand("SELECT * FROM [Users]", connect);
                SqlDataReader readerUsers = selectUsers.ExecuteReader();

                while(readerUsers.Read())
                {
                    Account user = new Account
                    {
                        FirstName = readerUsers.GetString(1),
                        LastName = readerUsers.GetString(2),
                        Age = readerUsers.GetInt32(3),
                        Gender = readerUsers.GetString(4),
                        ID = readerUsers.GetInt32(5),
                        BankNumber = readerUsers.GetString(6),
                        Money = readerUsers.GetDecimal(7),
                        PIN = readerUsers.GetInt32(8)
                    };
                    if (!(accountList.Exists(item => (item.FirstName == user.FirstName) && (item.LastName == user.LastName) && (item.Age == user.Age) && (item.Gender == user.Gender)
                        && (item.ID == user.ID) && (item.BankNumber == user.BankNumber) && (item.Money == user.Money) && (item.PIN == user.PIN)))) 
                    {
                        accountList.Add(user);
                    }
                    else
                    {
                        continue;
                    }
                }
                connect.Close();
                connect.Open();
                SqlCommand selectTransfers = new SqlCommand("SELECT * FROM [Transfers]", connect);
                SqlDataReader readerTransfers = selectTransfers.ExecuteReader();

                while(readerTransfers.Read())
                {
                    Transfer transfer = new Transfer
                    {
                        SenderFirstName = readerTransfers.GetString(1),
                        SenderLastName = readerTransfers.GetString(2),
                        ReceiverFirstName = readerTransfers.GetString(3),
                        ReceiverLastName = readerTransfers.GetString(4),
                        Sendmoney = readerTransfers.GetDecimal(5),
                        Date = readerTransfers.GetDateTime(6)
                    };
                    if (!(transferList.Exists(item => (item.SenderFirstName == transfer.SenderFirstName) && (item.SenderLastName == transfer.SenderLastName)
                        && (item.ReceiverFirstName == transfer.ReceiverFirstName) && (item.ReceiverLastName == transfer.ReceiverLastName)
                        && (item.Sendmoney == transfer.Sendmoney) && (item.Date == transfer.Date))))
                    {
                        transferList.Add(transfer);
                    }
                    else
                    {
                        continue;
                    }
                }

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
        private void createLog_Login(Account User)
        {
            string raport = "[" + DateTime.Now + "] " + User.FirstName + " " + User.LastName + " logged in.";
            using (StreamWriter log = new StreamWriter(logPath, true))
            {
                log.WriteLine(raport);
            }
        }
    }
}
