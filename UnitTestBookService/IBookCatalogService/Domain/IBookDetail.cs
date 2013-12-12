namespace IBookCatalogService.Domain
{
    /// <summary>
	/// IBookCatalogService.Domain.IBook
	/// </summary>
	public interface IBookDetail : IBaseDomain
	{
		/// <summary>
		/// Gets or sets the title.
		/// </summary>
		/// <value>The title.</value>
		string Title { get; set; }

		/// <summary>
		/// Gets or sets the author.
		/// </summary>
		/// <value>The author.</value>
		IAuthorDetail Author { get; set; }

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
		bool InCollection { get; }

		/// <summary>
		/// Gets or sets the collection detail.
		/// </summary>
		/// <value>The collection detail.</value>
		IBookCollection CollectionDetail { get; set; }

		/// <summary>
		/// Initialises the specified type.
		/// </summary>
		/// <param name="type">The type.</param>
    	void Initialise(IGenreType type);
		/// <summary>
		/// Initialises the specified type.
		/// </summary>
		/// <param name="type">The type.</param>
		/// <param name="name">The name.</param>
		void Initialise(IGenreType type, ISeriesName name);
	}
}