using System.ComponentModel.DataAnnotations;

namespace TekEnable.Models
{
    public class Subscription
    {
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
       
        [Required]
        public string HowYouHeard { get; set; }

        public string SignUpReason { get; set; }
    }
}
