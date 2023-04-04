using Microsoft.EntityFrameworkCore;
using SSP.PayeModel;
using System.Collections.Generic;

namespace SSP.Infrastructure.RawSql
{
    public interface IAllRawSql
    {
        List<BusinessEmployee> GetBusinessEmployeebyRin(string rin);
        List<AssetTaxPayerDetailsApi> GetAssociateBusinessbyRin(string rin);
        CompanyListApi GetCompanyListApibyRin(string rin);
    }
    public class AllRawSql : IAllRawSql
    {
        public List<AssetTaxPayerDetailsApi> GetAssociateBusinessbyRin(string rin)
        {
            List<AssetTaxPayerDetailsApi> employees = new List<AssetTaxPayerDetailsApi>();
            using (var db = new PinscherSpikeContext())
            {
                employees = db.AssetTaxPayerDetailsApis
                                .FromSqlRaw($"Select * from [AssetTaxPayerDetails_API] where TaxPayerRINNumber = '{rin}'")
                                .ToList();

            }
            return employees;
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
