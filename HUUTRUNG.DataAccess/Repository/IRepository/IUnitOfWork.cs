using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUUTRUNG.DataAccess.Repository.IRepository
{
	public interface IUnitOfWork
	{
		ICategoryRepository Category{ get; }
        ICharacterRepository Character { get; }
		IComicRepository Comic { get; }
        ITypeComicRepository TypeComic { get; }
        ISeriesRepository Series { get; }
        void Save();
	}
}
