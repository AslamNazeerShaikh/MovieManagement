using Serilog;

namespace MovieManagement.Services.Logging
{
    public static class LoggerService
    {
        public static void ConfigureLogger()
        {
            Log.Logger = new LoggerConfiguration()
                    .WriteTo.Console()
                .WriteTo.Async(a => a.File("Logs/log-.txt",
                    rollingInterval: RollingInterval.Hour,
                    fileSizeLimitBytes: 10_000_000,
                    rollOnFileSizeLimit: true)
                .MinimumLevel.Information())
                .CreateLogger();
        }
    }
}
