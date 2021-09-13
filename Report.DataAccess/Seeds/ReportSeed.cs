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
    public class ReportSeed : IEntityTypeConfiguration<Reports>
    {
        private readonly Guid[] _Ids;

        public ReportSeed(Guid[] Ids)
        {
            _Ids = Ids;

        }

        public void Configure(EntityTypeBuilder<Reports> builder)
        {
            builder.HasData(
          new Reports
          {
              Id = _Ids[0],
              ReportDemandDate = DateTime.Now,
              ReportStatusId = 1,
              Location = "Ankara",
              PhoneNumber = "555",
              PersonId = _Ids[0]


          }
         );
        }
    }
}
