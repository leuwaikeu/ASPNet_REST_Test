using System.ComponentModel.DataAnnotations;

namespace Rest.Models
{
    public class Transaction : IdBase
    {
        [Required]
        public string Workplace { set; get; }

        [Required]
        public string Email { set; get; }

        [Required]
        public string Phone { set; get; }

        [Required]
        public DateTime DateTime { set; get; }

        [Required]
        public PaymentResult PayResult { set; get; }
    }
}