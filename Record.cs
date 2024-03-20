using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibraryy
{
    public class Record
    {
        public int Account { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Balance { get; set; }

        public Record(): this(0, string .Empty, string.Empty, 0M) { }

        public Record(int account, string firstName, string lastName, decimal balance)
        {
            this.Account = account;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Balance = balance;
        }
    }
}
