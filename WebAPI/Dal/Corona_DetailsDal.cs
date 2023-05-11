
using Entity;
using Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public  class Corona_DetailsDal: ICorona_DetailsDal
    {
        DB db;


        public Corona_DetailsDal(DB db)
        {
            this.db = db;
        }

        public List<Corona_Details> getAllCorona_Detail()
        {
            return db.Corona_Details.ToList();
        }

        public Corona_Details getCorona_DetailsId(long id)
        {

            return db.Corona_Details.First(x => x.Id == id);
        }

        public void addCorona_Details(Corona_Details corona_Details)
        {
            db.Corona_Details.Add(corona_Details);
            db.SaveChanges();
        }


        public void AddCoronaToMember(string identity, Corona_Details corona_Details)
        {

            var member =  db.Members.First<Member>(x => x.tz .Equals(identity) );
            if (member != null)
            {
                var c = db.Corona_Details.Include(c=>c.member).FirstOrDefault(v => v.member.tz.Equals(identity));
                if (c == null)
                {
                    corona_Details.member = member;
                    corona_Details.memberId = member.Id;
                    //member.Corona_Details=corona_Details;
                    db.Corona_Details.Add(corona_Details);
                }
               
                else
                {
                    throw new Exception("You can only be sick once");
                }
                db.SaveChanges();
            }
            else
            {
                throw new Exception("member does not exists");
            }
        }
        public Corona_Details getCoronabyMemberId(string id)
        {
            return db.Corona_Details.FirstOrDefault(v => v.member.tz.Equals(id));
           
        }
    }
}
