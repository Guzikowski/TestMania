using System.Collections.Generic;
using IBookCatalogService.Contracts.Data;
using IBookCatalogService.Domain;

namespace BookCatalogService.Domain
{
	/// <summary>
	/// BookCatalogService.Domain.AuthorDetail
	/// </summary>
	public class AuthorDetail : BaseDomain, IAuthorDetail
	{
		/// <summary>
		/// Gets or sets the first name.
		/// </summary>
		/// <value>The first name.</value>
		public string FirstName { get; set; }

		/// <summary>
		/// Gets or sets the last name.
		/// </summary>
		/// <value>The last name.</value>
		public string LastName { get; set; }

		/// <summary>
		/// Gets or sets the aliases.
		/// </summary>
		/// <value>The aliases.</value>
		public IList<IAuthorDetail> Aliases
		{
            get { return _aliases ?? (_aliases = new List<IAuthorDetail>()); }
		    set { _aliases = value ?? new List<IAuthorDetail>(); }
		}
        private IList<IAuthorDetail> _aliases = new List<IAuthorDetail>();

        /// <summary>
		/// Converts to contract.
		/// </summary>
		/// <param name="author">The author.</param>
		/// <returns></returns>
		public static AuthorContract ConvertToContract(IAuthorDetail author)
		{
			if (author == null)
			{
				return new AuthorContract();
			}
            return  new AuthorContract
				{
					FirstName = author.FirstName,
					LastName = author.LastName
				};
		}
	}
}