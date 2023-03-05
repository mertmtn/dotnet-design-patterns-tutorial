using FactoryMethodPattern.BaseClasses;

namespace FactoryMethodPattern.ConcreteProduct
{
    public class RecaptchaV2 : GoogleRecaptcha
    {
        public override string Verify(string token)
        {
            return "Verified as RecaptchaV2";
        }
    }
}
