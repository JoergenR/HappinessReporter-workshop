using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HappinessReporter.Models
{
    public class WorkdaySatisfaction
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(1, 10)]
        public int Satisfaction { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }

        public virtual User? User { get; set; }
    }
}