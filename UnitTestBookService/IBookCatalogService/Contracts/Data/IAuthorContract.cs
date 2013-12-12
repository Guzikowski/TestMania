namespace IBookCatalogService.Contracts.Data
{
	/// <summary>
	/// IBookCatalogService.Contracts.Data.IAuthorContract
	/// </summary>
	public interface IAuthorContract
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
	}
}