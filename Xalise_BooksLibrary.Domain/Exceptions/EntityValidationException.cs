namespace Xalise_BooksLibrary.Domain.Exceptions
{
    /// <summary>
    /// Représente l'erreur levée lorsqu'une entité reçoit une valeur invalide.
    /// </summary>
    public class EntityValidationException : DomainException
    {
        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="EntityValidationException"/>.
        /// </summary>
        /// <param name="message">Message décrivant la valeur invalide.</param>
        public EntityValidationException(string message) : base(message) { }
    }
}
