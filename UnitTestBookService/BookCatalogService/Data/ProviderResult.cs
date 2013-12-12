using IBookCatalogService.Data;

namespace BookCatalogService.Data
{
	/// <summary>
	/// ProviderResult
	/// </summary>
	public class ProviderResult : IProviderResult
	{
		/// <summary>
		/// Gets or sets the id.
		/// </summary>
		/// <value>The id.</value>
		public int? Id { get; set; }
		/// <summary>
		/// Gets or sets the version timestamp.
		/// </summary>
		/// <value>The version timestamp.</value>
		public byte[] VersionTimestamp { get; set; }
	}
}