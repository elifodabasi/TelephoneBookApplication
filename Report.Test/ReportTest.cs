using Microsoft.AspNetCore.Mvc;
using Moq;
using Report.Business.ReportsOps;
using ReportAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Report.Test
{
   public class ReportTest
    {
        private readonly ReportController _reportController;

        private readonly Mock<IReportService> _mockRepo;

        public ReportTest()
        {
            _mockRepo = new Mock<IReportService>();
            _reportController = new ReportController(_mockRepo.Object);
        }

        [Fact]
        public async void GetAllReport_Test()
        {

            var result = await _reportController.GetAllReport();

            Assert.IsType<OkObjectResult>(result);

        }

        [Fact]
        public async void FindReport_Test()
        {


        }

    }
}
