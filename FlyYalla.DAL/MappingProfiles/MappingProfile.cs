using FlyYalla.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using AutoMapper;
using FlyYalla.DAL.DTOs.AuthDtos;


namespace FlyYalla.DAL.MappingProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RegisterDto, ApplicationUser>()
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.UserMail)) // Map UserMail to Email
                .ForMember(dest => dest.DateOfBirth, opt => opt.MapFrom(src => src.BirthDate)) // Map BirthDate to DateOfBirth
                .ForMember(dest => dest.DocumentIssuingCountry, opt => opt.MapFrom(src => src.IssuingCountry)) // Map IssuingCountry to DocumentIssuingCountry
                .ForMember(dest => dest.DocumentExpiryDate, opt => opt.MapFrom(src => src.DocumentExpiryDate));
                                                                                                               
        }
    }
}
