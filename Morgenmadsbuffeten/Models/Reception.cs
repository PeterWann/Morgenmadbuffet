using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Morgenmadsbuffeten.Models
{
    public class Reception
    {

        public int ReceptionId { get; set; }

        [Required]
        [DisplayName("Antal voksne")]
        public int AdultAmounts { get; set; }

        [Required]
        [DisplayName("Antal børn")]
        public int ChildrenAmount { get; set; }

        [Required]
        [DisplayName("Tjek ind dato")]
        public DateTime CheckInDate { get; set; }
        
    }
}
