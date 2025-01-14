using System.ComponentModel.DataAnnotations;

namespace dotnetapp.Models
{
    public class DonationRequest
    {
        [Key] public int RequestId { get; set; }
        [Required] public int OrganizationId { get; set; }
        [Required] public string RequestType { get; set; } // Clothes, Food, Funds, etc.   
        [StringLength(500)] public string Description { get; set; }
        public string Status { get; set; } // Pending, Approved, Rejected, etc.]
        public Organization Organization { get; set; }
    }

}
