using System;
using NUnit.Framework;
using Project;
using UnitTestUtilities;

namespace TestProject
{
    [TestFixture]
    public class TestReflectionTestHelper
    {
        [Test]
        public void TestGetInstanceField()
        {
            const string strExpected = "default2";
            var classUnderTest = new ConcreteClass("Private Field Test");
            var objectUnderTest = ReflectionTestHelper.GetInstanceField(
                 typeof(ConcreteClass),
                "_concreteParameter2",
                classUnderTest);
            var strActual = Convert.ToString(objectUnderTest);
            Assert.AreEqual(strExpected, strActual);
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGetInstanceField_InvalidType()
        {
            var classUnderTest = new ConcreteClass("Private Field Test");
            ReflectionTestHelper.GetInstanceField(
                 typeof(TestBaseClass),
                "_concreteParameter2",
                classUnderTest);
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGetInstanceField_InvalidMethod()
        {
            var classUnderTest = new ConcreteClass("Private Field Test");
            ReflectionTestHelper.GetInstanceField(
                 typeof(ConcreteClass),
                "_errorName",
                classUnderTest);
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGetInstanceField_NullMethod()
        {
            var classUnderTest = new ConcreteClass("Private Field Test");
            ReflectionTestHelper.GetInstanceField(
                 typeof(ConcreteClass),
                null,
                classUnderTest);
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGetInstanceField_NullObject()
        {
            ReflectionTestHelper.GetInstanceField(
                 typeof(ConcreteClass),
                "_concreteParameter2",
                null);        
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGetInstanceField_InvalidObject()
        {
            ReflectionTestHelper.GetInstanceField(
                 typeof(ConcreteClass),
                "_concreteParameter2",
                new object());
        }
        [Test]
        public void TestSetInstanceField()
        {
            const string strExpected = "Setting Value Here";
            var classUnderTest = new ConcreteClass("Private Field Test");
            var objectUnderTest = ReflectionTestHelper.SetInstanceField(
                 typeof(ConcreteClass),
                "_concreteParameter2",
                classUnderTest,
                "Setting Value Here");
            var strActual = Convert.ToString(objectUnderTest);
            Assert.AreEqual(strExpected, strActual);
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSetInstanceField_InvalidSetValue()
        {
            var classUnderTest = new ConcreteClass("Private Field Test");
            ReflectionTestHelper.SetInstanceField(
                 typeof(ConcreteClass),
                "_concreteParameter2",
                classUnderTest,
                1);
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSetInstanceField_InvalidType()
        {
            var classUnderTest = new ConcreteClass("Private Field Test");
            ReflectionTestHelper.SetInstanceField(
                 typeof(TestBaseClass),
                "_concreteParameter2",
                classUnderTest,
                "Setting Value Here");
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSetInstanceField_InvalidMethod()
        {
            var classUnderTest = new ConcreteClass("Private Field Test");
            ReflectionTestHelper.SetInstanceField(
                 typeof(ConcreteClass),
                "_errorName",
                classUnderTest,
                "Setting Value Here");
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSetInstanceField_NullMethod()
        {
            var classUnderTest = new ConcreteClass("Private Field Test");
            ReflectionTestHelper.SetInstanceField(
                 typeof(ConcreteClass),
                null,
                classUnderTest,
                "Setting Value Here");
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSetInstanceField_NullObject()
        {
            ReflectionTestHelper.SetInstanceField(
                 typeof(ConcreteClass),
                "_concreteParameter2",
                null,
                "Setting Value Here");
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSetInstanceField_InvalidObject()
        {
            ReflectionTestHelper.SetInstanceField(
                 typeof(ConcreteClass),
                "_concreteParameter2",
                new object(),
                "Setting Value Here");
        }
        [Test]
        public void TestGetInstanceProperty()
        {
            const string strExpected = "concrete protected property. default2";
            var classUnderTest = new ConcreteClass("Protected Property Test");
            var objectUnderTest = ReflectionTestHelper.GetInstanceProperty(
                 typeof(ConcreteClass),
                "ConcreteProtectedProperty",
                classUnderTest,
                new object[0]);
            var strActual = Convert.ToString(objectUnderTest);
            Assert.AreEqual(strExpected, strActual);

        }
        [Test]
        [ExpectedException(typeof(System.Reflection.TargetParameterCountException))]
        public void TestGetInstanceProperty_ParamPresent()
        {
            var classUnderTest = new ConcreteClass("Protected Property Test");
            ReflectionTestHelper.GetInstanceProperty(
                 typeof(ConcreteClass),
                "ConcreteProtectedProperty",
                classUnderTest,
                new object[] {"test", 2});
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGetInstanceProperty_InvalidType()
        {
            var classUnderTest = new ConcreteClass("Private Field Test");
            ReflectionTestHelper.GetInstanceProperty(
                 typeof(TestBaseClass),
                "ConcreteProtectedProperty",
                classUnderTest,
                new object[0]);
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGetInstanceProperty_InvalidMethod()
        {
            var classUnderTest = new ConcreteClass("Private Field Test");
            ReflectionTestHelper.GetInstanceProperty(
                 typeof(ConcreteClass),
                "ErrorName",
                classUnderTest,
                new object[0]);
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGetInstanceProperty_NullMethod()
        {
            var classUnderTest = new ConcreteClass("Private Field Test");
            ReflectionTestHelper.GetInstanceProperty(
                 typeof(ConcreteClass),
                null,
                classUnderTest,
                new object[0]);
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGetInstanceProperty_NullObject()
        {
            ReflectionTestHelper.GetInstanceProperty(
                 typeof(ConcreteClass),
                "ConcreteProtectedProperty",
                null,
                new object[0]);        
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGetInstanceProperty_InvalidObject()
        {
            ReflectionTestHelper.GetInstanceProperty(
                 typeof(ConcreteClass),
                "ConcreteProtectedProperty",
                new object(),
                new object[0]);
        }
        [Test]
        public void TestSetInstanceProperty()
        {
            const string strExpected = "concrete protected property. Setting Value Here";
            var classUnderTest = new ConcreteClass("Private Field Test");
            var objectUnderTest = ReflectionTestHelper.SetInstanceProperty(
                 typeof(ConcreteClass),
                "ConcreteProtectedProperty",
                classUnderTest,
                "Setting Value Here",
                new object[0]);
            var strActual = Convert.ToString(objectUnderTest);
            Assert.AreEqual(strExpected, strActual);
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void SetInstanceProperty_InvalidSetValue()
        {
            var classUnderTest = new ConcreteClass("Private Field Test");
            ReflectionTestHelper.SetInstanceProperty(
                 typeof(ConcreteClass),
                "ConcreteProtectedProperty",
                classUnderTest,
                1,
                new object[0]);
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSetInstanceProperty_InvalidType()
        {
            var classUnderTest = new ConcreteClass("Private Field Test");
            ReflectionTestHelper.SetInstanceProperty(
                 typeof(TestBaseClass),
                "ConcreteProtectedProperty",
                classUnderTest,
                "Setting Value Here",
                new object[0]);
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSetInstanceProperty_InvalidMethod()
        {
            var classUnderTest = new ConcreteClass("Private Field Test");
            ReflectionTestHelper.SetInstanceProperty(
                 typeof(ConcreteClass),
                "ErrorName",
                classUnderTest,
                "Setting Value Here",
                new object[0]);
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSetInstanceProperty_NullMethod()
        {
            var classUnderTest = new ConcreteClass("Private Field Test");
            ReflectionTestHelper.SetInstanceProperty(
                 typeof(ConcreteClass),
                null,
                classUnderTest,
                "Setting Value Here",
                new object[0]);
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSetInstanceProperty_NullObject()
        {
            ReflectionTestHelper.SetInstanceProperty(
                 typeof(ConcreteClass),
                "ConcreteProtectedProperty",
                null,
                "Setting Value Here",
                new object[0]);
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSetInstanceProperty_InvalidObject()
        {
            ReflectionTestHelper.SetInstanceProperty(
                 typeof(ConcreteClass),
                "ConcreteProtectedProperty",
                new object(),
                "Setting Value Here",
                new object[0]);
        }
        [Test]
        public void TestRunInstanceMethod()
        {
            const string strExpected = "concrete protected method.";
            var classUnderTest = new ConcreteClass("Protected Method Test");
            var objectUnderTest = ReflectionTestHelper.RunInstanceMethod(
                 typeof(ConcreteClass),
                "ConcreteProtectedMethod",
                classUnderTest,
                new object[0]);
            var strActual = Convert.ToString(objectUnderTest);
            Assert.AreEqual(strExpected, strActual);
        }
        [Test]
        [ExpectedException(typeof(System.Reflection.TargetParameterCountException))]
        public void TestRunInstanceMethod_ParamPresent()
        {
            var classUnderTest = new ConcreteClass("Protected Property Test");
            ReflectionTestHelper.RunInstanceMethod(
                 typeof(ConcreteClass),
                "ConcreteProtectedMethod",
                classUnderTest,
                new object[] { "test", 2 });
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRunInstanceMethod_InvalidType()
        {
            var classUnderTest = new ConcreteClass("Private Field Test");
            ReflectionTestHelper.RunInstanceMethod(
                 typeof(TestBaseClass),
                "ConcreteProtectedMethod",
                classUnderTest,
                new object[0]);
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRunInstanceMethod_InvalidMethod()
        {
            var classUnderTest = new ConcreteClass("Private Field Test");
            ReflectionTestHelper.RunInstanceMethod(
                 typeof(ConcreteClass),
                "ErrorName",
                classUnderTest,
                new object[0]);
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRunInstanceMethod_NullMethod()
        {
            var classUnderTest = new ConcreteClass("Private Field Test");
            ReflectionTestHelper.RunInstanceMethod(
                 typeof(ConcreteClass),
                null,
                classUnderTest,
                new object[0]);
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRunInstanceMethod_NullObject()
        {
            ReflectionTestHelper.RunInstanceMethod(
                 typeof(ConcreteClass),
                "ConcreteProtectedMethod",
                null,
                new object[0]);
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRunInstanceMethod_InvalidObject()
        {
            ReflectionTestHelper.GetInstanceProperty(
                 typeof(ConcreteClass),
                "ConcreteProtectedMethod",
                new object(),
                new object[0]);
        }
        [Test]
        public void TestRunStaticMethod()
        {
            const string strExpected = "concrete private static method.";

            var objectUnderTest = ReflectionTestHelper.RunStaticMethod(
                typeof(ConcreteClass),
                "ConcretePrivateStaticMethod", new object[0]);
            var strActual = Convert.ToString(objectUnderTest);

            Assert.AreEqual(strExpected, strActual);
        }
        [Test]
        [ExpectedException(typeof(System.Reflection.TargetParameterCountException))]
        public void TestRunStaticMethod_ParamPresent()
        {
            ReflectionTestHelper.RunStaticMethod(
                 typeof(ConcreteClass),
                "ConcretePrivateStaticMethod",
                new object[] { "test", 2 });
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRunStaticMethod_InvalidType()
        {
            ReflectionTestHelper.RunStaticMethod(
                 typeof(TestBaseClass),
                "ConcretePrivateStaticMethod",
                new object[0]);
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRunStaticMethod_InvalidMethod()
        {
            ReflectionTestHelper.RunStaticMethod(
                 typeof(ConcreteClass),
                "ErrorName",
                new object[0]);
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRunStaticMethod_NullMethod()
        {
            ReflectionTestHelper.RunStaticMethod(
                 typeof(ConcreteClass),
                null,
                new object[0]);
        }
        [Test]
        public void TestGetStaticProperty()
        {
            const string strExpected = "concrete protected static property.";
            var objectUnderTest = ReflectionTestHelper.GetStaticProperty(
                 typeof(ConcreteClass),
                "ConcreteProtectedStaticProperty",
                new object[0]);
            var strActual = Convert.ToString(objectUnderTest);
            Assert.AreEqual(strExpected, strActual);
        }
        [Test]
        [ExpectedException(typeof(System.Reflection.TargetParameterCountException))]
        public void TestGetStaticProperty_ParamPresent()
        {
            ReflectionTestHelper.GetStaticProperty(
                 typeof(ConcreteClass),
                "ConcreteProtectedStaticProperty",
                new object[] { "test", 2 });
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGetStaticProperty_InvalidType()
        {
            ReflectionTestHelper.GetStaticProperty(
                 typeof(TestBaseClass),
                "ConcreteProtectedStaticProperty",
                new object[0]);
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGetStaticProperty_InvalidMethod()
        {
            ReflectionTestHelper.GetStaticProperty(
                 typeof(ConcreteClass),
                "ErrorName",
                new object[0]);
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGetStaticProperty_NullMethod()
        {
            ReflectionTestHelper.GetStaticProperty(
                 typeof(ConcreteClass),
                null,
                new object[0]);
        }
        [Test]
        public void TestGetStaticField()
        {
            const string strExpected = "default";
            var objectUnderTest = ReflectionTestHelper.GetStaticField(
                 typeof(ConcreteClass),
                "_staticParameter");
            var strActual = Convert.ToString(objectUnderTest);
            Assert.AreEqual(strExpected, strActual);
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGetStaticField_InvalidType()
        {
            ReflectionTestHelper.GetStaticField(
                 typeof(TestBaseClass),
                "_staticParameter");
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGetStaticField_InvalidMethod()
        {
            ReflectionTestHelper.GetStaticField(
                 typeof(ConcreteClass),
                "ErrorName");
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGetStaticField_NullMethod()
        {
            ReflectionTestHelper.GetStaticField(
                 typeof(ConcreteClass),
                null);
        }
        [Test]
        public void TestSetStaticProperty()
        {
            const string strExpected = "concrete private property. Setting Value Here";
            var objectUnderTest = ReflectionTestHelper.SetStaticProperty(
                 typeof(ConcreteClass),
                "ConcretePrivateStaticProperty",
                "Setting Value Here",
                new object[0]);
            var strActual = Convert.ToString(objectUnderTest);
            Assert.AreEqual(strExpected, strActual);
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSetStaticProperty_InvalidSetValue()
        {
            ReflectionTestHelper.SetStaticProperty(
                 typeof(ConcreteClass),
                "ConcretePrivateStaticProperty",
                1,
                new object[0]);
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSetStaticProperty_InvalidType()
        {
            ReflectionTestHelper.SetStaticProperty(
                 typeof(TestBaseClass),
                "ConcretePrivateStaticProperty",
                "Setting Value Here",
                new object[0]);
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSetStaticProperty_InvalidMethod()
        {
            ReflectionTestHelper.SetStaticProperty(
                 typeof(ConcreteClass),
                "ErrorName",
                "Setting Value Here",
                new object[0]);
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSetStaticProperty_NullMethod()
        {
            ReflectionTestHelper.SetStaticProperty(
                 typeof(ConcreteClass),
                null,
                "Setting Value Here",
                new object[0]);
        }
        
        [Test]
        public void TestSetStaticField()
        {
            const string strExpected = "Setting Value Here";
            var objectUnderTest = ReflectionTestHelper.SetStaticField(
                 typeof(ConcreteClass),
                "_staticParameter",
                "Setting Value Here");
            var strActual = Convert.ToString(objectUnderTest);
            Assert.AreEqual(strExpected, strActual);
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSetStaticField_InvalidSetValue()
        {
            ReflectionTestHelper.SetStaticField(
                 typeof(ConcreteClass),
                "_staticParameter",
                1);
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSetStaticField_InvalidType()
        {
            ReflectionTestHelper.SetStaticField(
                 typeof(TestBaseClass),
                "_staticParameter",
                "Setting Value Here");
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSetStaticField_InvalidMethod()
        {
            ReflectionTestHelper.SetStaticField(
                 typeof(ConcreteClass),
                "_errorName",
               "Setting Value Here");
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSetStaticField_NullMethod()
        {
            ReflectionTestHelper.SetStaticField(
                 typeof(ConcreteClass),
                null,
                "Setting Value Here");
        }
        

    }
}
