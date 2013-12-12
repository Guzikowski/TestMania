using System.ServiceModel;
using IBookCatalogService.Contracts.Data;

namespace IBookCatalogService.Service
{
    /// <summary>
    /// IBookCatalogService.Service.IBookLookupService
    /// </summary>
	[ServiceContract]
	public interface IBookLookupService
	{
        /// <summary>
        /// Gets the book detail.
        /// </summary>
        /// <param name="bookId">The book id.</param>
        /// <returns></returns>
		[OperationContract]
		BookContract GetBookDetail(int bookId);
	}
}