using System.Collections.Generic;

namespace Xalise_BooksLibrary.Domain.Contracts
{
    /// <summary>
    /// Représente un résultat paginé retourné par une recherche.
    /// </summary>
    /// <typeparam name="TItem">Type des éléments contenus dans la page.</typeparam>
    public class PagedResult<TItem>
    {
        /// <summary>
        /// Obtient ou définit les éléments de la page courante.
        /// </summary>
        public IReadOnlyCollection<TItem> Items { get; set; } = new List<TItem>();

        /// <summary>
        /// Obtient ou définit le nombre total d'éléments disponibles.
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// Obtient ou définit le numéro de la page courante.
        /// </summary>
        public int PageNumber { get; set; }

        /// <summary>
        /// Obtient ou définit le nombre d'éléments par page.
        /// </summary>
        public int PageSize { get; set; }
    }
}
