using System.ComponentModel.DataAnnotations;

namespace Rest.Models
{
    public class OrganisationInfo
    {
        [Required]
        [StringLength(50)]
        public string Name { set; get; }

        [Required]
        [StringLength(50)]
        public string PaymentGatway { set; get; }

        [Required]
        [StringLength(50)]
        public string SumUpAPIKey { set; get; }
    }
}