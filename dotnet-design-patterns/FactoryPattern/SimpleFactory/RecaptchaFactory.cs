using FactoryMethodPattern.BaseClasses;
using FactoryMethodPattern.ConcreteProduct;

namespace FactoryMethodPattern.SimpleFactory
{
    internal class RecaptchaFactory : IRecaptchaFactory
    {
        public GoogleRecaptcha CreateRecaptcha(GoogleRecaptcha recaptchaType)
        {
            switch (recaptchaType)
            {
                case RecaptchaInvisible:
                    return new RecaptchaInvisible();
                case RecaptchaV2:
                    return new RecaptchaV2();
                case RecaptchaV3:
                    return new RecaptchaV3();
            }
            return null;
        }
    }
}
