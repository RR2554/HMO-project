using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Corona_DetailsDto
    {

        public long Id { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "PositiveDate is required")]
        public DateTime? PositiveDate { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "recoveryDate is required")]
        public DateTime? recoveryDate { get; set; }



    }
}
