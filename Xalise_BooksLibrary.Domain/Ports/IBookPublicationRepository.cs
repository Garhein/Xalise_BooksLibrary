using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xalise_BooksLibrary.Domain.Entities;

namespace Xalise_BooksLibrary.Domain.Ports
{
    /// <summary>
    /// Définit les opérations de persistance disponibles pour les publications de livres.
    /// </summary>
    public interface IBookPublicationRepository
    {
        /// <summary>
        /// Récupère les publications associées à un livre.
        /// </summary>
        /// <param name="bookId">Identifiant technique du livre concerné.</param>
        /// <param name="cancellationToken">Jeton d'annulation de l'opération.</param>
        /// <returns>Publications associées au livre.</returns>
        Task<IReadOnlyCollection<BookPublication>> GetByBookIdAsync(int bookId, CancellationToken cancellationToken);

        /// <summary>
        /// Ajoute une publication de livre.
        /// </summary>
        /// <param name="bookPublication">Publication à ajouter.</param>
        /// <param name="cancellationToken">Jeton d'annulation de l'opération.</param>
        /// <returns>Tâche représentant l'opération asynchrone.</returns>
        Task AddAsync(BookPublication bookPublication, CancellationToken cancellationToken);

        /// <summary>
        /// Supprime physiquement une publication de livre.
        /// </summary>
        /// <param name="bookPublication">Publication à supprimer.</param>
        /// <param name="cancellationToken">Jeton d'annulation de l'opération.</param>
        /// <returns>Tâche représentant l'opération asynchrone.</returns>
        Task DeleteAsync(BookPublication bookPublication, CancellationToken cancellationToken);
    }
}
