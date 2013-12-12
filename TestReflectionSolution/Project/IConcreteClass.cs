
namespace Project
{
    public interface IConcreteClass : IBaseClass
    {
        string ConcretePublicProperty { get; }

        string ConcretePublicMethod();
       
    }
}