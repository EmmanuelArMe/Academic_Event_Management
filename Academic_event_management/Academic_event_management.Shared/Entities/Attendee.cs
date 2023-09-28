
using System.ComponentModel.DataAnnotations;

namespace Academic_event_management.Shared.Entities
{
    public class Attendee
    {
        public int Id { get; set; }

        [Display(Name = "Attendee Name")]
        [MaxLength(100, ErrorMessage = "The {0} field must have a maximum of {1} characters.")]
        [Required(ErrorMessage = "{0} field is required.")]
        public string Name { get; set; } = null!;

        [MaxLength(100, ErrorMessage = "The field Institutional Affilitation must have a maximum of 100 characters.")]
        [Required(ErrorMessage = "Please insert a Start Date.")]
        public string InstitutionalAffilitation { get; set; } = null!;

        [MaxLength(100, ErrorMessage = "The field Interest Area must have a maximum of 100 characters.")]
        [Required(ErrorMessage = "Please insert a Interest Area.")]
        public string InterestArea { get; set; } = null!;

        [Required(ErrorMessage = "Please insert a Participant Type.")]
        public string ParticipantType { get; set; } = null!;
    }
}
