﻿using HUUTRUNG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUUTRUNG.DataAccess.Repository.IRepository
{
    public interface INewsRepository : IRepository<News>
    {
        void Update(News obj);
        //void Save();
    }
}
