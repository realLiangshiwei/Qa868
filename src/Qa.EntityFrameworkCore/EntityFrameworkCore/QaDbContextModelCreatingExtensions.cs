using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Qa.EntityFrameworkCore
{
    public static class QaDbContextModelCreatingExtensions
    {
        public static void ConfigureQa(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(QaConsts.DbTablePrefix + "YourEntities", QaConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}