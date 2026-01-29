namespace CatImageApi.Models;

public class GetCatResponse
{
    public string Url { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public GetCatResponse() { }

    public GetCatResponse(Cat? cat)
    {
        if (cat == null) return;

        Url = cat.Url;
        Description = cat.Description;
    }
}