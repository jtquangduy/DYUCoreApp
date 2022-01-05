using DYUCoreApp.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeduCoreApp.Data.EF.Extensions;

namespace TeduCoreApp.Data.EF.Configurations
{
    internal class SystemConfigConfiguration : DbEntityConfiguration<SystemConfig>
    {
        public override void Configure(EntityTypeBuilder<SystemConfig> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(255).IsRequired();
            // etc.
        }
    }
}