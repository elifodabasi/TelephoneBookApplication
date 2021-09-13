using Report.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report.Business.ReportStatusOps
{
    public interface IReportStatusService
    {
        List<ReportStatus> GetAll();
        ReportStatus Find(int id);
    }
}
