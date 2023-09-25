using System.ComponentModel.DataAnnotations;

namespace Rest.Models
{
    public class PaymentResult
    {
        [Required]
        public int ResultCode { set; get; }

        [Required]
        public string ResultMessage { set; get; }

        [Required]
        public string TxCode { set; get; }

        [Required]
        public bool ReceiptSent { set; get; }

        [Required]
        public string TxInfo { set; get; }
    }
}