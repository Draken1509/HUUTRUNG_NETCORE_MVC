using HUUTRUNG.DataAccess.Data;
using HUUTRUNG.DataAccess.Repository.IRepository;
using HUUTRUNG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUUTRUNG.DataAccess.Repository
{
	// Bất lợi của UnitOfWork:
	// nếu chỉ muốn sử dụng CategoryRepository nhưng UOW nó sẽ tạo ra triển khai tất cả các Repo đã đăng kí

	public class UnitOfWork : IUnitOfWork
	{
		private readonly ApplicationDbContext _db;
		public ICategoryRepository Category{ get; private set; }
        public ICharacterRepository Character{ get; private set; }
        public IComicRepository Comic { get; private set; }
        public ITypeComicRepository TypeComic { get; private set; }
        public ISeriesRepository Series { get; private set; }

        public UnitOfWork (ApplicationDbContext db)
		{
			_db = db;
			Category = new CategoryRepository(_db);  
			Character =new CharacterRepository(_db);
            Comic= new ComicRepository(_db);
            TypeComic = new TypeComicRepository(_db);
            Series = new SeriesRepository(_db);
        }
		
		public void Save()
		{
			_db.SaveChanges();
		}
	}
}
