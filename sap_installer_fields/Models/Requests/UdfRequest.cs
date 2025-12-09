using System.Collections.Generic;

namespace sap_installer_fields.Models.Requests
{
    public class UdfRequest
    {
        // Estándar
        public string TableName { get; set; }
        public string FieldName { get; set; }
        public string Description { get; set; }
        public string FieldType { get; set; }
        public int Size { get; set; }
        public bool Mandatory { get; set; }
        public string DefaultValue { get; set; }

        // Valores Válidos
        public List<UdfValidValue> ValidValues { get; set; }
        public string ValidValuesText
        {
            get
            {
                if (ValidValues == null || ValidValues.Count == 0)
                    return "";

                return string.Join(", ",
                    ValidValues.ConvertAll(v => $"{v.Value}:{v.Description}"));
            }
        }
    }

    public class UdfValidValue
    {
        public string Value { get; set; }
        public string Description { get; set; }
    }
}
