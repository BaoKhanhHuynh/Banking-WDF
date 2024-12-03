using System.Security.Cryptography;
using System.Text;
using Bank_System.Models;
using Bank_System.Util;

namespace Bank_System.Controllers
{
    internal class EmployeeController : IController<Employee>
    {
        private List<Employee> items;
        private DataHelper db;

        public EmployeeController()
        {
            items = new List<Employee>();
            db = new DataHelper();
        }

        public List<Employee> Items
        {
            get { return items; }
        }

        public bool Create(Employee model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));

            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(model.Password);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                model.Password = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }

            string query = $"INSERT INTO Employee (id, employee_name, password, role) VALUES ('{model.Id}', '{model.Employee_Name}', '{model.Password}', '{model.Role}')";
            db.ExecuteNonQuery(query);
            return true;
        }

        public bool Delete(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"DELETE FROM Employee WHERE id = '{id}'";
            db.ExecuteNonQuery(query);
            return true;
        }

        public bool IsExist(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"SELECT COUNT(1) FROM Employee WHERE id = '{id}'";
            var results = db.ExecuteQuery(query);
            return results.Count > 0 && (int)results[0]["COUNT(1)"] > 0;
        }

        public bool IsExist(Employee model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));
            return IsExist(model.Id);
        }

        public bool Load()
        {
            string query = "SELECT id, password, role, employee_name FROM Employee";
            var results = db.ExecuteQuery(query);
            items.Clear();
            foreach (var row in results)
            {
                Employee employee = new Employee
                {
                    Id = row["id"]?.ToString() ?? string.Empty,
                    Password = row["password"]?.ToString() ?? string.Empty,
                    Role = row["role"]?.ToString() ?? string.Empty,
                    Employee_Name = row["employee_name"]?.ToString() ?? string.Empty,
                };
                items.Add(employee);
            }
            return true;
        }


        public bool Load(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"SELECT * FROM Employee WHERE id = '{id}'";
            var results = db.ExecuteQuery(query);
            if (results.Count > 0)
            {
                items.Clear();
                foreach (var row in results)
                {
                    Employee employee = new Employee
                    {
                        Id = row["id"]?.ToString() ?? string.Empty,
                        Password = row["password"]?.ToString() ?? string.Empty,
                        Employee_Name = row["employee_name"]?.ToString() ?? string.Empty,
                        Role = row["role"]?.ToString() ?? string.Empty
                    };
                    items.Add(employee);
                }
                return true;
            }
            return false;
        }

        public Employee Read(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"SELECT * FROM Employee WHERE id = '{id}'";
            var results = db.ExecuteQuery(query);
            if (results.Count > 0)
            {
                var row = results[0];
                Employee employee = new Employee
                {
                    Id = row["id"]?.ToString() ?? string.Empty,
                    Employee_Name = row["employee_name"]?.ToString() ?? string.Empty,
                    Password = row["password"]?.ToString() ?? string.Empty,
                    Role = row["role"]?.ToString() ?? string.Empty
                };
                return employee;
            }
            return null;
        }

        public bool Update(Employee model)
        {
            if (!string.IsNullOrEmpty(model.Password))
            {
                using (MD5 md5 = MD5.Create())
                {
                    byte[] inputBytes = Encoding.UTF8.GetBytes(model.Password);
                    byte[] hashBytes = md5.ComputeHash(inputBytes);
                    model.Password = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                }
            }

            string query = $"UPDATE Employee SET employee_name = '{model.Employee_Name}', " +
                           (string.IsNullOrEmpty(model.Password) ? "" : $"password = '{model.Password}', ") +
                           $"role = '{model.Role}' WHERE id = '{model.Id}'";

            query = query.Replace(", WHERE", " WHERE");
            db.ExecuteNonQuery(query);
            return true;
        }

        public bool Login(string employeeName, string password)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                password = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }

            string query = $"SELECT * FROM Employee WHERE employee_name = '{employeeName}' AND password = '{password}'";
            var results = db.ExecuteQuery(query);
            return results.Count > 0 ? true : false;
        }
    }
}
