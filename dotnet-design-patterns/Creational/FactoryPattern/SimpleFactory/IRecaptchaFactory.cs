using FactoryMethodPattern.BaseClasses;

namespace FactoryMethodPattern.SimpleFactory
{
    public interface IRecaptchaFactory
    {
        GoogleRecaptcha CreateRecaptcha(GoogleRecaptcha recaptchaType);
    }
}
