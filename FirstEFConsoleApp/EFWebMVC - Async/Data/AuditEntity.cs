using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFWebMVC_Async.Data
{
    public class AuditEntity
    {
        public int AuditEntityId { get; set; }

        public DateTime Date { get; set; }

        public string Operation { get; set; }

        public string ExtensedDescription { get; set; }

        public string UserName { get; set; }

        public string IpAddress { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }

        public string City { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public string IP { get; set; }

        public string UserAgent { get; set; }

        public string OperationSystem { get; set; }
    }
}
