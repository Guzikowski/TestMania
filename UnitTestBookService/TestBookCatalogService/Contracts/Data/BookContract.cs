using System;
using IBookCatalogService.Contracts.Data;
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
		public static IBookContract GetBookContractGoodMock()
		{
			return new BookContract
			{
				Title = UnitTestValues.Title,
				Author = (AuthorContract)GetAuthorContractWithAliasGoodMock(),
				ISBN = UnitTestValues.ISBN,
				Series = UnitTestValues.Series,
				Genre = UnitTestValues.Genre,
				InCollection = true,
				Type = UnitTestValues.Type,
				DateAdded = DateTime.Now
			};
		}

	}
}

namespace TestBookCatalogService.Domain
{

	/// <summary>
	/// TestBookCatalogService.Domain.BookContractTest
	/// </summary>
	[TestFixture]
	public class BookContractTest : AutoMockerBase<BookContract>
	{
		#region Target Object Contructors
		/// <summary>
		/// Creates the target object.
		/// </summary>
		/// <returns></returns>
		private static BookContract CreateTargetObject()
		{
			return new BookContract();
		}

		/// <summary>
		/// Creates the target interface object.
		/// </summary>
		/// <returns></returns>
		private static IBookContract CreateTargetInterfaceObject()
		{
			IBookContract target = CreateTargetObject();
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
			var defaultValue = new AuthorContract();
			CheckProperty(p => p.Author, defaultValue, null, MockHelper.GetAuthorContractWithAliasGoodMock());
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
		/// Tests the type.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestType()
		{
			var target = CreateTargetObject();
			Assert.IsNull(target.Type);

			CheckProperty(p => p.Type, null, null, UnitTestValues.Type);
		}
		/// <summary>
		/// Tests the type of the interface.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestInterfaceType()
		{
			var target = CreateTargetInterfaceObject();
			Assert.IsNull(target.Type);

			target.Type = UnitTestValues.Type;
			Assert.AreEqual(UnitTestValues.Type, target.Type);
		}
		/// <summary>
		/// Tests the date added.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestDateAdded()
		{
			var target = CreateTargetObject();
			Assert.IsNull(target.DateAdded);

			CheckProperty(p => p.DateAdded, DateTime.MinValue, null, DateTime.MaxValue);
		}
		/// <summary>
		/// Tests the interface date added.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestInterfaceDateAdded()
		{
			var target = CreateTargetInterfaceObject();
			Assert.IsNull(target.DateAdded);

			var expected = DateTime.Now;
			target.DateAdded = expected;
			Assert.AreEqual(expected, target.DateAdded);
		}
		/// <summary>
		/// Tests the is new.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestIsNew()
		{
			var target = CreateTargetObject();
			Assert.IsNotNull(target.InCollection);

			CheckProperty(p => p.InCollection, false, false, true);
		}

		/// <summary>
		/// Tests the interface is new.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestInterfaceIsNew()
		{
			var target = CreateTargetInterfaceObject();
			Assert.IsNotNull(target.InCollection);

			target.InCollection = true;
			Assert.IsTrue(target.InCollection);
		}

	}
}