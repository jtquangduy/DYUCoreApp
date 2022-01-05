using DYUCoreApp.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeduCoreApp.Data.EF.Extensions;

namespace TeduCoreApp.Data.EF.Configurations
{
    public class ContactDetailConfiguration : DbEntityConfiguration<Contact>
    {
        public override void Configure(EntityTypeBuilder<Contact> entity)
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Id).HasMaxLength(255).IsRequired();
            // etc.
        }
    }
}