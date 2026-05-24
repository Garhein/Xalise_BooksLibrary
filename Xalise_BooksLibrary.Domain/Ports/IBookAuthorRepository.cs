using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xalise_BooksLibrary.Domain.Entities;

namespace Xalise_BooksLibrary.Domain.Ports
{
    /// <summary>
    /// Définit les opérations de persistance disponibles pour les associations entre livres et auteurs.
    /// </summary>
    public interface IBookAuthorRepository
    {
        /// <summary>
        /// Récupère les auteurs associés à un livre.
        /// </summary>
        /// <param name="bookId">Identifiant technique du livre concerné.</param>
        /// <param name="cancellationToken">Jeton d'annulation de l'opération.</param>
        /// <returns>Associations entre le livre et ses auteurs.</returns>
        Task<IReadOnlyCollection<BookAuthor>> GetByBookIdAsync(int bookId, CancellationToken cancellationToken);

        /// <summary>
        /// Ajoute une association entre un livre et un auteur.
        /// </summary>
        /// <param name="bookAuthor">Association à ajouter.</param>
        /// <param name="cancellationToken">Jeton d'annulation de l'opération.</param>
        /// <returns>Tâche représentant l'opération asynchrone.</returns>
        Task AddAsync(BookAuthor bookAuthor, CancellationToken cancellationToken);

        /// <summary>
        /// Supprime physiquement une association entre un livre et un auteur.
        /// </summary>
        /// <param name="bookAuthor">Association à supprimer.</param>
        /// <param name="cancellationToken">Jeton d'annulation de l'opération.</param>
        /// <returns>Tâche représentant l'opération asynchrone.</returns>
        Task DeleteAsync(BookAuthor bookAuthor, CancellationToken cancellationToken);
    }
}
