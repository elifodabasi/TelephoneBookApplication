using Report.Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report.Entity
{
    public class ReportStatus : IEntity
    {
        public ReportStatus()
        {

        }

        public int Id { get; set; }
        public string Status { get; set; }

    }
}
