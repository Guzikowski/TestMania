using BookCatalogService.Domain;
using IBookCatalogService.Domain;
using NUnit.Framework;
using Assert=NUnit.Framework.Assert;
using MSPrivateObject = Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject;
using MSPrivateType = Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType;


namespace TestBookCatalogService.Domain
{

	/// <summary>
	/// TestBookCatalogService.Domain.BaseDomainTest
	/// </summary>
	[TestFixture]
	public class BaseDomainTest : AutoMockerBase<BaseDomain>
	{
		#region Target Object Contructors
		/// <summary>
		/// TestBookCatalogService.Domain.BaseDomainTest.ConcreteBaseDomain
		/// </summary>
		public class ConcreteBaseDomain : BaseDomain
		{
		}
		/// <summary>
		/// Creates the target object.
		/// </summary>
		/// <returns></returns>
		private static ConcreteBaseDomain CreateTargetObject()
		{
			return new ConcreteBaseDomain();
		}

		/// <summary>
		/// Creates the target interface object.
		/// </summary>
		/// <returns></returns>
		private static IBaseDomain CreateTargetInterfaceObject()
		{
            IBaseDomain target = CreateTargetObject();
			return target;
		}
		#endregion

		/// <summary>
		/// Tests the is new.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestIsNew()
		{
			var target = CreateTargetObject();
			Assert.IsNotNull(target.IsNew);

			CheckProperty(p => p.IsNew, false, false, true);
		}
		/// <summary>
		/// Tests the interface is new.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestInterfaceIsNew()
		{
			var target = CreateTargetInterfaceObject();
			Assert.IsNotNull(target.IsNew);

			target.IsNew = true;
			Assert.IsTrue(target.IsNew);
		}
		/// <summary>
		/// Tests the is removed.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestIsRemoved()
		{
			var target = CreateTargetObject();
			Assert.IsNotNull(target.IsRemoved);

			CheckProperty(p => p.IsNew, false, false, true);
		}
		/// <summary>
		/// Tests the interface is removed.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestInterfaceIsRemoved()
		{
			var target = CreateTargetInterfaceObject();
			Assert.IsNotNull(target.IsRemoved);

			target.IsRemoved = true;
			Assert.IsTrue(target.IsRemoved);
		}
		/// <summary>
		/// Tests the has changed.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestHasChanged()
		{
			var target = CreateTargetObject();
			Assert.IsNotNull(target.HasChanged);

			CheckProperty(p => p.HasChanged, false, false, true);
		}
		/// <summary>
		/// Tests the interface has changed.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestInterfaceHasChanged()
		{
			var target = CreateTargetInterfaceObject();
			Assert.IsNotNull(target.HasChanged);

			target.HasChanged = true;
			Assert.IsTrue(target.HasChanged);
		}
		/// <summary>
		/// Tests the id.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestId()
		{
			var target = CreateTargetObject();
			Assert.IsNotNull(target.Id);

			CheckProperty(p => p.Id, int.MinValue, 0, int.MaxValue);
		}
		/// <summary>
		/// Tests the interface id.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestInterfaceId()
		{
			var target = CreateTargetInterfaceObject();
			Assert.IsNotNull(target.Id);

			target.Id = UnitTestValues.Id;
			Assert.AreEqual(UnitTestValues.Id, target.Id);
		}
		/// <summary>
		/// Tests the timestamp.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestTimestamp()
		{
			var target = CreateTargetObject();
			Assert.IsNull(target.Timestamp);

			CheckProperty(p => p.Timestamp, UnitTestValues.TimestampBegin, null, UnitTestValues.TimestampEnd);
		}
		/// <summary>
		/// Tests the interface timestamp.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestInterfaceTimestamp()
		{
			var target = CreateTargetInterfaceObject();
			Assert.IsNull(target.Timestamp);

			target.Timestamp = UnitTestValues.TimestampBegin;
			Assert.AreEqual(UnitTestValues.TimestampBegin, target.Timestamp);
		}

		#region Private Accessor
		/// <summary>
		/// TestBookCatalogService.Domain.AuthorDetailTest.PrivateAccessor
		/// </summary>
		public class PrivateAccessor
		{
			private const string FileName = "BookCatalogService";
			private const string FullClassName = "BookCatalogService.Domain.BaseDomain";

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