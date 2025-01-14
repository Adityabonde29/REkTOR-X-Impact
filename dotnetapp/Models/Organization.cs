using System.ComponentModel.DataAnnotations;

namespace dotnetapp.Models
{
    public class Organization
    {
        [Key] public int OrganizationId { get; set; }
        [Required][StringLength(100)] public string Name { get; set; }
        [StringLength(500)] public string Description { get; set; }
        [Required] public string ContactInfo { get; set; }
        public bool IsVerified { get; set; }

        public ICollection<DonationRequest> DonationRequests { get; set; }

    }

}
