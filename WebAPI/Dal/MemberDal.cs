
using Entity;
using Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public  class MemberDal: IMemberDal
    {
        DB db;

        public MemberDal(DB db)
        {
            this.db = db;
        }

        public List<Member> getAllMembers()
        {
            return db.Members.Include(m=>m.Corona_Details).Include(m=>m.vaccines).ToList();
        }
       

        public Member getMemberbyId(string id)
        {
            var m= db.Members.FirstOrDefault<Member>(x => x.tz == id);
            if (m != null)
                return m;
            else { throw new Exception("the member  does not exist "); }
        }


        public void addMember(Member member)
        {
            db.Members.Add(member);
            db.SaveChanges();
        }
    }
}
