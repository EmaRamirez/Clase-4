using System.ComponentModel.DataAnnotations;
namespace Clase4.Models;
public class Movie
{
    public Movie() { }
    public Movie(string code, string name, int minutes, string categoria, string review)
    {
        this.Code = code;
        this.Name = name;
        this.Minutes = minutes;
        this.Category = categoria;
        this.Review = review;
    }
    public string Code { get; set; }

    [Display(Name = "Nombre")]
    [Required]
    public string Name { get; set; }
    [Range(1, 500)]
    public int Minutes { get; set; }

    public string Category { get; set; }
    public string Review { get; set; }
}