using FactoryMethodPattern.BaseClasses;

namespace FactoryMethodPattern.ConcreteProduct
{
    public class RecaptchaV3 : GoogleRecaptcha
    {
        public override string Verify(string token)
        {
            return "Verified as RecaptchaV3";
        }
    }
}
