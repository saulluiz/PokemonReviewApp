//using AutoMapper;
//using PokemonReviewApp.Dto;
//using PokemonReviewApp.Models;

//namespace PokemonReviewApp.Helper
//{
//    public class MappingProfiles: Profile
//    {
//        public MappingProfiles()
//        {
//            CreateMap<Pokemon, PokemonDto>();
//            CreateMap<Category, CategoryDto>();
//            CreateMap<CategoryDto, Category >();
//            CreateMap<Country, CountryDto>();
//            CreateMap<CountryDto, Country>();
//            CreateMap<Owner, OwnerDto>();
//            CreateMap<OwnerDto, Owner>();
//            CreateMap<Review, ReviewDto>();
//            CreateMap<Reviewer, ReviewerDto>();


//        }
//    }
//}
using AutoMapper;
using PokemonReviewApp.Dto;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Pokemon, PokemonDto>();
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();
            CreateMap<CountryDto, Country>();
            CreateMap<OwnerDto, Owner>();
            CreateMap<PokemonDto, Pokemon>();
            CreateMap<ReviewDto, Review>();
            CreateMap<ReviewerDto, Reviewer>();
            CreateMap<Country, CountryDto>();
            CreateMap<Owner, OwnerDto>();
            CreateMap<Review, ReviewDto>();
            CreateMap<Reviewer, ReviewerDto>();
        }
    }
}
