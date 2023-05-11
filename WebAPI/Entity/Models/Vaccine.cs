using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Vaccine
    {
        [Key]
        public long Id { get; set; }

        public DateTime? VaccineDate { get; set; }

        public string vaccine_manufacturer { get; set; }

        public string? memberIdentity { get; set; }

        public long? memberId { get; set; }

        public Member member { get; set; }  
    }
}

