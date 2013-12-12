//Hi I was here
using System.Collections.Generic;

namespace Project
{
    public abstract class BaseClass : IBaseClass
    {
        private string _baseParameter = "default";
        protected IList<string> BaseSampleList;

        protected BaseClass(string parameter)
        {
            BasePrivateProperty = parameter;

            BaseSampleList = new List<string>
                             {
                                 BasePrivateProperty,
                                 BasePrivateStaticProperty,
                                 BasePrivateMethod(),
                                 BasePrivateStaticMethod(),
                                 BasePrivateMethodWithParameters("test value", 99),
                                 BasePrivateStaticMethodWithParameters("testing value", 77)
                             };
        }

        public string BasePublicProperty
        {
            get { return "base public property."; }
        }
        public static string BasePublicStaticProperty
        {
            get { return "base public static property.";}
        }

        protected virtual string BaseProtectedProperty
        {
            get { return "base protected property.";}
        }
        protected static string BaseProtectedStaticProperty
        {
            get { return "base protected static property.";}
        }
        private string BasePrivateProperty
        {
            get { return string.Format("base private property. {0}", _baseParameter);}
            set { _baseParameter = value; }
        }
        private static string BasePrivateStaticProperty
        {
            get { return "base private static property."; }
        }
        
        public virtual string BasePublicMethod()
        {
            return "base public method.";
        }        
        public static string BasePublicStaticMethod()
        {
            return "base public static method.";
        }

        protected virtual string BaseProtectedMethod()
        {
            return "base protected method.";
        }
        protected static string BaseProtectedStaticMethod()
        {
            return "base protected static method.";
        }
        private string BasePrivateMethod()
        {
            return string.Format("base private method. {0}", _baseParameter);           
        }
        private static string BasePrivateStaticMethod()
        {
            return "base private static method.";
        }
        private string BasePrivateMethodWithParameters(string value, int index)
        {
            return string.Format("base private method with parameters: arg1 = '{0}' arg2 = '{1}'. {2}", value, index, _baseParameter);
        }
        private static string BasePrivateStaticMethodWithParameters(string value, int index)
        {
            return string.Format("base private static method with parameters: arg1 = '{0}' arg2 = '{1}'. ", value, index);
        }
    }
}
