using HUUTRUNG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUUTRUNG.DataAccess.Repository.IRepository
{
    public interface IMovieCategoryRepository : IRepository<MovieCategory>
    {
        void Update(MovieCategory obj);
        //void Save();
    }
}
