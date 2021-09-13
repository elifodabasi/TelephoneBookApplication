using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportLocation.Communication.Message
{
  public  class ReportLocationMessage
    {
        public string LocationName { get; set; }
        public string PhoneNumber  { get; set; }
        public Guid PersonId { get; set; }
    }
}
