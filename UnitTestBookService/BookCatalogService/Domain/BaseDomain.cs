using IBookCatalogService.Domain;

namespace BookCatalogService.Domain
{
	/// <summary>
	/// BookCatalogService.Domain.BaseDomain
	/// </summary>
	public abstract class BaseDomain : IBaseDomain
	{
		/// <summary>
		/// Gets or sets a value indicating whether this instance is new.
		/// </summary>
		/// <value><c>true</c> if this instance is new; otherwise, <c>false</c>.</value>
		public bool IsNew { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this instance is removed.
		/// </summary>
		/// <value>
		/// 	<c>true</c> if this instance is removed; otherwise, <c>false</c>.
		/// </value>
		public bool IsRemoved { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this instance has changed.
		/// </summary>
		/// <value>
		/// 	<c>true</c> if this instance has changed; otherwise, <c>false</c>.
		/// </value>
		public bool HasChanged { get; set; }

		/// <summary>
		/// Gets or sets the id.
		/// </summary>
		/// <value>The id.</value>
		public int Id { get; set; }

		/// <summary>
		/// Gets or sets the timestamp.
		/// </summary>
		/// <value>The timestamp.</value>
		public byte[] Timestamp { get; set; }
	}
}