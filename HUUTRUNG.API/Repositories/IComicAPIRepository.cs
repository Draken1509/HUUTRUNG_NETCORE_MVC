using HUUTRUNG.Models.Domain;
using HUUTRUNG.Models.DTO;
using HUUTRUNG_WEBAPI.Model.Domain;
using Microsoft.AspNetCore.Mvc;

namespace HUUTRUNG_WEBAPI.Repositories
{
    public interface IComicAPIRepository
    {
       public Task<ComicPagedDTO> GetAllAsync(string? filterOn=null, string? filterQuery=null,
             [FromQuery] string? sortBy=null, [FromQuery] bool? isAscending = null,
             [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 1000);

       public Task<List<ComicDTO?>> GetLastestComicAsync();
       public Task<List<ComicDTO?>> GetHighestRatingComicAsync();
       public Task<ComicDTO?> GetByIdAsync(int id);
       public Task<Comic> CreateAsync(Comic Comic);
       public Task<Comic> UpdateAsync(int id,Comic Comic);
       public Task<Comic?> DeleteAsync(int id);
       public Task<List<PageDTO>> GetPagebyIdAsync(int comicId);

       public Task<List<ComicDTO?>> GetSavedComicAsync(string id);
       public Task<List<ComicDTO?>> GetReadComicAsync(string id);
       public Task<List<ComicDTO?>> GetCurrentlReadingComicAsync(string id);
    }
   
}
