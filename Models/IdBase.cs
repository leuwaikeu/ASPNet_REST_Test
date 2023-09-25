using System.ComponentModel.DataAnnotations;

namespace Rest.Models
{
    public abstract class IdBase
    {
        [Required]
        public string Id { set; get; }
    }
}