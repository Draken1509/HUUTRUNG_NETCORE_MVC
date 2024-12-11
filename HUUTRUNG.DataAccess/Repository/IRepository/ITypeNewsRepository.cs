using HUUTRUNG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUUTRUNG.DataAccess.Repository.IRepository
{
    public interface ITypeNewsRepository : IRepository<TypeNews>
    {
        void Update(TypeNews obj);
        //void Save();
    }
}
