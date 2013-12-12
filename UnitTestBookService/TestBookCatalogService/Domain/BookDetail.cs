using System.Collections.Generic;
using BookCatalogService.Domain;
using IBookCatalogService.Contracts.Data;
using IBookCatalogService.Domain;
using NUnit.Framework;
using MSPrivateObject = Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject;
using MSPrivateType = Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType;

namespace TestBookCatalogService
{
	/// <summary>
	/// TestBookCatalogService.Domain.MockHelper
	/// </summary>
	public static partial class MockHelper
	{

		/// <summary>
		/// Gets the author detail good mock.
		/// </summary>
		/// <returns></returns>
		public static IBookDetail GetBookDetailGoodMock()
		{
			return new BookDetail
			       	{
			       		Title = UnitTestValues.Title,
			       		Author = GetAuthorDetailWithAliasGoodMock(),
			       		ISBN = UnitTestValues.ISBN,
			       		Series = UnitTestValues.Series,
			       		Genre = UnitTestValues.Genre,
			       		CollectionDetail = GetBookCollectionGoodMock()
			       	};
		}

	}
}

namespace TestBookCatalogService.Domain
{
	#region MockHelper

	#endregion

	/// <summary>
	/// TestBookCatalogService.Domain.BookDetailTest
	/// </summary>
	[TestFixture]
	public class BookDetailTest : AutoMockerBase<BookDetail>
	{
		#region Target Object Contructors
		/// <summary>
		/// Creates the target object.
		/// </summary>
		/// <returns></returns>
		private static BookDetail CreateTargetObject()
		{
			return new BookDetail();
		}

		/// <summary>
		/// Creates the target interface object.
		/// </summary>
		/// <returns></returns>
		private static IBookDetail CreateTargetInterfaceObject()
		{
            IBookDetail target = CreateTargetObject();
			return target;
		}
		#endregion

		/// <summary>
		/// Tests the title.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestTitle()
		{
			var target = CreateTargetObject();
			Assert.IsNull(target.Title);

			CheckProperty(p => p.Title, null, null, UnitTestValues.Title);
		}
		/// <summary>
		/// Tests the interface title.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestInterfaceTitle()
		{
			var target = CreateTargetInterfaceObject();
			Assert.IsNull(target.Title);

			target.Title = UnitTestValues.Title;
			Assert.AreEqual(UnitTestValues.Title, target.Title);
		}
		/// <summary>
		/// Tests the author.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestAuthor()
		{
			var target = CreateTargetObject();
			Assert.IsNull(target.Author);

			CheckProperty(p => p.Author, null, null, MockHelper.GetAuthorDetailWithAliasGoodMock());
		}
		/// <summary>
		/// Tests the interface author.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestInterfaceAuthor()
		{
			var target = CreateTargetInterfaceObject();
			Assert.IsNull(target.Author);

			var expected = MockHelper.GetAuthorDetailGoodMock();
			target.Author = expected;
			Assert.AreEqual(expected, target.Author);
		}

		/// <summary>
		/// Tests the ISBN.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestISBN()
		{
			var target = CreateTargetObject();
			Assert.IsNull(target.ISBN);

			CheckProperty(p => p.ISBN, null, null, UnitTestValues.ISBN);
		}
		/// <summary>
		/// Tests the interface ISBN.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestInterfaceISBN()
		{
			var target = CreateTargetInterfaceObject();
			Assert.IsNull(target.ISBN);

			target.ISBN = UnitTestValues.ISBN;
			Assert.AreEqual(UnitTestValues.ISBN, target.ISBN);
		}
		/// <summary>
		/// Tests the series.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestSeries()
		{
			var target = CreateTargetObject();
			Assert.IsNull(target.Series);

			CheckProperty(p => p.Series, null, null, UnitTestValues.Series);
		}
		/// <summary>
		/// Tests the interface series.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestInterfaceSeries()
		{
			var target = CreateTargetInterfaceObject();
			Assert.IsNull(target.Series);

			target.Series = UnitTestValues.Series;
			Assert.AreEqual(UnitTestValues.Series, target.Series);
		}
		/// <summary>
		/// Tests the genre.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestGenre()
		{
			var target = CreateTargetObject();
			Assert.IsNull(target.Genre);

			CheckProperty(p => p.Genre, null, null, UnitTestValues.Genre);
		}
		/// <summary>
		/// Tests the interface genre.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestInterfaceGenre()
		{
			var target = CreateTargetInterfaceObject();
			Assert.IsNull(target.Genre);

			target.Genre = UnitTestValues.Genre;
			Assert.AreEqual(UnitTestValues.Genre, target.Genre);
		}
		/// <summary>
		/// Tests the collection detail.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestCollectionDetail()
		{
			var target = CreateTargetObject();
			Assert.IsNull(target.CollectionDetail);

			CheckProperty(p => p.CollectionDetail, null, null, MockHelper.GetBookCollectionGoodMock());
		}
		/// <summary>
		/// Tests the interface collection detail.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestInterfaceCollectionDetail()
		{
			var target = CreateTargetInterfaceObject();
			Assert.IsNull(target.CollectionDetail);

			var expected = MockHelper.GetBookCollectionGoodMock();
			target.CollectionDetail = expected;
			Assert.AreEqual(expected, target.CollectionDetail);
		}


		/// <summary>
		/// Tests the in collection.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestInCollection()
		{
			var target = CreateTargetObject();
			Assert.IsFalse(target.InCollection);

			target.CollectionDetail = MockHelper.GetBookCollectionGoodMock();
			Assert.IsTrue(target.InCollection);

			target.CollectionDetail = null;
			Assert.IsFalse(target.InCollection);
		}
		/// <summary>
		/// Converts to contract null object.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void ConvertToContractNullObject()
		{
			var actual = BookDetail.ConvertToContract(null);
			Assert.IsNotNull(actual);
		}
		/// <summary>
		/// Converts to contract.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void ConvertToContract()
		{
			var expected = MockHelper.GetBookDetailGoodMock();
			var actual = BookDetail.ConvertToContract(expected);
			Assert.IsNotNull(actual);
			Assert.AreEqual(actual.Title, expected.Title);
		}
		
