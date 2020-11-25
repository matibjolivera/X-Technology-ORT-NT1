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
        
        public string Firstname { get; set; }
        
        public string Lastname { get; set; }
        
        public string Document { get; set; }
        
        public string Email { get; set; }
        
        public string GetFullname()
        {
            return Firstname + " " + Lastname;
        }

        public string GetData()
        {
            return GetFullname() + " - DNI: " + Document + " - " + Email;
        }
    }
}