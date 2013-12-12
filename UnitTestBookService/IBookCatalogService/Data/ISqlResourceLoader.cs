namespace IBookCatalogService.Data
{
	/// <summary>
	/// IBookCatalogService.Data.ISqlResourceLoader
	/// </summary>
	public interface ISqlResourceLoader
	{
		/// <summary>
		/// Loads the SQL statement. This must be called from a concrete provider directly as we need the calling assembly
		/// </summary>
		/// <param name="fileName">Name of the file.</param>
		/// <returns></returns>
		string LoadSqlStatement(string fileName);
	}
}