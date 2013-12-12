using BookCatalogService.Domain;
using IBookCatalogService.Contracts.Data;
using IBookCatalogService.Process;
using IBookCatalogService.Service;

namespace BookCatalogService.Service
{
    /// <summary>
    /// BookCatalogService.Service.BookLookupService
    /// </summary>
	public class BookLookupService : IBookLookupService
	{
	    private readonly IFetchBookProcess _fetchProcess;

        /// <summary>
        /// Initializes a new instance of the <see cref="BookLookupService"/> class.
        /// </summary>
        /// <param name="fetchProcess">The fetch process.</param>
        public BookLookupService(IFetchBookProcess fetchProcess)
        {
            _fetchProcess = fetchProcess;
        }
        /// <summary>
        /// Gets the book detail.
        /// </summary>
        /// <param name="bookId">The book id.</param>
        /// <returns></returns>
		public BookContract GetBookDetail(int bookId)
		{
		    var book = _fetchProcess.FetchByIndex(bookId);
            return BookDetail.ConvertToContract(book);
		}
	}
}