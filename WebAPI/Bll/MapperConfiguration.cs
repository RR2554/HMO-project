

using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using DTO;
using Entity;
using Entity.Models;
using DTO;

namespace Bll
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {

            CreateMap<Member, MemberDto>();
            CreateMap<MemberDto, Member>();
            CreateMap<Vaccine, VaccineDto>();
            CreateMap<VaccineDto, Vaccine>();
            CreateMap<Corona_Details, Corona_DetailsDto>();
            CreateMap<Corona_DetailsDto, Corona_Details>();
        }
    }
}
