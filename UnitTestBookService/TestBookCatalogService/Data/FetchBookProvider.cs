using System;
using System.Data;
using System.Data.SqlClient;
using BookCatalogService.Data;
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
		/// Gets the fetch book provider exception mock.
		/// </summary>
		/// <returns></returns>
		public static IFetchBookProvider GetFetchBookProviderExceptionMock()
		{
			var mock = MockRepository.GenerateStub<IFetchBookProvider>();
			mock.Stub(x => x.Fetch(Arg<SqlConnection>.Is.Anything, Arg<int>.Is.Anything))
				.Throw(new InvalidOperationException("You did something bad!"));
			return mock;
		}
		/// <summary>
		/// Gets the fetch book provider bad mock.
		/// </summary>
		/// <returns></returns>
		public static IFetchBookProvider GetFetchBookProviderBadMock()
		{
			var mock = MockRepository.GenerateStub<IFetchBookProvider>();
			mock.Stub(x => x.Fetch(Arg<SqlConnection>.Is.Anything, Arg<int>.Is.Anything))
				.Return(null);
			return mock;

		}
		/// <summary>
		/// Gets the fetch book provider mock.
		/// </summary>
		/// <returns></returns>
		public static IFetchBookProvider GetFetchBookProviderMock()
		{
			var mock = MockRepository.GenerateStub<IFetchBookProvider>();
			mock.Stub(x => x.Fetch(Arg<SqlConnection>.Is.Anything, Arg<int>.Is.Anything))
				.Return(GetBookDetailGoodMock());
			return mock;
		}

		/// <summary>
		/// Creates the book reader mock.
		/// </summary>
		/// <returns></returns>
		public static IDataReader CreateBookReaderMock()
		{
			var mock = MockRepository.GenerateMock<IDataReader>();
			mock.Expect(x => x.GetOrdinal("Id")).Return(1);
			mock.Expect(x => x.GetOrdinal("Title")).Return(2);
			mock.Expect(x => x.GetOrdinal("FirstName")).Return(3);
			mock.Expect(x => x.GetOrdinal("LastName")).Return(4);
			mock.Expect(x => x.GetInt32(1)).Return(1);
			mock.Expect(x => x.GetString(2)).Return(UnitTestValues.Title);
			mock.Expect(x => x.GetString(3)).Return(UnitTestValues.FirstName1);
			mock.Expect(x => x.GetString(4)).Return(UnitTestValues.LastName1);
			mock.Stub(x => x.Read()).Return(true).Repeat.Times(1);
			mock.Stub(x => x.Read()).Return(false);
			return mock;
		}
	}
    /// <summary>
    /// AutoMockerBase
    /// </summary>
    /// <typeparam name="TClassUnderTest">The type of the class under test.</typeparam>
    public abstract partial class AutoMockerBase<TClassUnderTest>
    {
        /// <summary>
        /// Creates the fetch book provider mock.
        /// </summary>
        protected void CreateFetchBookProviderMock()
        {
            AutoMocker.Get<IFetchBookProvider>().Expect(
                x => x.Fetch(Arg<SqlConnection>.Is.Anything, Arg<int>.Is.Anything))
                .Return(MockHelper.GetBookDetailGoodMock());
        }

    }

}

namespace TestBookCatalogService.Data
{
    #region MockHelper

	#endregion

    /// <summary>
	/// TestBookCatalogService.Data.FetchBookProviderTest
    /// </summary>
    [TestFixture]
	public class FetchBookProviderTest : AutoMockerBase<FetchBookProvider>
    {
		#region Additional test attributes
		/// <summary>
		/// Mies the test fixture set up.
		/// </summary>
		[TestFixtureSetUp]
		public void MyTestFixtureSetUp()
		{
			BaseDatabaseTestFixtureSetUp();
		}

