using System;

namespace IBookCatalogService.Contracts.Data
{
	/// <summary>
	/// IBookCatalogService.Contracts.Data.BookContract
	/// </summary>
	public class BookContract : IBookContract
	{
		/// <summary>
		/// Gets or sets the title.
		/// </summary>
		/// <value>The title.</value>
		public string Title { get; set; }
        /// <summary>
		/// Gets or sets the author.
		/// </summary>
		/// <value>The author.</value>
		public AuthorContract Author { get; set; }
		/// <summary>
		/// Gets or sets the ISBN.
		/// </summary>
		/// <value>The ISBN.</value>
		public string ISBN { get; set; }
		/// <summary>
		/// Gets or sets the series.
		/// </summary>
		/// <value>The series.</value>
		public string Series { get; set; }
		/// <summary>
		/// Gets or sets the genre.
		/// </summary>
		/// <value>The genre.</value>
		public string Genre { get; set; }
		/// <summary>
		/// Gets a value indicating whether [in collection].
		/// </summary>
		/// <value><c>true</c> if [in collection]; otherwise, <c>false</c>.</value>
		public bool InCollection { get; set; }

		/// <summary>
		/// Gets or sets the type of the book.
		/// </summary>
		/// <value>The type of the book.</value>
		public string Type { get; set; }

		/// <summary>
		/// Gets or sets the date added.
		/// </summary>
		/// <value>The date added.</value>
		public DateTime? DateAdded { get; set; }
	}
}