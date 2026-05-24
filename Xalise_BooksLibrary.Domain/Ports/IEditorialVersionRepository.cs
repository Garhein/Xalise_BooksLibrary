using System;
using System.Threading;
using System.Threading.Tasks;
using Xalise_BooksLibrary.Domain.Contracts;
using Xalise_BooksLibrary.Domain.Contracts.Criteria;
using Xalise_BooksLibrary.Domain.Entities;

namespace Xalise_BooksLibrary.Domain.Ports
{
    /// <summary>
    /// Définit les opérations de persistance disponibles pour les versions éditoriales.
    /// </summary>
    public interface IEditorialVersionRepository
    {
        /// <summary>
        /// Recherche les versions éditoriales correspondant aux critères fournis.
        /// </summary>
        /// <param name="criteria">Critères de recherche appliqués aux versions éditoriales.</param>
        /// <param name="cancellationToken">Jeton d'annulation de l'opération.</param>
        /// <returns>Résultat paginé contenant les versions éditoriales trouvées.</returns>
        Task<PagedResult<EditorialVersion>> SearchAsync(EntitySearchCriteria criteria, CancellationToken cancellationToken);

        /// <summary>
        /// Récupère une version éditoriale à partir de son identifiant technique.
        /// </summary>
        /// <param name="editorialVersionId">Identifiant technique de la version éditoriale recherchée.</param>
        /// <param name="cancellationToken">Jeton d'annulation de l'opération.</param>
        /// <returns>Version éditoriale trouvée, ou <see langword="null"/> si aucune version ne correspond.</returns>
        Task<EditorialVersion?> GetByIdAsync(int editorialVersionId, CancellationToken cancellationToken);

        /// <summary>
        /// Indique si une version éditoriale porte déjà le nom fourni.
        /// </summary>
        /// <param name="name">Nom à contrôler.</param>
        /// <param name="cancellationToken">Jeton d'annulation de l'opération.</param>
        /// <returns><see langword="true"/> si le nom est déjà utilisé, sinon <see langword="false"/>.</returns>
        Task<bool> ExistsByNameAsync(string name, CancellationToken cancellationToken);

        /// <summary>
        /// Ajoute une version éditoriale à la persistance.
        /// </summary>
        /// <param name="editorialVersion">Version éditoriale à ajouter.</param>
        /// <param name="cancellationToken">Jeton d'annulation de l'opération.</param>
        /// <returns>Tâche représentant l'opération asynchrone.</returns>
        Task AddAsync(EditorialVersion editorialVersion, CancellationToken cancellationToken);

        /// <summary>
        /// Met à jour une version éditoriale existante.
        /// </summary>
        /// <param name="editorialVersion">Version éditoriale contenant les informations à enregistrer.</param>
        /// <param name="cancellationToken">Jeton d'annulation de l'opération.</param>
        /// <returns>Tâche représentant l'opération asynchrone.</returns>
        Task UpdateAsync(EditorialVersion editorialVersion, CancellationToken cancellationToken);

        /// <summary>
        /// Supprime physiquement une version éditoriale.
        /// </summary>
        /// <param name="editorialVersionId">Identifiant technique de la version éditoriale à supprimer.</param>
        /// <param name="cancellationToken">Jeton d'annulation de l'opération.</param>
        /// <returns>Tâche représentant l'opération asynchrone.</returns>
        Task DeleteAsync(int editorialVersionId, CancellationToken cancellationToken);
    }
}
