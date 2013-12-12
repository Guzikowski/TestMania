using System;
using BookCatalogService.Domain;
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
		public static IBookCollection GetBookCollectionGoodMock()
		{
			return new BookCollection
			       	{
			       		Type = UnitTestValues.Type,
			       		DateAdded = DateTime.Now,
			       	};
		}

	}
}

namespace TestBookCatalogService.Domain
{
	#region MockHelper

	#endregion

	/// <summary>
	/// TestBookCatalogService.Domain.BookCollectionTest
	/// </summary>
	[TestFixture]
	public class BookCollectionTest : AutoMockerBase<BookCollection>
	{
		#region Target Object Contructors
		/// <summary>
		/// Creates the target object.
		/// </summary>
		/// <returns></returns>
		private static BookCollection CreateTargetObject()
		{
			return new BookCollection();
		}

		/// <summary>
		/// Creates the target interface object.
		/// </summary>
		/// <returns></returns>
		private static IBookCollection CreateTargetInterfaceObject()
		{
            IBookCollection target = CreateTargetObject();
			return target;
		}
		#endregion

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
		/// Tests the initialise.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestInitialise()
		{
			var target = CreateTargetObject();
			Assert.IsNotNull(target);
			
			target.Initialise(MockHelper.GetBookTypeGoodMock());
			Assert.IsNotNull(target.Type);
			Assert.AreEqual(UnitTestValues.Type, target.Type);
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
			Assert.IsNull(target.Type);
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

			target.Initialise(MockHelper.GetBookTypeGoodMock());
			Assert.IsNotNull(target.Type);
			Assert.AreEqual(UnitTestValues.Type, target.Type);
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
			Assert.IsNull(target.Type);
		}

		/// <summary>
		/// Tests the type of the private book.
		/// </summary>
		[Test]
		[Category("version2.0")]
		[Category("defect")]
		[Category("BCS101")]
		public void TestPrivateBookType()
		{
			var param0 = PrivateAccessor.CreatePrivate();
			var target = new PrivateAccessor(param0);

			Assert.IsNotNull(target);
			Assert.IsNotNull(target.PrivateBookType);

			var expected = MockHelper.GetBookTypeGoodMock();
			target.PrivateBookType = expected;
			Assert.AreEqual(expected, target.PrivateBookType);

			target.PrivateBookType = null;
			Assert.IsNull(target.PrivateBookType);
		}

		#region Private Accessor
		/// <summary>
		/// TestBookCatalogService.Domain.BookCollectionTest.PrivateAccessor
		/// </summary>
		public class PrivateAccessor
		{
			private const string FileName = "BookCatalogService";
			private const string FullClassName = "BookCatalogService.Domain.BookCollection";

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
			/// Gets or sets the type of the private book.
			/// </summary>
			/// <value>The type of the private book.</value>
			public IBookType PrivateBookType
			{
				get
				{
					return (IBookType)_mmsPrivateObject.GetFieldOrProperty("_bookType");
				}
				set
				{
					_mmsPrivateObject.SetFieldOrProperty("_bookType", value);
				}
			}
		}
		#endregion
	}
}