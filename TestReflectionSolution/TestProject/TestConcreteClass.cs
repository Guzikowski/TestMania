
using System;
using NUnit.Framework;
using Project;

namespace TestProject
{
    [TestFixture]
    public class TestConcreteClass
    {

        #region Concrete Test Class
        /// <summary>
        /// Summary description for MyObjectTester.
        /// </summary>
        public class ConcreteClassTester : ConcreteClass
        {
            public ConcreteClassTester(string strName)
                : base(strName)
            {

            }
            public string TestProtectedMethod()
            {
                return ConcreteProtectedMethod();
            }

            public string TestProtectedProperty
            {
                get { return ConcreteProtectedProperty; }
            }
        }
        #endregion
        [Test]
        public void TestPublicProperty()
        {
            const string strExpected = "concrete public property.";
            var classUnderTest = new ConcreteClass("Public Property Test");
            var strActual = classUnderTest.ConcretePublicProperty;
            Assert.AreEqual(strExpected, strActual);
        }
        [Test]
        public void TestPublicStaticProperty()
        {
            const string strExpected = "concrete public static property.";
            var strActual = ConcreteClass.ConcretePublicStaticProperty;
            Assert.AreEqual(strExpected, strActual);
        }
        [Test]
        public void TestPublicMethod()
        {
            const string strExpected = "concrete public method.";
            var classUnderTest = new ConcreteClass("Public Method Test");
            var strActual = classUnderTest.ConcretePublicMethod();
            Assert.AreEqual(strExpected, strActual);
        }
        [Test]
        public void TestPublicStaticMethod()
        {
            const string strExpected = "concrete public static method.";
            var strActual = ConcreteClass.ConcretePublicStaticMethod();
            Assert.AreEqual(strExpected, strActual);
        }
        [Test]
        public void TestBasePublicMethod()
        {
            const string strExpected = "overridden base public method.";
            var classUnderTest = new ConcreteClass("Public Method Test");
            var strActual = classUnderTest.BasePublicMethod();
            Assert.AreEqual(strExpected, strActual);
        }
        [Test]
        public void TestProtectedMethod()
        {
            const string strExpected = "concrete protected method.";
            var classUnderTest = new ConcreteClassTester("Protected Method Test");
            var strActual = classUnderTest.TestProtectedMethod();
            Assert.AreEqual(strExpected, strActual);
        }

        [Test]
        public void TestProtectedInstanceMethod()
        {
            const string strExpected = "concrete protected method.";
            var classUnderTest = new ConcreteClass("Protected Method Test");
            var objectUnderTest = UnitTestUtilities.ReflectionTestHelper.RunInstanceMethod(
                 typeof(ConcreteClass),
                "ConcreteProtectedMethod",
                classUnderTest,
                new object[0]);
            var strActual = Convert.ToString(objectUnderTest);
            Assert.AreEqual(strExpected, strActual);
        }


        [Test]
        public void TestBaseProtectedInstanceMethod()
        {
            const string strExpected = "overriden base protected method.";
            var classUnderTest = new ConcreteClass("Base Protected Method Test");
            var objectUnderTest = UnitTestUtilities.ReflectionTestHelper.RunInstanceMethod(
                 typeof(ConcreteClass),
                "BaseProtectedMethod",
                classUnderTest,
                new object[0]);
            var strActual = Convert.ToString(objectUnderTest);
            Assert.AreEqual(strExpected, strActual);
        }

        [Test]
        public void TestProtectedStaticMethod()
        {
            const string strExpected = "concrete protected static method.";

            var objectUnderTest = UnitTestUtilities.ReflectionTestHelper.RunStaticMethod(
                typeof(ConcreteClass),
                "ConcreteProtectedStaticMethod", new object[0]);
            var strActual = Convert.ToString(objectUnderTest);

            Assert.AreEqual(strExpected, strActual);

        }


        [Test]
        public void TestProtectedProperty()
        {
            const string strExpected = "concrete protected property. default2";
            var classUnderTest = new ConcreteClassTester("Protected Property Test");
            var strActual = classUnderTest.TestProtectedProperty;
            Assert.AreEqual(strExpected, strActual);
        }

