using FactoryMethodPattern.BaseClasses;

namespace FactoryMethodPattern.ConcreteProduct
{
    public class RecaptchaInvisible : GoogleRecaptcha
    {
        public override string Verify(string token)
        {
            return "Verified as RecaptchaInvisible";
        }
    }
}
