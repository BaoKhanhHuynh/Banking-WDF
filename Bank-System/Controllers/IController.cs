﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_System.Models;
using Microsoft.EntityFrameworkCore.Metadata;
using WindowsFormsApp1;

namespace Bank_System.Controllers
{
    internal interface IController<T> where T : class
    {
        List<T> Items { get; }
        bool Create(T model);
        bool Update(T model);
        bool Delete(object id);
        T Read(object id);
        bool Load();
        bool Load(object id);
        bool IsExist(object id);
        bool IsExist(T model);
    }
}
