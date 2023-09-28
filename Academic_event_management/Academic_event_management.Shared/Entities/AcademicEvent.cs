
using System.ComponentModel.DataAnnotations;

namespace Academic_event_management.Shared.Entities
{
    public class AcademicEvent
    {
        public int Id { get; set; }

        [Display(Name = "Event Name")]
        [MaxLength(100, ErrorMessage = "The {0} field must have a maximum of {1} characters.")]
        [Required(ErrorMessage = "{0} field is required.")]
        public string AcademicEventName { get; set; } = null!;

        [Required(ErrorMessage = "Please insert a start date.")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Please insert a finish date.")]
        public DateTime FinishDate { get; set; }

        [MaxLength(70, ErrorMessage = "The field Location must have a maximum of 70 characters.")]
        [Required(ErrorMessage = "Please insert a Location.")]
        public string Location { get; set; } = null!;

        [MaxLength(250, ErrorMessage = "The field Description must have a maximum of 250 characters.")]
        [Required(ErrorMessage = "Please insert a Description.")]
        public string Description { get; set; } = null!;

        [MaxLength(50, ErrorMessage = "The field Topic must have a maximum of 50 characters.")]
        [Required(ErrorMessage = "Please insert a Topic.")]
        public string Topic { get; set; }= null!;

    }
}
