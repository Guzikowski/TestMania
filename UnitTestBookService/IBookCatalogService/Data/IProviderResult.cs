namespace IBookCatalogService.Data
{
	/// <summary>
	/// IProviderResult
	/// </summary>
	public interface IProviderResult
	{
		/// <summary>
		/// Gets or sets the id.
		/// </summary>
		/// <value>The id.</value>
		int? Id { get; set; }
		/// <summary>
		/// Gets or sets the version timestamp.
		/// </summary>
		/// <value>The version timestamp.</value>
		byte[] VersionTimestamp { get; set; }
	}
}