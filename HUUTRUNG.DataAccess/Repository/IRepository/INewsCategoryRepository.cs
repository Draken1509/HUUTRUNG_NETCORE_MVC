﻿using HUUTRUNG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUUTRUNG.DataAccess.Repository.IRepository
{
    public interface INewsCategoryRepository : IRepository<NewsCategory>
    {
        void Update(NewsCategory obj);
        //void Save();
    }
}
