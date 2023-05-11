using Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class VaccineDto
    {
        public long Id { get; set; }


        [DataType(DataType.Date)]
        [Required(ErrorMessage = "VaccineDate is required")]
        public DateTime? VaccineDate { get; set; }

       
        [Required(ErrorMessage = "vaccine_manufacturer is required")]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "Only letters and spaces are allowed.")]
        public string vaccine_manufacturer { get; set; }
    }
}
