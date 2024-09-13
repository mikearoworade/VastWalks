﻿using AutoMapper;
using VastWalks.API.Models.Domain;
using VastWalks.API.Models.DTO;

namespace VastWalks.API.Mappings
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Region, RegionDto>().ReverseMap();
            CreateMap<AddRegionRequestDto, Region>().ReverseMap();
            CreateMap<UpdateRegionRequeustDto, Region>().ReverseMap(); 
            CreateMap<AddWalkRequestDto, Walk>().ReverseMap();
            CreateMap<Walk,  WalkDto>().ReverseMap();
            CreateMap<Difficulty, DifficultyDto>().ReverseMap();
            CreateMap<UpdateWalkRequestDto, Walk>().ReverseMap();
        }
    }
}
