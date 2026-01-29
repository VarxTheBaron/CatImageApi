namespace CatImageApi.Models;

public class GetCatFactResponse
{
    public string Fact { get; set; } = string.Empty;

    public GetCatFactResponse() { }

    public GetCatFactResponse(CatFact catFact)
    {
        Fact = catFact.Fact;
    }
}