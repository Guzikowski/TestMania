using System;

namespace IBookCatalogService.Contracts.Data
{
	public interface IBookContract
	{
		/// <summary>
		/// Gets or sets the title.
		/// </summary>
		/// <value>The title.</value>
		string Title { get; set; }
		/// <summary>
		/// Gets or sets the ISBN.
		/// </summary>
		/// <value>The ISBN.</value>
		string ISBN { get; set; }

		/// <summary>
		/// Gets or sets the series.
		/// </summary>
		/// <value>The series.</value>
		string Series { get; set; }

		/// <summary>
		/// Gets or sets the genre.
		/// </summary>
		/// <value>The genre.</value>
		string Genre { get; set; }

		/// <summary>
		/// Gets a value indicating whether [in collection].
		/// </summary>
		/// <value><c>true</c> if [in collection]; otherwise, <c>false</c>.</value>
		bool InCollection { get; set; }

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

	}
}