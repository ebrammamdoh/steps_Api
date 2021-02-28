using AutoMapper;
using Data.Entities;
using Steps_Assignment.Api.Models;
using Steps_Assignment.Data.Entities;
using Steps_Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Steps_Assignment.MapperProfiles
{
    public class AppProfile : Profile
    {
        public AppProfile()
        {
            CreateMap<Step, StepDTO>()
                .ForMember(dest =>
                    dest.Id,
                    opt => opt.MapFrom(src => src.Id))
                .ForMember(dest =>
                    dest.StepNumber,
                    opt => opt.MapFrom(src => src.StepNumber));

            CreateMap<Item, ItemDTO>()
                .ForMember(dest =>
                    dest.Id,
                    opt => opt.MapFrom(src => src.Id))
                .ForMember(dest =>
                    dest.Title,
                    opt => opt.MapFrom(src => src.Title))
                 .ForMember(dest =>
                    dest.Description,
                    opt => opt.MapFrom(src => src.Description))
                .ForMember(dest =>
                    dest.StepId,
                    opt => opt.MapFrom(src => src.StepId));
        }
  
    }
}
