namespace CatImageApi.Models;

public class CatFact
{
    public int Id { get; set; }
    public string Fact { get; set; } = string.Empty;
    public int? BreedID { get; set; }
}