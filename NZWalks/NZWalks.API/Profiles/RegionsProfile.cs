using AutoMapper;
using Microsoft.AspNetCore.Routing.Constraints;

namespace NZWalks.API.Profiles
{
    public class RegionsProfile : Profile
    {
        public RegionsProfile()
        {
            CreateMap<Models.Domain.Region, Models.DTO.Region>()
                .ReverseMap();

        }
    }
}
