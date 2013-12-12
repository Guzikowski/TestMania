using BookCatalogService.Data;
using IBookCatalogService.Data;
using NUnit.Framework;

namespace TestBookCatalogService.Data
{
	/// <summary>
	/// TestBookCatalogService.Data.ProviderResultTest
	/// </summary>
	[TestFixture]
	public class ProviderResultTest : AutoMockerBase<ProviderResult>
	{
		#region Target Object Contructors
		/// <summary>
		/// Creates the target object.
		/// </summary>
		/// <returns></returns>
		private static ProviderResult CreateTargetObject()
		{
			return new ProviderResult();
		}

		/// <summary>
		/// Creates the target interface object.
		/// </summary>
		/// <returns></returns>
		private static IProviderResult CreateTargetInterfaceObject()
		{
			IProviderResult target = CreateTargetObject();
			return target;
		}
		#endregion

		/// <summary>
		/// Tests the id.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestId()
		{
			var target = CreateTargetObject();
			Assert.IsNull(target.Id);

			CheckProperty(p => p.Id, int.MinValue, null, int.MaxValue);
		}
		/// <summary>
		/// Tests the interface id.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestInterfaceId()
		{
			var target = CreateTargetInterfaceObject();
			Assert.IsNull(target.Id);

			target.Id = UnitTestValues.Id;
			Assert.AreEqual(UnitTestValues.Id, target.Id);
		}
		/// <summary>
		/// Tests the timestamp.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestVersionTimestamp()
		{
			var target = CreateTargetObject();
			Assert.IsNull(target.VersionTimestamp);

			CheckProperty(p => p.VersionTimestamp, UnitTestValues.TimestampBegin, null, UnitTestValues.TimestampEnd);
		}
		/// <summary>
		/// Tests the interface timestamp.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestInterfaceVersionTimestamp()
		{
			var target = CreateTargetInterfaceObject();
			Assert.IsNull(target.VersionTimestamp);

			target.VersionTimestamp = UnitTestValues.TimestampBegin;
			Assert.AreEqual(UnitTestValues.TimestampBegin, target.VersionTimestamp);
		}

	}
}