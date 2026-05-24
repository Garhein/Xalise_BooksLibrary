using Xalise_BooksLibrary.Domain.Exceptions;

namespace Xalise_BooksLibrary.Domain.Entities
{
    /// <summary>
    /// Représente l'association entre un livre et un auteur.
    /// </summary>
    public class BookAuthor
    {
        /// <summary>
        /// Message utilisé lorsque l'identifiant du livre est absent.
        /// </summary>
        private const string BookIdRequiredMessage = "L'identifiant du livre est obligatoire.";

        /// <summary>
        /// Message utilisé lorsque l'identifiant de l'auteur est absent.
        /// </summary>
        private const string AuthorIdRequiredMessage = "L'identifiant de l'auteur est obligatoire.";

        /// <summary>
        /// Identifiant technique du livre associé.
        /// </summary>
        public int BookId { get; private set; }

        /// <summary>
        /// Identifiant technique de l'auteur associé.
        /// </summary>
        public int AuthorId { get; private set; }

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="BookAuthor"/>.
        /// </summary>
        /// <param name="bookId">Identifiant technique du livre associé.</param>
        /// <param name="authorId">Identifiant technique de l'auteur associé.</param>
        public BookAuthor(int bookId, int authorId)
        {
            this.Update(bookId, authorId);
        }

        /// <summary>
        /// Modifie les informations de l'association.
        /// </summary>
        /// <param name="bookId">Identifiant technique du livre associé.</param>
        /// <param name="authorId">Identifiant technique de l'auteur associé.</param>
        public void Update(int bookId, int authorId)
        {
            this.ChangeBookId(bookId);
            this.ChangeAuthorId(authorId);
        }

        /// <summary>
        /// Modifie l'identifiant du livre.
        /// </summary>
        /// <param name="bookId">Identifiant du livre.</param>
        /// <exception cref="EntityValidationException">Si <paramref name="bookId"/> est inférieur ou égal à 0.</exception>
        public void ChangeBookId(int bookId)
        {
            if (bookId <= 0)
            {
                throw new EntityValidationException(BookAuthor.BookIdRequiredMessage);
            }

            this.BookId = bookId;
        }

        /// <summary>
        /// Modifie l'identifiant de l'auteur.
        /// </summary>
        /// <param name="authorId">Identifiant de l'auteur.</param>
        /// <exception cref="EntityValidationException">Si <paramref name="authorId"/> est inférieur ou égal à 0.</exception>
        public void ChangeAuthorId(int authorId)
        {
            if (authorId <= 0)
            {
                throw new EntityValidationException(BookAuthor.AuthorIdRequiredMessage);
            }

            this.AuthorId = authorId;
        }
    }
}
