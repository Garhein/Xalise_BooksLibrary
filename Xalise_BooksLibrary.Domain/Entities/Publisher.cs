using Xalise_BooksLibrary.Domain.Exceptions;

namespace Xalise_BooksLibrary.Domain.Entities
{
    /// <summary>
    /// Représente une maison d'édition.
    /// </summary>
    public class Publisher
    {
        /// <summary>
        /// Message utilisé lorsque le nom de la maison d'édition est absent.
        /// </summary>
        private const string NameRequiredMessage = "Le nom de la maison d'édition est obligatoire.";

        /// <summary>
        /// Identifiant technique de la maison d'édition.
        /// </summary>
        public int Id { get; private set; } = 0;

        /// <summary>
        /// Nom de la maison d'édition.
        /// </summary>
        public string Name { get; private set; } = string.Empty;

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="Publisher"/>.
        /// </summary>
        /// <param name="name">Nom de la maison d'édition.</param>
        public Publisher(string name)
        {
            this.UpdateName(name);
        }

        /// <summary>
        /// Modifie le nom de la maison d'édition.
        /// </summary>
        /// <param name="name">Nouveau nom de la maison d'édition.</param>
        /// <exception cref="EntityValidationException">Si <paramref name="name"/> est <see langword="null"/>, vide ou ne contient que des espaces.</exception>
        public void UpdateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new EntityValidationException(Publisher.NameRequiredMessage);
            }

            this.Name = name.Trim();
        }
    }
}
