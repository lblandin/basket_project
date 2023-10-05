using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NBA_project.Common.Models
{
    public class Stades
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public int Capacity { get; set; }

        public virtual Players? Players { get; set; }
        [ForeignKey(nameof(Players))]
        public int PlayersId { get; set; }
    }
}
