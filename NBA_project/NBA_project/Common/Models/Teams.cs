using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NBA_project.Common.Models
{
    public class Teams
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? City { get; set; }

        public virtual Players? Players { get; set; }
        [ForeignKey(nameof(Players))]
        public int PlayersId { get; set; }

        public virtual Stades? Stades { get; set; }
        [ForeignKey(nameof(Stades))]
        public int StadesId { get; set; }
    }
}
