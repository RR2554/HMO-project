using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public interface IMemberBll
    {
        List <MemberDto> getAllMembers();

        MemberDto getMemberbyId(string id);

        void addMember(MemberDto member);

    }
}
