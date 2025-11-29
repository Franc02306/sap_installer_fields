using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sap_installer_fields.Models.Requests
{
    public class UdtRequest
    {
        public string TableName { get; set; }
        public string TableDescription { get; set; }
        public string TableType { get; set; }
    }
}
