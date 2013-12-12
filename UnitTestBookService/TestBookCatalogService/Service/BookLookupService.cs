using BookCatalogService.Service;
using IBookCatalogService.Process;
using IBookCatalogService.Service;
using NUnit.Framework;
using MSPrivateObject = Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject;
using MSPrivateType = Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType;

namespace TestBookCatalogService.Service
{
	/// <summary>
	/// TestBookCatalogService.Data.BookLookupServiceTest
	/// </summary>
	[TestFixture]
	public class BookLookupServiceTest : AutoMockerBase<BookLookupService>
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
		private static BookLookupService CreateTargetObjectMock()
		{
			return new BookLookupService(MockHelper.GetFetchBookProcessMock());
		}
		/// <summary>
		/// Creates the target object bad mock.
		/// </summary>
		/// <returns></returns>
		private static BookLookupService CreateTargetObjectBadMock()
		{
			return new BookLookupService(MockHelper.GetFetchBookProcessBadMock());
		}
		/// <summary>
		/// Creates the target object exception mock.
		/// </summary>
		/// <returns></returns>
		private static BookLookupService CreateTargetObjectExceptionMock()
		{
			return new BookLookupService(MockHelper.GetFetchBookProcessExceptionMock());
		}
		/// <summary>
		/// Creates the private accessor.
		/// </summary>
		/// <returns></returns>
		private static PrivateAccessor CreatePrivateAccessor()
		{
			var param0 = PrivateAccessor.CreatePrivate(MockHelper.GetFetchBookProcessMock());
			return new PrivateAccessor(param0);
		}

		/// <summary>
		/// Creates the target interface object.
		/// </summary>
		/// <returns></returns>
		private static IBookLookupService CreateTargetInterfaceObject()
		{
			IBookLookupService target = CreateTargetObjectMock();
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
            CreateFetchBookProcessMock();
            var actual = ClassUnderTest.GetBookDetail(1);
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
			var actual = target.GetBookDetail(1);
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
			var actual = target.GetBookDetail(1);
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
			var actual = target.GetBookDetail(1);
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
			var actual = target.GetBookDetail(1);
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
			var actual = target.GetBookDetail(1);
			Assert.IsNotNull(actual);
		}
		/// <summary>
		/// Tests the book data manager.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestFetchProcess()
		{
			var target = CreatePrivateAccessor();
			Assert.IsNotNull(target.FetchProcess);
		}
		#region Private Accessor
		/// <summary>
		/// TestBookCatalogService.Domain.AuthorDetailTest.PrivateAccessor
		/// </summary>
		public class PrivateAccessor
		{
			private const string FileName = "BookCatalogService";
			private const string FullClassName = "BookCatalogService.Service.BookLookupService";

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
			public static object CreatePrivate(IFetchBookProcess fetchBookProcess)
			{
				var args = new object[] { fetchBookProcess };
				var privObj = new MSPrivateObject(FileName, FullClassName,
				                                  new[] { typeof(IFetchBookProcess) }, args);
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
			/// Gets or sets the fetch process.
			/// </summary>
			/// <value>The fetch process.</value>
			public IFetchBookProcess FetchProcess
			{
				get
				{
					return (IFetchBookProcess)_mmsPrivateObject.GetFieldOrProperty("_fetchProcess");
				}
				set
				{
					_mmsPrivateObject.SetFieldOrProperty("_fetchProcess", value);
				}
			}
		}
		#endregion
	}
}