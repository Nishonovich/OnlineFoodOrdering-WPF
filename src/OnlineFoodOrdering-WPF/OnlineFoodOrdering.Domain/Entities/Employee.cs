using DataAnnotationsExtensions;
using OnlineFoodOrdering.Domain.Common;
using OnlineFoodOrdering.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFoodOrdering.Domain.Entities
{
    public class Employee : Auditable
    {
        [Required, MaxLength(60)]
        public string FullName { get; set; } = String.Empty;

        [Required, Column(TypeName = "date")]
        public DateOnly BirthDate { get; set; }  // diagrammada ko'rsatilmagan

        [Required]
        public Gender Gender { get; set; }  // diagrammada ko'rsatilmagan

        [Phone, Required, MaxLength(13)]
        public string  PhoneNumber { get; set; } = String.Empty;

        [Required, MaxLength(30)]
        public string Email { get; set; } = String.Empty;

        [Required]
        public double Salary { get; set; }  // diagrammada ko'rsatilmagan

        [Required, MinLength(5)]
        public string Login { get; set; } = String.Empty;

        [Required, MinLength(8)]
        public string Password { get; set; } = String.Empty;

    }
}
