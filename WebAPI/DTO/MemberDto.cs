using Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MemberDto
    {

        public long Id { get; set; }

        [Required(ErrorMessage = "fitst name is required")]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "Only letters and spaces are allowed.")]
        [MinLength(2, ErrorMessage = "fitst name must be at least 2 character long")]
        public string first_Name { get; set; }

        [Required(ErrorMessage = "last name is required")]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "Only letters and spaces are allowed.")]
        [MinLength(2, ErrorMessage = "last name must be at least 2 character long")]
        public string last_Name { get; set; }

        [Required(ErrorMessage = "tz is required")]
        [MaxLength(9, ErrorMessage = "tz must have 9 digits"), MinLength(9)]
        [RegularExpression(@"^\d+$", ErrorMessage = "The tz field can only contain numbers.")]
        public string tz { get; set; }

        [Required(ErrorMessage = "city is required")]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "Only letters and spaces are allowed.")]
        [MinLength(2, ErrorMessage = "fitst name must be at least 2 character long")]
        public string city { get; set; }

        [Required(ErrorMessage = "street must have 9 digits")]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "Only letters and spaces are allowed.")]
        [MinLength(2, ErrorMessage = "street must be at least 2 character long")]
        public string street { get; set; }

        [Required (ErrorMessage = "NumHouse is required")]
        public int NumHouse { get; set; }

        [Required(ErrorMessage = "Date_of_birth is required")]
        [DataType(DataType.Date)]
        public DateTime? Date_of_birth { get; set; }

        [Required(ErrorMessage = "phone is required"), Phone]
        public string phone { get; set; }

        [Required(ErrorMessage = "Mobile_Phone is required"), Phone]
        public string Mobile_Phone { get; set; }


        public ICollection<VaccineDto>? vaccines { get; set; }

        public Corona_DetailsDto? Corona_Details { get; set; }
    }
}
