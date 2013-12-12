using IBookCatalogService.Domain;

namespace IBookCatalogService.Process
{
    /// <summary>
    /// IBookCatalogService.Process.IFetchBookService
    /// </summary>
    public interface IFetchBookProcess
    {
        /// <summary>
        /// Fetches the index of the by.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        IBookDetail FetchByIndex(int index);
    }
}