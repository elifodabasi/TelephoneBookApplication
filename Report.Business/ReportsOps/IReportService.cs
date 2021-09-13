using Report.Entity;
using ReportLocation.Communication.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report.Business.ReportsOps
{
    public interface IReportService
    {
        List<Reports> GetAll();
        Reports Find(Guid id);
        void Add(Reports entity);
        void Update(Reports entity);
        Task<Reports> GetReportLocation(ReportLocationMessage reportLocationMessage);

    }
}
