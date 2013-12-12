namespace IBookCatalogService.Domain
{
	/// <summary>
	/// IBookCatalogService.Domain.IBaseLookup
	/// </summary>
	public interface IBaseLookup : IBaseDomain
	{
		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		string Name { get; set; }

		/// <summary>
		/// Values the changed.
		/// </summary>
		/// <param name="newName">The new name.</param>
		void ValueChanged(string newName);
	}
}