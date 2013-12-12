using System.Collections.Generic;
using System.Runtime.Serialization;

namespace IBookCatalogService.Contracts.Data
{
	/// <summary>
	/// IBookCatalogService.Contracts.Data.AuthorContract
	/// </summary>
	[DataContract]
	public class AuthorContract : IAuthorContract
	{
		/// <summary>
		/// Gets or sets the first name.
		/// </summary>
		/// <value>The first name.</value>
		[DataMember]
		public string FirstName { get; set; }

		/// <summary>
		/// Gets or sets the last name.
		/// </summary>
		/// <value>The last name.</value>
		[DataMember]
		public string LastName { get; set; }

		/// <summary>
		/// Gets or sets the aliases.
		/// </summary>
		/// <value>The aliases.</value>
		[DataMember]
		public List<AuthorContract> Aliases { get; set; }
	}
}