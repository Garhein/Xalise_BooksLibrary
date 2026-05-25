using Xalise_BooksLibrary.Domain.Exceptions;

namespace Xalise_BooksLibrary.Domain.Entities
{
    /// <summary>
    /// Représente un livre géré par la bibliothèque.
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Message utilisé lorsque le titre est absent.
        /// </summary>
        private const string TitleRequiredMessage = "Le titre du livre est obligatoire.";

        /// <summary>
        /// Identifiant technique du livre.
        /// </summary>
        public int Id { get; private set; } = 0;

        /// <summary>
        /// Titre du livre.
        /// </summary>
        public string Title { get; private set; } = string.Empty;

        /// <summary>
        /// Résumé du livre.
        /// </summary>
        public string? Summary { get; private set; } = string.Empty;

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="Book"/>.
        /// </summary>
        /// <param name="title">Titre du livre.</param>
        /// <param name="summary">Résumé du livre.</param>
        public Book(string title, string summary)
        {
            this.Update(title, summary);
        }

        /// <summary>
        /// Modifie les informations du livre.
        /// </summary>
        /// <param name="title">Titre du livre.</param>
        /// <param name="summary">Résumé du livre.</param>
        public void Update(string title, string summary)
        {
            this.UpdateTitle(title);
            this.UpdateSummary(summary);
        }

        /// <summary>
        /// Modifie le titre du livre.
        /// </summary>
        /// <param name="title">Nouveau titre du livre.</param>
        /// <exception cref="EntityValidationException">Si <paramref name="title"/> est <see langword="null"/>, vide ou ne contient que des espaces.</exception>
        public void UpdateTitle(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new EntityValidationException(Book.TitleRequiredMessage);
            }

            this.Title = title.Trim();
        }

        /// <summary>
        /// Modifie le résumé du livre.
        /// </summary>
        /// <param name="summary">Nouveau résumé du livre, ou <see langword="null"/> si aucun résumé n'est renseigné.</param>
        public void UpdateSummary(string? summary)
        {
            this.Summary = string.IsNullOrWhiteSpace(summary) ? null : summary.Trim();
        }
    }
}
