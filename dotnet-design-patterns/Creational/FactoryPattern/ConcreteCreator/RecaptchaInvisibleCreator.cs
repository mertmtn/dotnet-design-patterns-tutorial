using FactoryMethodPattern.BaseClasses;
using FactoryMethodPattern.ConcreteProduct;
namespace FactoryMethodPattern.ConcreteCreator
{
    public class RecaptchaInvisibleCreator : CaptchaCreator
    {
        public override GoogleRecaptcha FactoryMethod()
        {
            return new RecaptchaInvisible();
        }
    }
}
