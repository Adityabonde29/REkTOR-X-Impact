using System.ComponentModel.DataAnnotations;

namespace dotnetapp.Models
{
    public class Admin
    {
        [Key] public int AdminId { get; set; }
        [Required][StringLength(100)] public string Name { get; set; }
        [Required][EmailAddress] public string Email { get; set; }
        [Required][StringLength(100)] public string Password { get; set; }
    }

}
