using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectBankLibrary
{
    public class Record
    {
        public int? Account {  get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }
        public decimal? Balance { get; set; }

        public Record() : this(0, string.Empty, string.Empty, 0M) { }

        public Record(int account, string firstName, string lastName, decimal balance)
        {
            Account = Account;
            FirstName = FirstName;
            LastName = LastName;
            Balance = Balance;
        }
    }
}
