using System.ComponentModel.DataAnnotations;

namespace X_Technology_ORTv2.Models
{
    public class Billing
    {
        public Billing()
        {
        }

        public Billing(string firstname, string lastname, string document, string email)
        {
            Firstname = firstname;
            Lastname = lastname;
            Document = document;
            Email = email;
        }

        public int Id { get; set; }
        
        [Required]
        public string Firstname { get; set; }
        
        [Required]
        public string Lastname { get; set; }
        
        [Required]
        public string Document { get; set; }
        
        [Required]
        public string Email { get; set; }
    }
}