using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Qa.EntityFrameworkCore
{
    [DependsOn(
        typeof(QaEntityFrameworkCoreModule)
        )]
    public class QaEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<QaMigrationsDbContext>();
        }
    }
}
