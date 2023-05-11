using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface IVaccineDal
    {
        List<Vaccine> getAllVaccines();

        List<Vaccine> getVaccinebyMemberId(string id);

        void addVaccine(Vaccine vaccine);

        void AddVaccineToMember(string identity, Vaccine vaccine);

    }
}
