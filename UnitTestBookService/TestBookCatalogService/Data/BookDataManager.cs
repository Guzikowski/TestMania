using BookCatalogService.Data;
using BookCatalogService.Domain;
using IBookCatalogService.Data;
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
		/// Gets the book data manager exception mock.
		/// </summary>
		/// <returns></returns>
		public static IBookDataManager GetBookDataManagerExceptionMock()
		{
			var mock = MockRepository.GenerateStub<IBookDataManager>();
			mock.Stub(x => x.FetchBookByIndex(Arg<int>.Is.Anything))
				.Return(null);
			return mock;
		}
		/// <summary>
		/// Gets the book data manager bad mock.
		/// </summary>
		/// <returns></returns>
		public static IBookDataManager GetBookDataManagerBadMock()
		{
			var mock = MockRepository.GenerateStub<IBookDataManager>();
			mock.Stub(x => x.FetchBookByIndex(Arg<int>.Is.Anything))
				.Return(new BookDetail());
			return mock;

		}
		/// <summary>
		/// Gets the book data manager mock.
		/// </summary>
		/// <returns></returns>
		public static IBookDataManager GetBookDataManagerMock()
		{
			var mock = MockRepository.GenerateStub<IBookDataManager>();
			mock.Stub(x => x.FetchBookByIndex(Arg<int>.Is.Anything))
				.Return(GetBookDetailGoodMock());
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
        /// Creates the book data manager mock.
        /// </summary>
        protected void CreateBookDataManagerMock()
        {
            AutoMocker.Get<IBookDataManager>().Expect(
                x => x.FetchBookByIndex(Arg<int>.Is.Anything))
                .Return(MockHelper.GetBookDetailGoodMock());
        }

    }
}

namespace TestBookCatalogService.Data
{
	#region MockHelper

	#endregion

	/// <summary>
	/// TestBookCatalogService.Data.BookDataManagerTest
	/// </summary>
	[TestFixture]
	public class BookDataManagerTest : AutoMockerBase<BookDataManager>
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

		#region Target Object Contructors
		/// <summary>
		/// Creates the target object.
		/// </summary>
		/// <returns></returns>
		private static BookDataManager CreateTargetObject()
		{
			return new BookDataManager(new DatabaseConnectionProvider(), 
													 new FetchBookProvider(new SqlResourceLoader()));
		}
		/// <summary>
		/// Creates the target object mock.
		/// </summary>
		/// <returns></returns>
		private static BookDataManager CreateTargetObjectMock()
		{
			return new BookDataManager(new DatabaseConnectionProvider(),
													 MockHelper.GetFetchBookProviderMock());
		}
		/// <summary>
		/// Creates the target object bad mock.
		/// </summary>
		/// <returns></returns>
		private static BookDataManager CreateTargetObjectBadMock()
		{
			return new BookDataManager(new DatabaseConnectionProvider(),
													 MockHelper.GetFetchBookProviderBadMock());
		}
		/// <summary>
		/// Creates the target object exception mock.
		/// </summary>
		/// <returns></returns>
		private static BookDataManager CreateTargetObjectExceptionMock()
		{
			return new BookDataManager(new DatabaseConnectionProvider(),
													 MockHelper.GetFetchBookProviderExceptionMock());
		}
		/// <summary>
		/// Creates the private accessor.
		/// </summary>
		/// <returns></returns>
		private static PrivateAccessor CreatePrivateAccessor()
		{
			var param0 = PrivateAccessor.CreatePrivate(new DatabaseConnectionProvider(),
													                     new FetchBookProvider(new SqlResourceLoader()));
			return new PrivateAccessor(param0);
		}

		/// <summary>
		/// Creates the target interface object.
		/// </summary>
		/// <returns></returns>
		private static IBookDataManager CreateTargetInterfaceObject()
		{
			IBookDataManager target = CreateTargetObject();
			return target;
		}
		#endregion
		/// <summary>
		/// Tests the index of the fetch book by.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestFetchBookByIndex()
		{
			var target = CreateTargetObject();
			var actual = target.FetchBookByIndex(1);
			Assert.IsNotNull(actual);
		}
		/// <summary>
		/// Tests the index of the interface fetch book by.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestInterfaceFetchBookByIndex()
		{
			var target = CreateTargetInterfaceObject();
			var actual = target.FetchBookByIndex(1);
			Assert.IsNotNull(actual);
		}
		/// <summary>
		/// Tests the fetch book by index mock.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestFetchBookByIndexMock()
		{
			var target = CreateTargetObjectMock();
			var actual = target.FetchBookByIndex(1);
			Assert.IsNotNull(actual);
		}
		/// <summary>
		/// Tests the fetch book by index bad mock.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestFetchBookByIndexBadMock()
		{
			var target = CreateTargetObjectBadMock();
			var actual = target.FetchBookByIndex(1);
			Assert.IsNull(actual);
		}
		/// <summary>
		/// Tests the fetch book by index exception mock.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestFetchBookByIndexExceptionMock()
		{
			var target = CreateTargetObjectExceptionMock();
			var actual = target.FetchBookByIndex(1);
			Assert.IsNotNull(actual);
		}
		/// <summary>
		/// Tests the fetch book by index no data.
		/// </summary>
        [Test]
		[Category("version1.0")]
		public void TestFetchBookByIndexNoData()
		{
			var target = CreateTargetObject();
			var actual = target.FetchBookByIndex(0);
			Assert.IsNotNull(actual);
		}
		/// <summary>
		/// Tests the database connection provider.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestDatabaseConnectionProvider()
		{
			var target = CreatePrivateAccessor();
			Assert.IsNotNull(target.DatabaseConnectionProvider);
		}
		/// <summary>
		/// Tests the fetch book provider.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestFetchBookProvider()
		{
			var target = CreatePrivateAccessor();
			Assert.IsNotNull(target.FetchBookProvider);
		}
		#region Private Accessor
		/// <summary>
		/// TestBookCatalogService.Domain.AuthorDetailTest.PrivateAccessor
		/// </summary>
		public class PrivateAccessor
		{
			private const string FileName = "BookCatalogService";
			private const string FullClassName = "BookCatalogService.Data.BookDataManager";

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
			public static object CreatePrivate(IDatabaseConnectionProvider databaseConnectionProvider,
														   IFetchBookProvider fetchBookProvider)
			{
				var args = new object[] { databaseConnectionProvider, fetchBookProvider };
				var privObj = new MSPrivateObject(FileName, FullClassName,
																new[] { typeof(IDatabaseConnectionProvider),
																            typeof(IFetchBookProvider) }, args);
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
			/// Gets or sets the database connection provider.
			/// </summary>
			/// <value>The database connection provider.</value>
			public IDatabaseConnectionProvider DatabaseConnectionProvider
			{
				get
				{
					return (IDatabaseConnectionProvider)_mmsPrivateObject.GetFieldOrProperty("_databaseConnectionProvider");
				}
				set
				{
					_mmsPrivateObject.SetFieldOrProperty("_databaseConnectionProvider", value);
				}
			}


			/// <summary>
			/// Gets or sets the fetch book provider.
			/// </summary>
			/// <value>The fetch book provider.</value>
			public IFetchBookProvider FetchBookProvider
			{
				get
				{
					return (IFetchBookProvider)_mmsPrivateObject.GetFieldOrProperty("_fetchBookProvider");
				}
				set
				{
					_mmsPrivateObject.SetFieldOrProperty("_fetchBookProvider", value);
				}
			}

		}
		#endregion
	}
}