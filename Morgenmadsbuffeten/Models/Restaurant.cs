using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Morgenmadsbuffeten.Models
{
    public class Restaurant
    {

        public int RestaurantId { get; set; }

        [Required]
        [DisplayName("Værelsesnummer")]
        public int RoomNumber { get; set; }

        [Required]
        [DisplayName("Antal Voksne")]
        public int AmountAdults { get; set; }

        [Required]
        [DisplayName("Antal Børn")]
        public int AmountChildren { get; set; }
    }
}
