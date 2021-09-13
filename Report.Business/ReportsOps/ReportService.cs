using Report.DataAccess.EntityFramework.ReportDal;
using Report.Entity;
using ReportLocation.Communication.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Report.Business.ReportsOps
{
    public class ReportService : IReportService
    {
        IReportDal _reportDal;

        public ReportService(IReportDal reportDal)
        {
            _reportDal = reportDal;

        }
        public void Add(Reports entity)
        {
            entity.ReportStatusId = 1;
            _reportDal.Add(entity);
        }

        public Reports Find(Guid id)
        {
            return _reportDal.Find(x => x.Id == id);
        }

        public List<Reports> GetAll()
        {
            return _reportDal.GetAll().ToList();

        }

        public void Update(Reports entity)
        {
            var report = _reportDal.Find(x => x.Id == entity.Id);
            if (report != null)
            {
                report.ReportStatusId = 2;
                report.ReportDemandDate = DateTime.Now;
                _reportDal.Update(report);

            }
            else
            {
                throw new Exception("Kayıt bulunamadı.");
            }
        }

        //public async Task<Reports> GetLocationReport(string location)
        //{
        //    Reports reports = new Reports();
        //    reports.Location = location;
        //    //reports.PersonId = xxx;
        //    //reports.PhoneNumber = yyy;
        //    reports.ReportDemandDate = DateTime.Now();


        //    Add(reports);


        //    var locationCount = _reportDal.GetAll().Where(x => x.Location == location).Count();

        //}

  public async Task<Reports> GetReportLocation(ReportLocationMessage reportLocationMessage)
        {
            Reports reports = new Reports();
            reports.Location = reportLocationMessage.LocationName;
            reports.PhoneNumber = reportLocationMessage.PhoneNumber;
            reports.PersonId = reportLocationMessage.PersonId;
            reports.ReportDemandDate = DateTime.Now;
            reports.ReportStatusId = 2;

            return reports;
        }


    }
}
