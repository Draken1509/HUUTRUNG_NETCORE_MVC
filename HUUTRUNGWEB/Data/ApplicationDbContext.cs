using HUUTRUNGWEB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace HUUTRUNGWEB.Data
{
    //Dung de ket noi CSDL voi Entity Framework core
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Caterogy>  Caterogies { get; set; }
}
   
}
