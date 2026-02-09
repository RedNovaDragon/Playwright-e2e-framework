using DotNetEnv;

namespace PlaywrightTests.Config;

public static class ConfigLoader
{
    public static TestConfig Load()
    {

        var envPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../props.env");
        Env.Load(envPath);

        return new TestConfig
        {
            BaseUrl = Environment.GetEnvironmentVariable("BASE_URL") ?? ""
        };
    }
}