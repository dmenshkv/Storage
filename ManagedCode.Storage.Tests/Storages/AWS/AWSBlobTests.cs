using Microsoft.Extensions.DependencyInjection;
using Testcontainers.LocalStack;

namespace ManagedCode.Storage.Tests.Storages.AWS;

public class AWSBlobTests : BlobTests<LocalStackContainer>
{
    protected override LocalStackContainer Build()
    {
        return new LocalStackBuilder().Build();
    }

    protected override ServiceProvider ConfigureServices()
    {
        return AWSConfigurator.ConfigureServices(Container.GetConnectionString());
    }
}