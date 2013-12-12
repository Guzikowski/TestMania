
using System;
using NUnit.Framework;
using Project;

// Merge test 1234
// Merge test one

namespace TestProject
{
    [TestFixture]
    public class TestBaseClass
    {
        #region Concrete Test Class
        /// <summary>
        /// Concrete representation of base class for testing
        /// </summary>
        public class ConcreteBaseClass : BaseClass
        {
            public ConcreteBaseClass(string parameter)
                : base(parameter)
            {
            }
        }
        #endregion

        #region Concrete Test Class
        /// <summary>
        /// Summary description for MyObjectTester.
        /// </summary>
        public class BaseClassTester : ConcreteBaseClass
        {
            public BaseClassTester(string strName)
                : base(strName)
            {

            }
            public string TestProtectedMethod()
            {
                return base.BaseProtectedMethod();
            }
            
        }
        #endregion


        [Test]
        public void TestPublicMethod()
        {
            const string strExpected = "base public method.";
            var classUnderTest = new ConcreteBaseClass("Public Method Test");
            var strActual = classUnderTest.BasePublicMethod();
            Assert.AreEqual(strExpected, strActual);
        }
        [Test]
        public void TestPublicStaticMethod()
        {
            const string strExpected = "base public static method.";
            var strActual = BaseClass.BasePublicStaticMethod();
            Assert.AreEqual(strExpected, strActual);
        }
        [Test]
        public void TestPublicProperty()
        {
            const string strExpected = "base public property.";
            var classUnderTest = new ConcreteBaseClass("Public Property Test");
            var strActual = classUnderTest.BasePublicProperty;
            Assert.AreEqual(strExpected, strActual);
        }
        [Test]
        public void TestPublicStaticProperty()
        {
            const string strExpected = "base public static property.";
            var strActual = BaseClass.BasePublicStaticProperty;
            Assert.AreEqual(strExpected, strActual);
        }
       
         [Test]
        public void TestProtectedInstanceProperty()
        {
            const string strExpected = "base protected property.";

            var classUnderTest = new ConcreteBaseClass("Protected Property Test");
            var objectUnderTest = UnitTestUtilities.ReflectionTestHelper.GetInstanceProperty(
                typeof(BaseClass),
                "BaseProtectedProperty",
                classUnderTest,
                new object[0]);
            var strActual = Convert.ToString(objectUnderTest);

            Assert.AreEqual(strExpected, strActual);

        }

         [Test]
         public void TestProtectedStaticProperty()
         {
             const string strExpected = "base protected static property.";

             var objectUnderTest = UnitTestUtilities.ReflectionTestHelper.GetStaticProperty(
                 typeof(BaseClass),
                 "BaseProtectedStaticProperty",
                 new object[0]);
             var strActual = Convert.ToString(objectUnderTest);

             Assert.AreEqual(strExpected, strActual);

         }

         [Test]
         public void TestGetPrivateInstanceProperty()
         {
             const string strExpected = "base private property. Private Property Test";

             var classUnderTest = new ConcreteBaseClass("Private Property Test");
             var objectUnderTest = UnitTestUtilities.ReflectionTestHelper.GetInstanceProperty(
                 typeof(BaseClass),
                 "BasePrivateProperty",
                 classUnderTest,
                 new object[0]);
             var strActual = Convert.ToString(objectUnderTest);

             Assert.AreEqual(strExpected, strActual);

         }
         [Test]
         public void TestSetPrivateInstanceProperty()
         {
             const string strExpected = "base private property. PPT";

             var classUnderTest = new ConcreteBaseClass("Private Property Test");
             var objectUnderTest = UnitTestUtilities.ReflectionTestHelper.SetInstanceProperty(
                 typeof(BaseClass),
                 "BasePrivateProperty",
                 classUnderTest,
                 "PPT",
                 new object[0]);
             var strActual = Convert.ToString(objectUnderTest);

             Assert.AreEqual(strExpected, strActual);

         }

