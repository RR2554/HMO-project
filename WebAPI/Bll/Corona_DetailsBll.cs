using AutoMapper;
using Dal;
using DTO;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class Corona_DetailsBll:ICorona_DetailsBll
    {
        ICorona_DetailsDal corona_DetailsDal;
        IMapper mapper;
        public Corona_DetailsBll(ICorona_DetailsDal corona_DetailsDal, IMapper mapper)
        {
            this.corona_DetailsDal = corona_DetailsDal;
            this.mapper = mapper;
        }

        public List<Corona_DetailsDto> getAllCorona_Details()
        {
            return mapper.Map<List<Corona_DetailsDto>>(corona_DetailsDal.getAllCorona_Detail());
        }

        public Corona_DetailsDto getCorona_DetailsbyId(long id)
        {
            return mapper.Map<Corona_DetailsDto>(corona_DetailsDal.getCorona_DetailsId(id));
        }

        public void addCorona_Details(Corona_DetailsDto corona_Details)
        {

            corona_DetailsDal.addCorona_Details(mapper.Map<Corona_Details>(corona_Details));
        }
       public void AddCoronaToMember(string identity, Corona_DetailsDto corona_Details)
        {
            corona_DetailsDal.AddCoronaToMember(identity, mapper.Map<Corona_Details>(corona_Details));
        }


        public Corona_DetailsDto getCoronabyMemberId(string id)
        {
            return mapper.Map<Corona_DetailsDto>(corona_DetailsDal.getCoronabyMemberId(id));
        }
    }
}
