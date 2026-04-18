public static AppDbContext CreateEmptyContext(string dbName)
{
    var options = new DbContextOptionsBuilder<AppDbContext>()
        .UseInMemoryDatabase(databaseName: dbName)
        .Options;

    var context = new AppDbContext(options);

    context.Database.EnsureDeleted();
    context.Database.EnsureCreated(); // 🔥 ESTA LÍNEA ES LA CLAVE

    return context;
}
