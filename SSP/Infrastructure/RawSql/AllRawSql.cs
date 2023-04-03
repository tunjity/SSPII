using Microsoft.EntityFrameworkCore;
using SSP.PayeModel;
using System.Collections.Generic;

namespace SSP.Infrastructure.RawSql
{
    public interface IAllRawSql
    {
        List<BusinessEmployee> GetBusinessEmployeebyId(string busname);
        List<BusinessEmployee> GetBusinessEmployeebyRin(string rin);
        CompanyListApi GetCompanyListApibyRin(string rin);
        object GetByEmployeeName(string nameid);
    }

    public class AllRawSql : IAllRawSql
    {

        public List<BusinessEmployee> GetBusinessEmployeebyId(string busname)
        {
            List<BusinessEmployee> employeeName = new List<BusinessEmployee>();
            using (var db = new PinscherSpikeContext())
            {
                employeeName = db.BusinessEmployees
                                .FromSqlRaw($"Select * from Business_API_Main where Id = '{busname}'")
                                .ToList();
            }
            return employeeName;    
        }
        public List<BusinessEmployee> GetBusinessEmployeebyRin(string rin)
        {
            List<BusinessEmployee> employees = new List<BusinessEmployee>();
            using (var db = new PinscherSpikeContext())
            {
                employees = db.BusinessEmployees
                                .FromSqlRaw($"Select * from Business_Employee where assetrin = '{rin}'")
                                .ToList();

            }

            return employees;
        }

        public object GetByEmployeeName(string nameid)
        {
            throw new NotImplementedException();
        }

        public CompanyListApi GetCompanyListApibyRin(string rin)
        {
            CompanyListApi? res = new CompanyListApi();
            using (var db = new PinscherSpikeContext())
            {
                res = db.CompanyListApis
                                .FromSqlRaw($"Select * from CompanyList_API where TaxPayerRin = '{rin}'")
                                .FirstOrDefault();

            }
            return res;
        }
    }
}
