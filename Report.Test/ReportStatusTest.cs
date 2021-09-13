using Microsoft.AspNetCore.Mvc;
using Moq;
using Report.Business.ReportStatusOps;
using ReportAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Report.Test
{
    public class ReportStatusTest
    {
        private readonly ReportStatusController _reportStatusController;

        private readonly Mock<IReportStatusService> _mockRepo;

        public ReportStatusTest()
        {
            _mockRepo = new Mock<IReportStatusService>();
            _reportStatusController = new ReportStatusController(_mockRepo.Object);
        }

        [Fact]
        public async void GetAllReportStatus_Test()
        {

            var result = await _reportStatusController.GetAll();

            Assert.IsType<OkObjectResult>(result);

        }

        [Fact]
        public async void FindReportStatus_Test()
        {


        }

    }
}
