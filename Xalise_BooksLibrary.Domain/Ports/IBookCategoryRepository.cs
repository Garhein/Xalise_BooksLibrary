using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xalise_BooksLibrary.Domain.Entities;

namespace Xalise_BooksLibrary.Domain.Ports
{
    /// <summary>
    /// Définit les opérations de persistance disponibles pour les associations entre livres et catégories.
    /// </summary>
    public interface IBookCategoryRepository
    {
        /// <summary>
        /// Récupère les catégories associées à un livre.
        /// </summary>
        /// <param name="bookId">Identifiant technique du livre concerné.</param>
        /// <param name="cancellationToken">Jeton d'annulation de l'opération.</param>
        /// <returns>Associations entre le livre et ses catégories.</returns>
        Task<IReadOnlyCollection<BookCategory>> GetByBookIdAsync(int bookId, CancellationToken cancellationToken);

        /// <summary>
        /// Ajoute une association entre un livre et une catégorie.
        /// </summary>
        /// <param name="bookCategory">Association à ajouter.</param>
        /// <param name="cancellationToken">Jeton d'annulation de l'opération.</param>
        /// <returns>Tâche représentant l'opération asynchrone.</returns>
        Task AddAsync(BookCategory bookCategory, CancellationToken cancellationToken);

        /// <summary>
        /// Supprime physiquement une association entre un livre et une catégorie.
        /// </summary>
        /// <param name="bookCategory">Association à supprimer.</param>
        /// <param name="cancellationToken">Jeton d'annulation de l'opération.</param>
        /// <returns>Tâche représentant l'opération asynchrone.</returns>
        Task DeleteAsync(BookCategory bookCategory, CancellationToken cancellationToken);
    }
}
