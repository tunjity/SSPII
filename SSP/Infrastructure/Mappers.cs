using AutoMapper;
using SSP.PayeModelII;

namespace SSP.Infrastructure
{
    public class Mappers
    {
        public class TransMapper : AutoMapper.Profile
        {
            public TransMapper()
            {
                CreateMap<BusinessEmployee, BusinessEmployeeViewModel>();
            }
        }
    }
}