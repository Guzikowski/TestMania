namespace IBookCatalogService.Domain
{
	/// <summary>
	/// IBookCatalogService.Domain.IBaseDomain
	/// </summary>
	public interface IBaseDomain
	{
		/// <summary>
		/// Gets or sets a value indicating whether this instance is new.
		/// </summary>
		/// <value><c>true</c> if this instance is new; otherwise, <c>false</c>.</value>
		bool IsNew { get; set; }
		/// <summary>
		/// Gets or sets a value indicating whether this instance is removed.
		/// </summary>
		/// <value>
		/// 	<c>true</c> if this instance is removed; otherwise, <c>false</c>.
		/// </value>
		bool IsRemoved { get; set; }
		/// <summary>
		/// Gets or sets a value indicating whether this instance has changed.
		/// </summary>
		/// <value>
		/// 	<c>true</c> if this instance has changed; otherwise, <c>false</c>.
		/// </value>
		bool HasChanged { get; set; }

		/// <summary>
		/// Gets or sets the id.
		/// </summary>
		/// <value>The id.</value>
		int Id { get; set; }
		/// <summary>
		/// Gets or sets the timestamp.
		/// </summary>
		/// <value>The timestamp.</value>
		byte[] Timestamp { get; set; }

	}
}