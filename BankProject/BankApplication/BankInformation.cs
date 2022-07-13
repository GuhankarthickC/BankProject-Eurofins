using System;
using System.Collections.Generic;

#nullable disable

namespace BankProj.BankApplication
{
    public partial class BankInformation
    {
        public int BankInfoId { get; set; }
        public int AccountNumber { get; set; }
        public string BankName { get; set; }
        public string AccountType { get; set; }
        public string Ifsccode { get; set; }
        public long? Balance { get; set; }
    }
}
