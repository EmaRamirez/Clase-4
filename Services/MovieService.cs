using Clase4.Models;
namespace Clase4.Services;
public static class MovieService
{
    static List<Movie> Movies { get; set; }

    static MovieService()
    {
        Movies = new List<Movie>(){
    new Movie("BTF","Back to the future",110,"Sci fi",""),
    new Movie("AVT","Avatar",500,"Sci fi","Buenos efectos, pero muy larga..."),
    new Movie("HNL","Hannibal",110,"Terror",""),
    new Movie("ELC","Esperando la carroza",110,"Comedy",""),
    new Movie("ARG","Argentina 1985",110,"Drama",""),
    new Movie("ELP","El padrino",120,"Drama",""),
};
    }

    public static List<Movie> GetAll() => Movies;

    public static void Add(Movie code)
    {
        if (code == null)
        {
            return;
        }
        Movies.Add(code);
    }

    public static Movie? Get(string code) => Movies.FirstOrDefault(x => x.Code.ToLower() == code.ToLower());

    public static void Delete(string code)
    {
        var borrar = Get(code);
        if (borrar == null)
        {
            return;
        }
        Movies.Remove(borrar);
    }
}