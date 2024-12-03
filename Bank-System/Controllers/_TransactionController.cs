using Bank_System.Models;
using Bank_System.Util;

namespace Bank_System.Controllers
{
    internal class _TransactionController : IController<Transaction>
    {
        private List<Transaction> items;
        private DataHelper db;

        public _TransactionController()
        {
            items = new List<Transaction>();
            db = new DataHelper();
        }

        public List<Transaction> Items
        {
            get { return items; }
        }
        public bool Create(Transaction model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));

            string query = $"INSERT INTO _Transaction (id, from_account_id, branch_id, date_of_trans, amount, pin, to_account_id, employee_id) VALUES ('{model.Id}', '{model.FromAccountId}', '{model.BranchId}', '{model.DateOfTrans}', '{model.Amount}', '{model.Pin}', '{model.ToAccountId}','{model.EmployeeId}')";
            db.ExecuteNonQuery(query);
            return true;
        }
        public bool Delete(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"DELETE FROM _Transaction WHERE id = '{id}'";
            db.ExecuteNonQuery(query);
            return true;
        }
        public bool IsExist(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"SELECT COUNT(1) FROM Customer WHERE id = '{id}'";
            var results = db.ExecuteQuery(query);
            return results.Count > 0 && (int)results[0]["COUNT(1)"] > 0;
        }

        public bool IsExist(Customer model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));
            return IsExist(model.Id);
        }

        public bool IsExist(Transaction model)
        {
            throw new NotImplementedException();
        }

        public bool Load()
        {
            string query = "SELECT id, from_account_id, branch_id, date_of_trans, amount, pin, to_account_id, employee_id FROM _Transaction ";
            var results = db.ExecuteQuery(query);
            items.Clear();
            foreach (var row in results)
            {
                Transaction transaction = new Transaction
                {
                    Id = row["id"] != null ? Convert.ToInt32(row["id"]) : 0,
                    FromAccountId = row["from_account_id"] != null ? Convert.ToInt32(row["from_account_id"]) : 0,
                    BranchId = row["branch_id"]?.ToString() ?? string.Empty,
                    DateOfTrans = row["date_of_trans"] != null ? Convert.ToDateTime(row["date_of_trans"]) : DateTime.MinValue,
                    Amount = Convert.ToDouble(row["amount"] ?? 0),
                    Pin = row["pin"]?.ToString() ?? string.Empty,
                    ToAccountId = row["to_account_id"] != null ? Convert.ToInt32(row["to_account_id"]) : 0,
                    EmployeeId = row["employee_id"]?.ToString() ?? string.Empty,
                };
                items.Add(transaction);
            }
            return true;
        }


        public bool Load(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"SELECT * FROM _Transaction WHERE id = '{id}'";
            var results = db.ExecuteQuery(query);
            if (results.Count > 0)
            {
                items.Clear();
                foreach (var row in results)
                {
                    Transaction transaction = new Transaction
                    {
                        Id = row["id"] != null ? Convert.ToInt32(row["id"]) : 0,
                        FromAccountId = row["from_account_id"] != null ? Convert.ToInt32(row["from_account_id"]) : 0,
                        BranchId = row["branch_id"]?.ToString() ?? string.Empty,
                        DateOfTrans = row["date_of_trans"] != null ? Convert.ToDateTime(row["date_of_trans"]) : DateTime.MinValue,
                        Amount = Convert.ToDouble(row["amount"] ?? 0),
                        Pin = row["pin"]?.ToString() ?? string.Empty,
                        ToAccountId = row["to_account_id"] != null ? Convert.ToInt32(row["to_account_id"]) : 0,
                        EmployeeId = row["employee_id"]?.ToString() ?? string.Empty,
                    };
                    items.Add(transaction);
                }
                return true;
            }
            return false;
        }
        public Transaction Read(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"SELECT * FROM _Transaction WHERE id = '{id}'";
            var results = db.ExecuteQuery(query);
            if (results.Count > 0)
            {
                var row = results[0];
                Transaction transaction = new Transaction
                {
                    Id = row["id"] != null ? Convert.ToInt32(row["id"]) : 0,
                    FromAccountId = row["from_account_id"] != null ? Convert.ToInt32(row["from_account_id"]) : 0,
                    BranchId = row["branch_id"]?.ToString() ?? string.Empty,
                    DateOfTrans = row["date_of_trans"] != null ? Convert.ToDateTime(row["date_of_trans"]) : DateTime.MinValue,
                    Amount = Convert.ToDouble(row["amount"] ?? 0),
                    Pin = row["pin"]?.ToString() ?? string.Empty,
                    ToAccountId = row["to_account_id"] != null ? Convert.ToInt32(row["to_account_id"]) : 0,
                    EmployeeId = row["employee_id"]?.ToString() ?? string.Empty,
                };
                return transaction;
            }
            return null;
        }

        public bool Update(Transaction model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));

            string query = $"UPDATE _Transaction SET from_account_id = '{model.FromAccountId}', branch_id = '{model.BranchId}', date_of_trans = '{model.DateOfTrans}', amount = '{model.Amount}', pin = '{model.Pin}', to_account_id = '{model.ToAccountId}' WHERE id = '{model.Id}'";
            db.ExecuteNonQuery(query);
            return true;
        }

    }
}
