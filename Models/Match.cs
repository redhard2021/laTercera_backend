using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace laTercera.Models;

public class Match
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Date { get; set; }
    [ForeignKey("Tournament")]
    public int IdTournament { get; set; }
    [ForeignKey("Field")]
    public int IdField { get; set; }
    [ForeignKey("Team")]
    public int IdTeam1 { get; set; }
    [ForeignKey("Team")]
    public int IdTeam2 { get; set; }
    public string Result { get; set; }
}