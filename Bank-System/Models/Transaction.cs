using System;

namespace Bank_System.Models
{
    public partial class Transaction
    {
        public Transaction() { }

        public Transaction(int id, int from_account_id, string branch_id, DateTime date_of_trans, double amount, string pin, int to_account_id, string employee_id)
        {
            Id = id;
            FromAccountId = from_account_id;
            BranchId = branch_id;
            DateOfTrans = date_of_trans;
            Amount = amount;
            Pin = pin;
            ToAccountId = to_account_id;
            EmployeeId = employee_id;
        }

        public int Id { get; set; }
        public int FromAccountId { get; set; } // Liên kết với bảng Account
        public string BranchId { get; set; } = string.Empty; // Liên kết với bảng Branch
        public DateTime DateOfTrans { get; set; }
        public double Amount { get; set; } = 0.0;
        public string Pin { get; set; } = string.Empty;
        public int ToAccountId { get; set; } // Liên kết với bảng Account
        public string EmployeeId { get; set; } = string.Empty; // Liên kết với bảng Employee
    }
}
