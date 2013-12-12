using System.Collections.Generic;

namespace Project
{
    public class ConcreteClass : BaseClass, IConcreteClass
    {
        protected IList<string> ConcreteSampleList;
        private static string _staticParameter = "not initialised";

        public ConcreteClass(string parameter) : base(parameter)
        {
            if (string.IsNullOrEmpty(_staticParameter) 
            || (_staticParameter == "not initialised"))
            {
                _staticParameter = "default";
            }
            ConcretePrivateProperty = parameter;
            ConcretePrivateStaticProperty = _staticParameter;

            ConcreteSampleList = new List<string>
                             {
                                 ConcretePrivateProperty,
                                 ConcretePrivateStaticProperty,
                                 ConcretePrivateMethod(),
                                 ConcretePrivateStaticMethod()
                             };
        }
        public string ConcretePublicProperty
        {
            get { return "concrete public property."; }
        }
        public static string ConcretePublicStaticProperty
        {
            get { return "concrete public static property."; }
        }
        protected override string BaseProtectedProperty
        {
            get { return "overridde base protected property."; }
        }
        protected string ConcreteProtectedProperty
        {
            get { return string.Format("concrete protected property. {0}", _concreteParameter2); }
            set { _concreteParameter2 = value; }
        } private string _concreteParameter2 = "default2";
        protected static string ConcreteProtectedStaticProperty
        {
            get { return "concrete protected static property."; }
        }
        private string ConcretePrivateProperty
        {
            get { return string.Format("concrete private property. {0}", _concreteParameter);}
            set { _concreteParameter = value; }
        } private string _concreteParameter = "default";

        private static string ConcretePrivateStaticProperty
        {
            get { return string.Format("concrete private property. {0}", _concreteStaticParameter); }
            set { _concreteStaticParameter = value; }
        } private static string _concreteStaticParameter = "default";

        public override string BasePublicMethod()
        {
            return "overridden base public method.";
        }
        public string ConcretePublicMethod()
        {
            return "concrete public method.";
        }
        public static string ConcretePublicStaticMethod()
        {
            return "concrete public static method.";
        }
        protected override string BaseProtectedMethod()
        {
            return "overriden base protected method.";
        }
        protected string ConcreteProtectedMethod()
        {
            return "concrete protected method.";
        }
        protected static string ConcreteProtectedStaticMethod()
        {
            return "concrete protected static method.";
        }
        private string ConcretePrivateMethod()
        {
            return string.Format("concrete private method. {0}", _concreteParameter); 
        }
        private static string ConcretePrivateStaticMethod()
        {
            return "concrete private static method.";
        }
    }
}
