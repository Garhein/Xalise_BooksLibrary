using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Xalise_BooksLibrary.Application.DependencyInjection;
using Xalise_BooksLibrary.Infrastructure.DependencyInjection;

namespace Xalise_BooksLibrary.Web
{
    /// <summary>
    /// Représente le point d'entrée de l'application web.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Nom du dossier contenant les données locales de l'application web.
        /// </summary>
        private const string AppDataDirectoryName = "App_Data";

        /// <summary>
        /// Nom du dossier contenant les clés de protection des données.
        /// </summary>
        private const string DataProtectionKeysDirectoryName = "DataProtectionKeys";

        /// <summary>
        /// Configure les services, prépare le pipeline HTTP et démarre l'application web.
        /// </summary>
        /// <param name="args">Arguments transmis par le processus au démarrage de l'application.</param>
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

            builder.Logging.ClearProviders();
            builder.Logging.AddConsole();

            string dataProtectionKeysPath = Program.CreateDataProtectionKeysPath(builder.Environment);

            builder.Services.AddRazorPages();
            builder.Services.AddDataProtection()
                            .PersistKeysToFileSystem(new DirectoryInfo(dataProtectionKeysPath));

            builder.Services.AddApplicationServices()
                            .AddInfrastructureServices(builder.Configuration);

            WebApplication app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapRazorPages()
               .WithStaticAssets();

            app.Run();
        }

        /// <summary>
        /// Crée le dossier local dans lequel ASP.NET Core stocke les clés de protection des données.
        /// </summary>
        /// <param name="environment">Environnement d'hébergement utilisé pour localiser le dossier racine de l'application.</param>
        /// <returns>Chemin complet du dossier destiné aux clés de protection des données.</returns>
        private static string CreateDataProtectionKeysPath(IWebHostEnvironment environment)
        {
            string dataProtectionKeysPath = Path.Combine(
                environment.ContentRootPath,
                Program.AppDataDirectoryName,
                Program.DataProtectionKeysDirectoryName
            );

            Directory.CreateDirectory(dataProtectionKeysPath);

            return dataProtectionKeysPath;
        }
    }
}
