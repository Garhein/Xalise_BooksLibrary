using Xalise_BooksLibrary.Domain.Exceptions;

namespace Xalise_BooksLibrary.Domain.Entities
{
    /// <summary>
    /// Représente l'association entre un livre et une catégorie.
    /// </summary>
    public class BookCategory
    {
        /// <summary>
        /// Message utilisé lorsque l'identifiant du livre est absent.
        /// </summary>
        private const string BookIdRequiredMessage = "L'identifiant du livre est obligatoire.";

        /// <summary>
        /// Message utilisé lorsque l'identifiant de la catégorie est absent.
        /// </summary>
        private const string CategoryIdRequiredMessage = "L'identifiant de la catégorie est obligatoire.";

        /// <summary>
        /// Identifiant technique du livre associé.
        /// </summary>
        public int BookId { get; private set; }

        /// <summary>
        /// Identifiant technique de la catégorie associée.
        /// </summary>
        public int CategoryId { get; private set; }

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="BookCategory"/>.
        /// </summary>
        /// <param name="bookId">Identifiant technique du livre associé.</param>
        /// <param name="categoryId">Identifiant technique de la catégorie associée.</param>
        public BookCategory(int bookId, int categoryId)
        {
            this.Update(bookId, categoryId);
        }

        /// <summary>
        /// Modifie les informations de la liaison.
        /// </summary>
        /// <param name="bookId">Identifiant technique du livre associé.</param>
        /// <param name="categoryId">Identifiant technique de la catégorie associée.</param>
        public void Update(int bookId, int categoryId)
        {
            this.UpdateBookId(bookId);
            this.UpdateCategoryId(categoryId);
        }

        /// <summary>
        /// Modifie l'identifiant du livre associé.
        /// </summary>
        /// <param name="bookId">Identifiant du livre associé.</param>
        /// <exception cref="EntityValidationException">Si <paramref name="bookId"/> est inférieur ou égal à 0.</exception>
        public void UpdateBookId(int bookId)
        {
            if (bookId <= 0)
            {
                throw new EntityValidationException(BookCategory.BookIdRequiredMessage);
            }

            this.BookId = bookId;
        }

        /// <summary>
        /// Modifie l'identifiant de la catégorie associée.
        /// </summary>
        /// <param name="categoryId">Identifiant de la catégorie associée.</param>
        /// <exception cref="EntityValidationException">Si <paramref name="categoryId"/> est inférieur ou égal à 0.</exception>
        public void UpdateCategoryId(int categoryId)
        {
            if (categoryId <= 0)
            {
                throw new EntityValidationException(BookCategory.CategoryIdRequiredMessage);
            }

            this.CategoryId = categoryId;
        }
    }
}
