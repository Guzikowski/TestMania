using IBookCatalogService.Contracts.Data;
using IBookCatalogService.Domain;

namespace BookCatalogService.Domain
{
	/// <summary>
	/// BookCatalogService.Domain.BookDetail
	/// </summary>
	public class BookDetail : BaseDomain, IBookDetail
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
		public IAuthorDetail Author { get; set; }

		/// <summary>
		/// Gets or sets the ISBN.
		/// </summary>
		/// <value>The ISBN.</value>
		public string ISBN { get; set; }

		/// <summary>
		/// Gets or sets the series.
		/// </summary>
		/// <value>The series.</value>
		public string Series
		{
			get { return _series.Name; }
			set
			{
				if (value !=  _series.Name)
				{
					_series.ValueChanged(value);
				}
			}
		}
		private ISeriesName _series = new SeriesName();

		/// <summary>
		/// Gets or sets the genre.
		/// </summary>
		/// <value>The genre.</value>
		public string Genre
		{
			get { return _genre.Name; }
			set
			{
				if (value != _genre.Name)
				{
					_genre.ValueChanged(value);
				}
			}
		}
		private IGenreType _genre = new GenreType();

		/// <summary>
		/// Gets a value indicating whether [in collection].
		/// </summary>
		/// <value><c>true</c> if [in collection]; otherwise, <c>false</c>.</value>
		public bool InCollection
		{
			get { return CollectionDetail != null; }
		}

		/// <summary>
		/// Gets or sets the collection detail.
		/// </summary>
		/// <value>The collection detail.</value>
		public IBookCollection CollectionDetail { get; set; }

		/// <summary>
		/// Initialises the specified type.
		/// </summary>
		/// <param name="type">The type.</param>
		public void Initialise(IGenreType type)
		{
			if (type != null)
			{
				_genre = type;
			}
		}

		/// <summary>
		/// Initialises the specified type.
		/// </summary>
		/// <param name="type">The type.</param>
		/// <param name="name">The name.</param>
		public void Initialise(IGenreType type, ISeriesName name)
		{
			if (type != null)
			{
				_genre = type;
			}
			if (name != null)
			{
				_series = name;
			}
		}

		/// <summary>
		/// Converts to contract.
		/// </summary>
		/// <param name="book">The book.</param>
		/// <returns></returns>
		public static BookContract ConvertToContract(IBookDetail book)
		{
			if (book == null)
			{
				return new BookContract();
			}
			
			return new BookContract
			       	{
						Author = AuthorDetail.ConvertToContract(book.Author),
						Genre = book.Genre,
						InCollection = book.InCollection,
						ISBN = book.ISBN,
						Series = book.Series,
						Title = book.Title,
						DateAdded = book.CollectionDetail != null ? book.CollectionDetail.DateAdded : null,
						Type = book.CollectionDetail != null ? book.CollectionDetail.Type : null
			       	};
		}
	}
}