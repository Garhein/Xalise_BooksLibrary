using System;
using System.Threading;
using System.Threading.Tasks;
using Xalise_BooksLibrary.Domain.Contracts;
using Xalise_BooksLibrary.Domain.Contracts.Criteria;
using Xalise_BooksLibrary.Domain.Entities;

namespace Xalise_BooksLibrary.Domain.Ports
{
    /// <summary>
    /// Définit les opérations de persistance disponibles pour les catégories.
    /// </summary>
    public interface ICategoryRepository
    {
        /// <summary>
        /// Recherche les catégories correspondant aux critères fournis.
        /// </summary>
        /// <param name="criteria">Critères de recherche appliqués aux catégories.</param>
        /// <param name="cancellationToken">Jeton d'annulation de l'opération.</param>
        /// <returns>Résultat paginé contenant les catégories trouvées.</returns>
        Task<PagedResult<Category>> SearchAsync(EntitySearchCriteria criteria, CancellationToken cancellationToken);

        /// <summary>
        /// Récupère une catégorie à partir de son identifiant technique.
        /// </summary>
        /// <param name="categoryId">Identifiant technique de la catégorie recherchée.</param>
        /// <param name="cancellationToken">Jeton d'annulation de l'opération.</param>
        /// <returns>Catégorie trouvée, ou <see langword="null"/> si aucune catégorie ne correspond.</returns>
        Task<Category?> GetByIdAsync(int categoryId, CancellationToken cancellationToken);

        /// <summary>
        /// Indique si une catégorie porte déjà le nom fourni.
        /// </summary>
        /// <param name="name">Nom à contrôler.</param>
        /// <param name="cancellationToken">Jeton d'annulation de l'opération.</param>
        /// <returns><see langword="true"/>si le nom est déjà utilisé, sinon <see langword="false"/>.</returns>
        Task<bool> ExistsByNameAsync(string name, CancellationToken cancellationToken);

        /// <summary>
        /// Ajoute une catégorie à la persistance.
        /// </summary>
        /// <param name="category">Catégorie à ajouter.</param>
        /// <param name="cancellationToken">Jeton d'annulation de l'opération.</param>
        /// <returns>Tâche représentant l'opération asynchrone.</returns>
        Task AddAsync(Category category, CancellationToken cancellationToken);

        /// <summary>
        /// Met à jour une catégorie existante.
        /// </summary>
        /// <param name="category">Catégorie contenant les informations à enregistrer.</param>
        /// <param name="cancellationToken">Jeton d'annulation de l'opération.</param>
        /// <returns>Tâche représentant l'opération asynchrone.</returns>
        Task UpdateAsync(Category category, CancellationToken cancellationToken);

        /// <summary>
        /// Supprime physiquement une catégorie.
        /// </summary>
        /// <param name="categoryId">Identifiant technique de la catégorie à supprimer.</param>
        /// <param name="cancellationToken">Jeton d'annulation de l'opération.</param>
        /// <returns>Tâche représentant l'opération asynchrone.</returns>
        Task DeleteAsync(int categoryId, CancellationToken cancellationToken);
    }
}
