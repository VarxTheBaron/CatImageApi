using CatImageApi.Data;

public static class CatDbExtensions
{
    public static void SetUpDatabase(this CatDbContext db)
    {
        db.Database.EnsureCreated();
    }
}