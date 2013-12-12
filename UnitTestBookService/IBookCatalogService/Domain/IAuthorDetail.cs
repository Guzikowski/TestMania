using System.Collections.Generic;

namespace IBookCatalogService.Domain
{
	/// <summary>
	/// IBookCatalogService.Domain.IAuthorDetail
	/// </summary>
	public interface IAuthorDetail : IBaseDomain
	{
		/// <summary>
		/// Gets or sets the first name.
		/// </summary>
		/// <value>The first name.</value>
		string FirstName { get; set; }
		/// <summary>
		/// Gets or sets the last name.
		/// </summary>
		/// <value>The last name.</value>
		string LastName { get; set; }
		/// <summary>
		/// Gets or sets the aliases.
		/// </summary>
		/// <value>The aliases.</value>
		IList<IAuthorDetail> Aliases { get; set; } 
	}
}