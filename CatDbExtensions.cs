using CatImageApi.Data;

public static class CatDbExtensions
{
    public static void SetUpDatabase(this CatDbContext db, bool deleteDb = false)
    {
        if (deleteDb == true) db.Database.EnsureDeleted();
        db.Database.EnsureCreated();
    }
}