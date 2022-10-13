// See https://aka.ms/new-console-template for more information
using DGLI.PrisonVan.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = Host.CreateDefaultBuilder(args);
host.ConfigureServices(services =>
{
    services.AddDbContext<IUnitOfWork, UnitOfWork>(opts => opts.UseSqlite(@$"DataSource=database.db"));
});

await host.RunConsoleAsync();