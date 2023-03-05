using FactoryMethodPattern.ConcreteCreator;
using FactoryMethodPattern.ConcreteProduct;
using FactoryMethodPattern.SimpleFactory;


//Simple Factory vs Factory Method

var googleRecaptchaFactoryMethod = new RecaptchaInvisibleCreator().FactoryMethod();
Console.WriteLine(googleRecaptchaFactoryMethod.Verify("token"));

var googleRecaptchaSimpleFactory = new RecaptchaFactory();
Console.WriteLine(googleRecaptchaSimpleFactory.CreateRecaptcha(new RecaptchaInvisible()).Verify("token"));

Console.ReadKey();
