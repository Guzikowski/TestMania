using System;

namespace IBookCatalogService.Domain
{
	/// <summary>
	/// IBookCatalogService.Domain.IBookCollection
	/// </summary>
	public interface IBookCollection : IBaseDomain
	{
		/// <summary>
		/// Gets or sets the type of the book.
		/// </summary>
		/// <value>The type of the book.</value>
		string Type { get; set; }
		/// <summary>
		/// Gets or sets the date added.
		/// </summary>
		/// <value>The date added.</value>
		DateTime? DateAdded { get; set; }

		/// <summary>
		/// Initialises the specified type.
		/// </summary>
		/// <param name="type">The type.</param>
		void Initialise(IBookType type);
	}
}