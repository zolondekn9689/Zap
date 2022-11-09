using Xunit.Abstractions;
using Zap.Shared.Services;

namespace Zap.IntegrationTests;

public class UnitTest1
{
    private readonly ITestOutputHelper logger;

    public UnitTest1(Xunit.Abstractions.ITestOutputHelper logger)
    {
        this.logger = logger;
    }

    [Fact]
    public void AppDirectory()
    {
        var config = new ConfigService();
        logger.WriteLine(config.ConfigFilePath);
        
    }
    [Fact]
    public void BuildFile()
    {
        var config = new ConfigService();
        Assert.True(File.Exists(config.ConfigFilePath));
    }
}
