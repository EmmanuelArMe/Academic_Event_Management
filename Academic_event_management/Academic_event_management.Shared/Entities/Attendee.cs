
using System.ComponentModel.DataAnnotations;

namespace Academic_event_management.Shared.Entities
{
    public class Attendee
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please insert a start name.")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string Name { get; set; } = null!;
        [Required(ErrorMessage = "Please insert a start date.")]
        public string InstitutionalAffilitation { get; set; } = null!;
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string InterestArea { get; set; } = null!;
        [Required(ErrorMessage = "Please insert a participation type.")]
        public string TypeParticipation { get; set; } = null!;
    }
}
