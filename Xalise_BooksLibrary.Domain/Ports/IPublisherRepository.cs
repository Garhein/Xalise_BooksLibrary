using System;
using System.Threading;
using System.Threading.Tasks;
using Xalise_BooksLibrary.Domain.Contracts;
using Xalise_BooksLibrary.Domain.Contracts.Criteria;
using Xalise_BooksLibrary.Domain.Entities;

namespace Xalise_BooksLibrary.Domain.Ports
{
    /// <summary>
    /// Définit les opérations de persistance disponibles pour les maisons d'édition.
    /// </summary>
    public interface IPublisherRepository
    {
        /// <summary>
        /// Recherche les maisons d'édition correspondant aux critères fournis.
        /// </summary>
        /// <param name="criteria">Critères de recherche appliqués aux maisons d'édition.</param>
        /// <param name="cancellationToken">Jeton d'annulation de l'opération.</param>
        /// <returns>Résultat paginé contenant les maisons d'édition trouvées.</returns>
        Task<PagedResult<Publisher>> SearchAsync(EntitySearchCriteria criteria, CancellationToken cancellationToken);

        /// <summary>
        /// Récupère une maison d'édition à partir de son identifiant technique.
        /// </summary>
        /// <param name="publisherId">Identifiant technique de la maison d'édition recherchée.</param>
        /// <param name="cancellationToken">Jeton d'annulation de l'opération.</param>
        /// <returns>Maison d'édition trouvée, ou <see langword="null"/> si aucune maison ne correspond.</returns>
        Task<Publisher?> GetByIdAsync(int publisherId, CancellationToken cancellationToken);

        /// <summary>
        /// Indique si une maison d'édition porte déjà le nom fourni.
        /// </summary>
        /// <param name="name">Nom à contrôler.</param>
        /// <param name="cancellationToken">Jeton d'annulation de l'opération.</param>
        /// <returns><see langword="true"/> si le nom est déjà utilisé, sinon <see langword="false"/>.</returns>
        Task<bool> ExistsByNameAsync(string name, CancellationToken cancellationToken);

        /// <summary>
        /// Ajoute une maison d'édition à la persistance.
        /// </summary>
        /// <param name="publisher">Maison d'édition à ajouter.</param>
        /// <param name="cancellationToken">Jeton d'annulation de l'opération.</param>
        /// <returns>Tâche représentant l'opération asynchrone.</returns>
        Task AddAsync(Publisher publisher, CancellationToken cancellationToken);

        /// <summary>
        /// Met à jour une maison d'édition existante.
        /// </summary>
        /// <param name="publisher">Maison d'édition contenant les informations à enregistrer.</param>
        /// <param name="cancellationToken">Jeton d'annulation de l'opération.</param>
        /// <returns>Tâche représentant l'opération asynchrone.</returns>
        Task UpdateAsync(Publisher publisher, CancellationToken cancellationToken);

        /// <summary>
        /// Supprime physiquement une maison d'édition.
        /// </summary>
        /// <param name="publisherId">Identifiant technique de la maison d'édition à supprimer.</param>
        /// <param name="cancellationToken">Jeton d'annulation de l'opération.</param>
        /// <returns>Tâche représentant l'opération asynchrone.</returns>
        Task DeleteAsync(int publisherId, CancellationToken cancellationToken);
    }
}
