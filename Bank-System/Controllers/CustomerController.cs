using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_System.Models;
using Bank_System.Util;

namespace Bank_System.Controllers
{
    internal class CustomerController : IController<Customer>
    {
        private List<Customer> items;
        private DataHelper db;

        public CustomerController()
        {
            items = new List<Customer>();
            db = new DataHelper();
        }

        public List<Customer> Items
        {
            get { return items; }
        }
        public bool Create(Customer model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));

            string query = $"INSERT INTO Customer (id, name, phone, email, house_no, city, pin) VALUES ('{model.Id}', '{model.Name}', '{model.Phone}','{model.Email}','{model.HouseNo}', '{model.City}', '{model.Pin}')";
            db.ExecuteNonQuery(query);
            return true;
        }
        public bool Delete(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"DELETE FROM Customer WHERE id = '{id}'";
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
        public bool Load()
        {
            string query = "SELECT id, name, phone, email, house_no, city, pin FROM Customer";
            var results = db.ExecuteQuery(query);
            items.Clear();
            foreach (var row in results)
            {
                Customer customer = new Customer
                {
                    Id = row["id"]?.ToString() ?? string.Empty,
                    Name = row["name"]?.ToString() ?? string.Empty,
                    Phone = row["phone"]?.ToString() ?? string.Empty,
                    Email = row["email"]?.ToString() ?? string.Empty,
                    HouseNo = row["house_no"]?.ToString() ?? string.Empty,
                    Pin = row["pin"]?.ToString() ?? string.Empty,
                    City = row["city"]?.ToString() ?? string.Empty,
                };
                items.Add(customer);
            }
            return true;
        }


        public bool Load(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"SELECT * FROM Customer WHERE id = '{id}'";
            var results = db.ExecuteQuery(query);
            if (results.Count > 0)
            {
                items.Clear();
                foreach (var row in results)
                {
                    Customer customer = new Customer
                    {
                        Id = row["id"]?.ToString() ?? string.Empty,
                        Name = row["name"]?.ToString() ?? string.Empty,
                        Phone = row["phone"]?.ToString() ?? string.Empty,
                        Email = row["email"]?.ToString() ?? string.Empty,
                        HouseNo = row["house_no"]?.ToString() ?? string.Empty,
                        Pin = row["pin"]?.ToString() ?? string.Empty,
                        City = row["city"]?.ToString() ?? string.Empty,
                    };
                    items.Add(customer);
                }
                return true;
            }
            return false;
        }
        public Customer Read(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"SELECT * FROM Customer WHERE id = '{id}'";
            var results = db.ExecuteQuery(query);
            if (results.Count > 0)
            {
                var row = results[0];
                Customer customer = new Customer
                {
                    Id = row["id"]?.ToString() ?? string.Empty,
                    Name = row["name"]?.ToString() ?? string.Empty,
                    Phone = row["phone"]?.ToString() ?? string.Empty,
                    Email = row["email"]?.ToString() ?? string.Empty,
                    HouseNo = row["house_no"]?.ToString() ?? string.Empty,
                    Pin = row["pin"]?.ToString() ?? string.Empty,
                    City = row["city"]?.ToString() ?? string.Empty,
                };
                return customer;
            }
            return null;
        }

        public bool Update(Customer model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));

            string query = $"UPDATE Customer SET name = '{model.Name}', phone = '{model.Phone}', email = '{model.Email}', house_no = '{model.HouseNo}', pin = '{model.Pin}', city = '{model.City}' WHERE id = '{model.Id}'";
            db.ExecuteNonQuery(query);
            return true;
        }

    }
}
