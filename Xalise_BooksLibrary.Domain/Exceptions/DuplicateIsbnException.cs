namespace Xalise_BooksLibrary.Domain.Exceptions
{
    /// <summary>
    /// Représente l'erreur levée lorsqu'un ISBN est déjà utilisé par un autre livre.
    /// </summary>
    public class DuplicateIsbnException : DomainException
    {
        /// <summary>
        /// Message utilisé lorsqu'un ISBN est déjà enregistré.
        /// </summary>
        private const string DuplicateIsbnMessage = "L'ISBN indiqué est déjà associé à un livre existant.";

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="DuplicateIsbnException"/>.
        /// </summary>
        public DuplicateIsbnException() : base(DuplicateIsbnException.DuplicateIsbnMessage) { }
    }
}
