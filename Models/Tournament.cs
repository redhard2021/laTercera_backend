using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace laTercera.Models;

public class Tournament
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Name { get; set; }
    public string TournamentLogo { get; set; }
    [ForeignKey("Organizer")]
    public int IdOrganizer { get; set; }
}