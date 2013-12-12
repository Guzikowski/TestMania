using System;
using IBookCatalogService.Domain;

namespace BookCatalogService.Domain
{
	/// <summary>
	/// BookCatalogService.Domain.BookCollection
	/// </summary>
	public class BookCollection : BaseDomain, IBookCollection
	{
		/// <summary>
		/// Gets or sets the type of the book.
		/// </summary>
		/// <value>The type of the book.</value>
		public string Type
    	{
			get { return _bookType.Name; }
			set
			{
				if (value != _bookType.Name)
				{
					_bookType.ValueChanged(value);
				}
			}
		}
		private IBookType _bookType = new BookType();

		/// <summary>
		/// Gets or sets the date added.
		/// </summary>
		/// <value>The date added.</value>
		public DateTime? DateAdded { get; set; }

		/// <summary>
		/// Initialises the specified type.
		/// </summary>
		/// <param name="type">The type.</param>
		public void Initialise(IBookType type)
		{
			if (type != null)
			{
				_bookType = type;
			}
		}
	}
}