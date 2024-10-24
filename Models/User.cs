using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models;

public class User
{
    public int Id { get; set; }
    [Required]
    [StringLength(30, MinimumLength = 5)]
    public string FirstName { get; set; }

    [Required]
    [StringLength(30, MinimumLength = 4)]
    public string LastName { get; set; }

    [Required]
    [StringLength(50)]
    public string Title { get; set; } 

    [StringLength(500, MinimumLength = 100)]
    public string Biography { get; set; } 

    [Range(0, 200)] 
    public int Age { get; set; }
}