namespace FactoryMethodPattern.BaseClasses
{
    public abstract class GoogleRecaptcha
    {
        public abstract string Verify(string token);
    }
}
