using System.ComponentModel.DataAnnotations;

namespace ODataTutorial.Entities;

public class Note
{
    public Guid Id { get; set; }
    [Required]
    public string MessageNote { get; set; } = default!;
}