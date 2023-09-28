using System.ComponentModel.DataAnnotations;

namespace Academic_event_management.Shared.Entities
{
    public class EventProgram
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please insert a Schedule.")]
        public string Schedule { get; set; } = null!;

        [Required(ErrorMessage = "Please insert a Session.")]
        public string Session { get; set; } = null!;

        [MaxLength(100, ErrorMessage = "The field Speaker must have a maximum of 100 characters.")]
        [Required(ErrorMessage = "Please insert a Speaker.")]
        public string Speaker { get; set; } = null!;

        [MaxLength(100, ErrorMessage = "The field Subject must have a maximum of 100 characters.")]
        [Required(ErrorMessage = "Please insert a Subject.")]
        public string Subject { get; set; } = null!;

    }
}
