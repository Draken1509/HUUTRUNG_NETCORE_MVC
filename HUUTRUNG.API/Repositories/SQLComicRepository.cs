using HUUTRUNG.DataAccess.Data;
using HUUTRUNG.Models.Domain;
using HUUTRUNG.Models.DTO;
using HUUTRUNG_WEBAPI.Model.Domain;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HUUTRUNG_WEBAPI.Repositories
{
    public class SQLComicRepository : IComicAPIRepository
    {
       
        private readonly ApplicationDbContext _dbContext; 
        public SQLComicRepository(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;      
        }
        public async Task<Comic> CreateAsync(Comic comic)
        {
            await _dbContext.Comics.AddAsync(comic);
            await _dbContext.SaveChangesAsync();
            return comic;
        }

        public async Task<Comic> DeleteAsync(int id)
        {
            var exstingComic = await _dbContext.Comics.FirstOrDefaultAsync(s => s.Id == id);
            if (exstingComic == null)
            {
                return null;
            }
            _dbContext.Comics.Remove(exstingComic);
            await _dbContext.SaveChangesAsync();
            return exstingComic;
        }


        public async Task<ComicPagedDTO> GetAllAsync(string? filterOn = null, string? filterQuery = null,
           [FromQuery] string? sortBy = null, [FromQuery] bool? isAscending = null,
           [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 1000)
        {

          

            var comics = _dbContext.Comics
                .Include(x => x.Ratings)
                .Include(c => c.ComicCategory)
                .Where(comic => comic.IsFree)
                .Select(comic => new ComicDTO
                {
                    Id = comic.Id,
                    Name = comic.Name,
                    Thumbnail = comic.Thumbnail,
                    AverageRating = comic.AverageRating,
                    ComicCategory = comic.ComicCategory,
                    ComicCategoryId = (int)comic.ComicCategoryId,
                    OnSaleDate = comic.OnSaleDate
                })
                .AsQueryable();

            // Filtering
            if (!string.IsNullOrWhiteSpace(filterOn) && !string.IsNullOrWhiteSpace(filterQuery))
            {
                switch (filterOn.ToLower())
                {
                    case "name":
                        comics = comics.Where(x => x.Name.Contains(filterQuery));
                        break;
                    // Add more filters if needed
                    default:
                        break;
                }
            }

            // Sorting 
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                if (sortBy.Equals("Name", StringComparison.OrdinalIgnoreCase))
                {
                    comics = isAscending == true ? comics.OrderBy(x => x.Name) : comics.OrderByDescending(x => x.Name);
                }
                else if (sortBy.Equals("Writer", StringComparison.OrdinalIgnoreCase))
                {
                    comics = isAscending == true ? comics.OrderBy(x => x.Writer) : comics.OrderByDescending(x => x.Writer);
                }
            }

            // Pagination
            var skipResults = (pageNumber - 1) * pageSize;
            var totalItems = await comics.CountAsync();
            var pagedComics = await comics.Skip(skipResults).Take(pageSize).ToListAsync();

            // Return paged results along with total items count
            return new ComicPagedDTO
            {
                Comics = pagedComics,
                TotalItems = totalItems,               
            };

        }




        public async Task<List<ComicDTO>> GetLastestComicAsync()
        {
            return await _dbContext.Comics
                .AsNoTracking() // Không cần theo dõi thay đổi
                .Where(comic => comic.IsFree)
                .OrderByDescending(comic => comic.OnSaleDate) // Sắp xếp theo ngày phát hành
                .Select(comic => new ComicDTO
                {
                    Id = comic.Id,
                    Name = comic.Name,
                    Thumbnail = comic.Thumbnail,
                    AverageRating = comic.AverageRating,
                    ComicCategory = comic.ComicCategory, // Nếu cần hiển thị thông tin danh mục
                    ComicCategoryId = comic.ComicCategoryId ?? 0, // Xử lý nếu null
                    OnSaleDate = comic.OnSaleDate
                })
                .Take(12) // Lấy 12 kết quả đầu tiên
                .ToListAsync();
        }

        public async Task<List<ComicDTO>> GetHighestRatingComicAsync()
        {
            var comics =  _dbContext.Comics                                        
                                         .Include(c => c.Ratings)
                                         .Include(c => c.ComicCategory)
                                         .Where(comic => comic.IsFree)
                                         .AsQueryable();

            return await  comics.OrderByDescending(comic => comic.Ratings.Any()
                        ? comic.Ratings.Average(r => r.Score)
                        : 0)
                    .Take(10)
                    .Select(comic => new ComicDTO
                    {
                        Id = comic.Id,
                        Name = comic.Name,
                        Thumbnail = comic.Thumbnail,
                        ComicCategory = comic.ComicCategory,
                        ComicCategoryId = (int)comic.ComicCategoryId,
                        OnSaleDate = comic.OnSaleDate,
                        AverageRating = comic.Ratings.Any() ? comic.Ratings.Average(r => r.Score)
                                        : 0
                    })
                    .ToListAsync();
        }



        public async Task<ComicDTO?> GetByIdAsync(int id)
        {
            var comic = await _dbContext.Comics
                .Include(x => x.Series)
                .Include(x => x.ComicCategory)
                .FirstOrDefaultAsync(s => s.Id == id);

            if (comic == null) return null;

            // Lấy danh sách các trang của comic
            var pages = await _dbContext.Pages
                .Where(p => p.ComicId == id)
                .Select(p => new PageDTO
                {
                    Id = p.Id,
                    ImageUrl = p.ImageUrl,
                    PageNumber = p.PageNumber
                }).ToListAsync();

            // Lấy danh sách các comment
            var comments = await _dbContext.Comments
                .Where(c => c.ComicId == id)
                .Select(c => new CommentDTO
                {
                    CommentId = c.CommentId,
                    Content = c.Content,
                    LikeCount = c.LikeCount,
                    ApplicationUser = new ApplicationUserDTO
                    {
                        Id = c.ApplicationUser.Id,
                        UserName = c.ApplicationUser.UserName
                    }
                })
                .ToListAsync();

            // Lấy danh sách các rating
            var ratings = await _dbContext.Ratings
                .Where(r => r.ComicId == id)
                .Select(r => new RatingDTO
                {
                    Id = r.Id,
                    Score = r.Score
                }).ToListAsync();

            // Tính toán lại AverageRating nếu có ratings
            var averageRating = ratings.Any()
                ? ratings.Average(r => r.Score)
                : 0;

            // Lấy danh sách các comic liên quan
            var relatedComics = await _dbContext.Comics
                .Where(c => c.SeriesId == comic.SeriesId && c.Id != id)
                .Select(c => new ComicDTO
                {
                    Id = c.Id,
                    Name = c.Name,
                }).ToListAsync();

            // Trả về ComicDTO
            return new ComicDTO
            {
                Id = comic.Id,
                Name = comic.Name,
                Description = comic.Description,
                Thumbnail = comic.Thumbnail,
                Series = comic.Series,
                ComicCategory = comic.ComicCategory,
                AverageRating = averageRating,  // Gán giá trị tính lại nếu cần
                Pages = pages,
                Comments = comments,
                Ratings = ratings,
                RelatedComics = relatedComics
            };
        }


        public async Task<Comic> UpdateAsync(int id, Comic Comic)
        {
            var existingComic = await _dbContext.Comics.Include(x => x.Series).Include(x => x.ComicCategory).FirstOrDefaultAsync(x => x.Id == id);
            if (existingComic == null)
            {
                return null;
            }

            existingComic.Name = Comic.Name;
            existingComic.Description = Comic.Description;
            existingComic.Writer = Comic.Writer;
            existingComic.Thumbnail = Comic.Thumbnail;
            existingComic.ArtBy = Comic.ArtBy;
            existingComic.Cover = Comic.Cover;
            existingComic.Colorist = Comic.Colorist;
            existingComic.ComicCategoryId = Comic.ComicCategoryId;
            existingComic.SeriesId = Comic.SeriesId;

            await _dbContext.SaveChangesAsync();
            return existingComic;
        }
        public async Task<List<PageDTO>> GetPagebyIdAsync(int comicId)
        {
            return await _dbContext.Pages
                .Where(p => p.ComicId == comicId)
                .Select(p => new PageDTO 
                {
                    Id = p.Id,
                    ImageUrl = p.ImageUrl,
                    PageNumber = p.PageNumber
                })
                .ToListAsync();
        }

        public async Task<List<ComicDTO>> GetSavedComicAsync(string id)
        {
            return await _dbContext.Bookmarks
                .AsNoTracking()
                .Where(b => b.ApplicationUserId == id && b.IsSave == true) // Lọc theo UserId
                .Select(b => new ComicDTO
                {
                    Id = b.Comic.Id, // Liên kết tới bảng Comics qua Bookmark
                    Name = b.Comic.Name,
                    Thumbnail = b.Comic.Thumbnail,
                    AverageRating = b.Comic.AverageRating,
                    ComicCategory = b.Comic.ComicCategory,
                    ComicCategoryId = b.Comic.ComicCategoryId ?? 0,
                    OnSaleDate = b.Comic.OnSaleDate
                })
                .ToListAsync();
        }


        public async Task<List<ComicDTO>> GetReadComicAsync(string id)
        {
            return await _dbContext.Bookmarks
               .AsNoTracking()
               .Where(b => b.ApplicationUserId == id && b.Comic != null && b.IsRead==true ) 
               .Select(b => new ComicDTO
               {
                   Id = b.Comic!.Id, 
                   Name = b.Comic.Name,
                   Thumbnail = b.Comic.Thumbnail,
                   AverageRating = b.Comic.AverageRating,
                   ComicCategory = b.Comic.ComicCategory,
                   ComicCategoryId = b.Comic.ComicCategoryId ?? 0,
                   OnSaleDate = b.Comic.OnSaleDate
               })
               .ToListAsync();
        }

        public async Task<List<ComicDTO>> GetCurrentlReadingComicAsync(string id)
        {
            return await _dbContext.Bookmarks
                .AsNoTracking()
                .Where(b => b.ApplicationUserId == id && b.IsCurrentlyReading == true) // Lọc theo UserId
                .Select(b => new ComicDTO
                {
                    Id = b.Comic.Id, // Liên kết tới bảng Comics qua Bookmark
                    Name = b.Comic.Name,
                    Thumbnail = b.Comic.Thumbnail,
                    AverageRating = b.Comic.AverageRating,
                    ComicCategory = b.Comic.ComicCategory,
                    ComicCategoryId = b.Comic.ComicCategoryId ?? 0,
                    OnSaleDate = b.Comic.OnSaleDate
                })
                .ToListAsync();
        }

       
    }
}
