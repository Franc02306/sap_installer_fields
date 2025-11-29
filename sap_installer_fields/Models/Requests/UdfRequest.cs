using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sap_installer_fields.Models.Requests
{
    public class UdfRequest
    {
        public string TableName { get; set; }
        public string FieldName { get; set; }
        public string Description { get; set; }
        public string FieldType { get; set; }
        public int Size { get; set; }
        public bool Mandatory { get; set; }
    }
}
