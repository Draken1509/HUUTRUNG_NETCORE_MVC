using HUUTRUNG.DataAccess.Data;
using HUUTRUNG.DataAccess.Repository.IRepository;
using HUUTRUNG.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HUUTRUNG.DataAccess.Repository
{ 
	public class TypeNewsRepository : Repository<TypeNews>, ITypeNewsRepository
	{
		private readonly ApplicationDbContext _db;	
		public TypeNewsRepository(ApplicationDbContext db):base(db) {
			_db = db;			
		}	
		public void Update(TypeNews obj)
		{
            _db.TypeNews.Update(obj);
        }
	}
}
