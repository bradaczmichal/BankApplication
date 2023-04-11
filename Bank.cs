using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Bank
{
    internal abstract class Bank
    {       
        internal decimal Money { get; set; }
        internal int PIN {get; set;}
        internal double ID { get; set; }
        internal string BankNumber { get; set; }

        protected abstract bool CheckPIN(int pin);


        internal abstract void PayIn(decimal moneyIn, int pin);

        internal abstract void PayOut(decimal moneyOut, int pin);
        internal abstract void ChangePIN(int pin, int currentlyPin);    
        internal abstract void SendMoney(Account receiver, decimal moneySend, int pin);

       
    }
}
