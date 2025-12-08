using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpaAndBeautyWebsite.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }

        // --- Foreign Keys (The Numbers) ---
        public int? EmployeeId { get; set; }
        public int? CustomerId { get; set; }
        public int? ServiceId { get; set; }

        [Required]
        public string Description { get; set; } = string.Empty;

        [Range(1, 10)]
        public int Rating { get; set; }

        // --- NAVIGATION PROPERTIES (THE FIX) ---
        // These allow you to type "review.Customer.FirstName"
        [ForeignKey("CustomerId")]
        public virtual Customer? Customer { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual Employee? Employee { get; set; }

        [ForeignKey("ServiceId")]
        public virtual Service? Service { get; set; }
    }
}