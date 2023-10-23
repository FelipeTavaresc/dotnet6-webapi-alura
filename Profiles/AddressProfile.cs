﻿using AutoMapper;
using Microsoft.AspNetCore.Components;
using MovieApi.Data.Dtos;
using MovieApi.Models;

namespace MovieApi.Profiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<CreateAddressDto, Address>();
            CreateMap<Address, ReadAddressDto>();
            CreateMap<UpdateAddressDto, Address>();
        }
    }
}
