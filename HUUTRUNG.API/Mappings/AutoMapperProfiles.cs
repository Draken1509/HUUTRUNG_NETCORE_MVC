using AutoMapper;
using HUUTRUNG.Models.Domain;
using HUUTRUNG_WEBAPI.Model.Domain;
using HUUTRUNG_WEBAPI.Model.DTO;

namespace HUUTRUNG_WEBAPI.Mappings
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Series, SeriesDTO>().ReverseMap();
            CreateMap<Series, AddSeriesRequestDTO>().ReverseMap();
            CreateMap<Series, UpdateSeriesRequestDTO>().ReverseMap();

            CreateMap<Comic, ComicDTO>().ReverseMap();
            CreateMap<AddComicRequestDTO,Comic >().ReverseMap();
            CreateMap<Comic, UpdateComicRequestDTO>().ReverseMap();

        }
    }
}
       //.ForMember(dest => dest.Pages, opt => opt.MapFrom(src => src.Pages))
       //     .ForMember(dest => dest.Comments, opt => opt.MapFrom(src => src.Comments))
       //     .ForMember(dest => dest.Ratings, opt => opt.MapFrom(src => src.Ratings))