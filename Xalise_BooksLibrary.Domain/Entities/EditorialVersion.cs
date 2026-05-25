using Xalise_BooksLibrary.Domain.Exceptions;

namespace Xalise_BooksLibrary.Domain.Entities
{
    /// <summary>
    /// Représente une version éditoriale d'une publication.
    /// </summary>
    public class EditorialVersion
    {
        /// <summary>
        /// Message utilisé lorsque le nom de la version éditoriale est absent.
        /// </summary>
        private const string NameRequiredMessage = "Le nom de la version éditoriale est obligatoire.";

        /// <summary>
        /// Identifiant technique de la version éditoriale.
        /// </summary>
        public int Id { get; private set; } = 0;

        /// <summary>
        /// Nom de la version éditoriale.
        /// </summary>
        public string Name { get; private set; } = string.Empty;

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="EditorialVersion"/>.
        /// </summary>
        /// <param name="name">Nom de la version éditoriale.</param>
        public EditorialVersion(string name)
        {
            this.UpdateName(name);
        }

        /// <summary>
        /// Modifie le nom de la version éditoriale.
        /// </summary>
        /// <param name="name">Nouveau nom de la version éditoriale.</param>
        /// <exception cref="EntityValidationException">Si <paramref name="name"/> est <see langword="null"/>, vide ou ne contient que des espaces.</exception>
        public void UpdateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new EntityValidationException(EditorialVersion.NameRequiredMessage);
            }

            this.Name = name.Trim();
        }
    }
}
