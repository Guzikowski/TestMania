using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using BookCatalogService.Data;
using BookCatalogService.Domain;
using IBookCatalogService.Data;
using IBookCatalogService.Domain;
using NUnit.Framework;
using Rhino.Mocks;
using MSPrivateObject = Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject;
using MSPrivateType = Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType;

namespace TestBookCatalogService
{
	/// <summary>
	/// TestBookCatalogService.Data.MockHelper
	/// </summary>
	public static partial class MockHelper
	{

		/// <summary>
		/// Creates the deletion reader mock.
		/// </summary>
		/// <returns></returns>
		public static IDataReader CreateDeletionReaderMock()
		{
			var mock = MockRepository.GenerateMock<IDataReader>();
			mock.Expect(x => x.GetOrdinal("DeleteResult")).Return(1);
			mock.Expect(x => x.IsDBNull(1)).Return(false);
			mock.Expect(x => x.GetInt32(1)).Return(0);
			return mock;
		}
		/// <summary>
		/// Creates the deletion reader bad mock.
		/// </summary>
		/// <returns></returns>
		public static IDataReader CreateDeletionReaderBadMock()
		{
			var mock = MockRepository.GenerateMock<IDataReader>();
			mock.Expect(x => x.GetOrdinal("DeleteResult")).Return(1);
			mock.Expect(x => x.IsDBNull(1)).Return(true);
			mock.Expect(x => x.GetInt32(1)).Return(1);
			return mock;
		}
		/// <summary>
		/// Creates the deletion reader exception mock.
		/// </summary>
		/// <returns></returns>
		public static IDataReader CreateDeletionReaderExceptionMock()
		{
			var mock = MockRepository.GenerateMock<IDataReader>();
			mock.Expect(x => x.GetOrdinal("DeleteResult")).Return(1);
			mock.Expect(x => x.IsDBNull(1)).Return(false);
			mock.Expect(x => x.GetInt32(1)).Throw(new InvalidOperationException("You did something bad!"));
			return mock;
		}

		/// <summary>
		/// Creates the result reader mock.
		/// </summary>
		/// <returns></returns>
		public static IDataReader CreateResultReaderMock()
		{
			var stamp = new SqlBytes(UnitTestValues.TimestampBegin);
			var mock = MockRepository.GenerateMock<SqlDataReader>();

            mock.Stub(x => x.GetOrdinal(Arg<String>.Is.Anything)).Return(1);
            mock.Stub(x => x.IsDBNull(Arg<int>.Is.Anything)).Return(false);
            mock.Stub(x => x.GetInt32(Arg<int>.Is.Anything)).Return(1);
           // mock.Expect(x => x.GetOrdinal(Arg<String>.Is.Anything)).Return(2);
            mock.Stub(x => x.GetSqlBytes(Arg<int>.Is.Anything)).Return(stamp);


            //mock.Expect(x => x.GetOrdinal("Id")).Return(1);
            //mock.Expect(x => x.IsDBNull(1)).Return(false);
            //mock.Expect(x => x.GetInt32(1)).Return(1);
            //mock.Expect(x => x.GetOrdinal("VersionTimestamp")).Return(2);
            //mock.Expect(x => x.GetSqlBytes(2)).Return(stamp);
			return mock;


            
    	}
		/// <summary>
		/// Creates the result reader bad mock.
		/// </summary>
		/// <returns></returns>
		public static IDataReader CreateResultReaderBadMock()
		{
			var stamp = new SqlBytes(UnitTestValues.TimestampBegin);
			var mock = MockRepository.GenerateMock<SqlDataReader>();
			mock.Expect(x => x.GetOrdinal("Id")).Return(1);
			mock.Expect(x => x.IsDBNull(1)).Return(true);
			mock.Expect(x => x.GetInt32(1)).Throw(new InvalidOperationException("You did something bad!"));
			mock.Expect(x => x.GetOrdinal("VersionTimestamp")).Return(2);
			mock.Expect(x => x.GetSqlBytes(2)).Return(stamp);
			return mock;
		}

