using OnlineFoodOrdering.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineFoodOrdering.Domain.Entities
{
    public class Customer : Auditable
    {
        [Required, MaxLength(50)]
        public string FirstName { get; set; } = String.Empty;

        [Required, MaxLength(50)]
        public string LastName { get; set; } = String.Empty;

        [Required, Column(TypeName = "date")]
        public DateOnly BirthDate { get; set; }

        [Required, MaxLength(50)]
        public string Email { get; set; } = String.Empty;

        [Required, MaxLength(15)]
        public string PhoneNumber { get; set; } = String.Empty;

        [Required, MaxLength(20), MinLength(5)]
        public string Login { get; set; } = String.Empty;

        [Required]
        public string Password { get; set; } = String.Empty;
    }
}
