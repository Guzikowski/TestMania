using System.Data;
using System.Data.SqlClient;
using BookCatalogService.Domain;
using IBookCatalogService.Data;
using IBookCatalogService.Domain;

namespace BookCatalogService.Data
{
	/// <summary>
	/// BookCatalogService.Data.FetchBookProvider
	/// </summary>
    public class FetchBookProvider : BaseProvider, IFetchBookProvider
    {
		/// <summary>
		/// Initializes a new instance of the <see cref="FetchBookProvider"/> class.
		/// </summary>
		/// <param name="sqlResourceLoader">The SQL resource loader.</param>
		public FetchBookProvider(ISqlResourceLoader sqlResourceLoader)
            : base(sqlResourceLoader)
        {
        }

		/// <summary>
		/// Fetches the specified connection.
		/// </summary>
		/// <param name="connection">The connection.</param>
		/// <param name="index">The index.</param>
		/// <returns></returns>
		public IBookDetail Fetch(SqlConnection connection, int index)
		{
			var sqlStatement = SqlLoader.LoadSqlStatement("GetSimpleBookDetail.sql");
			var returnResponse = PreValidateSqlExecution(connection, sqlStatement) ? ExecuteSql(connection, sqlStatement, index) : HandleProviderError<BookDetail>(ProviderErrorType.PreValidationFailure);
			
			if (!ValidateSqlResponse(index, returnResponse))
			{
				returnResponse = HandleProviderError<BookDetail>(ProviderErrorType.PostValidationFailure);
			}
			return returnResponse;

		}
        /// <summary>
		/// Executes the SQL.
		/// </summary>
		/// <param name="connection">The connection.</param>
		/// <param name="sqlStatement">The SQL statement.</param>
		/// <param name="index">The index.</param>
		/// <returns></returns>
		private static IBookDetail ExecuteSql(SqlConnection connection, string sqlStatement, int index)
		{
			IBookDetail book;
			var command = new SqlCommand
			              	{
			              		CommandType = CommandType.Text,
			              		Connection = connection,
			              		CommandText = sqlStatement
			              	};
			command.Parameters.AddWithValue("@BookId", index);
			using (var reader = command.ExecuteReader())
			{
				book = CreateEntity(reader);
			}
			return book;
		}

		/// <summary>
		/// Creates the entity.
		/// </summary>
		/// <param name="reader">The reader.</param>
		/// <returns></returns>
		private static IBookDetail CreateEntity(IDataReader reader)
		{
			var book = new BookDetail();
			if (reader == null)
			{
				return book;
			}
			while (reader.Read())
			{
				book = new BookDetail
				       	{
							Id = reader.GetInt32(reader.GetOrdinal("Id")),
				       		Title = reader.GetString(reader.GetOrdinal("Title")),
							Author = new AuthorDetail
										 {
												FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
												LastName = reader.GetString(reader.GetOrdinal("LastName"))
										  },
				       	};
			}
			return book;
		}
    }
}