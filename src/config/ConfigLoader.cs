using DotNetEnv;

namespace PlaywrightTests.Config;

public static class ConfigLoader
{
    //likely a very elaborate way for me to load env variables from a file, but it works and I don't know how to do it better :D
    public static TestConfig Load()
    {
        //yea, no I did not write this 
        var envPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../props.env");
        Env.Load(envPath);

        return new TestConfig
        {
            BaseUrl = Environment.GetEnvironmentVariable("BASE_URL") ?? ""
        };
    }
}