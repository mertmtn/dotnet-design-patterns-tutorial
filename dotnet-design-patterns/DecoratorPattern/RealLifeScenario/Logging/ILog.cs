namespace DecoratorPattern.RealLifeScenario.Logging
{
    public interface ILog
    {
        void Error(Exception ex, LogInformation logInformation);

        void Information(LogInformation logInformation);

        void Warning(LogInformation logInformation);
    }
}
