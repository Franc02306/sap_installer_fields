using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sap_installer_fields.Models.Requests;
using SAPbobsCOM;

namespace sap_installer_fields.Services
{
    public class SapConnectionService
    {
        public Company Connect(SapConnectionRequest req)
        {
            Company company = new Company();
            company.Server = req.Server;
            company.CompanyDB = req.CompanyDB;
            company.UserName = req.User;
            company.Password = req.Password;
            company.LicenseServer = req.LicenseServer;

            company.DbServerType = req.DbType == "HANA" ? BoDataServerTypes.dst_HANADB : BoDataServerTypes.dst_MSSQL2019;

            int res = company.Connect();

            if (res != 0)
                throw new Exception(company.GetLastErrorDescription());

            return company;
        }
    }
}
