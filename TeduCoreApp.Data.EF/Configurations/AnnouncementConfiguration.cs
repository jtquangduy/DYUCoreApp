using DYUCoreApp.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TeduCoreApp.Data.EF.Extensions;

namespace TeduCoreApp.Data.EF.Configurations
{
    public class AnnouncementConfiguration : DbEntityConfiguration<Announcement>
    {
        public override void Configure(EntityTypeBuilder<Announcement> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(128).IsRequired();
            // etc.
        }
    }
}