using System.Data.SqlClient;
using IBookCatalogService.Domain;

namespace IBookCatalogService.Data
{
    /// <summary>
    /// IBookCatalogService.Data.IFetchBookProvider
    /// </summary>
    public interface IFetchBookProvider
    {
        /// <summary>
        /// Fetches the specified connection.
        /// </summary>
        /// <param name="connection">The connection.</param>
        /// <param name="index">The index.</param>
        /// <returns></returns>
         IBookDetail Fetch(SqlConnection connection, int index);
    }
}