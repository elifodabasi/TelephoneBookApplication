using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Report.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report.DataAccess.Configurations
{
    public class ReportConfiguration : IEntityTypeConfiguration<Reports>
    {
        public void Configure(EntityTypeBuilder<Reports> builder)
        {
            builder.ToTable("Reports");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.ReportDemandDate);
            builder.Property(x => x.ReportStatusId);
            builder.Property(x => x.PersonId);
            builder.Property(x => x.Location);
            builder.Property(x => x.PhoneNumber);
        }
    }
}