         [Test]
         public void TestPrivateStaticProperty()
         {
             const string strExpected = "base private static property.";

             var objectUnderTest = UnitTestUtilities.ReflectionTestHelper.GetStaticProperty(
                 typeof(BaseClass),
                 "BasePrivateStaticProperty",
                 new object[0]);
             var strActual = Convert.ToString(objectUnderTest);

             Assert.AreEqual(strExpected, strActual);

         }
        [Test]
        public void TestProtectedMethod()
        {
            const string strExpected = "base protected method.";
            var classUnderTest = new BaseClassTester("Protected Method Test");
            var strActual = classUnderTest.TestProtectedMethod();
            Assert.AreEqual(strExpected, strActual);
        }
        [Test]
        public void TestProtectedInstanceMethod()
        {
            const string strExpected = "base protected method.";

            var classUnderTest = new ConcreteBaseClass("Protected Method Test");
            var objectUnderTest = UnitTestUtilities.ReflectionTestHelper.RunInstanceMethod(
                typeof(BaseClass),
                "BaseProtectedMethod",
                classUnderTest,
                new object[0]);
            var strActual = Convert.ToString(objectUnderTest);

            Assert.AreEqual(strExpected, strActual);

        }
        [Test]
        public void TestProtectedStaticMethod()
        {
            const string strExpected = "base protected static method.";

            var objectUnderTest = UnitTestUtilities.ReflectionTestHelper.RunStaticMethod(
                typeof(BaseClass),
                "BaseProtectedStaticMethod", new object[0]);
            var strActual = Convert.ToString(objectUnderTest);

            Assert.AreEqual(strExpected, strActual);

        }
        [Test]
        public void TestPrivateStaticMethod()
        {
            const string strExpected = "base private static method.";

            var objectUnderTest = UnitTestUtilities.ReflectionTestHelper.RunStaticMethod(
                typeof(BaseClass),
                "BasePrivateStaticMethod", new object[0]);
            var strActual = Convert.ToString(objectUnderTest);

            Assert.AreEqual(strExpected, strActual);

        }

        [Test]
        public void TestPrivateInstanceMethod()
        {
            const string strExpected = "base private method. Private Method Test";

            var classUnderTest = new ConcreteBaseClass("Private Method Test");
            var objectUnderTest = UnitTestUtilities.ReflectionTestHelper.RunInstanceMethod(
                typeof(BaseClass),
                "BasePrivateMethod",
                classUnderTest,
                new object[0]);
            var strActual = Convert.ToString(objectUnderTest);

            Assert.AreEqual(strExpected, strActual);

        }
        [Test]
        public void TestPrivateStaticMethodWithParameters()
        {
            const string strExpected = "base private static method with parameters: arg1 = 'testing stage' arg2 = '33'. ";

            var objectUnderTest = UnitTestUtilities.ReflectionTestHelper.RunStaticMethod(
                typeof(BaseClass),
                "BasePrivateStaticMethodWithParameters", new object[] { "testing stage", 33 });
            var strActual = Convert.ToString(objectUnderTest);

            Assert.AreEqual(strExpected, strActual);

        }
        [Test]
        public void TestPrivateInstanceMethodWithParameters()
        {
            const string strExpected = "base private method with parameters: arg1 = 'testing string' arg2 = '11'. Private Method Test";

            var classUnderTest = new ConcreteBaseClass("Private Method Test");
            var objectUnderTest = UnitTestUtilities.ReflectionTestHelper.RunInstanceMethod(
                typeof(BaseClass),
                "BasePrivateMethodWithParameters",
                classUnderTest,
                new object[] { "testing string", 11});
            var strActual = Convert.ToString(objectUnderTest);

            Assert.AreEqual(strExpected, strActual);

        }
        [Test]
        public void TestGetPrivateField()
        {
            const string strExpected = "Private Field Test";
            var classUnderTest = new ConcreteBaseClass("Private Field Test");
            var objectUnderTest = UnitTestUtilities.ReflectionTestHelper.GetInstanceField(
                 typeof(BaseClass),
                "_baseParameter",
                classUnderTest);
            var strActual = Convert.ToString(objectUnderTest);
            Assert.AreEqual(strExpected, strActual);
        }

        [Test]
        public void TestSetPrivateField()
        {
            const string strExpected = "Setting Value Here";
            var classUnderTest = new ConcreteBaseClass("Private Field Test");
            var objectUnderTest = UnitTestUtilities.ReflectionTestHelper.SetInstanceField(
                 typeof(BaseClass),
                "_baseParameter",
                classUnderTest,
                "Setting Value Here");
            var strActual = Convert.ToString(objectUnderTest);
            Assert.AreEqual(strExpected, strActual);
        }

    }
}

