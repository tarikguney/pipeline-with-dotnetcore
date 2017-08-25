using System;

namespace Common
{
    public class Account
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Balance { get; set; }
        public AccountStatus Status {get;set;}
        public CustomerType CustomerType { get; set; }
    }

    public enum AccountStatus{
        Bad,
        Average, 
        Good, 
        Great
    }

    public enum CustomerType{
        Regular,
        Premium
    }
}