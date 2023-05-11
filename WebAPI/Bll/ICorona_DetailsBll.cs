using DTO;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public interface ICorona_DetailsBll
    {
        List <Corona_DetailsDto> getAllCorona_Details();

        Corona_DetailsDto getCorona_DetailsbyId(long id);

        void addCorona_Details(Corona_DetailsDto  corona_Details);
        void AddCoronaToMember(string identity, Corona_DetailsDto corona_Details);

        Corona_DetailsDto getCoronabyMemberId(string id);
        }
}
