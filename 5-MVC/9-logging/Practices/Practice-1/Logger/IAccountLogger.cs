namespace Practice_1.Logger
{
    public interface IAccountLogger
    {
        void LogError( string message);
        void LogWarning(string message);
        void LogInfo(string message);
    }
}