		/// <summary>
		/// Tests the initialise.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestInitialise()
		{
			var target = CreateTargetObject();
			Assert.IsNotNull(target);

			target.Initialise(MockHelper.GetGenreTypeGoodMock());
			Assert.IsNotNull(target.Genre);
			Assert.AreEqual(UnitTestValues.Genre, target.Genre);
		}
		/// <summary>
		/// Tests the initialise null object.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestInitialiseNullObject()
		{
			var target = CreateTargetObject();
			target.Initialise(null);
			Assert.IsNull(target.Genre);
		}
		/// <summary>
		/// Tests the initialise full.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestInitialiseFull()
		{
			var target = CreateTargetObject();
			Assert.IsNotNull(target);

			target.Initialise(MockHelper.GetGenreTypeGoodMock(), MockHelper.GetSeriesNameGoodMock());
			Assert.IsNotNull(target.Genre);
			Assert.AreEqual(UnitTestValues.Genre, target.Genre);
			Assert.IsNotNull(target.Series);
			Assert.AreEqual(UnitTestValues.Series, target.Series);

		}
		/// <summary>
		/// Tests the initialise full null object.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestInitialiseFullNullObject()
		{
			var target = CreateTargetObject();
			target.Initialise(null, null);
			Assert.IsNull(target.Genre);
			Assert.IsNull(target.Series);
		}

		/// <summary>
		/// Tests the interface initialise.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestInterfaceInitialise()
		{
			var target = CreateTargetInterfaceObject();
			Assert.IsNotNull(target);

			target.Initialise(MockHelper.GetGenreTypeGoodMock());
			Assert.IsNotNull(target.Genre);
			Assert.AreEqual(UnitTestValues.Genre, target.Genre);
		}
		/// <summary>
		/// Tests the interface initialise null object.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestInterfaceInitialiseNullObject()
		{
			var target = CreateTargetInterfaceObject();
			target.Initialise(null);
			Assert.IsNull(target.Genre);
		}
		/// <summary>
		/// Tests the interface initialise full.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestInterfaceInitialiseFull()
		{
			var target = CreateTargetInterfaceObject();
			Assert.IsNotNull(target);

			target.Initialise(MockHelper.GetGenreTypeGoodMock(), MockHelper.GetSeriesNameGoodMock());
			Assert.IsNotNull(target.Genre);
			Assert.AreEqual(UnitTestValues.Genre, target.Genre);
			Assert.IsNotNull(target.Series);
			Assert.AreEqual(UnitTestValues.Series, target.Series);
		}
		/// <summary>
		/// Tests the interface initialise full null object.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestInterfaceInitialiseFullNullObject()
		{
			var target = CreateTargetInterfaceObject();
			target.Initialise(null, null);
			Assert.IsNull(target.Genre);
		}

		/// <summary>
		/// Tests the type of the private book.
		/// </summary>
		[Test]
		[Category("version2.0")]
		[Category("defect")]
		[Category("BCS102")]
		public void TestPrivateBookType()
		{
			var param0 = PrivateAccessor.CreatePrivate();
			var target = new PrivateAccessor(param0);

			Assert.IsNotNull(target);
			Assert.IsNotNull(target.PrivateGenre);

			var expected = MockHelper.GetGenreTypeGoodMock();
			target.PrivateGenre = expected;
			Assert.AreEqual(expected, target.PrivateGenre);

			target.PrivateGenre = null;
			Assert.IsNull(target.PrivateGenre);
		}
		/// <summary>
		/// Tests the private series.
		/// </summary>
		[Test]
		[Category("version2.0")]
		[Category("defect")]
		[Category("BCS103")]
		public void TestPrivateSeries()
		{
			var param0 = PrivateAccessor.CreatePrivate();
			var target = new PrivateAccessor(param0);

			Assert.IsNotNull(target);
			Assert.IsNotNull(target.PrivateSeries);

			var expected = MockHelper.GetSeriesNameGoodMock();
			target.PrivateSeries = expected;
			Assert.AreEqual(expected, target.PrivateSeries);

			target.PrivateSeries = null;
			Assert.IsNull(target.PrivateSeries);
		}

		#region Private Accessor
		/// <summary>
		/// TestBookCatalogService.Domain.BookDetailTest.PrivateAccessor
		/// </summary>
		public class PrivateAccessor
		{
			private const string FileName = "BookCatalogService";
			private const string FullClassName = "BookCatalogService.Domain.BookDetail";

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
			public static object CreatePrivate()
			{
				var privObj = new MSPrivateObject(FileName, FullClassName);
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
			/// Gets or sets the private series.
			/// </summary>
			/// <value>The private series.</value>
			public ISeriesName PrivateSeries
			{
				get
				{
					return (ISeriesName)_mmsPrivateObject.GetFieldOrProperty("_series");
				}
				set
				{
					_mmsPrivateObject.SetFieldOrProperty("_series", value);
				}
			}
			/// <summary>
			/// Gets or sets the private genre.
			/// </summary>
			/// <value>The private genre.</value>
			public IGenreType PrivateGenre
			{
				get
				{
					return (IGenreType)_mmsPrivateObject.GetFieldOrProperty("_genre");
				}
				set
				{
					_mmsPrivateObject.SetFieldOrProperty("_genre", value);
				}
			}

		}
		#endregion
	}
}