namespace FactoryMethodPattern.BaseClasses
{
    public abstract class CaptchaCreator
    {
        public abstract GoogleRecaptcha FactoryMethod();
    }
}
