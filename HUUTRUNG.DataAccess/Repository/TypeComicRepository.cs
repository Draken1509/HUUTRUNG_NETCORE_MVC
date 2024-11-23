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
	public class TypeComicRepository : Repository<TypeComic>, ITypeComicRepository
	{
		private readonly ApplicationDbContext _db;	
		public TypeComicRepository(ApplicationDbContext db):base(db) {
			_db = db;			
		}	
		public void Update(TypeComic obj)
		{
			_db.TypeComics.Update(obj);
		}
	}
}
