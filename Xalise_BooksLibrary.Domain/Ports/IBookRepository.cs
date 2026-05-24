using System;
using System.Threading;
using System.Threading.Tasks;
using Xalise_BooksLibrary.Domain.Contracts;
using Xalise_BooksLibrary.Domain.Contracts.Criteria;
using Xalise_BooksLibrary.Domain.Entities;

namespace Xalise_BooksLibrary.Domain.Ports
{
    /// <summary>
    /// Définit les opérations de persistance disponibles pour les livres.
    /// </summary>
    public interface IBookRepository
    {
        /// <summary>
        /// Recherche les livres correspondant aux critères fournis.
        /// </summary>
        /// <param name="criteria">Critères de recherche appliqués aux livres.</param>
        /// <param name="cancellationToken">Jeton d'annulation de l'opération.</param>
        /// <returns>Résultat paginé contenant les livres trouvés.</returns>
        Task<PagedResult<Book>> SearchAsync(BookSearchCriteria criteria, CancellationToken cancellationToken);

        /// <summary>
        /// Récupère un livre à partir de son identifiant technique.
        /// </summary>
        /// <param name="bookId">Identifiant technique du livre recherché.</param>
        /// <param name="cancellationToken">Jeton d'annulation de l'opération.</param>
        /// <returns>Livre trouvé, ou <see langword="null"/> si aucun livre ne correspond.</returns>
        Task<Book?> GetByIdAsync(int bookId, CancellationToken cancellationToken);

        /// <summary>
        /// Indique si un livre est référencé par une association du domaine.
        /// </summary>
        /// <param name="bookId">Identifiant technique du livre à contrôler.</param>
        /// <param name="cancellationToken">Jeton d'annulation de l'opération.</param>
        /// <returns><see langword="true"/> si le livre est référencé, sinon <see langword="false"/>.</returns>
        Task<bool> IsReferencedAsync(int bookId, CancellationToken cancellationToken);

        /// <summary>
        /// Ajoute un livre à la persistance.
        /// </summary>
        /// <param name="book">Livre à ajouter.</param>
        /// <param name="cancellationToken">Jeton d'annulation de l'opération.</param>
        /// <returns>Tâche représentant l'opération asynchrone.</returns>
        Task AddAsync(Book book, CancellationToken cancellationToken);

        /// <summary>
        /// Met à jour un livre existant.
        /// </summary>
        /// <param name="book">Livre contenant les informations à enregistrer.</param>
        /// <param name="cancellationToken">Jeton d'annulation de l'opération.</param>
        /// <returns>Tâche représentant l'opération asynchrone.</returns>
        Task UpdateAsync(Book book, CancellationToken cancellationToken);

        /// <summary>
        /// Supprime physiquement un livre.
        /// </summary>
        /// <param name="bookId">Identifiant technique du livre à supprimer.</param>
        /// <param name="cancellationToken">Jeton d'annulation de l'opération.</param>
        /// <returns>Tâche représentant l'opération asynchrone.</returns>
        Task DeleteAsync(int bookId, CancellationToken cancellationToken);
    }
}
