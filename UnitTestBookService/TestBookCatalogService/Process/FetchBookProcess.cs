using BookCatalogService.Domain;
using BookCatalogService.Process;
using IBookCatalogService.Data;
using IBookCatalogService.Process;
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
		/// Gets the fetch book process exception mock.
		/// </summary>
		/// <returns></returns>
		public static IFetchBookProcess GetFetchBookProcessExceptionMock()
		{
			var mock = MockRepository.GenerateStub<IFetchBookProcess>();
			mock.Stub(x => x.FetchByIndex(Arg<int>.Is.Anything))
				.Return(null);
			return mock;
		}
		/// <summary>
		/// Gets the fetch book process bad mock.
		/// </summary>
		/// <returns></returns>
		public static IFetchBookProcess GetFetchBookProcessBadMock()
		{
			var mock = MockRepository.GenerateStub<IFetchBookProcess>();
			mock.Stub(x => x.FetchByIndex(Arg<int>.Is.Anything))
				.Return(new BookDetail());
			return mock;

		}
		/// <summary>
		/// Gets the fetch book process mock.
		/// </summary>
		/// <returns></returns>
		public static IFetchBookProcess GetFetchBookProcessMock()
		{
			var mock = MockRepository.GenerateStub<IFetchBookProcess>();
			mock.Stub(x => x.FetchByIndex(Arg<int>.Is.Anything))
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
        /// Creates the fetch book process mock.
        /// </summary>
        protected void CreateFetchBookProcessMock()
        {
            AutoMocker.Get<IFetchBookProcess>().Expect(
                x => x.FetchByIndex(Arg<int>.Is.Anything))
                .Return(MockHelper.GetBookDetailGoodMock());
        }

    }

}
namespace TestBookCatalogService.Process
{

	/// <summary>
	/// TestBookCatalogService.Data.FetchBookProcessTest
	/// </summary>
	[TestFixture]
	public class FetchBookProcessTest : AutoMockerBase<FetchBookProcess>
	{
		#region Additional test attributes
		/// <summary>
		/// Mies the test fixture set up.
		/// </summary>
		[TestFixtureSetUp]
		public void MyTestFixtureSetUp()
		{
			BaseTestFixtureSetUp();
		}

		/// <summary>
		/// Tests the fixture tear down.
		/// </summary>
		[TestFixtureTearDown]
		public void TestFixtureTearDown()
		{
			BaseTestFixtureTearDown();
		}
		/// <summary>
		/// Tests the set up.
		/// </summary>
		[SetUp]
		public void TestSetUp()
		{
			BaseTestSetUp();
		}
		/// <summary>
		/// Tests the tear down.
		/// </summary>
		[TearDown]
		public void TestTearDown()
		{
			BaseTestTearDown();
		}

		#endregion

		#region Target Object Contructors
		/// <summary>
		/// Creates the target object mock.
		/// </summary>
		/// <returns></returns>
		private static FetchBookProcess CreateTargetObjectMock()
		{
			return new FetchBookProcess(MockHelper.GetBookDataManagerMock());
		}
		/// <summary>
		/// Creates the target object bad mock.
		/// </summary>
		/// <returns></returns>
		private static FetchBookProcess CreateTargetObjectBadMock()
		{
			return new FetchBookProcess(MockHelper.GetBookDataManagerBadMock());
		}
		/// <summary>
		/// Creates the target object exception mock.
		/// </summary>
		/// <returns></returns>
		private static FetchBookProcess CreateTargetObjectExceptionMock()
		{
			return new FetchBookProcess(MockHelper.GetBookDataManagerExceptionMock());
		}
		/// <summary>
		/// Creates the private accessor.
		/// </summary>
		/// <returns></returns>
		private static PrivateAccessor CreatePrivateAccessor()
		{
			var param0 = PrivateAccessor.CreatePrivate(MockHelper.GetBookDataManagerMock());
			return new PrivateAccessor(param0);
		}

		/// <summary>
		/// Creates the target interface object.
		/// </summary>
		/// <returns></returns>
		private static IFetchBookProcess CreateTargetInterfaceObject()
		{
			IFetchBookProcess target = CreateTargetObjectMock();
			return target;
		}
		#endregion

        /// <summary>
        /// Tests the fetch by index auto mock.
        /// </summary>
        [Test]
        [Category("version1.0")]
        public void TestFetchByIndexAutoMock()
        {
            CreateBookDataManagerMock();
            var actual = ClassUnderTest.FetchByIndex(1);
            Assert.IsNotNull(actual);
        }


		/// <summary>
		/// Tests the index of the fetch book by.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestFetchByIndex()
		{
			var target = CreateTargetObjectMock();
			var actual = target.FetchByIndex(1);
			Assert.IsNotNull(actual);
		}

		/// <summary>
		/// Tests the index of the interface fetch book by.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestInterfaceFetchByIndex()
		{
			var target = CreateTargetInterfaceObject();
			var actual = target.FetchByIndex(1);
			Assert.IsNotNull(actual);
		}
		/// <summary>
		/// Tests the fetch book by index mock.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestFetchByIndexMock()
		{
			var target = CreateTargetObjectMock();
			var actual = target.FetchByIndex(1);
			Assert.IsNotNull(actual);
		}
		/// <summary>
		/// Tests the fetch book by index bad mock.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestFetchByIndexBadMock()
		{
			var target = CreateTargetObjectBadMock();
			var actual = target.FetchByIndex(1);
			Assert.IsNotNull(actual);
		}
		/// <summary>
		/// Tests the fetch book by index exception mock.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestFetchByIndexExceptionMock()
		{
			var target = CreateTargetObjectExceptionMock();
			var actual = target.FetchByIndex(1);
			Assert.IsNull(actual);
		}
		/// <summary>
		/// Tests the book data manager.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestBookDataManager()
		{
			var target = CreatePrivateAccessor();
			Assert.IsNotNull(target.BookDataManager);
		}
		#region Private Accessor
		/// <summary>
		/// TestBookCatalogService.Domain.AuthorDetailTest.PrivateAccessor
		/// </summary>
		public class PrivateAccessor
		{
			private const string FileName = "BookCatalogService";
			private const string FullClassName = "BookCatalogService.Process.FetchBookProcess";

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
			public static object CreatePrivate(IBookDataManager bookDataManager)
			{
				var args = new object[] { bookDataManager };
				var privObj = new MSPrivateObject(FileName, FullClassName,
												  new[] { typeof(IBookDataManager) }, args);
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
			/// Gets or sets the book data manager.
			/// </summary>
			/// <value>The book data manager.</value>
			public IBookDataManager BookDataManager
			{
				get
				{
					return (IBookDataManager)_mmsPrivateObject.GetFieldOrProperty("_bookDataManager");
				}
				set
				{
					_mmsPrivateObject.SetFieldOrProperty("_bookDataManager", value);
				}
			}
		}
		#endregion
	}
}