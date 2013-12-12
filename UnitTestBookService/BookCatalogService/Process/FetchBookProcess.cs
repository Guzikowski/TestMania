using IBookCatalogService.Data;
using IBookCatalogService.Domain;
using IBookCatalogService.Process;

namespace BookCatalogService.Process
{
    /// <summary>
    /// BookCatalogService.Process.FetchBookProcess
    /// </summary>
    public class FetchBookProcess : IFetchBookProcess
    {
        private readonly IBookDataManager _bookDataManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="FetchBookProcess"/> class.
        /// </summary>
        /// <param name="bookDataManager">The book data manager.</param>
        public FetchBookProcess(IBookDataManager bookDataManager)
        {
            _bookDataManager = bookDataManager;
        }

        /// <summary>
        /// Fetches the index of the by.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        public IBookDetail FetchByIndex(int index)
        {
            return _bookDataManager.FetchBookByIndex(index);
        }
    }
}