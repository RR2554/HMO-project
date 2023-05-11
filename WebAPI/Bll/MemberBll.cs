using AutoMapper;

using Entity;
using Dal;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Models;

namespace Bll
{
    public class MemberBll : IMemberBll
    {
        private readonly IMemberDal memberDal;
        private readonly IMapper mapper;
        public MemberBll(IMemberDal memberDal, IMapper mapper)
        {
            this.memberDal = memberDal;
            this.mapper = mapper;
        }

        public List<MemberDto> getAllMembers()
        {
            return mapper.Map<List<MemberDto>>(memberDal.getAllMembers());
        }

        public MemberDto getMemberbyId(string id)
        {
            return mapper.Map<MemberDto>(memberDal.getMemberbyId(id));
        }


        public void addMember(MemberDto member)
        {

            memberDal.addMember(mapper.Map<Member>(member));
           
        }
    }
}
