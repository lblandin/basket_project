using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NBA_project.Common.Models
{
    public class Players
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string? Position { get; set; }

        [Required]
        public string? Surname { get; set; }

        public virtual Teams? Teams { get; set; }
        [ForeignKey(nameof(Teams))]
        public int TeamsId { get; set; }
    }
}
