using System;
using System.Collections.Generic;
using System.Text;

namespace DataManagement.Common.Models
{
   public class Audit
    {
        public Guid Id { get; set; }
        public Guid OrganisationId { get; set; }
        public Guid Createdby { get; set; }
        public Guid Modifiedby { get; set; }
        public DateTime Createddate { get; set; }
        public DateTime Modifieddate { get; set; }
        public Boolean Isactive { get; set; }


    }
}
