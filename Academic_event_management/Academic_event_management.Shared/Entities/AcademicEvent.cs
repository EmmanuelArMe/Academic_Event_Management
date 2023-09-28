
using System.ComponentModel.DataAnnotations;

namespace Academic_event_management.Shared.Entities
{
    public class AcademicEvent
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please insert a name.")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string AcademicEventName { get; set; } = null!;
        [Required(ErrorMessage = "Please insert a start date.")]
        public DateTime StartDate { get; set; }
        [Required(ErrorMessage = "Please insert a finish date.")]
        public DateTime FinishDate { get; set; }
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string Location { get; set; } = null!;
        [MaxLength(250, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string Description { get; set; } = null!;
        [Required(ErrorMessage = "Please insert a topic.")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string Topic { get; set; }= null!;

    }
}
