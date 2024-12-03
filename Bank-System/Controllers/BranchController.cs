using Bank_System.Models;
using Bank_System.Util;
using System;
using System.Collections.Generic;

namespace Bank_System.Controllers
{
    internal class BranchController : IController<Branch>
    {
        private List<Branch> items;
        private DataHelper db;

        public BranchController()
        {
            items = new List<Branch>();
            db = new DataHelper();
        }

        public List<Branch> Items
        {
            get { return items; }
        }

        public bool Create(Branch model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));

            string query = $"INSERT INTO Branch (id, name, house_no, city) VALUES ('{model.Id}', '{model.Name}', '{model.HouseNo}', '{model.City}')";
            db.ExecuteNonQuery(query);
            return true;
        }

        public bool Delete(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"DELETE FROM Branch WHERE id = '{id}'";
            db.ExecuteNonQuery(query);
            return true;
        }

        public bool IsExist(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"SELECT COUNT(1) FROM Branch WHERE id = '{id}'";
            var results = db.ExecuteQuery(query);
            return results.Count > 0 && (int)results[0]["COUNT(1)"] > 0;
        }

        public bool IsExist(Branch model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));
            return IsExist(model.Id);
        }

        public bool Load()
        {
            string query = "SELECT id, name, house_no, city FROM Branch";
            var results = db.ExecuteQuery(query);
            items.Clear();
            foreach (var row in results)
            {
                Branch branch = new Branch
                {
                    Id = row["id"]?.ToString() ?? string.Empty,
                    Name = row["name"]?.ToString() ?? string.Empty,
                    HouseNo = row["house_no"]?.ToString() ?? string.Empty,
                    City = row["city"]?.ToString() ?? string.Empty
                };
                items.Add(branch);
            }
            return true;
        }

        public bool Load(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"SELECT * FROM Branch WHERE id = '{id}'";
            var results = db.ExecuteQuery(query);
            if (results.Count > 0)
            {
                items.Clear();
                foreach (var row in results)
                {
                    Branch branch = new Branch
                    {
                        Id = row["id"]?.ToString() ?? string.Empty,
                        Name = row["name"]?.ToString() ?? string.Empty,
                        HouseNo = row["house_no"]?.ToString() ?? string.Empty,
                        City = row["city"]?.ToString() ?? string.Empty
                    };
                    items.Add(branch);
                }
                return true;
            }
            return false;
        }

        public Branch Read(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string query = $"SELECT * FROM Branch WHERE id = '{id}'";
            var results = db.ExecuteQuery(query);
            if (results.Count > 0)
            {
                var row = results[0];
                Branch branch = new Branch
                {
                    Id = row["id"]?.ToString() ?? string.Empty,
                    Name = row["name"]?.ToString() ?? string.Empty,
                    HouseNo = row["house_no"]?.ToString() ?? string.Empty,
                    City = row["city"]?.ToString() ?? string.Empty
                };
                return branch;
            }
            return null;
        }

        public bool Update(Branch model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));

            string query = $"UPDATE Branch SET name = '{model.Name}', house_no = '{model.HouseNo}', city = '{model.City}' WHERE id = '{model.Id}'";
            db.ExecuteNonQuery(query);
            return true;
        }
    }
}
