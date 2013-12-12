using BookCatalogService.Domain;
using IBookCatalogService.Domain;
using NUnit.Framework;
using MSPrivateObject = Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject;
using MSPrivateType = Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType;


namespace TestBookCatalogService.Domain
{
	/// <summary>
	/// TestBookCatalogService.Domain.BaseLookupTest
	/// </summary>
	[TestFixture]
	public class BaseLookupTest : AutoMockerBase<BaseLookup>
	{
		#region Target Object Contructors
		/// <summary>
		/// TestBookCatalogService.Domain.BaseLookupTest.ConcreteBaseLookup
		/// </summary>
		public class ConcreteBaseLookup : BaseLookup
		{
		}
		/// <summary>
		/// Creates the target object.
		/// </summary>
		/// <returns></returns>
		private static ConcreteBaseLookup CreateTargetObject()
		{
			return new ConcreteBaseLookup();
		}

		/// <summary>
		/// Creates the target interface object.
		/// </summary>
		/// <returns></returns>
		private static IBaseLookup CreateTargetInterfaceObject()
		{
            IBaseLookup target = CreateTargetObject();
			return target;
		}
		#endregion

		/// <summary>
		/// Tests the name.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestName()
		{
			var target = CreateTargetObject();
			Assert.IsNull(target.Name);

			CheckProperty(p => p.Name, null, null, UnitTestValues.LastName1);
		}
		/// <summary>
		/// Tests the name of the interface.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestInterfaceName()
		{
			var target = CreateTargetInterfaceObject();
			Assert.IsNull(target.Name);

			target.Name = UnitTestValues.LastName1;
			Assert.AreEqual(UnitTestValues.LastName1, target.Name);
		}
		/// <summary>
		/// Tests the value changed.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestValueChanged()
		{
			var target = CreateTargetObject();
			Assert.IsNull(target.Name);
			Assert.IsFalse(target.HasChanged);

			target.ValueChanged(UnitTestValues.LastName1);
			Assert.IsNotNull(target.Name);
			Assert.IsTrue(target.HasChanged);
			Assert.AreEqual(UnitTestValues.LastName1, target.Name);
		}
		/// <summary>
		/// Tests the interface id.
		/// </summary>
		[Test]
		[Category("version1.0")]
		public void TestInterfaceId()
		{
			var target = CreateTargetInterfaceObject();
			Assert.IsNull(target.Name);
			Assert.IsFalse(target.HasChanged);

			target.ValueChanged(UnitTestValues.LastName1);
			Assert.IsNotNull(target.Name);
			Assert.IsTrue(target.HasChanged);
			Assert.AreEqual(UnitTestValues.LastName1, target.Name);
		}

		#region Private Accessor
		/// <summary>
		/// TestBookCatalogService.Domain.AuthorDetailTest.PrivateAccessor
		/// </summary>
		public class PrivateAccessor
		{
			private const string FileName = "BookCatalogService";
			private const string FullClassName = "BookCatalogService.Domain.BaseLookup";

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