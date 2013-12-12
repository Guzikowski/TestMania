using System;
using BookCatalogService.Domain;
using IBookCatalogService.Data;
using IBookCatalogService.Domain;

namespace BookCatalogService.Data
{
    /// <summary>
    /// BookCatalogService.Data.BookDataManager
    /// </summary>
    public class BookDataManager : IBookDataManager 
    {
        private readonly IDatabaseConnectionProvider _databaseConnectionProvider;
        private readonly IFetchBookProvider _fetchBookProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="BookDataManager"/> class.
        /// </summary>
        /// <param name="databaseConnectionProvider">The database connection provider.</param>
        /// <param name="fetchBookProvider">The fetch book provider.</param>
        public BookDataManager(IDatabaseConnectionProvider databaseConnectionProvider,
                                IFetchBookProvider fetchBookProvider)
        {
            _databaseConnectionProvider = databaseConnectionProvider;
            _fetchBookProvider = fetchBookProvider;
        }

        /// <summary>
        /// Fetches the index of the book by.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        public IBookDetail FetchBookByIndex(int index)
        {
            IBookDetail book;
			try
			{
				using (var connection = _databaseConnectionProvider.GetConnection())
				{
					book = _fetchBookProvider.Fetch(connection, index);
				}
			}
			catch (Exception exception)
			{
				// TODO : Log exception
			    var message = exception.Message;
				return new BookDetail();
			}
            return book;
        }
    }
}