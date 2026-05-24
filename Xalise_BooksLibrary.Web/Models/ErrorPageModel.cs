using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Xalise_BooksLibrary.Web.Models
{
    /// <summary>
    /// Représente le modèle de page utilisé lors de l'affichage d'une erreur.
    /// </summary>
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    [IgnoreAntiforgeryToken]
    public class ErrorPageModel : PageModel
    {
        /// <summary>
        /// Obtient ou définit l'identifiant de la requête ayant déclenché l'affichage de l'erreur.
        /// </summary>
        public string? RequestId { get; set; }

        /// <summary>
        /// Obtient une valeur indiquant si un identifiant de requête est disponible pour l'affichage.
        /// </summary>
        public bool ShowRequestId => !string.IsNullOrEmpty(this.RequestId);

        /// <summary>
        /// Renseigne les informations affichées par la page d'erreur lors d'une requête GET.
        /// </summary>
        public void OnGet()
        {
            this.RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier;
        }
    }
}
