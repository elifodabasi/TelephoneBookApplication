using MassTransit;
using Microsoft.AspNetCore.Mvc;
using ReportLocation.Communication.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelephoneBook.Entity;

namespace TelephoneBookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageCommandController : ControllerBase
    {
        private readonly ISendEndpointProvider _sendEndpointProvider;

        public MessageCommandController(ISendEndpointProvider sendEndpointProvider)
        {
            _sendEndpointProvider = sendEndpointProvider;
        }

        [HttpPost]
        public async Task<bool> GetReportLocation(ContactInfo contactInfo)
        {
            var sendEndpoint = await _sendEndpointProvider.GetSendEndpoint(new Uri("queue:telephonebook-service"));

            ReportLocationMessage reportLocationMessage = new ReportLocationMessage();
            reportLocationMessage.PhoneNumber = contactInfo.PhoneNumber;
            reportLocationMessage.LocationName = contactInfo.Location;
            reportLocationMessage.PersonId = contactInfo.PersonId;

            await sendEndpoint.Send<ReportLocationMessage>(reportLocationMessage);

            return true;

        }

    }
}
