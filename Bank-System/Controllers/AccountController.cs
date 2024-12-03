using Bank_System.Models;
using Bank_System.Util;

namespace Bank_System.Controllers
{
    internal class AccountController : IController<Account>
    {
        private List<Account> items;
        private DataHelper db;

        public AccountController()
        {
            items = new List<Account>();
            db = new DataHelper();
        }

        public List<Account> Items
        {
            get { return items; }
        }
        public bool Create(Account model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));

            string query = $"INSERT INTO Account (id, customerid, date_opened, balance) VALUES ('{model.Id}', '{model.CustomerId}', '{model.DateOpened}','{model.Balance}')";
            db.ExecuteNonQuery(query);
            return true;
        }
        public bool Delete(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"DELETE FROM Account WHERE id = '{id}'";
            db.ExecuteNonQuery(query);
            return true;
        }
        public bool IsExist(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"SELECT COUNT(1) FROM Account WHERE id = '{id}'";
            var results = db.ExecuteQuery(query);
            return results.Count > 0 && (int)results[0]["COUNT(1)"] > 0;
        }

        public bool IsExist(Account model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));
            return IsExist(model.Id);
        }
        public bool Load()
        {
            string query = "SELECT id, customerid, date_opened, balance FROM Account";
            var results = db.ExecuteQuery(query);
            items.Clear();
            foreach (var row in results)
            {
                Account account = new Account
                {
                    Id = row["id"] != null ? Convert.ToInt32(row["id"]) : 0,
                    CustomerId = row["customerid"]?.ToString() ?? string.Empty,
                    DateOpened = row["date_opened"] != null ? Convert.ToDateTime(row["date_opened"]) : DateTime.MinValue,
                    Balance = Convert.ToDouble(row["balance"] ?? 0),

                };
                items.Add(account);
            }
            return true;
        }


        public bool Load(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"SELECT * FROM Account WHERE id = '{id}'";
            var results = db.ExecuteQuery(query);
            if (results.Count > 0)
            {
                items.Clear();
                foreach (var row in results)
                {
                    Account account = new Account
                    {
                        Id = row["id"] != null ? Convert.ToInt32(row["id"]) : 0,
                        CustomerId = row["customerid"]?.ToString() ?? string.Empty,
                        DateOpened = row["date_opened"] != null ? Convert.ToDateTime(row["date_opened"]) : DateTime.MinValue,
                        Balance = Convert.ToDouble(row["balance"] ?? 0),
                    };
                    items.Add(account);
                }
                return true;
            }
            return false;
        }
        public Account Read(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"SELECT * FROM Account WHERE id = '{id}'";
            var results = db.ExecuteQuery(query);
            if (results.Count > 0)
            {
                var row = results[0];
                Account account = new Account
                {
                    Id = row["id"] != null ? Convert.ToInt32(row["id"]) : 0,
                    CustomerId = row["customerid"]?.ToString() ?? string.Empty,
                    DateOpened = row["date_opened"] != null ? Convert.ToDateTime(row["date_opened"]) : DateTime.MinValue,
                    Balance = Convert.ToDouble(row["balance"] ?? 0),
                };
                return account;
            }
            return null;
        }
        public bool Update(Account model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));

            string query = $"UPDATE Customer SET customerid = '{model.CustomerId}', date_opened = '{model.DateOpened}', balance = '{model.Balance}' WHERE id = '{model.Id}'";
            db.ExecuteNonQuery(query);
            return true;
        }
    }
}
