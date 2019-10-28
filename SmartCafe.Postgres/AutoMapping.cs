using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SmartCafe.Postgres.DTO;
using SmartCafe.Postgres.Models;

namespace SmartCafe.Postgres
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Users, UserDto>();
            CreateMap<Tables, TableDto>();
        }
    }
}
