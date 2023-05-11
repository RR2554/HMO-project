using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Corona_Details
    {
        [Key]
        public long Id { get; set; }
       
        public DateTime? PositiveDate { get; set; }

        public DateTime? recoveryDate { get; set; }
      
        public long? memberId { get; set; }

        public Member member { get; set; }





    }
}
