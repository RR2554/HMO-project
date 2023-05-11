using DTO;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public interface IVaccineBll
    {
        List <VaccineDto> getAllVaccines();

        List<VaccineDto> getVaccinebyMemberId(string id);

        void addVaccine(VaccineDto vaccine);
        void AddVaccineToMember(string identity, VaccineDto vaccine);

     

    }
}
