using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Bank
{
    class Transfer
    {
        internal string SenderFirstName { get; set; }
        internal string SenderLastName { get; set; }
        internal string ReceiverFirstName { get; set; }
        internal  string ReceiverLastName { get; set; }
        internal  decimal Sendmoney { get; set; }
        internal DateTime Date { get; set; }

        public Transfer(Account sender, Account receiver, decimal sendMoney, DateTime date)
        {
            SenderFirstName = sender.FirstName;
            SenderLastName = sender.LastName;
            ReceiverFirstName = receiver.FirstName;
            ReceiverLastName = receiver.LastName;
            Sendmoney = sendMoney;
            Date = date;
        }
        public Transfer() { }

    }
}
