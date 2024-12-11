using HUUTRUNG.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HUUTRUNG.DataAccess.Repository.IRepository
{
	public interface IRepository<T> where T : class   //T : kiểu tổng quát. IRepository<T>: là interface dung chung. where T : class là ràng buộc, chỉ cho phép T là một kiểu tham chiếu (class) chứ không phải kiểu giá trị.
	{
		//T - Caterory
		IEnumerable<T> GetAll(string? includeProperties = null);
		IEnumerable<T> GetAll(Expression<Func<T, bool>> filter,string? includeProperties = null);
		//IEnumerable<List<T>> GetAllAsync(Expression<Func<T, bool>> filter, string? includeProperties = null,
		//	string ? filterOn = null, string? filterQuery = null,
		//	 [FromQuery] string? sortBy = null, [FromQuery] bool? isAscending = null,
		//	   [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 1000);    
        T Get(Expression<Func<T, bool>> filter, string? includeProperties = null, bool tracked =true);
		void Add(T entity);		
		void Remove(T entity);
		void RemoveRange(IEnumerable<T> entity);
	}
}