		/// <summary>
		/// Tests the fixture tear down.
		/// </summary>
		[TestFixtureTearDown]
		public void TestFixtureTearDown()
		{
			BaseDatabaseTestFixtureTearDown();
		}
		/// <summary>
		/// Tests the set up.
		/// </summary>
        [SetUp]
		public void TestSetUp()
		{
			BaseDatabaseTestSetUp();
		}
		/// <summary>
		/// Tests the tear down.
		/// </summary>
		[TearDown]
		public void TestTearDown()
		{
			BaseDatabaseTestTearDown();
		}

		#endregion

    	private const string MockSelectStatement =
    		" SELECT [Id] = 1"
    		+ ",[Title] = '" + UnitTestValues.Title + "' "
    		+ ",[FirstName] = '" + UnitTestValues.FirstName1 + "' "
    		+ ",[LastName] = '" + UnitTestValues.LastName1 + "' ";

		private const string MockEmptySelectStatement = "SELECT * from Book WHERE [Id] = -1";

        #region Target Object Contructors
        /// <summary>
        /// Creates the target object.
        /// </summary>
        /// <returns></returns>
        private static FetchBookProvider CreateTargetObject()
        {
            return new FetchBookProvider(new SqlResourceLoader());
        }

        /// <summary>
        /// Creates the target interface object.
        /// </summary>
        /// <returns></returns>
        private static IFetchBookProvider CreateTargetInterfaceObject()
        {
            IFetchBookProvider target = CreateTargetObject();
            return target;
        }
        #endregion

		/// <summary>
		/// Tests the fetch empty connection.
		/// </summary>
		[Test]
		[Category("version1.0")]
		[ExpectedException(typeof(InvalidOperationException))]
		public void TestFetchEmptyConnection()
		{
			var target = CreateTargetObject();
			var actual = target.Fetch(new SqlConnection(), 1);
			Assert.IsNotNull(actual);
		}
		/// <summary>
		/// Tests the fetch null connection.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestFetchNullConnection()
		{
			var target = CreateTargetObject();
			var actual = target.Fetch(null, 1);
			Assert.IsNotNull(actual);
		}

		/// <summary>
		/// Tests the fetch load failure.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestFetchLoadFailure()
		{
			using (var connection = new DatabaseConnectionProvider().GetConnection())
			{
				var mockLoader = MockHelper.GetSqlResourceLoaderBadMock();

				var target = new FetchBookProvider(mockLoader);
				var actual = target.Fetch(connection,1);
				Assert.IsNotNull(actual);
			}
		}
		/// <summary>
		/// Tests the fetch no data.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestFetchNoData()
		{
			using (var connection = new DatabaseConnectionProvider().GetConnection())
			{
				var target = CreateTargetObject();
				var actual = target.Fetch(connection, 0);
				Assert.IsNotNull(actual);
			}
		}
		/// <summary>
		/// Tests the fetch load exception.
		/// </summary>
		[Test]
		[Category("version1.0")]
		[ExpectedException(typeof(InvalidOperationException))]
		public void TestFetchLoadException()
		{
			using (var connection = new DatabaseConnectionProvider().GetConnection())
			{
				var mockLoader = MockHelper.GetSqlResourceLoaderExceptionMock();

				var target = new FetchBookProvider(mockLoader);
				var actual = target.Fetch(connection, 1);
				Assert.IsNotNull(actual);
			}
		}

		/// <summary>
		/// Tests the fetch.
		/// </summary>
        [Test]
        [Category("version1.0")]
        public void TestFetch()
        {
			using (var connection = new DatabaseConnectionProvider().GetConnection())
			{
				var target = CreateTargetObject();
				var actual = target.Fetch(connection, 1);
				Assert.IsNotNull(actual);
			}

        }
		/// <summary>
		/// Tests the interface fetch.
		/// </summary>
        [Test]
        [Category("version1.0")]
        public void TestInterfaceFetch()
        {
			using (var connection = new DatabaseConnectionProvider().GetConnection())
			{
				var target = CreateTargetInterfaceObject();
				var actual = target.Fetch(connection, 1);
				Assert.IsNotNull(actual);
			}
		}

