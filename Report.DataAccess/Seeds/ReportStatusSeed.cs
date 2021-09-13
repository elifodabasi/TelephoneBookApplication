using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Report.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report.DataAccess.Seeds
{
    public class ReportStatusSeed : IEntityTypeConfiguration<ReportStatus>
    {


        public void Configure(EntityTypeBuilder<ReportStatus> builder)
        {
            builder.HasData(
          new ReportStatus
          {
              Id = 1,
              Status = "Hazırlanıyor"

          }
         );

            builder.HasData(
         new ReportStatus
         {
             Id = 2,
             Status = "Tamamlandı"

         }
        );
        }
    }
}
