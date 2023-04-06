using System.Net;
using System;
using SSP.PayeModel;

namespace SSP.Infrastructure
{
    public interface ICompanyListApiRepository : IGenericRepository<CompanyListApi> {
        CompanyListApi GetByRIN(string rin);
    }
    public interface IAssetTaxPayerDetailsApiRepository : IGenericRepository<AssetTaxPayerDetailsApi> { }
    public interface IAgencyRepository : IGenericRepository<Agency> { }
    public interface IBusinessEmployeeRepository : IGenericRepository<BusinessEmployee> { }
}
