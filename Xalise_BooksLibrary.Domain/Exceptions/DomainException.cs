using System;

namespace Xalise_BooksLibrary.Domain.Exceptions
{
    /// <summary>
    /// Représente l'exception de base des erreurs métier du domaine.
    /// </summary>
    public class DomainException : Exception
    {
        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="DomainException"/>.
        /// </summary>
        /// <param name="message">Message décrivant l'erreur métier.</param>
        public DomainException(string message) : base(message) { }
    }
}
