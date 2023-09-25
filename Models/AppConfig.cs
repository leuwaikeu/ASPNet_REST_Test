using System.ComponentModel.DataAnnotations;

namespace Rest.Models
{
    public class AppConfig : IdBase
    {
        [Required]
        [StringLength(200)]
        public string Description { set; get; }

        [Required]
        [StringLength(7)]
        public string BackgroundColour { set; get; }

        [Required]
        [StringLength(7)]
        public string ButtonColour { set; get; }

        [Required]
        [StringLength(7)]
        public string FontColour { set; get; }

        [Required]
        [StringLength(255)]
        public string LogoURL { set; get; }

        [Required]
        public bool Button1Disabled { set; get; }

        [Required]
        [StringLength(10)]
        public string Button1Value { set; get; }

        [Required]
        public bool Button2Disabled { set; get; }

        [Required]
        [StringLength(10)]
        public string Button2Value { set; get; }

        [Required]
        public bool Button3Disabled { set; get; }

        [Required]
        [StringLength(10)]
        public string Button3Value { set; get; }

        [Required]
        public bool Button4Disabled { set; get; }

        [Required]
        [StringLength(10)]
        public string Button4Value { set; get; }

        [Required]
        public bool ButtonOtherDisabled { set; get; }

        [Required]
        [StringLength(20)]
        public string ButtonOtherText { set; get; }
    }
}