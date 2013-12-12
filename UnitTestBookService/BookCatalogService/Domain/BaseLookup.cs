using IBookCatalogService.Domain;

namespace BookCatalogService.Domain
{
	/// <summary>
	/// BookCatalogService.Domain.BaseLookup
	/// </summary>
	public abstract class BaseLookup : BaseDomain, IBaseLookup
	{
		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public string Name { get; set;}

		/// <summary>
		/// Values the changed.
		/// </summary>
		/// <param name="newName">The new name.</param>
		public void ValueChanged(string newName)
		{
			HasChanged = true;
            Name = newName;
		}
	}
}