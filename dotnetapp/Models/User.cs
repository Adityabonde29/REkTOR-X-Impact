using System.ComponentModel.DataAnnotations;

namespace dotnetapp.Models
{
    public class User
    {
        [Key] public int UserId { get; set; }
        [Required][StringLength(100)] public string Name { get; set; }
        [Required][EmailAddress] public string Email { get; set; }
        [Required][StringLength(100)] public string Password { get; set; }
        [Required] public string Role { get; set; } // Admin, Organization, User

        public ICollection<DonationOffer> DonationOffers { get; set; }


    }

}
