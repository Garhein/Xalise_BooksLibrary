using Microsoft.Extensions.DependencyInjection;

namespace Xalise_BooksLibrary.Application.DependencyInjection
{
    /// <summary>
    /// Fournit les méthodes d'extension permettant d'enregistrer les services de la couche application.
    /// </summary>
    public static class ApplicationServiceCollectionExtensions
    {
        /// <summary>
        /// Enregistre les services de la couche application dans la collection de services.
        /// </summary>
        /// <param name="services">Collection de services dans laquelle les dépendances sont enregistrées.</param>
        /// <returns>La collection de services enrichie avec les dépendances de la couche application.</returns>
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            return services;
        }
    }
}
