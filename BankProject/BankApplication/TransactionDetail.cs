using System;
using System.Collections.Generic;

#nullable disable

namespace BankProj.BankApplication
{
    public partial class TransactionDetail
    {
        public int TransactionId { get; set; }
        public string MadeBy { get; set; }
        public string MadeTo { get; set; }
        public long? TransactionAmount { get; set; }
        public string TransactionType { get; set; }
        public string Date { get; set; }
        public string Status { get; set; }
        public long? Balance { get; set; }

        public TransactionDetail(string MadeBy,string MadeTo,long? TransactionAmount,string TransactionType,string Date,string Status,long? Balance)
        {
            this.MadeBy = MadeBy;
            this.MadeTo = MadeTo;
            this.TransactionAmount = TransactionAmount;
            this.TransactionType = TransactionType;
            this.Date = Date;
            this.Status = Status;
            this.Balance = Balance;
        }
        public TransactionDetail()
        {

        }
    }
}
