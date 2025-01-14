using System.ComponentModel.DataAnnotations;

namespace dotnetapp.Models
{
    public class DonationOffer
    {
        [Key] public int OfferId { get; set; }
        [Required] public int UserId { get; set; }
        [Required] public string OfferType { get; set; } // Clothes, Food, Funds, etc.    
        [StringLength(500)] public string Description { get; set; }
        public string Status { get; set; } // Pending, Accepted, Rejected, etc.

        // Navigation property
        public User User { get; set; }
    }
}