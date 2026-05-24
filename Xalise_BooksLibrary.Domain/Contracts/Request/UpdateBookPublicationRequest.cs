using System;

namespace Xalise_BooksLibrary.Domain.Contracts.Request
{
    /// <summary>
    /// Regroupe les informations nécessaires à la modification d'une publication d'un livre
    /// par une maison d'édition dans une version éditoriale.
    /// </summary>
    public class UpdateBookPublicationRequest
    {
        /// <summary>
        /// Identifiant technique du livre publié.
        /// </summary>
        public int BookId { get; set; } = 0;

        /// <summary>
        /// Identifiant technique de la maison d'édition.
        /// </summary>
        public int PublisherId { get; set; } = 0;

        /// <summary>
        /// Identifiant technique de la version éditoriale.
        /// </summary>
        public int EditorialVersionId { get; set; } = 0;

        /// <summary>
        /// ISBN du livre.
        /// </summary>
        public string Isbn { get; set; } = string.Empty;

        /// <summary>
        /// Date de publication.
        /// </summary>
        /// <remarks>Représente uniquement la date civile (sans composante horaire).</remarks>
        public DateOnly PublicationDate { get; set; } = default;
    }
}
