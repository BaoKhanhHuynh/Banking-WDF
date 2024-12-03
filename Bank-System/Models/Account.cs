using System;

namespace Bank_System.Models
{
    public partial class Account
    {
        public Account() { }

        public Account(int id, string customerId, DateTime dateOpened, double balance)
        {
            Id = id;
            CustomerId = customerId;
            DateOpened = dateOpened;
            Balance = balance;
        }

        public int Id { get; set; }
        public string CustomerId { get; set; } = string.Empty; // Liên kết với bảng Customer
        public DateTime DateOpened { get; set; }
        public double Balance { get; set; } = 0.0;
    }
}
