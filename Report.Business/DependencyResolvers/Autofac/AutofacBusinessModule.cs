using Autofac;
using Report.Business.ReportsOps;
using Report.Business.ReportStatusOps;
using Report.DataAccess.EntityFramework.ReportDal;
using Report.DataAccess.EntityFramework.ReportStatusDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            #region DataAccessLayers
            builder.RegisterType<EfReportDal>().As<IReportDal>().SingleInstance();
            builder.RegisterType<EfReportStatusDal>().As<IReportStatusDal>().SingleInstance();
            #endregion

            #region BusinessLayer
            builder.RegisterType<ReportService>().As<IReportService>().SingleInstance();
            builder.RegisterType<ReportStatusService>().As<IReportStatusService>().SingleInstance();
            #endregion
        }
    }
}