		/// <summary>
		/// Creates the result reader exception mock.
		/// </summary>
		/// <returns></returns>
		public static IDataReader CreateResultReaderExceptionMock()
		{
			var stamp = new SqlBytes(UnitTestValues.TimestampBegin);
			var mock = MockRepository.GenerateMock<SqlDataReader>();
			mock.Expect(x => x.GetOrdinal("Id")).Return(1);
			mock.Expect(x => x.IsDBNull(1)).Return(false);
			mock.Expect(x => x.GetInt32(1)).Throw(new InvalidOperationException("You did something bad!"));
			mock.Expect(x => x.GetOrdinal("VersionTimestamp")).Return(2);
			mock.Expect(x => x.GetSqlBytes(2)).Return(stamp);
			return mock;
		}
		/// <summary>
		/// Creates the result reader invalid mock.
		/// </summary>
		/// <returns></returns>
		public static IDataReader CreateResultReaderInvalidMock()
		{
			var stamp = new SqlBytes(UnitTestValues.TimestampBegin);
			var mock = MockRepository.GenerateMock<SqlDataReader>();
			mock.Expect(x => x.GetOrdinal("Id")).Return(1);
			mock.Expect(x => x.IsDBNull(1)).Return(false);
			mock.Expect(x => x.GetInt32(1)).Return(1);
			mock.Expect(x => x.GetOrdinal("VersionTimestamp")).Return(2);
			mock.Expect(x => x.GetSqlBytes(2)).Return(stamp);
			return mock;
		}
	}
}

