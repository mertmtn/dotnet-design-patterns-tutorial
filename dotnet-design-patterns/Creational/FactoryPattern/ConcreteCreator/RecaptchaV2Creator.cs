using FactoryMethodPattern.BaseClasses;
using FactoryMethodPattern.ConcreteProduct;

namespace FactoryMethodPattern.ConcreteCreator
{
    public class RecaptchaV2Creator : CaptchaCreator
    {
        public override GoogleRecaptcha FactoryMethod()
        {
            return new RecaptchaV2();
        }
    }
}
