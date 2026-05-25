using System;
using Xalise_BooksLibrary.Domain.Contracts.Request;
using Xalise_BooksLibrary.Domain.Exceptions;

namespace Xalise_BooksLibrary.Domain.Entities
{
    /// <summary>
    /// Représente la publication d'un livre par une maison d'édition dans une version éditoriale.
    /// </summary>
    public class BookPublication
    {
        #region Messages d'erreur

        /// <summary>
        /// Message utilisé lorsque l'identifiant du livre est absent.
        /// </summary>
        private const string BookIdRequiredMessage = "L'identifiant du livre est obligatoire.";

        /// <summary>
        /// Message utilisé lorsque l'identifiant de la maison d'édition est absent.
        /// </summary>
        private const string PublisherIdRequiredMessage = "L'identifiant de la maison d'édition est obligatoire.";

        /// <summary>
        /// Message utilisé lorsque l'identifiant de la version éditoriale est absent.
        /// </summary>
        private const string EditorialVersionIdRequiredMessage = "L'identifiant de la version éditoriale est obligatoire.";

        /// <summary>
        /// Message utilisé lorsque la date de publication est absente.
        /// </summary>
        private const string PublicationDateRequiredMessage = "La date de publication est obligatoire.";

        /// <summary>
        /// Message utilisé lorsque l'ISBN est absent.
        /// </summary>
        private const string IsbnRequiredMessage = "L'ISBN du livre est obligatoire.";

        #endregion

        /// <summary>
        /// Identifiant technique du livre publié.
        /// </summary>
        public int BookId { get; private set; }

        /// <summary>
        /// Identifiant technique de la maison d'édition.
        /// </summary>
        public int PublisherId { get; private set; }

        /// <summary>
        /// ISBN du livre.
        /// </summary>
        public string Isbn { get; private set; } = string.Empty;

        /// <summary>
        /// Identifiant technique de la version éditoriale.
        /// </summary>
        public int EditorialVersionId { get; private set; }

        /// <summary>
        /// Date de publication.
        /// </summary>
        /// <remarks>Représente uniquement la date civile (sans composante horaire).</remarks>
        public DateOnly PublicationDate { get; private set; }

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="BookPublication"/>.
        /// </summary>
        /// <param name="request">Informations nécessaires à la création de la publication.</param>
        /// <exception cref="ArgumentNullException">Si <paramref name="request"/> est <see langword="null"/>.</exception>
        public BookPublication(CreateBookPublicationRequest request)
        {
            ArgumentNullException.ThrowIfNull(request);

            this.Update(
                new UpdateBookPublicationRequest
                {
                    BookId              = request.BookId,
                    PublisherId         = request.PublisherId,
                    EditorialVersionId  = request.EditorialVersionId,
                    Isbn                = request.Isbn,
                    PublicationDate     = request.PublicationDate
                }
            );
        }

        /// <summary>
        /// Modifie les informations de la publication.
        /// </summary>
        /// <param name="request">Information à appliquer à la publication.</param>
        /// <exception cref="ArgumentNullException">Si <paramref name="request"/> est <see langword="null"/>.</exception>
        public void Update(UpdateBookPublicationRequest request)
        {
            ArgumentNullException.ThrowIfNull(request);

            this.UpdateBookId(request.BookId);
            this.UpdatePublisherId(request.PublisherId);
            this.UpdateEditorialVersionId(request.EditorialVersionId);
            this.UpdateIsbn(request.Isbn);
            this.UpdatePublicationDate(request.PublicationDate);
        }

        /// <summary>
        /// Modifie l'identifiant du livre publié.
        /// </summary>
        /// <param name="bookId">Identifiant du livre publié.</param>
        /// <exception cref="EntityValidationException">Si <paramref name="bookId"/> est inférieur ou égal à 0.</exception>
        public void UpdateBookId(int bookId)
        {
            if (bookId <= 0)
            {
                throw new EntityValidationException(BookPublication.BookIdRequiredMessage);
            }

            this.BookId = bookId;
        }

        /// <summary>
        /// Modifie l'identifiant de la maison d'édition.
        /// </summary>
        /// <param name="publisherId">Identifiant de la maison d'édition.</param>
        /// <exception cref="EntityValidationException">Si <paramref name="publisherId"/> est inférieur ou égal à 0.</exception>
        public void UpdatePublisherId(int publisherId)
        {
            if (publisherId <= 0)
            {
                throw new EntityValidationException(BookPublication.PublisherIdRequiredMessage);
            }

            this.PublisherId = publisherId;
        }

        /// <summary>
        /// Modifie l'identifiant de la version éditoriale du livre.
        /// </summary>
        /// <param name="editorialVersionId">Identifiant de la version éditoriale du livre.</param>
        /// <exception cref="EntityValidationException">Si <paramref name="editorialVersionId"/> est inférieur ou égal à 0.</exception>
        public void UpdateEditorialVersionId(int editorialVersionId)
        {
            if (editorialVersionId <= 0)
            {
                throw new EntityValidationException(BookPublication.EditorialVersionIdRequiredMessage);
            }

            this.EditorialVersionId = editorialVersionId;
        }

        /// <summary>
        /// Modifie l'ISBN du livre.
        /// </summary>
        /// <param name="isbn">Nouvel ISBN du livre.</param>
        /// <exception cref="EntityValidationException">Si <paramref name="isbn"/> est <see langword="null"/>, vide ou ne contient que des espaces.</exception>
        public void UpdateIsbn(string isbn)
        {
            if (string.IsNullOrWhiteSpace(isbn))
            {
                throw new EntityValidationException(BookPublication.IsbnRequiredMessage);
            }

            this.Isbn = isbn.Trim();
        }

        /// <summary>
        /// Modifie la date de publication.
        /// </summary>
        /// <param name="publicationDate">Nouvelle date de publication.</param>
        /// <exception cref="EntityValidationException">Si <paramref name="publicationDate"/> est égal à <see langword="default"/>.</exception>
        public void UpdatePublicationDate(DateOnly publicationDate)
        {
            if (publicationDate == default)
            {
                throw new EntityValidationException(BookPublication.PublicationDateRequiredMessage);
            }

            this.PublicationDate = publicationDate;
        }
    }
}
