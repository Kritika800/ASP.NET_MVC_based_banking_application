//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bank_Management_System.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BankAuthorizationForm
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string EmailId { get; set; }
        public Nullable<long> Phone_No { get; set; }
        public string BankName { get; set; }
        public string BankBranch { get; set; }
        public string BankPhonenumber { get; set; }
        public string Type_OF_BankAccount { get; set; }
        public string Confirm_bank_Account_Type { get; set; }
        public string Signature { get; set; }
    }
}
