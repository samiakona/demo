using System.ComponentModel.DataAnnotations;

namespace purchase.Models
{
    public class Checkout
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string Name { get; set; }
        public string VisitingPlace { get; set; }

        public decimal? Price { get; set; }

        public int OrderId { get; set; }

        public string Address { get; set; }
        public string City { get; set; }
        public int Phone {  get; set; }
        public string Email { get;  set; }




    }
}
