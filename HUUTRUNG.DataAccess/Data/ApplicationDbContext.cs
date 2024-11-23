using HUUTRUNG.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using System.Globalization;

namespace HUUTRUNG.DataAccess.Data
{
    //Dung de ket noi CSDL voi Entity Framework core
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category>  Categories { get; set; }
		public DbSet<Character> Characters { get; set; }
		public DbSet<TypeComic> TypeComics { get; set; }
        public DbSet<Series> Series { get; set; }
		public DbSet<Alignment> Alignment { get; set; }
		public DbSet<Comic> Comics { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Graphic Novel", DisplayOrder = 1 },
				new Category { Id = 2, Name = "Comic Book", DisplayOrder = 2 }			
			);
			modelBuilder.Entity<Character>().HasData(
			  new Character {
				  Id = 1,
				  Name = "Action Novel",
				  Thumbnail="hehe.jpg",
				  Power="super metal",
				  Alias="Wonder woman",
				  BaseOfOperations="Chiu",
				  FirstAppearance="abc",
                  Description = "Hal Jordan’s life was changed twice by" +
				  " crashing aircraft. The first time was when" +
				  " he witnessed the death of his father, " +
				  "pilot Martin Jordan. The second was when," +
				  " as an adult and trained pilot himself," +
				  " he was summoned to the crashed wreckage " +
				  "of a spaceship belonging to an alien named Abin Sur." +
				  " Abin explained that he was a member of " +
				  "the Green Lantern Corps, an organization " +
				  "of beings from across the cosmos, armed with power r" +
				  "ings fueled by the green energy of all willpower in " +
				  "the universe. Upon his death, Abin entrusted his" +
				  " ring and duties as the Green Lantern of Earth’s" +
				  " space sector to Hal Jordan.",
				  Occupation = "abc",
                  Created_at = DateTime.Now.Date,
                  Updated_at = DateTime.Now.Date,
              },
					new Character
					{
						Id = 2,
						Name = "Action Novel",
                        Thumbnail = "hehe.jpg",
						Power = "super metal",
						Alias = "Wonder woman",
						BaseOfOperations = "Chiu",
						FirstAppearance = "abc",
                        Description = "Hal Jordan’s life was changed twice by" +
				  " crashing aircraft. The first time was when" +
				  " he witnessed the death of his father, " +
				  "pilot Martin Jordan. The second was when," +
				  " as an adult and trained pilot himself," +
				  " he was summoned to the crashed wreckage " +
				  "of a spaceship belonging to an alien named Abin Sur." +
				  " Abin explained that he was a member of " +
				  "the Green Lantern Corps, an organization " +
				  "of beings from across the cosmos, armed with power r" +
				  "ings fueled by the green energy of all willpower in " +
				  "the universe. Upon his death, Abin entrusted his" +
				  " ring and duties as the Green Lantern of Earth’s" +
				  " space sector to Hal Jordan.",
						Occupation = "abc",
                        Created_at = DateTime.Now.Date,
                        Updated_at = DateTime.Now.Date,
                    },
						  new Character
						  {
							  Id = 3,
							  Name = "Action Novel",
                              Thumbnail = "hehe.jpg",
							  Power = "super metal",
							  Alias = "Wonder woman",
							  BaseOfOperations = "Chiu",
							  FirstAppearance = "abc",
                              Description = "Hal Jordan’s life was changed twice by" +
				  " crashing aircraft. The first time was when" +
				  " he witnessed the death of his father, " +
				  "pilot Martin Jordan. The second was when," +
				  " as an adult and trained pilot himself," +
				  " he was summoned to the crashed wreckage " +
				  "of a spaceship belonging to an alien named Abin Sur." +
				  " Abin explained that he was a member of " +
				  "the Green Lantern Corps, an organization " +
				  "of beings from across the cosmos, armed with power r" +
				  "ings fueled by the green energy of all willpower in " +
				  "the universe. Upon his death, Abin entrusted his" +
				  " ring and duties as the Green Lantern of Earth’s" +
				  " space sector to Hal Jordan.",
							  Occupation = "abc",
                              Created_at = DateTime.Now.Date,
                              Updated_at = DateTime.Now.Date,
                          },
								new Character
								{
									Id = 4,
									Name = "Action Novel",
                                    Thumbnail = "hehe.jpg",
									Power = "super metal",
									Alias = "Wonder woman",
									BaseOfOperations = "Chiu",
									FirstAppearance = "abc",
                                    Description = "Hal Jordan’s life was changed twice by" +
				  " crashing aircraft. The first time was when" +
				  " he witnessed the death of his father, " +
				  "pilot Martin Jordan. The second was when," +
				  " as an adult and trained pilot himself," +
				  " he was summoned to the crashed wreckage " +
				  "of a spaceship belonging to an alien named Abin Sur." +
				  " Abin explained that he was a member of " +
				  "the Green Lantern Corps, an organization " +
				  "of beings from across the cosmos, armed with power r" +
				  "ings fueled by the green energy of all willpower in " +
				  "the universe. Upon his death, Abin entrusted his" +
				  " ring and duties as the Green Lantern of Earth’s" +
				  " space sector to Hal Jordan.",
									Occupation = "abc",
                                    Created_at = DateTime.Now.Date,
                                    Updated_at = DateTime.Now.Date,
                                },
									  new Character
									  {
										  Id = 5,
										  Name = "Action Novel",
                                          Thumbnail = "hehe.jpg",
										  Power = "super metal",
										  Alias = "Wonder woman",
										  BaseOfOperations = "Chiu",
										  FirstAppearance = "abc",
                                          Description = "Hal Jordan’s life was changed twice by" +
				  " crashing aircraft. The first time was when" +
				  " he witnessed the death of his father, " +
				  "pilot Martin Jordan. The second was when," +
				  " as an adult and trained pilot himself," +
				  " he was summoned to the crashed wreckage " +
				  "of a spaceship belonging to an alien named Abin Sur." +
				  " Abin explained that he was a member of " +
				  "the Green Lantern Corps, an organization " +
				  "of beings from across the cosmos, armed with power r" +
				  "ings fueled by the green energy of all willpower in " +
				  "the universe. Upon his death, Abin entrusted his" +
				  " ring and duties as the Green Lantern of Earth’s" +
				  " space sector to Hal Jordan.",
										  Occupation = "abc",
                                          Created_at = DateTime.Now.Date,
                                          Updated_at = DateTime.Now.Date,
                                      }

		  );
			modelBuilder.Entity<TypeComic>().HasData(
				  new TypeComic { Id = 1, Name = "Graphic Novel", DisplayOrder = 1, Description = "heheh" },
				  new TypeComic { Id = 2, Name = "Comic Book", DisplayOrder = 2, Description = "heheh" }
			  );
			modelBuilder.Entity<Series>().HasData(
				  new Series { Id = 1, Name = "BATMAN & ROBIN: YEAR ONE NOIR EDITION ", Description = "heheh" },
				  new Series { Id = 2, Name = "BATGIRL ", Description = "heheh" },
				  new Series { Id = 3, Name = "DC VS VAMPRIES: WORLD WAR ", Description = "heheh" }
			  );
			modelBuilder.Entity<Alignment>().HasData(
				  new Alignment { Id = 1, Name = "BIRDS OF PREY "},
				  new Alignment { Id = 2, Name = "BATGIRL "}				
			  );
			modelBuilder.Entity<Comic>().HasData(
			  new Comic {
				  Id = 1,
				  Name = "ABSOLUTE BATMAN NOIR EDITION #1 ",
				  Description = "Without the mansion…without the money…without the butler…what’s left is the Absolute Dark Knight! Noir Edition.",
				  Thumbnail = "hehe.jpg",
				  Writer = "Scott Snyder",
				  ArtBy = "Nick Dragotta",
				  Cover = "Frank Martin, Nick Dragotta",
				  Colorist = "Frank Martin",
				  Price = 3.5,
				  IsFree = true,
				  IsNew=false,                
                  OnSaleDate = DateTime.ParseExact("23-10-2024", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                  PageCount = 36,
				  Rated = "Teen",
				  Created_at = DateTime.Now.Date,
                  Updated_at = DateTime.Now.Date,
				  TypeComicId=1,				
				  SeriesId=1
              },
				new Comic
				{
					Id = 2,
					Name = "ABSOLUTE BATMAN NOIR EDITION #1 ",
					Description = "Without the mansion…without the money…without the butler…what’s left is the Absolute Dark Knight! Noir Edition.",
					Thumbnail = "hehe.jpg",
					Writer = "Scott Snyder",
					ArtBy = "Nick Dragotta",
					Cover = "Frank Martin, Nick Dragotta",
					Colorist = "Frank Martin",
					Price = 3.5,
					IsFree = false,
					IsNew = false,
                    OnSaleDate = DateTime.ParseExact("23-10-2024", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    PageCount = 36,
					Rated = "Teen",
					Created_at = DateTime.Now.Date,
					Updated_at = DateTime.Now.Date,
					TypeComicId = 2,				
					SeriesId = 2
				},
				new Comic
				{
					Id = 3,
					Name = "ABSOLUTE BATMAN NOIR EDITION #1 ",
					Description = "Without the mansion…without the money…without the butler…what’s left is the Absolute Dark Knight! Noir Edition.",
					Thumbnail = "hehe.jpg",
					Writer = "Scott Snyder",
					ArtBy = "Nick Dragotta",
					Cover = "Frank Martin, Nick Dragotta",
					Colorist = "Frank Martin",
					Price = 3.5,
					IsFree = true,
					IsNew = false,
                    OnSaleDate = DateTime.ParseExact("23-10-2024", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    PageCount = 36,
					Rated = "Teen",
					Created_at = DateTime.Now.Date,
					Updated_at = DateTime.Now.Date,
					TypeComicId = 2,					
					SeriesId = 1
				}


		  );

          


        }
	}       
   
}
