using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace laTercera.Models;

public class AvailableFields
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [ForeignKey("Field")]
    public int IdField { get; set; }
    [ForeignKey("Tournament")]
    public int IdTournament { get; set; }
    public string Surface { get; set; }

}