using Entity.Models;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface IMemberDal
    {

        List<Member> getAllMembers();

        Member getMemberbyId(string id);

        void addMember(Member Member);

    }
}
