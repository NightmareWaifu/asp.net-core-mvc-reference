using System.ComponentModel.DataAnnotations;

namespace Healthcare.Models
{
    public class Appointment
    {
        public Guid Id { get; set; } //input in controller, not required
        [Required]
        public string Type { get; set; }
        [Required]
        public string Description { get; set;}
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Doctor { get; set; }

        /*
         WIP STUFF
        Appointment Time 
        UserID - To tag appointment to user then use search query based on this to display appointment for that user 
        e.g. you can use a search bar "Enter your ID: " to view appointment status
         */
    }
}
