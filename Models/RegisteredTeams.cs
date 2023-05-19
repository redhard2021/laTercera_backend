using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace laTercera.Models;

public class RegisteredTeams
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [ForeignKey("Tournament")]
    public int IdTournament { get; set; }
    [ForeignKey("Team")]
    public int IdTeam { get; set; }
}