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
    public partial class registerForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=.;Initial Catalog=Bank;Integrated Security=True");
        List<Account> accountList = new List<Account>();
        List<Transfer> transferList = new List<Transfer>();
        private string logPath = @"D:\log.txt";
        public registerForm()
        {
            InitializeComponent();            
        }
        internal registerForm(List<Account> receiveAccountList)
        {
            InitializeComponent();
            accountList = receiveAccountList;
        }
        private void registerForm_Load(object sender, EventArgs e)
        {
            timer.Start();
            pinInput.MaxLength = 4;
            pinInput.PasswordChar = '*';
            startamountInput.MaxLength = 5;
            idInput.MaxLength = 6;
        }
        private void registerClick(object sender, EventArgs e)
        {           
            double age = checkAge();
            try
            {
                if (!(age >= 18))
                {
                    clearInputs();
                    throw new Exception("Invalid age. You must be 18 years old or older!");
                }
                if (string.IsNullOrWhiteSpace(firstnameInput.Text.ToString()) || string.IsNullOrWhiteSpace(lastnameInput.Text.ToString()) || string.IsNullOrWhiteSpace(startamountInput.Text.ToString())
                    || string.IsNullOrWhiteSpace(pinInput.Text.ToString()) || string.IsNullOrWhiteSpace(comboGender.Text.ToString()) || string.IsNullOrWhiteSpace(idInput.Text.ToString()))
                {
                    clearInputs();
                    throw new Exception("Invalid input!");
                }
                if (accountList.Exists(item => (item.ID == double.Parse(idInput.Text))))
                {
                    clearInputs();
                    throw new Exception("User with the given ID already exists!");
                }
                if (!(double.Parse(idInput.Text) > 111111 && double.Parse(idInput.Text) <= 999999))
                {
                    clearInputs();
                    throw new Exception("Invalid ID!");
                }
                if (!(int.Parse(pinInput.Text) > 1000 && int.Parse(pinInput.Text) <= 9999))
                {
                    clearInputs();
                    throw new Exception("Invalid PIN!");
                }
                string firstName = firstnameInput.Text.ToString().Trim(); firstName = firstToUpper(firstnameInput.Text);
                string lastName = lastnameInput.Text.ToString().Trim(); lastName = firstToUpper(lastnameInput.Text);
                string gender = comboGender.Text;
                double id = double.Parse(idInput.Text);
                string banknumber = bankAccNumber();
                decimal money = decimal.Parse(startamountInput.Text);
                int pin = int.Parse(pinInput.Text);

                Account User = new Account(firstName, lastName, age, gender, id, banknumber, money, pin);
                accountList.Add(User);
                saveToDataBase(firstName, lastName, age, gender, id, banknumber, money, pin);
                createLog_Registration(User);
                MessageBox.Show("Congratulations " + firstName + " your registration was successful!");
                loginForm form1 = new loginForm(accountList, transferList);
                this.Hide();
                form1.ShowDialog();
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
        private void backButtonClick(object sender, EventArgs e)
        {
            loginForm loginform = new loginForm(accountList, transferList);
            this.Hide();
            loginform.ShowDialog();
            this.Close();

        }

        private void timerTick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToShortDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }
        private double checkAge()
        {
            DateTime now= DateTime.Now;
            DateTime birthday = Convert.ToDateTime(dateTimePicker.Value);
            TimeSpan span = now.Subtract(birthday);
            double totalDays = span.TotalDays;
            var totalYear = Math.Truncate(totalDays/365);
            return totalYear;
        }
        private string bankAccNumber()
        {
            Random random = new Random();
            string numbers = "1234567890";
            char[] charArray = new char[26];   
            
            for (int i = 0; i < charArray.Length; i++)
                {
                  charArray[i] = numbers[random.Next(numbers.Length)];
                }               
            string bankAccNumber = new String(charArray);                
            return bankAccNumber;             
                       
        }
        private string firstToUpper(string name)
        {
            if (name.Length == 1)
            {
                char oneLetter = char.ToUpper(name[0]);
                return oneLetter.ToString();
            }
            else
            {
                char firstLetter = char.ToUpper(name[0]);
                string fullName = firstLetter.ToString() + name.Substring(1);
                return fullName;
            }
        }
        private void clearInputs()
        {
            firstnameInput.Clear();
            lastnameInput.Clear();
            idInput.Clear();
            pinInput.Clear();
            startamountInput.Clear();
        }
        private void saveToDataBase(string firstName, string lastName, double age, string gender, double id, string banknumber, decimal money, int pin)
        {
            try
            {
                connect.Open();
                SqlCommand insert = new SqlCommand("INSERT INTO [Users] VALUES (@FirstName, @LastName, @Age, @Gender, @AccountID, @AccountNumber, @Money, @PIN)", connect);
                insert.Parameters.AddWithValue("@FirstName", firstName);
                insert.Parameters.AddWithValue("@LastName", lastName);
                insert.Parameters.AddWithValue("@Age", age);
                insert.Parameters.AddWithValue("@Gender", gender);
                insert.Parameters.AddWithValue("@AccountID", id);
                insert.Parameters.AddWithValue("@AccountNumber", banknumber);
                insert.Parameters.AddWithValue("@Money", money);
                insert.Parameters.AddWithValue("@PIN", pin);
                insert.ExecuteNonQuery();
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
        private void createLog_Registration(Account User)
        {
            string raport = "[" + DateTime.Now + "] " + User.FirstName + " " + User.LastName + " have been registered.";
            using(StreamWriter log = new StreamWriter(logPath, true))
            {
                log.WriteLine(raport);
            }
        }

        }
    }

