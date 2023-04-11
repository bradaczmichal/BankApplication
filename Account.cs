using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Bank
{
    class Account : Bank
    {
        internal string FirstName { get; set; }
        internal string LastName { get; set; }
        internal double Age { get; set; }
        internal string Gender { get; set; }
        protected override bool CheckPIN(int pin)
        {
            if (pin == PIN)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        internal override void PayIn(decimal moneyIn, int pin)
        {
            if (moneyIn > 0 && CheckPIN(pin) == true)
            {
                Money += moneyIn;
            }
            else
            {
                throw new Exception("Invalid amount!");
            }
        }

        internal override void PayOut(decimal moneyOut, int pin)
        {
            if (moneyOut <= Money && moneyOut > 0 && CheckPIN(pin) == true)
            {
                Money -= moneyOut;
            }
            else
            {
                throw new Exception("Invalid amount!");
            }
        }
        internal override void ChangePIN(int pin, int currentlyPin)
        {
            if (CheckPIN(currentlyPin) == true)
            {
                if (pin > 1000 && pin <= 9999)
                {
                    PIN = pin;
                }
                else
                {
                    throw new Exception("Invalid new PIN!");
                }
            }
            else
            {
                throw new Exception("Invalid currently PIN!");
            }
        }
        internal override void SendMoney(Account receiver, decimal moneySend, int pin)
        {
            if (CheckPIN(pin) == true)
            {
                if (moneySend > 0 && moneySend <= Money)
                {
                    receiver.Money += moneySend;
                    Money -= moneySend;
                }
                else
                {
                    throw new Exception("Invalid amount!");
                }
            }
            else
            {
                throw new Exception("Invalid PIN");
            }

        }
        public Account(string firstName, string lastName, double age, string gender, double id, string bankknumber, decimal money, int pin)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Gender = gender;
            this.ID = id;
            this.BankNumber = bankknumber;
            this.Money = money;
            this.PIN = pin;
        }
        public Account() { }
    }
}
