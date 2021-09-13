using Microsoft.AspNetCore.Mvc;
using Report.Business.ReportsOps;
using Report.Entity;
using ReportLocation.Communication.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : Controller
    {
        private readonly IReportService _reportService;



        public ReportController(IReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAllReport()
        {
            var result = _reportService.GetAll();
            return Ok(result);
        }

        [HttpGet("find")]
        public Reports FindReport(Guid id)
        {
            return _reportService.Find(id);
        }

        [HttpPost("add")]
        public async Task AddReport(Reports report)
        {

            _reportService.Add(report);
        }

        [HttpPost("update")]
        public async Task UpdateReport(Reports report)
        {

            _reportService.Update(report);
        }

        [HttpPost("getReportLocation")]

        public async Task<Reports> GetReportLocation(ReportLocationMessage reportLocationMessage)
        {
          return await _reportService.GetReportLocation(reportLocationMessage);
        }

        //[HttpPost("getReportForLocation")]
        //public async Task<bool> GetReportLocation(string locationName)
        //{


        //    var send = await _sendEndpointProvider.GetSendEndpoint(new Uri("queue: telephonebook-service"));

        //    ReportLocationCustom reportLocationCustom = new ReportLocationCustom();

        //    reportLocationCustom.Location = locationName;
        //    reportLocationCustom.ReportDemandDate = DateTime.Now;
        //    reportLocationCustom.ReportStatus.Status = "Tamamlandı";

        //    await send.Send<ReportLocationCustom>(reportLocationCustom);
        //    // _reportService.GetReportForLocation(locationName);

        //    return true;
        //}

    }
}
