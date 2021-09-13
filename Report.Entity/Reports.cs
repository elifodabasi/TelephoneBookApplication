using Report.Core.Entity.Abstract;
using System;

namespace Report.Entity
{
    public class Reports : IEntity
    {
     
        public Reports()
        {

        }

        public Guid Id { get; set; }
        public DateTime ReportDemandDate { get; set; }
        public int ReportStatusId { get; set; }

       public string Location { get; set; }

        public string PhoneNumber { get; set; }
        public Guid PersonId { get; set; }


        public virtual ReportStatus ReportStatus { get; set; }

       
    }
}
