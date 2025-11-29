using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sap_installer_fields.Models.Requests
{
    public class SapConnectionRequest
    {
        public string Server { get; set; }
        public string CompanyDB { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string LicenseServer { get; set; }
        public string DbType { get; set; }
    }
}
