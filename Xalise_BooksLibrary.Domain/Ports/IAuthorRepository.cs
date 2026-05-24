using System;
using System.Threading;
using System.Threading.Tasks;
using Xalise_BooksLibrary.Domain.Contracts;
using Xalise_BooksLibrary.Domain.Contracts.Criteria;
using Xalise_BooksLibrary.Domain.Entities;

namespace Xalise_BooksLibrary.Domain.Ports
{
    /// <summary>
    /// Définit les opérations de persistance disponibles pour les auteurs.
    /// </summary>
    public interface IAuthorRepository
    {
        /// <summary>
        /// Recherche les auteurs correspondant aux critères fournis.
        /// </summary>
        /// <param name="criteria">Critères de recherche appliqués aux auteurs.</param>
        /// <param name="cancellationToken">Jeton d'annulation de l'opération.</param>
        /// <returns>Résultat paginé contenant les auteurs trouvés.</returns>
        Task<PagedResult<Author>> SearchAsync(EntitySearchCriteria criteria, CancellationToken cancellationToken);

        /// <summary>
        /// Récupère un auteur à partir de son identifiant technique.
        /// </summary>
        /// <param name="id">Identifiant technique de l'auteur recherché.</param>
        /// <param name="cancellationToken">Jeton d'annulation de l'opération.</param>
        /// <returns>Auteur trouvé, ou <see langword="null"/> si aucun auteur ne correspond.</returns>
        Task<Author?> GetByIdAsync(int id, CancellationToken cancellationToken);

        /// <summary>
        /// Indique si un auteur porte déjà le nom fourni.
        /// </summary>
        /// <param name="name">Nom à contrôler.</param>
        /// <param name="cancellationToken">Jeton d'annulation de l'opération.</param>
        /// <returns><see langword="true"/> si le nom est déjà utilisé, sinon <see langword="false"/>.</returns>
        Task<bool> ExistsByNameAsync(string name, CancellationToken cancellationToken);

        /// <summary>
        /// Ajoute un auteur à la persistance.
        /// </summary>
        /// <param name="author">Auteur à ajouter.</param>
        /// <param name="cancellationToken">Jeton d'annulation de l'opération.</param>
        /// <returns>Tâche représentant l'opération asynchrone.</returns>
        Task AddAsync(Author author, CancellationToken cancellationToken);

        /// <summary>
        /// Met à jour un auteur existant.
        /// </summary>
        /// <param name="author">Auteur contenant les informations à enregistrer.</param>
        /// <param name="cancellationToken">Jeton d'annulation de l'opération.</param>
        /// <returns>Tâche représentant l'opération asynchrone.</returns>
        Task UpdateAsync(Author author, CancellationToken cancellationToken);

        /// <summary>
        /// Supprime physiquement un auteur.
        /// </summary>
        /// <param name="id">Identifiant technique de l'auteur à supprimer.</param>
        /// <param name="cancellationToken">Jeton d'annulation de l'opération.</param>
        /// <returns>Tâche représentant l'opération asynchrone.</returns>
        Task DeleteAsync(int id, CancellationToken cancellationToken);
    }
}
