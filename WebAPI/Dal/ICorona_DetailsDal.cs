using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface ICorona_DetailsDal
    {
        List<Corona_Details> getAllCorona_Detail();

        Corona_Details getCorona_DetailsId(long id);

        void addCorona_Details(Corona_Details corona_Details);

        void AddCoronaToMember(string identity, Corona_Details corona_Details);

        Corona_Details getCoronabyMemberId(string id);
        }
}