namespace TestBookCatalogService.Data
{
	/// <summary>
	/// TestBookCatalogService.Data.BaseProviderTest.ConcreteBaseProvider
	/// </summary>
	public class ConcreteBaseProvider : BaseProvider
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ConcreteBaseProvider"/> class.
		/// </summary>
		/// <param name="sqlResourceLoader">The SQL resource loader.</param>
		public ConcreteBaseProvider(ISqlResourceLoader sqlResourceLoader) : base(sqlResourceLoader)
		{
		}
	}

	/// <summary>
	/// TestBookCatalogService.Data.ProviderBaseTest
	/// </summary>
	[TestFixture]
	public class BaseProviderTest
	{
		#region Target Object Contructors
		/// <summary>
		/// Creates the target object.
		/// </summary>
		/// <returns></returns>
		private static ConcreteBaseProvider CreateTargetObject()
		{
			return new ConcreteBaseProvider(new SqlResourceLoader());
		}
		/// <summary>
		/// Creates the private accessor.
		/// </summary>
		/// <returns></returns>
		private static PrivateAccessor CreatePrivateAccessor()
		{
			var param0 = PrivateAccessor.CreatePrivate(new SqlResourceLoader());
			return new PrivateAccessor(param0);
		}

        #endregion

		/// <summary>
		/// Tests the create concrete.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestCreateConcrete()
		{
			var target = CreateTargetObject();
			Assert.IsNotNull(target);
		}

		/// <summary>
		/// Tests the SQL loader.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestSqlLoader()
		{
			var target = CreatePrivateAccessor();
			Assert.IsNotNull(target.SqlLoader);
		}
		/// <summary>
		/// Tests the pre validate SQL execution.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestPreValidateSqlExecution()
		{
			using (var connection = new DatabaseConnectionProvider().GetConnection())
			{
				var target = CreatePrivateAccessor();
				var actual = target.PreValidateSqlExecution(connection, "Some Text");
				Assert.IsTrue(actual);
				
				actual = target.PreValidateSqlExecutionTx(connection.BeginTransaction(), "Some Text");
				Assert.IsTrue(actual);
			}
		}
		/// <summary>
		/// Tests the pre validate SQL execution null object.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestPreValidateSqlExecutionNullObject()
		{
			var target = CreatePrivateAccessor();
			var actual = target.PreValidateSqlExecution(null, "Some Text");
			Assert.IsFalse(actual);
			
			actual = target.PreValidateSqlExecutionTx(null, "Some Text");
			Assert.IsFalse(actual);
		}
		/// <summary>
		/// Tests the pre validate SQL execution null statement.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestPreValidateSqlExecutionNullStatement()
		{
			using (var connection = new DatabaseConnectionProvider().GetConnection())
			{
				var target = CreatePrivateAccessor();
				var actual = target.PreValidateSqlExecution(connection, null);
				Assert.IsFalse(actual);

				actual = target.PreValidateSqlExecutionTx(connection.BeginTransaction(), null);
				Assert.IsFalse(actual);
			}
		}

		/// <summary>
		/// Tests the validate SQL statement.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestValidateSqlStatement()
		{
			var target = CreatePrivateAccessor();
			var actual = target.ValidateSqlStatement("Some Text");
			Assert.IsTrue(actual);
			
			actual = target.ValidateSqlStatement(null);
			Assert.IsFalse(actual);
		}

		/// <summary>
		/// Tests the check deletion result.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestCheckDeletionResult()
		{
			var actual = PrivateAccessor.CheckDeletionResult(MockHelper.CreateDeletionReaderMock());
			Assert.IsTrue(actual);
		}
		/// <summary>
		/// Tests the check deletion result bad result.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestCheckDeletionResultBadResult()
		{
			var actual = PrivateAccessor.CheckDeletionResult(MockHelper.CreateDeletionReaderBadMock());
			Assert.IsFalse(actual);
		}
		/// <summary>
		/// Tests the check deletion result exception.
		/// </summary>
		[Test]
		[Category("version1.0")]
		[ExpectedException(typeof(InvalidOperationException))]
		public void TestCheckDeletionResultException()
		{
			var actual = PrivateAccessor.CheckDeletionResult(MockHelper.CreateDeletionReaderExceptionMock());
			Assert.IsTrue(actual);
		}
		/// <summary>
		/// Tests the process result.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestProcessResult()
		{
			var actual = PrivateAccessor.ProcessResult(MockHelper.
                CreateResultReaderMock());
			Assert.IsNotNull(actual);
			Assert.IsTrue(actual.Id == 1);
			Assert.IsTrue(actual.VersionTimestamp == UnitTestValues.TimestampEnd);
		}
		/// <summary>
		/// Tests the process result bad result.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestProcessResultBadResult()
		{
			var actual = PrivateAccessor.ProcessResult(MockHelper.CreateResultReaderMock());
			Assert.IsNotNull(actual);
			Assert.IsTrue(actual.Id == null);
			Assert.IsTrue(actual.VersionTimestamp == UnitTestValues.TimestampEnd);
		}
		/// <summary>
		/// Tests the process result invalid result.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestProcessResultInvalidResult()
		{
			var actual = PrivateAccessor.ProcessResult(MockHelper.CreateResultReaderBadMock());
			Assert.IsNotNull(actual);
			Assert.IsTrue(actual.Id == 1);
			Assert.IsTrue(actual.VersionTimestamp == UnitTestValues.TimestampBegin);
		}
		/// <summary>
		/// Tests the process result exception.
		/// </summary>
		[Test]
		[Category("version1.0")]
		[ExpectedException(typeof(InvalidOperationException))]
		public void TestProcessResultException()
		{
			var actual = PrivateAccessor.ProcessResult(MockHelper.CreateResultReaderExceptionMock());
			Assert.IsNotNull(actual);
			Assert.IsTrue(actual.Id == 1);
			Assert.IsTrue(actual.VersionTimestamp == UnitTestValues.TimestampEnd);
		}
		/// <summary>
		/// Tests the validate SQL response.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestValidateSqlResponse()
		{
			var result = new AuthorDetail { Id = 1 };
			var actual = PrivateAccessor.ValidateSqlResponse(result.Id, result);
			Assert.IsTrue(actual);
		}
		/// <summary>
		/// Tests the validate SQL response invalid result.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestValidateSqlResponseInvalidResult()
		{
			var result = new AuthorDetail { Id = 1 };
			var actual = PrivateAccessor.ValidateSqlResponse(2, result);
			Assert.IsFalse(actual);
		}
		/// <summary>
		/// Tests the validate SQL response null result.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestValidateSqlResponseNullResult()
		{
			var actual = PrivateAccessor.ValidateSqlResponse(2, null);
			Assert.IsFalse(actual);
		}

		#region Private Accessor
		/// <summary>
		/// TestBookCatalogService.Domain.AuthorDetailTest.PrivateAccessor
		/// </summary>
		public class PrivateAccessor
		{
			private const string FileName = "TestBookCatalogService";
			private const string FullClassName = "TestBookCatalogService.Data.ConcreteBaseProvider";

			private readonly MSPrivateObject _mmsPrivateObject;
			private static readonly MSPrivateType MmsPrivateType = new MSPrivateType(FileName, FullClassName);

			/// <summary>
			/// Initializes a new instance of the <see cref="PrivateAccessor"/> class.
			/// </summary>
			/// <param name="target">The target.</param>
			public PrivateAccessor(object target)
			{
				_mmsPrivateObject = new MSPrivateObject(target, MmsPrivateType);
			}

			/// <summary>
			/// Creates the private.
			/// </summary>
			/// <returns></returns>
			public static object CreatePrivate(ISqlResourceLoader sqlResourceLoader)
			{
				var args = new object[] { sqlResourceLoader };
				var privObj = new MSPrivateObject(FileName, FullClassName,
																new[] { typeof(ISqlResourceLoader) }, args);
				return privObj.Target;
			}
			/// <summary>
			/// Gets the MMS private object.
			/// </summary>
			/// <value>The MMS private object.</value>
			public MSPrivateObject MmsPrivateObject
			{
				get { return _mmsPrivateObject; }
			}

			/// <summary>
			/// Gets or sets the SQL loader.
			/// </summary>
			/// <value>The SQL loader.</value>
			public ISqlResourceLoader SqlLoader
			{
				get
				{
					return (ISqlResourceLoader)_mmsPrivateObject.GetFieldOrProperty("SqlLoader");
				}
				set
				{
					_mmsPrivateObject.SetFieldOrProperty("SqlLoader", value);
				}
			}
			/// <summary>
			/// Processes the result.
			/// </summary>
			/// <param name="reader">The reader.</param>
			/// <returns></returns>
			public static IProviderResult ProcessResult(IDataReader reader)
			{
				var args = new object[] { reader };
				return ((IProviderResult)(MmsPrivateType.InvokeStatic
					("ProcessResult", new[] { typeof(IDataReader) }, args)));
			}

			/// <summary>
			/// Checks the deletion result.
			/// </summary>
			/// <param name="reader">The reader.</param>
			/// <returns></returns>
			public static bool CheckDeletionResult(IDataReader reader)
			{
				var args = new object[] { reader };
				return ((bool)(MmsPrivateType.InvokeStatic
					("CheckDeletionResult", new[] { typeof(IDataReader) }, args)));
			}
			/// <summary>
			/// Pres the validate SQL execution tx.
			/// </summary>
			/// <param name="transaction">The transaction.</param>
			/// <param name="sqlStatement">The SQL statement.</param>
			/// <returns></returns>
			public bool PreValidateSqlExecutionTx(SqlTransaction transaction, string sqlStatement)
			{
				var args = new object[] { transaction,  sqlStatement};
				return ((bool)(_mmsPrivateObject.Invoke
					("PreValidateSqlExecution", new[] { typeof(SqlTransaction),  typeof(string)  }, args)));
			}
			/// <summary>
			/// Pres the validate SQL execution.
			/// </summary>
			/// <param name="connection">The connection.</param>
			/// <param name="sqlStatement">The SQL statement.</param>
			/// <returns></returns>
			public bool PreValidateSqlExecution(SqlConnection connection, string sqlStatement)
			{
				var args = new object[] { connection, sqlStatement };
				return ((bool)(_mmsPrivateObject.Invoke
					("PreValidateSqlExecution", new[] { typeof(SqlConnection), typeof(string) }, args)));
			}
			/// <summary>
			/// Validates the SQL statement.
			/// </summary>
			/// <param name="sqlStatement">The SQL statement.</param>
			/// <returns></returns>
			public bool ValidateSqlStatement(string sqlStatement)
			{
				var args = new object[] { sqlStatement };
				return ((bool)(_mmsPrivateObject.Invoke
					("ValidateSqlStatement", new[] { typeof(string) }, args)));
			}
			/// <summary>
			/// Validates the SQL response.
			/// </summary>
			/// <param name="index">The index.</param>
			/// <param name="result">The result.</param>
			/// <returns></returns>
			public static bool ValidateSqlResponse(int index, IBaseDomain result)
			{
				var args = new object[] { index, result };
				return ((bool)(MmsPrivateType.InvokeStatic
					("ValidateSqlResponse", new[] { typeof(int), typeof(IBaseDomain) }, args)));
			}
	   	}
		#endregion
	}
}