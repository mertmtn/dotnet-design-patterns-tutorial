namespace StrategyPattern
{
    internal interface ILoggingStrategy
    {
        void Error(Exception ex, LogInformation logInformation);

        void Information(LogInformation logInformation);

        void Warning(LogInformation logInformation);
    }
}
