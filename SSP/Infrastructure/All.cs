﻿using SSP.Controllers;
using SSP.PayeModel;
using System;

namespace SSP.Infrastructure
{
    #region CompanyListApi
    public class CompanyListApiRepository : ICompanyListApiRepository
    {
        // private readonly EmployeeDbEntities _context;
        private IGenericRepository<CompanyListApi> _repository = null;
        public CompanyListApiRepository()
        {
            //_context = new EmployeeDbEntities();
            _repository = new GenericRepository<CompanyListApi>();
        }
        public CompanyListApiRepository(IGenericRepository<CompanyListApi> repository)
        {
            _repository = repository;
        }
     
        public IEnumerable<CompanyListApi> GetAll()
        {
            //return _context.Employees.ToList();
            return _repository.GetAll();
        }
        public CompanyListApi GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(CompanyListApi CompanyListApi)
        {
            _repository.Insert(CompanyListApi);
            _repository.Save();
        }
        public void Update(CompanyListApi CompanyListApi)
        {
            _repository.Update(CompanyListApi);
            _repository.Save();
        }
        public void Delete(int id)
        {
            _repository.Delete(id);
            _repository.Save();
        }

        public CompanyListApi GetByRIN(string rin)
        {
            var ret = GetAll();
            if (ret.Count() > 0)
            {
                return ret.FirstOrDefault(o => o.TaxPayerRin == rin);
            }
            throw new System.Exception("No Record Found");
        }
        public void Save()
        {
            throw new NotImplementedException();
        }
    }
    #endregion
    #region AssetTaxPayerDetailsApi
    public class AssetTaxPayerDetailsApiRepository : IAssetTaxPayerDetailsApiRepository
    {
        private IGenericRepository<AssetTaxPayerDetailsApi> _repository = null;
        public AssetTaxPayerDetailsApiRepository()
        {
            _repository = new GenericRepository<AssetTaxPayerDetailsApi>();
        }
        public AssetTaxPayerDetailsApiRepository(IGenericRepository<AssetTaxPayerDetailsApi> repository)
        {
            _repository = repository;
        }
     
        public IEnumerable<AssetTaxPayerDetailsApi> GetAll()
        {
            //return _context.Employees.ToList();
            return _repository.GetAll();
        }
        public AssetTaxPayerDetailsApi GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(AssetTaxPayerDetailsApi AssociatedBusiness)
        {
            _repository.Insert(AssociatedBusiness);
            _repository.Save();
        }
        public void Update(AssetTaxPayerDetailsApi AssociatedBusiness)
        {
            _repository.Update(AssociatedBusiness);
            _repository.Save();
        }
        public void Delete(int id)
        {
            _repository.Delete(id);
            _repository.Save();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
    #endregion
}
