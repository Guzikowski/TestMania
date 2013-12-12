using System.Collections.Generic;
using IBookCatalogService.Contracts.Data;
using NUnit.Framework;

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
		public static IAuthorContract GetAuthorContractWithAliasGoodMock()
		{
			return new AuthorContract
					{
						FirstName = UnitTestValues.FirstName2,
						LastName = UnitTestValues.LastName2,
						Aliases = GetAuthorContractListGoodMock()
					};
		}
		/// <summary>
		/// Gets the author detail list good mock.
		/// </summary>
		/// <returns></returns>
		public static List<AuthorContract> GetAuthorContractListGoodMock()
		{
			return new List<AuthorContract>
			       	{
			       		(AuthorContract)GetAuthorContractGoodMock()
			       	};
		}

		/// <summary>
		/// Gets the author detail good mock.
		/// </summary>
		/// <returns></returns>
		public static IAuthorContract GetAuthorContractGoodMock()
		{
			return new AuthorContract
					{
						FirstName = UnitTestValues.FirstName1,
						LastName = UnitTestValues.LastName1,
					};
		}

	}
}
namespace TestBookCatalogService.Contracts.Data
{

	/// <summary>
	/// TestBookCatalogService.Domain.AuthorContractTest
	/// </summary>
	[TestFixture]
	public class AuthorContractTest : AutoMockerBase<AuthorContract>
	{
		#region Target Object Contructors
		/// <summary>
		/// Creates the target object.
		/// </summary>
		/// <returns></returns>
		private static AuthorContract CreateTargetObject()
		{
			return new AuthorContract();
		}

		/// <summary>
		/// Creates the target interface object.
		/// </summary>
		/// <returns></returns>
		private static IAuthorContract CreateTargetInterfaceObject()
		{
			IAuthorContract target = CreateTargetObject();
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
			Assert.IsNull(target.Aliases);
			var defaultValue = new List<AuthorContract>();
			CheckProperty(p => p.Aliases, defaultValue, null, MockHelper.GetAuthorContractListGoodMock());
		}
	}
}