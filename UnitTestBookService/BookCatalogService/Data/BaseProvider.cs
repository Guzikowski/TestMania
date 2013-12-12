using System.Data;
using System.Data.SqlClient;
using IBookCatalogService.Data;
using IBookCatalogService.Domain;

namespace BookCatalogService.Data
{
	/// <summary>
	/// BaseProvider
	/// </summary>
	public abstract class BaseProvider
	{
		protected ISqlResourceLoader SqlLoader { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="BaseProvider"/> class.
		/// </summary>
		/// <param name="sqlResourceLoader">The SQL resource loader.</param>
		protected BaseProvider(ISqlResourceLoader sqlResourceLoader)
		{
			SqlLoader = sqlResourceLoader;
		}

		/// <summary>
		/// Processes the result.
		/// </summary>
		/// <param name="reader">The reader.</param>
		/// <returns></returns>
		protected static IProviderResult ProcessResult(IDataReader reader)
		{
			IProviderResult result = new ProviderResult();
			if (reader != null)
			{
			    var ord = reader.GetOrdinal("Id");
                if (!reader.IsDBNull(ord))
                {
                    result.Id = reader.GetInt32(ord);
                }
			    else
			    {
			        result.Id = new int?();
			    }
				result.VersionTimestamp = ((SqlDataReader)reader).GetSqlBytes(reader.GetOrdinal("VersionTimestamp")).Value;
			}
			return result;
		}
		/// <summary>
		/// Checks the deletion result.
		/// </summary>
		/// <param name="reader">The reader.</param>
		/// <returns></returns>
		protected static bool CheckDeletionResult(IDataReader reader)
		{
			int? result = 1;
			if (reader != null)
			{
				result = !reader.IsDBNull(reader.GetOrdinal("DeleteResult")) ? (int?)reader.GetInt32(reader.GetOrdinal("DeleteResult")) : null;
                if (!result.HasValue) result = 0;

			}
			return !(result > 0);
		}

		/// <summary>
		/// Pre-validate SQL execution.
		/// </summary>
		/// <param name="transaction">The transaction.</param>
		/// <param name="sqlStatement">The SQL statement.</param>
		/// <returns></returns>
		protected bool PreValidateSqlExecution(SqlTransaction transaction, string sqlStatement)
		{
			return transaction != null && ValidateSqlStatement(sqlStatement);
		}


		/// <summary>
		/// Pre-validate SQL execution.
		/// </summary>
		/// <param name="connection">The connection.</param>
		/// <param name="sqlStatement">The SQL statement.</param>
		/// <returns></returns>
		protected bool PreValidateSqlExecution(SqlConnection connection, string sqlStatement)
		{
			return connection != null && ValidateSqlStatement(sqlStatement);
		}

		/// <summary>
		/// Validates the SQL statement.
		/// </summary>
		/// <param name="sqlStatement">The SQL statement.</param>
		/// <returns></returns>
		protected bool ValidateSqlStatement(string sqlStatement)
		{
			return !string.IsNullOrEmpty(sqlStatement);
		}

		/// <summary>
		/// Validates the SQL response.
		/// </summary>
		/// <param name="index">The index.</param>
		/// <param name="result">The result.</param>
		/// <returns></returns>
		protected static bool ValidateSqlResponse(int index, IBaseDomain result)
		{
			if (result == null)
			{
				return false;
			}
			return result.Id == index;
		}

		/// <summary>
		/// Handles the provider error.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="errorCode">The error code.</param>
		/// <returns></returns>
		protected static T HandleProviderError<T>(ProviderErrorType errorCode) where T : new()
		{
			// TODO: Log error
			return new T();
		}
	}

	/// <summary>
	/// ProviderErrorType
	/// </summary>
	public enum ProviderErrorType
	{
		/// <summary>
		/// PreValidationFailure - indicates issue with the SQL statement or the Connection / Transaction
		/// </summary>
		PreValidationFailure,
		/// <summary>
		/// PostValidationFailure - indicates that the SQL result was not what was expected, possibly no data or concurrency 
		/// </summary>
		PostValidationFailure
	}
}