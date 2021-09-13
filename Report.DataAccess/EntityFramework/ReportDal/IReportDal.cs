using Report.Core.DataAccess;
using Report.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report.DataAccess.EntityFramework.ReportDal
{
    public interface IReportDal : IEntityRepository<Reports>
    {
    }
}
