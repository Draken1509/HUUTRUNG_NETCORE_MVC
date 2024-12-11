using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using HUUTRUNG.DataAccess.Repository.IRepository;
using HUUTRUNG.DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace HUUTRUNG.DataAccess.Repository
{
	public class Repository<T> : IRepository<T> where T : class
    {

        //(parameters) => expression
		//parameters: Danh sách các tham số đầu vào.
		//=>: Là toán tử lambda, đọc là "goes to".
		//expression: Là biểu thức hoặc khối mã được thực thi khi biểu thức lambda được gọi.

        private readonly ApplicationDbContext _db;
		internal DbSet<T> dbSet;
        public Repository(ApplicationDbContext db)
        {
			_db = db;
			this.dbSet= _db.Set<T>();
			_db.Comics.Include(u => u.TypeComic).Include(u=>u.TypeComicId);  // lấy thêm dữ liệu từ bảng TypeComic, nếu muốn lấy thêm bảng thì cứ Include
        }
        public void Add(T entity)
		{
			dbSet.Add(entity);
		}
		public T Get(Expression<Func<T, bool>> filter, string? includeProperties = null, bool tracked = true)
		{
            IQueryable<T> query;
            if (tracked){
                query = dbSet;
            }
			else{
                query = dbSet.AsNoTracking();
            }
            query = query.Where(filter);
            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var includeProp in includeProperties
                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }
            return query.FirstOrDefault();
        }


		public IEnumerable<T> GetAll(string ? includeProperties=null)
		{
            IQueryable<T> query = dbSet;
            if (!string.IsNullOrEmpty(includeProperties))
			{
				foreach (var includeProp in
					includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
				{
					query = query.Include(includeProp);
				}

            }        
            if (dbSet == null)
			{
				throw new InvalidOperationException("The DbSet is not initialized.");
			}			
			return query.ToList();
		}
		public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter, string? includeProperties = null)
		{
			IQueryable<T> query = dbSet;
			
                query = query.Where(filter);
                   
            if (!string.IsNullOrEmpty(includeProperties))
			{
				foreach (var includeProp in
					includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
				{
					query = query.Include(includeProp);
				}

			}
			if (dbSet == null)
			{
				throw new InvalidOperationException("The DbSet is not initialized.");
			}
		
			return query.ToList();
		}

		public void Remove(T entity)
		{
			dbSet.Remove(entity);
		}			
		public void RemoveRange(IEnumerable<T> entity)
		{
			dbSet.RemoveRange(entity);
		}		
	}
}