        [Test]
        public void TestGetProtectedProperty()
        {
            const string strExpected = "concrete protected property. default2";
            var classUnderTest = new ConcreteClass("Protected Property Test");
            var objectUnderTest = UnitTestUtilities.ReflectionTestHelper.GetInstanceProperty(
                 typeof(ConcreteClass),
                "ConcreteProtectedProperty",
                classUnderTest,
                new object[0]);
            var strActual = Convert.ToString(objectUnderTest);
            Assert.AreEqual(strExpected, strActual);
        }
        [Test]
        public void TestGetBaseProtectedProperty()
        {
            const string strExpected = "overridde base protected property.";
            var classUnderTest = new ConcreteClass("Protected Property Test");
            var objectUnderTest = UnitTestUtilities.ReflectionTestHelper.GetInstanceProperty(
                 typeof(ConcreteClass),
                "BaseProtectedProperty",
                classUnderTest,
                new object[0]);
            var strActual = Convert.ToString(objectUnderTest);
            Assert.AreEqual(strExpected, strActual);
        }
        [Test]
        public void TestGetProtectedStaticProperty()
        {
            const string strExpected = "concrete protected static property.";
            var objectUnderTest = UnitTestUtilities.ReflectionTestHelper.GetStaticProperty(
                 typeof(ConcreteClass),
                "ConcreteProtectedStaticProperty",
                new object[0]);
            var strActual = Convert.ToString(objectUnderTest);
            Assert.AreEqual(strExpected, strActual);
        }
        [Test]
        public void TestGetPrivateStaticProperty()
        {
            const string strExpected = "concrete private property. default";
            var objectUnderTest = UnitTestUtilities.ReflectionTestHelper.GetStaticProperty(
                 typeof(ConcreteClass),
                "ConcretePrivateStaticProperty",
                new object[0]);
            var strActual = Convert.ToString(objectUnderTest);
            Assert.AreEqual(strExpected, strActual);
        }
        [Test]
        public void TestSetProtectedProperty()
        {
            const string strExpected = "concrete protected property. Setting Value Here";
            var classUnderTest = new ConcreteClass("Protected Property Test");
            var objectUnderTest = UnitTestUtilities.ReflectionTestHelper.SetInstanceProperty(
                 typeof(ConcreteClass),
                "ConcreteProtectedProperty",
                classUnderTest,
                "Setting Value Here",
                new object[0]);
            var strActual = Convert.ToString(objectUnderTest);
            Assert.AreEqual(strExpected, strActual);
        }

        [Test]
        public void TestGetPrivateProperty()
        {
            const string strExpected = "concrete private property. Private Property Test";
            var classUnderTest = new ConcreteClass("Private Property Test");
            var objectUnderTest = UnitTestUtilities.ReflectionTestHelper.GetInstanceProperty(
                 typeof(ConcreteClass),
                "ConcretePrivateProperty",
                classUnderTest,
                new object[0]);
            var strActual = Convert.ToString(objectUnderTest);
            Assert.AreEqual(strExpected, strActual);
        }
        [Test]
        public void TestSetPrivateProperty()
        {
            const string strExpected = "concrete private property. Setting Value Here";
            var classUnderTest = new ConcreteClass("Private Property Test");
            var objectUnderTest = UnitTestUtilities.ReflectionTestHelper.SetInstanceProperty(
                 typeof(ConcreteClass),
                "ConcretePrivateProperty",
                classUnderTest,
                "Setting Value Here",
                new object[0]);
            var strActual = Convert.ToString(objectUnderTest);
            Assert.AreEqual(strExpected, strActual);
        }
        [Test]
        public void TestPrivateStaticMethod()
        {
            const string strExpected = "concrete private static method.";

            var objectUnderTest = UnitTestUtilities.ReflectionTestHelper.RunStaticMethod(
                typeof(ConcreteClass),
                "ConcretePrivateStaticMethod", new object[0]);
            var strActual = Convert.ToString(objectUnderTest);

            Assert.AreEqual(strExpected, strActual);

        }

        [Test]
        public void TestPrivateInstanceMethod()
        {
            const string strExpected = "concrete private method. Private Method Test";

            var classUnderTest = new ConcreteClass("Private Method Test");
            var objectUnderTest = UnitTestUtilities.ReflectionTestHelper.RunInstanceMethod(
                typeof(ConcreteClass),
                "ConcretePrivateMethod",
                classUnderTest,
                new object[0]);
            var strActual = Convert.ToString(objectUnderTest);

            Assert.AreEqual(strExpected, strActual);

        }

        [Test]
        public void TestGetPrivateField()
        {
            const string strExpected = "default2";
            var classUnderTest = new ConcreteClass("Private Field Test");
            var objectUnderTest = UnitTestUtilities.ReflectionTestHelper.GetInstanceField(
                 typeof(ConcreteClass),
                "_concreteParameter2",
                classUnderTest);
            var strActual = Convert.ToString(objectUnderTest);
            Assert.AreEqual(strExpected, strActual);
        }
        [Test]
        public void TestGetStaticPrivateField()
        {
            const string strExpected = "default";
            var objectUnderTest = UnitTestUtilities.ReflectionTestHelper.GetStaticField(
                 typeof(ConcreteClass),
                "_staticParameter");
            var strActual = Convert.ToString(objectUnderTest);
            Assert.AreEqual(strExpected, strActual);
        }
        [Test]
        public void TestSetPrivateField()
        {
            const string strExpected = "Setting Value Here";
            var classUnderTest = new ConcreteClass("Private Field Test");
            var objectUnderTest = UnitTestUtilities.ReflectionTestHelper.SetInstanceField(
                 typeof(ConcreteClass),
                "_concreteParameter2",
                classUnderTest,
                "Setting Value Here");
            var strActual = Convert.ToString(objectUnderTest);
            Assert.AreEqual(strExpected, strActual);
        }

    }
}
