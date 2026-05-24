namespace Xalise_BooksLibrary.Domain.Exceptions
{
    /// <summary>
    /// Représente l'erreur levée lorsqu'un livre référencé ne peut pas être supprimé.
    /// </summary>
    public class ReferencedBookDeletionException : DomainException
    {
        /// <summary>
        /// Message utilisé lorsqu'un livre est encore référencé.
        /// </summary>
        private const string ReferencedBookDeletionMessage = "Le livre ne peut pas être supprimé car il est encore référencé.";

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="ReferencedBookDeletionException"/>.
        /// </summary>
        public ReferencedBookDeletionException() : base(ReferencedBookDeletionException.ReferencedBookDeletionMessage) { }
    }
}
