
using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using awsomAPI.Models;

namespace awsomAPI.Tests
{
  public class CustomWebAppFactory<TStartup> : WebApplicationFactory<Startup>
  {
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
      builder.ConfigureServices( services => 
      {
        ServiceProvider serviceProvider = new ServiceCollection().AddEntityFrameworkInMemoryDatabase().BuildServiceProvider();

        services.AddDbContext<AwsomApiContext>( options => 
        {
          options.UseInMemoryDatabase("MemoryDb");
          options.UseInternalServiceProvider(serviceProvider);
        });

        ServiceProvider sp = services.BuildServiceProvider();

        using (IServiceScope scope = sp.CreateScope())
        {
          IServiceProvider scopedServices = scope.ServiceProvider;
          AwsomApiContext context = scopedServices.GetRequiredService<AwsomApiContext>();
          context.Database.EnsureCreated();
          DbSeed.Populate(context);
        }
      });
    }
  }
}