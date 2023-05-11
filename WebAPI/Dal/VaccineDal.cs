using Entity;
using Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class VaccineDal : IVaccineDal
    {
        DB db;

        public VaccineDal(DB db)
        {
            this.db = db;
        }

        public List<Vaccine> getAllVaccines()
        {
            return db.Vaccines.ToList();
        }

        public List<Vaccine> getVaccinebyMemberId(string id)
        {
            return db.Vaccines.Include(v=>v.member).Where(v => v.member.tz.Equals(id)).ToList();

        }

        public void addVaccine(Vaccine vaccine)
        {
            db.Vaccines.Add(vaccine);
            db.SaveChanges();
        }


        public void AddVaccineToMember(string identity, Vaccine vaccine)
        {

            var member = db.Members.Include(p => p.vaccines).Where(v => v.tz.Equals(identity)).FirstOrDefault();
            if (member != null)
            {

                if (member.vaccines.Count()==0)
                {
                    member.vaccines = new List<Vaccine>() { vaccine };
                   
                }
                else
                {
                    vaccine.memberId = member.Id;
                    if (member.vaccines.Count() <= 3)
                    {
                        member.vaccines.Add(vaccine);
                    }
                    else
                    {
                        throw new Exception("Cannot add another Covid instance to member as maximum limit of 3 has been reached.");
                    }
                }
                db.SaveChanges();
            }
            else
            {
                throw new Exception("member does not exists");
            }
        }
    }
}

