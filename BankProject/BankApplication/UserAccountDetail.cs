using System;
using System.Collections.Generic;

#nullable disable

namespace BankProj.BankApplication
{
    public partial class UserAccountDetail
    {
        public string FullName { get; set; }
        public string DateofBirth { get; set; }
        public string Email { get; set; }
        public int? Phone { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int? AccountNumber { get; set; }
    }
}
