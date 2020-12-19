using BoilerplateConsole.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;

namespace BoilerplateConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Console.Out.WriteLineAsync("Hello World (from advanced template)!");


            Console.ReadLine();
        }

        static IHostBuilder CreateDefaultBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureServices((context, services) =>
		        services.AddDbContext<BoilerplateConsoleDbContext>(options =>
		        {
			        options.UseSqlServer(context.Configuration.GetConnectionString("DefaultConnection"));
		        }
		           ));
    }
}