		/// <summary>
		/// Tests the create entity.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestCreateEntity()
		{
			var mockReader = MockHelper.CreateBookReaderMock();
			var actual = PrivateAccessor.CreateEntity(mockReader);
			Assert.IsNotNull(actual);
			Assert.IsTrue(actual.Id == 1);
			Assert.IsTrue(actual.Title == UnitTestValues.Title);
			Assert.IsTrue(actual.Author.FirstName == UnitTestValues.FirstName1);
			Assert.IsTrue(actual.Author.LastName == UnitTestValues.LastName1);
		}
		/// <summary>
		/// Tests the create entity null reader.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestCreateEntityNullReader()
		{
			var actual = PrivateAccessor.CreateEntity(null);
			Assert.IsNotNull(actual);
			Assert.IsTrue(actual.Id == 0);
			Assert.IsNull(actual.Title);
			Assert.IsNull(actual.Author);
		}

		/// <summary>
		/// Tests the execute SQL controlled.
		/// </summary>
		[Test]
		[Category("version1.0")]
        public void TestExecuteSqlControlled()
		{
			using (var connection = new DatabaseConnectionProvider().GetConnection())
			{
				var actual = PrivateAccessor.ExecuteSql(connection, MockSelectStatement, 1);
				Assert.IsNotNull(actual);
			}
		}

		/// <summary>
		/// Tests the execute SQL null transaction actual.
		/// </summary>
		[Test]
		[Category("version1.0")]
		[ExpectedException(typeof(InvalidOperationException))]
		public void TestExecuteSqlNullTransactionActual()
		{
			var actual = PrivateAccessor.ExecuteSql(new SqlConnection(), MockSelectStatement, 1);
			Assert.IsNull(actual);
		}
		/// <summary>
		/// Tests the execute SQL null statement.
		/// </summary>
		[Test]
		[Category("version1.0")]
		[ExpectedException(typeof(InvalidOperationException))]
		public void TestExecuteSqlNullStatement()
		{
			using (var connection = new DatabaseConnectionProvider().GetConnection())
			{
				var actual = PrivateAccessor.ExecuteSql(connection, null, 1);
				Assert.IsNull(actual);
			}
		}

		/// <summary>
		/// Tests the execute SQL no data.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestExecuteSqlNoData()
		{
			using (var connection = new DatabaseConnectionProvider().GetConnection())
			{
				var actual = PrivateAccessor.ExecuteSql(connection, MockEmptySelectStatement, 0);
				Assert.IsNotNull(actual);
			}
		}
		
		#region Private Accessor
		/// <summary>
        /// TestBookCatalogService.Domain.AuthorDetailTest.PrivateAccessor
        /// </summary>
        public class PrivateAccessor
        {
            private const string FileName = "BookCatalogService";
            private const string FullClassName = "BookCatalogService.Data.FetchBookProvider";

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
			/// Gets the MMS private object.
			/// </summary>
			/// <value>The MMS private object.</value>
			public MSPrivateObject MmsPrivateObject
			{
				get { return _mmsPrivateObject; }
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
			/// Creates the entity.
			/// </summary>
			/// <param name="reader">The reader.</param>
			/// <returns></returns>
            public static IBookDetail CreateEntity(IDataReader reader)
            {
                var args = new object[] { reader };
				return ((IBookDetail)(MmsPrivateType.InvokeStatic
                    ("CreateEntity", new[] { typeof(IDataReader) }, args)));
            }

			/// <summary>
			/// Executes the SQL.
			/// </summary>
			/// <param name="connection">The connection.</param>
			/// <param name="sqlStatement">The SQL statement.</param>
			/// <param name="index">The index.</param>
			/// <returns></returns>
			public static IBookDetail ExecuteSql(SqlConnection connection, string sqlStatement, int index)
            {
                var args = new object[] { connection, sqlStatement, index };
				return ((IBookDetail)(MmsPrivateType.InvokeStatic
                    ("ExecuteSql", new[] { typeof(SqlConnection), typeof(string), typeof(int) }, args)));
            }
        }
        #endregion
    }
}