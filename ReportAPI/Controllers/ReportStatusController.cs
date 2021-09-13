using Microsoft.AspNetCore.Mvc;
using Report.Business.ReportStatusOps;
using Report.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportAPI.Controllers
{
    public class ReportStatusController : Controller
    {
        IReportStatusService _reportStatusService;

        public ReportStatusController(IReportStatusService reportStatusService)
        {
            _reportStatusService = reportStatusService;
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = _reportStatusService.GetAll();
            return Ok(result);
        }

        [HttpGet("find")]
        public ReportStatus Find(int id)
        {
            return _reportStatusService.Find(id);
        }
    }
}
