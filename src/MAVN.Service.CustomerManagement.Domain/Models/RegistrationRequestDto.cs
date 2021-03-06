namespace MAVN.Service.CustomerManagement.Domain.Models
{
    public class RegistrationRequestDto
    {
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public string Email { get; set; } 
        
        public string ReferralCode { get; set; }

        public string Password { get; set; }

        public int? CountryOfNationalityId { get; set; }
    }
}
