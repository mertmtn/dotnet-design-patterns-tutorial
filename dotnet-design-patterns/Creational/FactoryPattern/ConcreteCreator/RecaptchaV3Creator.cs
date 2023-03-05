using FactoryMethodPattern.BaseClasses;
using FactoryMethodPattern.ConcreteProduct;

namespace FactoryMethodPattern.ConcreteCreator
{
    public class RecaptchaV3Creator : CaptchaCreator
    {
        public override GoogleRecaptcha FactoryMethod()
        {
            return new RecaptchaV3();
        }
    }
}
