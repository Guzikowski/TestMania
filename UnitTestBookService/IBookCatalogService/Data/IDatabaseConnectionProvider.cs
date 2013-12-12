using System.Data.SqlClient;

namespace IBookCatalogService.Data
{
    /// <summary>
    /// IBookCatalogService.Data.IDatabaseConnectionProvider
    /// </summary>
    public interface IDatabaseConnectionProvider
    {
        /// <summary>
        /// Gets the connection.
        /// </summary>
        /// <returns></returns>
        SqlConnection GetConnection();
    }
}