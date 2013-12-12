using IBookCatalogService.Domain;

namespace IBookCatalogService.Data
{
    /// <summary>
    /// IBookCatalogService.Data.IBookDataManager
    /// </summary>
    public interface IBookDataManager
    {
        /// <summary>
        /// Fetches the index of the book by.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        IBookDetail FetchBookByIndex(int index);
    }
}