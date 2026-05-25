using Xalise_BooksLibrary.Domain.Exceptions;

namespace Xalise_BooksLibrary.Domain.Entities
{
    /// <summary>
    /// Représente une catégorie associable à un livre.
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Message utilisé lorsque le nom de la catégorie est absent.
        /// </summary>
        private const string NameRequiredMessage = "Le nom de la catégorie est obligatoire.";

        /// <summary>
        /// Identifiant technique de la catégorie.
        /// </summary>
        public int Id { get; private set; } = 0;

        /// <summary>
        /// Nom de la catégorie.
        /// </summary>
        public string Name { get; private set; } = string.Empty;

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="Category"/>.
        /// </summary>
        /// <param name="name">Nom de la catégorie.</param>
        public Category(string name)
        {
            this.UpdateName(name);
        }

        /// <summary>
        /// Modifie le nom de la catégorie.
        /// </summary>
        /// <param name="name">Nouveau nom de la catégorie.</param>
        /// <exception cref="EntityValidationException">Si <paramref name="name"/> est <see langword="null"/>, vide ou ne contient que des espaces.</exception>
        public void UpdateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new EntityValidationException(Category.NameRequiredMessage);
            }

            this.Name = name.Trim();
        }
    }
}
