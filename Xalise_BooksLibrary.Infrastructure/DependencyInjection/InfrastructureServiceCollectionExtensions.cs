using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Xalise_BooksLibrary.Infrastructure.DependencyInjection
{
    /// <summary>
    /// Fournit les méthodes d'extension permettant d'enregistrer les services de la couche infrastructure.
    /// </summary>
    public static class InfrastructureServiceCollectionExtensions
    {
        /// <summary>
        /// Enregistre les services de la couche infrastructure dans la collection de services.
        /// </summary>
        /// <param name="services">Collection de services dans laquelle les dépendances sont enregistrées.</param>
        /// <param name="configuration">Configuration utilisée pour paramétrer les dépendances techniques.</param>
        /// <returns>La collection de services enrichie avec les dépendances de la couche infrastructure.</returns>
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            ArgumentNullException.ThrowIfNull(configuration);

            return services;
        }
    }
}
