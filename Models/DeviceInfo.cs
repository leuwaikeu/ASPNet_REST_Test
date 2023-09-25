using System.ComponentModel.DataAnnotations;

namespace Rest.Models
{
    public class DeviceInfo : IdBase
    {
        [Required]
        public string DeviceName { set; get; }

        [Required]
        public string AppConfigName { set; get; }

        [Required]
        public string Workplace { set; get; }
    }
}