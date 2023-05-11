using AutoMapper;
using Dal;
using DTO;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll 

{
    public class VaccineBll: IVaccineBll
    {
        IVaccineDal vaccineDal;
        IMapper mapper;
        public VaccineBll(IVaccineDal vaccineDal, IMapper mapper)
        {
            this.vaccineDal = vaccineDal;
            this.mapper = mapper;
        }

        public List<VaccineDto> getAllVaccines()
        {
            return mapper.Map<List<VaccineDto>>(vaccineDal.getAllVaccines());
        }

        public List<VaccineDto> getVaccinebyMemberId(string id)
        {
            return mapper.Map<List<VaccineDto>>(vaccineDal.getVaccinebyMemberId(id));
        }

        public void addVaccine(VaccineDto vaccine)
        {

            vaccineDal.addVaccine(mapper.Map<Vaccine>(vaccine));
        }
        public void AddVaccineToMember(string identity, VaccineDto vaccine)
        {
            vaccineDal.AddVaccineToMember(identity,mapper.Map<Vaccine>(vaccine));
        }

        //public void AddVaccineToMember(string memberId, VaccineDto vaccine)
        // {
        //     vaccineDal.AddVaccineToMember(mapper.Map<Vaccine>(vaccine));
        // }
    }
}
