using Xalise_BooksLibrary.Domain.Exceptions;

namespace Xalise_BooksLibrary.Domain.Entities
{
    /// <summary>
    /// Représente un auteur référencé dans la bibliothèque.
    /// </summary>
    public class Author
    {
        /// <summary>
        /// Message utilisé lorsque le prénom de l'auteur est absent.
        /// </summary>
        private const string FirstNameRequiredMessage = "Le prénom de l'auteur est obligatoire.";

        /// <summary>
        /// Message utilisé lorsque le nom de famille de l'auteur est absent.
        /// </summary>
        private const string LastNameRequiredMessage = "Le prénom de l'auteur est obligatoire.";

        /// <summary>
        /// Identifiant technique de l'auteur.
        /// </summary>
        public int Id { get; private set; } = 0;

        /// <summary>
        /// Prénom de l'auteur.
        /// </summary>
        public string FirstName { get; private set; } = string.Empty;

        /// <summary>
        /// Nom de famille de l'auteur.
        /// </summary>
        public string LastName { get; private set; } = string.Empty;

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="Author"/>.
        /// </summary>
        /// <param name="firstName">Nom de l'auteur.</param>
        /// <param name="lastName">Nom de famille de l'auteur.</param>
        public Author(string firstName, string lastName)
        {
            this.Rename(firstName, lastName);
        }

        /// <summary>
        /// Modifie le prénom et le nom de famille de l'auteur.
        /// </summary>
        /// <param name="firstName">Nouveau prénom de l'auteur.</param>
        /// <param name="lastName">Nouveau nom de famille de l'auteur.</param>
        /// <exception cref="EntityValidationException">Si <paramref name="firstName"/> ou <paramref name="lastName"/> est <see langword="null"/>, vide ou ne contient que des espaces.</exception>
        public void Rename(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new EntityValidationException(Author.FirstNameRequiredMessage);
            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                throw new EntityValidationException(Author.LastNameRequiredMessage);
            }

            this.FirstName = firstName.Trim();
            this.LastName  = lastName.Trim();
        }
    }
}
