using HUUTRUNG.DataAccess.Data;
using HUUTRUNG.DataAccess.Repository.IRepository;
using HUUTRUNG.Models;
using HUUTRUNG.Models.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HUUTRUNG.DataAccess.Repository
{ 
	public class ComicRepository : Repository<Comic>, IComicRepository
	{
		private readonly ApplicationDbContext _db;	
		public ComicRepository(ApplicationDbContext db):base(db) {
			_db = db;			
		}
		//public void Save()
		//{
		//	_db.SaveChanges();
		//}
		public void Update(Comic obj)
		{
            var objFromDb = _db.Comics.FirstOrDefault(c => c.Id == obj.Id);
            if (objFromDb != null)
            {
                // Cập nhật từng thuộc tính
                objFromDb.Name = obj.Name;
                objFromDb.Writer = obj.Writer;
                objFromDb.ArtBy = obj.ArtBy;
                objFromDb.Price = obj.Price;
                objFromDb.Price50 = obj.Price50;
                objFromDb.Price100 = obj.Price100;
                objFromDb.Colorist = obj.Colorist;
                objFromDb.Cover = obj.Cover;
                objFromDb.OnSaleDate = obj.OnSaleDate;
                objFromDb.PageCount = obj.PageCount;
                objFromDb.Rated = obj.Rated;              
                objFromDb.TypeComicId = obj.TypeComicId;
                objFromDb.SeriesId = obj.SeriesId;
                objFromDb.Description = obj.Description;
                objFromDb.IsFree = obj.IsFree;
                objFromDb.IsNew = obj.IsNew;

                if (obj.Thumbnail !=null)
                {
                    objFromDb.Thumbnail = obj.Thumbnail;
                }            
                // Lưu thay đổi vào database
                _db.SaveChanges();
            }
            else
            {
                throw new Exception("Comic not found");
            }
        }
	}
}
