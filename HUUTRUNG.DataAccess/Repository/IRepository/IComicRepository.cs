﻿using HUUTRUNG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUUTRUNG.DataAccess.Repository.IRepository
{
    public interface IComicRepository : IRepository<Comic>
    {
        void Update(Comic obj);
        //void Save();
    }
}