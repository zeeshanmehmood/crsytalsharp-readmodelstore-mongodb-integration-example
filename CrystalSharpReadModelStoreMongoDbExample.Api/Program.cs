using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CrystalSharp;
using CrystalSharp.MongoDb.Extensions;
using CrystalSharp.MsSql.Extensions;
using CrystalSharp.MsSql.Migrator;
using CrystalSharpReadModelStoreMongoDbExample.Application.CommandHandlers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string eventStoreConnectionString = builder.Configuration.GetConnectionString("AppEventStoreConnectionString");
string readModelStoreConnectionString = builder.Configuration.GetConnectionString("AppReadModelStoreConnectionString");
string readModelStoreDatabase = "crystalsharp-readmodelstore-example";
MsSqlSettings eventStoreDbSettings = new(eventStoreConnectionString);
MongoDbSettings readModelStoreDbSettings = new(readModelStoreConnectionString, readModelStoreDatabase);

IResolver resolver = CrystalSharpAdapter.New(builder.Services)
    .AddCqrs(typeof(PlaceOrderCommandHandler))
    .AddMsSqlEventStoreDb<int>(eventStoreDbSettings)
    .AddMongoDbReadModelStore(readModelStoreDbSettings)
    .CreateResolver();

IMsSqlDatabaseMigrator databaseMigrator = resolver.Resolve<IMsSqlDatabaseMigrator>();

MsSqlEventStoreSetup.Run(databaseMigrator, eventStoreDbSettings.ConnectionString).Wait();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
