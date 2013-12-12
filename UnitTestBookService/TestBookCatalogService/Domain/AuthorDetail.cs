using System.Collections.Generic;
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
		/// Gets the author detail with alias good mock.
		/// </summary>
		/// <returns></returns>
		public static IAuthorDetail GetAuthorDetailWithAliasGoodMock()
		{
			return new AuthorDetail
			       	{
			       		FirstName = UnitTestValues.FirstName2,
			       		LastName = UnitTestValues.LastName2,
			       		Aliases = GetAuthorDetailListGoodMock()
			       	};
		}
		/// <summary>
		/// Gets the author detail list good mock.
		/// </summary>
		/// <returns></returns>
		public static IList<IAuthorDetail> GetAuthorDetailListGoodMock()
		{
			return new List<IAuthorDetail>
			       	{
			       		GetAuthorDetailGoodMock()
			       	};
		}

		/// <summary>
		/// Gets the author detail good mock.
		/// </summary>
		/// <returns></returns>
		public static IAuthorDetail GetAuthorDetailGoodMock()
		{
			return new AuthorDetail
			       	{
			       		FirstName = UnitTestValues.FirstName1,
			       		LastName = UnitTestValues.LastName1,
			       	};
		}

	}
}

namespace TestBookCatalogService.Domain
{
	#region MockHelper

	#endregion

	/// <summary>
	/// TestBookCatalogService.Domain.AuthorDetailTest
	/// </summary>
	[TestFixture]
	public class AuthorDetailTest : AutoMockerBase<AuthorDetail>
	{
		#region Target Object Contructors
		/// <summary>
		/// Creates the target object.
		/// </summary>
		/// <returns></returns>
		private static AuthorDetail CreateTargetObject()
		{
			return new AuthorDetail();
		}

		/// <summary>
		/// Creates the target interface object.
		/// </summary>
		/// <returns></returns>
		private static IAuthorDetail CreateTargetInterfaceObject()
		{
            IAuthorDetail target = CreateTargetObject();
			return target;
		}
		#endregion

		/// <summary>
		/// Tests the first name.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestFirstName()
		{
			var target = CreateTargetObject();
			Assert.IsNull(target.FirstName);

			CheckProperty(p => p.FirstName, null, null, UnitTestValues.FirstName1);
		}
		/// <summary>
		/// Tests the first name of the interface.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestInterfaceFirstName()
		{
			var target = CreateTargetInterfaceObject();
			Assert.IsNull(target.FirstName);

			target.FirstName = UnitTestValues.FirstName2;
			Assert.AreEqual(UnitTestValues.FirstName2, target.FirstName);
		}
		/// <summary>
		/// Tests the last name.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestLastName()
		{
			var target = CreateTargetObject();
			Assert.IsNull(target.LastName);

			CheckProperty(p => p.LastName, null, null, UnitTestValues.LastName1);
		}
		/// <summary>
		/// Tests the last name of the interface.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestInterfaceLastName()
		{
			var target = CreateTargetInterfaceObject();
			Assert.IsNull(target.LastName);

			target.LastName = UnitTestValues.LastName2;
			Assert.AreEqual(UnitTestValues.LastName2, target.LastName);
		}
		/// <summary>
		/// Tests the aliases.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestAliases()
		{
			var target = CreateTargetObject();
			Assert.IsNotNull(target.Aliases);
            IList<IAuthorDetail> defaultValue = new List<IAuthorDetail>();
			CheckProperty(p => p.Aliases, defaultValue, defaultValue, MockHelper.GetAuthorDetailListGoodMock());
		}
		/// <summary>
		/// Tests the interface aliases.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestInterfaceAliases()
		{
			var target = CreateTargetInterfaceObject();
			Assert.IsNotNull(target.Aliases);

			var expected = MockHelper.GetAuthorDetailListGoodMock();
			target.Aliases = expected;
			Assert.AreEqual(expected, target.Aliases);
		}
		/// <summary>
		/// Tests the private aliases.
		/// </summary>
		[Test]
		[Category("version2.0")]
		[Category("defect")]
		[Category("BCS100")]
		public void TestPrivateAliases()
		{
			var param0 = PrivateAccessor.CreatePrivate();
			var target = new PrivateAccessor(param0);

			Assert.IsNotNull(target);
			Assert.IsNotNull(target.PrivateAliases);
			
			var expected = MockHelper.GetAuthorDetailListGoodMock();
			target.PrivateAliases = expected;
			Assert.AreEqual(expected, target.PrivateAliases);

			target.PrivateAliases = null;
			Assert.IsNull(target.PrivateAliases);

		}
		/// <summary>
		/// Converts to contract null object.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void ConvertToContractNullObject()
		{
			var actual = AuthorDetail.ConvertToContract(null);
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
			var actual = AuthorDetail.ConvertToContract(expected.Author);
			Assert.IsNotNull(actual);
			Assert.AreEqual(actual.FirstName, expected.Author.FirstName);
		}
		#region Private Accessor
		/// <summary>
		/// TestBookCatalogService.Domain.AuthorDetailTest.PrivateAccessor
		/// </summary>
		public class PrivateAccessor
		{
			private const string FileName = "BookCatalogService";
			private const string FullClassName = "BookCatalogService.Domain.AuthorDetail";

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
			/// Gets or sets the private aliases.
			/// </summary>
			/// <value>The private aliases.</value>
			public IList<IAuthorDetail> PrivateAliases
			{
				get
				{
					return (IList<IAuthorDetail>)_mmsPrivateObject.GetFieldOrProperty("_aliases");
				}
				set
				{
					_mmsPrivateObject.SetFieldOrProperty("_aliases", value);
				}
			}
		}
		#endregion
	}
}