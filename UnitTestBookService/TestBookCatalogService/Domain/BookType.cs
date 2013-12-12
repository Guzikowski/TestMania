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
		public static IBookType GetBookTypeGoodMock()
		{
			return new BookType
			       	{
			       		Name = UnitTestValues.Type,
			       	};
		}
	}
}

namespace TestBookCatalogService.Domain
{

	#region MockHelper

	#endregion

	/// <summary>
	/// TestBookCatalogService.Domain.BookTypeTest
	/// </summary>
	[TestFixture]
	public class BookTypeTest : AutoMockerBase<BookType>
	{
		#region Target Object Contructors
		/// <summary>
		/// Creates the target object.
		/// </summary>
		/// <returns></returns>
		private static BookType CreateTargetObject()
		{
			return new BookType();
		}

		/// <summary>
		/// Creates the target interface object.
		/// </summary>
		/// <returns></returns>
		private static IBookType CreateTargetInterfaceObject()
		{
            IBookType target = CreateTargetObject();
			return target;
		}
		#endregion

		#region Private Accessor
		/// <summary>
		/// TestBookCatalogService.Domain.AuthorDetailTest.PrivateAccessor
		/// </summary>
		public class PrivateAccessor
		{
			private const string FileName = "BookCatalogService";
			private const string FullClassName = "BookCatalogService.Domain.BookType";

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

		}
		#endregion
	}
}