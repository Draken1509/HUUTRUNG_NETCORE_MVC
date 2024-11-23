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
		IEnumerable<T> GetAll(string? inclueProperties = null);
		IEnumerable<T> GetAll(Expression<Func<T, bool>> filter,string? inclueProperties = null);
		T Get(Expression<Func<T, bool>> filter, string? inclueProperties = null);
		void Add(T entity);		
		void Remove(T entity);
		void RemoveRange(IEnumerable<T> entity);
	}
}
