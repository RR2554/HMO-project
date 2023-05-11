using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Member
    {
        [Key]
        public long Id { get; set; }
        public string first_Name { get; set; }

        public string last_Name { get; set; }

        public string tz { get; set; }

        public string city { get; set; }

        public string street { get; set; }

        public int NumHouse { get; set; }

        public DateTime? Date_of_birth { get; set; }

        public string phone { get; set; }

        public string Mobile_Phone { get; set; }

        public Corona_Details? Corona_Details { get; set; }

        public ICollection<Vaccine> vaccines { get; set; }


    }
}
