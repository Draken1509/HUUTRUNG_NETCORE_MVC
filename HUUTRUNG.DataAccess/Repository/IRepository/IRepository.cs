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
        Task<IEnumerable<T>> GetAllAsync(string? includeProperties = null);
		Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> filter,string? includeProperties = null);		
        Task<T> GetAsync(Expression<Func<T, bool>> filter, string? includeProperties = null, bool tracked =true);
		void AddAsync(T entity);		
		void Remove(T entity);
		void RemoveRange(IEnumerable<T> entity);
	}
}
