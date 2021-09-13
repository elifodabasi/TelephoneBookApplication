using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Report.Entity;

namespace Report.DataAccess.Configurations
{
    public class ReportStatusConfiguration : IEntityTypeConfiguration<ReportStatus>
    {
        public void Configure(EntityTypeBuilder<ReportStatus> builder)
        {
            builder.ToTable("ReportStatuses");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Status);
        }
    }
}
