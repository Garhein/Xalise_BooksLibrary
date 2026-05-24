namespace Xalise_BooksLibrary.Domain.Contracts.Criteria
{
    /// <summary>
    /// Regroupe les critères communs utilisés pour rechercher des référentiels simples.
    /// </summary>
    public class EntitySearchCriteria
    {
        /// <summary>
        /// Obtient ou définit le texte recherché dans les informations du référentiel.
        /// </summary>
        public string? SearchTerm { get; set; }

        /// <summary>
        /// Obtient ou définit le nom de la colonne utilisée pour le tri.
        /// </summary>
        public string? SortColumn { get; set; }

        /// <summary>
        /// Obtient ou définit une valeur indiquant si le tri doit être décroissant.
        /// </summary>
        public bool SortDescending { get; set; }

        /// <summary>
        /// Obtient ou définit le numéro de page demandé.
        /// </summary>
        public int PageNumber { get; set; }

        /// <summary>
        /// Obtient ou définit le nombre d'éléments par page.
        /// </summary>
        public int PageSize { get; set; }
    }
}
