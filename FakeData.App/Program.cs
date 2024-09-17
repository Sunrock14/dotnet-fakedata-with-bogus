using FakeData.App.Fakers;
using FakeData.App.Models;
using FakeData.App.Utils;
using FakeData.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((hostContext, services) =>
    {
        services.AddDbContext<FakerContext>((serviceProvider, options) =>
        {
            var configuration = serviceProvider.GetRequiredService<IConfiguration>();
            //string conn = configuration.GetConnectionString("Server=localhost,1433; Database=FakerApp; User Id=sa; Password=216Fmby216fk; Trusted_Connection=False; TrustServerCertificate=True; Integrated Security=False; Connect Timeout=30; MultipleActiveResultSets=True;");
            string conn = "Server=localhost,1433; Database=FakerApp; User Id=sa; Password=216Fmby216fk; Trusted_Connection=False; TrustServerCertificate=True; Integrated Security=False; Connect Timeout=30; MultipleActiveResultSets=True;";
            options.UseSqlServer(conn);
        });

        services.AddTransient<DataGenerator>();
    })
    .Build();

using (var scope = host.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<FakerContext>();

    services.GetRequiredService<DataGenerator>();

    var products = DataGenerator.GenerateByCount<Product, ProductFaker>(100);

    context.SaveChanges();
}

Console.WriteLine("Veritabanı oluşturuldu, migration'lar uygulandı ve veriler eklendi!");
