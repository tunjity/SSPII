using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SSP.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSP.Repository
{

    public class ReturnObject
    {
        public bool status { get; set; }
        public int id { get; set; }
        public int statusCode { get; set; }
        public string? message { get; set; }
        public object? data { get; set; }
    }
    public class TokenDecryt
    {
        public string CompanyId { get; set; }
        public string ExpiryIn { get; set; }
    }
    public static class RegisterServicesExtension
    {
        

        public static void InstallServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IAgencyTypeRepository, AgencyTypeRepository>();
            services.AddTransient<IAssetTypeRepository, AssetTypeRepository>();
            services.AddTransient<IBusinessTypeRepository, BusinessTypeRepository>();
            services.AddTransient<IExceptionTypeRepository, ExceptionTypeRepository>();
            services.AddTransient<INotificationTypeRepository, NotificationTypeRepository>();
            services.AddTransient<ISalaryTypeMasterRepository, SalaryTypeMasterRepository>();
            services.AddTransient<ITaxPayerTypeRepository, TaxPayerTypeRepository>();
            services.AddTransient<IAssetTaxPayerDetailsApiRepository, AssetTaxPayerDetailsApiRepository>();
        }
    }
   
}
