using Report.Core.DataAccess.EntityFramework;
using Report.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report.DataAccess.EntityFramework.ReportDal
{
    public class EfReportDal : EfRepositoryBase<Reports, EfDbContext>, IReportDal
    {
    }
}
