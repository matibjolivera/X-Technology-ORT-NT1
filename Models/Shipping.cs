using System.ComponentModel.DataAnnotations;

namespace X_Technology_ORTv2.Models
{
    public class Shipping
    {
        public Shipping()
        {
            
        }
        
        public Shipping(string firstname, string lastname, string address, string zipCode, string extraInformation, string province, string city)
        {
            Firstname = firstname;
            Lastname = lastname;
            Address = address;
            ZipCode = zipCode;
            ExtraInformation = extraInformation;
            Province = province;
            City = city;
        }

        public int Id { get; set; }
        
        [Required]
        public string Firstname { get; set; }
        
        [Required]
        public string Lastname { get; set; }
        
        [Required]
        public string Address { get; set; }
        
        [Required]
        public string ZipCode { get; set; }
        
        public string ExtraInformation { get; set; }
        
        [Required]
        public string Province { get; set; }
        
        [Required]
        public string City { get; set; }

        public string GetFullname()
        {
            return Firstname + " " + Lastname;
        }

        public string GetData()
        {
            return GetFullname() + " - " + Address + " (" + ZipCode + "), " + City + ", " + Province + " - " + ExtraInformation;
        }
    }
}