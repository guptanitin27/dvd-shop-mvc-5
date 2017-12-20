using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using DVD_Shop.Dtos;
using DVD_Shop.Models;

namespace DVD_Shop.App_Start
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
                             //source   distination
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<CustomerDto, Customer>().ForMember(c=>c.Id,opt=>opt.Ignore());


            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<Genre, GenreDto>();
            Mapper.CreateMap<MovieDto, Movie>().ForMember(m => m.Id, opt => opt.Ignore());
        }
    }
}