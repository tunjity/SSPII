
using SSP.Repository.Payee;
using System;

namespace SSP.Repository.Infrastructure
{
    #region EmployeesMonthlyIncome
    public class EmployeesMonthlyIncomeRepository : IEmployeesMonthlyIncomeRepository
    {
        // private readonly EmployeeDbEntities _context;
        private IGenericRepository<EmployeesMonthlyIncome> _repository = null;
       
        public EmployeesMonthlyIncomeRepository()
        {
            //_context = new EmployeeDbEntities();
            _repository = new GenericRepository<EmployeesMonthlyIncome>();
        }
        public EmployeesMonthlyIncomeRepository(IGenericRepository<EmployeesMonthlyIncome> repository)
        {
            _repository = repository;
        }
    
        public IEnumerable<EmployeesMonthlyIncome> GetAll()
        {
            //return _context.Employees.ToList();
            return _repository.GetAll();
        }
        public EmployeesMonthlyIncome GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(EmployeesMonthlyIncome CompanyListApi)
        {
            _repository.Insert(CompanyListApi);
            _repository.Save();
        }
        public void Update(EmployeesMonthlyIncome CompanyListApi)
        {
            _repository.Update(CompanyListApi);
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

        public IEnumerable<EmployeesMonthlyIncome> GetById(string id)
        {
            return _repository.GetById(id);
        }
    }
    #endregion
    
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

        public IEnumerable<CompanyListApi> GetById(string id)
        {
            return _repository.GetById(id);
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

        public IEnumerable<AssetTaxPayerDetailsApi> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion 

    #region BusinessEmployee
    public class BusinessEmployeeRepository : IBusinessEmployeeRepository
    {
        private IGenericRepository<BusinessEmployee> _repository = null;
        public BusinessEmployeeRepository()
        {
            _repository = new GenericRepository<BusinessEmployee>();
        }
        public BusinessEmployeeRepository(IGenericRepository<BusinessEmployee> repository)
        {
            _repository = repository;
        }
     
        public IEnumerable<BusinessEmployee> GetAll()
        {
            return _repository.GetAll();
        }
        public BusinessEmployee GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(BusinessEmployee BusinessEmployee)
        {
            _repository.Insert(BusinessEmployee);
            _repository.Save();
        }
        public void Update(BusinessEmployee BusinessEmployee)
        {
            _repository.Update(BusinessEmployee);
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

        public IEnumerable<BusinessEmployee> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region AddPayeInputFile
    public class AddPayeInputFileRepository : IAddPayeInputFileRepository
    {
        private IGenericRepository<AddPayeInputFile> _repository = null;
        public AddPayeInputFileRepository()
        {
            _repository = new GenericRepository<AddPayeInputFile>();
        }
        public AddPayeInputFileRepository(IGenericRepository<AddPayeInputFile> repository)
        {
            _repository = repository;
        }

        public IEnumerable<AddPayeInputFile> GetAll()
        {
            return _repository.GetAll();
        }
        public AddPayeInputFile GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(AddPayeInputFile AddPayeInputFile)
        {
            _repository.Insert(AddPayeInputFile);
            _repository.Save();
        }
        public void Update(AddPayeInputFile AddPayeInputFile)
        {
            _repository.Update(AddPayeInputFile);
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

        public IEnumerable<AddPayeInputFile> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region Agency
    public class AgencyRepository : IAgencyRepository
    {
        private IGenericRepository<Agency> _repository = null;
        public AgencyRepository()
        {
            _repository = new GenericRepository<Agency>();
        }
        public AgencyRepository(IGenericRepository<Agency> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Agency> GetAll()
        {
            return _repository.GetAll();
        }
        public Agency GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(Agency Agency)
        {
            _repository.Insert(Agency);
            _repository.Save();
        }
        public void Update(Agency Agency)
        {
            _repository.Update(Agency);
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

        public IEnumerable<Agency> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region AgencyType
    public class AgencyTypeRepository : IAgencyTypeRepository
    {
        private IGenericRepository<AgencyType> _repository = null;
        public AgencyTypeRepository()
        {
            _repository = new GenericRepository<AgencyType>();
        }
        public AgencyTypeRepository(IGenericRepository<AgencyType> repository)
        {
            _repository = repository;
        }

        public IEnumerable<AgencyType> GetAll()
        {
            return _repository.GetAll();
        }
        public AgencyType GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(AgencyType AgencyType)
        {
            _repository.Insert(AgencyType);
            _repository.Save();
        }
        public void Update(AgencyType AgencyType)
        {
            _repository.Update(AgencyType);
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

        public IEnumerable<AgencyType> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region ApiJsonStr
    public class ApiJsonStrRepository : IApiJsonStrRepository
    {
        private IGenericRepository<ApiJsonStr> _repository = null;
        public ApiJsonStrRepository()
        {
            _repository = new GenericRepository<ApiJsonStr>();
        }
        public ApiJsonStrRepository(IGenericRepository<ApiJsonStr> repository)
        {
            _repository = repository;
        }

        public IEnumerable<ApiJsonStr> GetAll()
        {
            return _repository.GetAll();
        }
        public ApiJsonStr GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(ApiJsonStr ApiJsonStr)
        {
            _repository.Insert(ApiJsonStr);
            _repository.Save();
        }
        public void Update(ApiJsonStr ApiJsonStr)
        {
            _repository.Update(ApiJsonStr);
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

        public IEnumerable<ApiJsonStr> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region Assessment
    public class AssessmentRepository : IAssessmentRepository
    {
        private IGenericRepository<Assessment> _repository = null;
        public AssessmentRepository()
        {
            _repository = new GenericRepository<Assessment>();
        }
        public AssessmentRepository(IGenericRepository<Assessment> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Assessment> GetAll()
        {
            return _repository.GetAll();
        }
        public Assessment GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(Assessment Assessment)
        {
            _repository.Insert(Assessment);
            _repository.Save();
        }
        public void Update(Assessment Assessment)
        {
            _repository.Update(Assessment);
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

        public IEnumerable<Assessment> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region AssessmentChild
    public class AssessmentChildRepository : IAssessmentChildRepository
    {
        private IGenericRepository<AssessmentChild> _repository = null;
        public AssessmentChildRepository()
        {
            _repository = new GenericRepository<AssessmentChild>();
        }
        public AssessmentChildRepository(IGenericRepository<AssessmentChild> repository)
        {
            _repository = repository;
        }

        public IEnumerable<AssessmentChild> GetAll()
        {
            return _repository.GetAll();
        }
        public AssessmentChild GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(AssessmentChild AssessmentChild)
        {
            _repository.Insert(AssessmentChild);
            _repository.Save();
        }
        public void Update(AssessmentChild AssessmentChild)
        {
            _repository.Update(AssessmentChild);
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

        public IEnumerable<AssessmentChild> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region AssessmentGroup
    public class AssessmentGroupRepository : IAssessmentGroupRepository
    {
        private IGenericRepository<AssessmentGroup> _repository = null;
        public AssessmentGroupRepository()
        {
            _repository = new GenericRepository<AssessmentGroup>();
        }
        public AssessmentGroupRepository(IGenericRepository<AssessmentGroup> repository)
        {
            _repository = repository;
        }

        public IEnumerable<AssessmentGroup> GetAll()
        {
            return _repository.GetAll();
        }
        public AssessmentGroup GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(AssessmentGroup AssessmentGroup)
        {
            _repository.Insert(AssessmentGroup);
            _repository.Save();
        }
        public void Update(AssessmentGroup AssessmentGroup)
        {
            _repository.Update(AssessmentGroup);
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

        public IEnumerable<AssessmentGroup> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region AssessmentItem
    public class AssessmentItemRepository : IAssessmentItemRepository
    {
        private IGenericRepository<AssessmentItem> _repository = null;
        public AssessmentItemRepository()
        {
            _repository = new GenericRepository<AssessmentItem>();
        }
        public AssessmentItemRepository(IGenericRepository<AssessmentItem> repository)
        {
            _repository = repository;
        }

        public IEnumerable<AssessmentItem> GetAll()
        {
            return _repository.GetAll();
        }
        public AssessmentItem GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(AssessmentItem AssessmentItem)
        {
            _repository.Insert(AssessmentItem);
            _repository.Save();
        }
        public void Update(AssessmentItem AssessmentItem)
        {
            _repository.Update(AssessmentItem);
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

        public IEnumerable<AssessmentItem> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region AssessmentItemApi
    public class AssessmentItemApiRepository : IAssessmentItemApiRepository
    {
        private IGenericRepository<AssessmentItemApi> _repository = null;
        public AssessmentItemApiRepository()
        {
            _repository = new GenericRepository<AssessmentItemApi>();
        }
        public AssessmentItemApiRepository(IGenericRepository<AssessmentItemApi> repository)
        {
            _repository = repository;
        }

        public IEnumerable<AssessmentItemApi> GetAll()
        {
            return _repository.GetAll();
        }
        public AssessmentItemApi GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(AssessmentItemApi AssessmentItemApi)
        {
            _repository.Insert(AssessmentItemApi);
            _repository.Save();
        }
        public void Update(AssessmentItemApi AssessmentItemApi)
        {
            _repository.Update(AssessmentItemApi);
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

        public IEnumerable<AssessmentItemApi> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region AssessmentItemBkApi
    public class AssessmentItemBkApiRepository : IAssessmentItemBkApiRepository
    {
        private IGenericRepository<AssessmentItemBkApi> _repository = null;
        public AssessmentItemBkApiRepository()
        {
            _repository = new GenericRepository<AssessmentItemBkApi>();
        }
        public AssessmentItemBkApiRepository(IGenericRepository<AssessmentItemBkApi> repository)
        {
            _repository = repository;
        }

        public IEnumerable<AssessmentItemBkApi> GetAll()
        {
            return _repository.GetAll();
        }
        public AssessmentItemBkApi GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(AssessmentItemBkApi AssessmentItemBkApi)
        {
            _repository.Insert(AssessmentItemBkApi);
            _repository.Save();
        }
        public void Update(AssessmentItemBkApi AssessmentItemBkApi)
        {
            _repository.Update(AssessmentItemBkApi);
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

        public IEnumerable<AssessmentItemBkApi> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region AssessmentItemCategory
    public class AssessmentItemCategoryRepository : IAssessmentItemCategoryRepository
    {
        private IGenericRepository<AssessmentItemCategory> _repository = null;
        public AssessmentItemCategoryRepository()
        {
            _repository = new GenericRepository<AssessmentItemCategory>();
        }
        public AssessmentItemCategoryRepository(IGenericRepository<AssessmentItemCategory> repository)
        {
            _repository = repository;
        }

        public IEnumerable<AssessmentItemCategory> GetAll()
        {
            return _repository.GetAll();
        }
        public AssessmentItemCategory GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(AssessmentItemCategory AssessmentItemCategory)
        {
            _repository.Insert(AssessmentItemCategory);
            _repository.Save();
        }
        public void Update(AssessmentItemCategory AssessmentItemCategory)
        {
            _repository.Update(AssessmentItemCategory);
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

        public IEnumerable<AssessmentItemCategory> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region AssessmentItemSubCategory
    public class AssessmentItemSubCategoryRepository : IAssessmentItemSubCategoryRepository
    {
        private IGenericRepository<AssessmentItemSubCategory> _repository = null;
        public AssessmentItemSubCategoryRepository()
        {
            _repository = new GenericRepository<AssessmentItemSubCategory>();
        }
        public AssessmentItemSubCategoryRepository(IGenericRepository<AssessmentItemSubCategory> repository)
        {
            _repository = repository;
        }

        public IEnumerable<AssessmentItemSubCategory> GetAll()
        {
            return _repository.GetAll();
        }
        public AssessmentItemSubCategory GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(AssessmentItemSubCategory AssessmentItemSubCategory)
        {
            _repository.Insert(AssessmentItemSubCategory);
            _repository.Save();
        }
        public void Update(AssessmentItemSubCategory AssessmentItemSubCategory)
        {
            _repository.Update(AssessmentItemSubCategory);
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

        public IEnumerable<AssessmentItemSubCategory> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region AssessmentRule
    public class AssessmentRuleRepository : IAssessmentRuleRepository
    {
        private IGenericRepository<AssessmentRule> _repository = null;
        public AssessmentRuleRepository()
        {
            _repository = new GenericRepository<AssessmentRule>();
        }
        public AssessmentRuleRepository(IGenericRepository<AssessmentRule> repository)
        {
            _repository = repository;
        }

        public IEnumerable<AssessmentRule> GetAll()
        {
            return _repository.GetAll();
        }
        public AssessmentRule GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(AssessmentRule AssessmentRule)
        {
            _repository.Insert(AssessmentRule);
            _repository.Save();
        }
        public void Update(AssessmentRule AssessmentRule)
        {
            _repository.Update(AssessmentRule);
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

        public IEnumerable<AssessmentRule> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region AssessmentRule1
    public class AssessmentRule1Repository : IAssessmentRule1Repository
    {
        private IGenericRepository<AssessmentRule1> _repository = null;
        public AssessmentRule1Repository()
        {
            _repository = new GenericRepository<AssessmentRule1>();
        }
        public AssessmentRule1Repository(IGenericRepository<AssessmentRule1> repository)
        {
            _repository = repository;
        }

        public IEnumerable<AssessmentRule1> GetAll()
        {
            return _repository.GetAll();
        }
        public AssessmentRule1 GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(AssessmentRule1 AssessmentRule1)
        {
            _repository.Insert(AssessmentRule1);
            _repository.Save();
        }
        public void Update(AssessmentRule1 AssessmentRule1)
        {
            _repository.Update(AssessmentRule1);
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

        public IEnumerable<AssessmentRule1> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region AssessmentRuleMasterApi
    public class AssessmentRuleMasterApiRepository : IAssessmentRuleMasterApiRepository
    {
        private IGenericRepository<AssessmentRuleMasterApi> _repository = null;
        public AssessmentRuleMasterApiRepository()
        {
            _repository = new GenericRepository<AssessmentRuleMasterApi>();
        }
        public AssessmentRuleMasterApiRepository(IGenericRepository<AssessmentRuleMasterApi> repository)
        {
            _repository = repository;
        }

        public IEnumerable<AssessmentRuleMasterApi> GetAll()
        {
            return _repository.GetAll();
        }
        public AssessmentRuleMasterApi GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(AssessmentRuleMasterApi AssessmentRuleMasterApi)
        {
            _repository.Insert(AssessmentRuleMasterApi);
            _repository.Save();
        }
        public void Update(AssessmentRuleMasterApi AssessmentRuleMasterApi)
        {
            _repository.Update(AssessmentRuleMasterApi);
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

        public IEnumerable<AssessmentRuleMasterApi> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region AssessmentRulesApi
    public class AssessmentRulesApiRepository : IAssessmentRulesApiRepository
    {
        private IGenericRepository<AssessmentRulesApi> _repository = null;
        public AssessmentRulesApiRepository()
        {
            _repository = new GenericRepository<AssessmentRulesApi>();
        }
        public AssessmentRulesApiRepository(IGenericRepository<AssessmentRulesApi> repository)
        {
            _repository = repository;
        }

        public IEnumerable<AssessmentRulesApi> GetAll()
        {
            return _repository.GetAll();
        }
        public AssessmentRulesApi GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(AssessmentRulesApi AssessmentRulesApi)
        {
            _repository.Insert(AssessmentRulesApi);
            _repository.Save();
        }
        public void Update(AssessmentRulesApi AssessmentRulesApi)
        {
            _repository.Update(AssessmentRulesApi);
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

        public IEnumerable<AssessmentRulesApi> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region AssessmentsApi
    public class AssessmentsApiRepository : IAssessmentsApiRepository
    {
        private IGenericRepository<AssessmentsApi> _repository = null;
        public AssessmentsApiRepository()
        {
            _repository = new GenericRepository<AssessmentsApi>();
        }
        public AssessmentsApiRepository(IGenericRepository<AssessmentsApi> repository)
        {
            _repository = repository;
        }

        public IEnumerable<AssessmentsApi> GetAll()
        {
            return _repository.GetAll();
        }
        public AssessmentsApi GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(AssessmentsApi AssessmentsApi)
        {
            _repository.Insert(AssessmentsApi);
            _repository.Save();
        }
        public void Update(AssessmentsApi AssessmentsApi)
        {
            _repository.Update(AssessmentsApi);
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

        public IEnumerable<AssessmentsApi> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region AssessmentStatus
    public class AssessmentStatusRepository : IAssessmentStatusRepository
    {
        private IGenericRepository<AssessmentStatus> _repository = null;
        public AssessmentStatusRepository()
        {
            _repository = new GenericRepository<AssessmentStatus>();
        }
        public AssessmentStatusRepository(IGenericRepository<AssessmentStatus> repository)
        {
            _repository = repository;
        }

        public IEnumerable<AssessmentStatus> GetAll()
        {
            return _repository.GetAll();
        }
        public AssessmentStatus GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(AssessmentStatus AssessmentStatus)
        {
            _repository.Insert(AssessmentStatus);
            _repository.Save();
        }
        public void Update(AssessmentStatus AssessmentStatus)
        {
            _repository.Update(AssessmentStatus);
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

        public IEnumerable<AssessmentStatus> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region AssessmentSubGroup
    public class AssessmentSubGroupRepository : IAssessmentSubGroupRepository
    {
        private IGenericRepository<AssessmentSubGroup> _repository = null;
        public AssessmentSubGroupRepository()
        {
            _repository = new GenericRepository<AssessmentSubGroup>();
        }
        public AssessmentSubGroupRepository(IGenericRepository<AssessmentSubGroup> repository)
        {
            _repository = repository;
        }

        public IEnumerable<AssessmentSubGroup> GetAll()
        {
            return _repository.GetAll();
        }
        public AssessmentSubGroup GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(AssessmentSubGroup AssessmentSubGroup)
        {
            _repository.Insert(AssessmentSubGroup);
            _repository.Save();
        }
        public void Update(AssessmentSubGroup AssessmentSubGroup)
        {
            _repository.Update(AssessmentSubGroup);
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

        public IEnumerable<AssessmentSubGroup> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region AssetType
    public class AssetTypeRepository : IAssetTypeRepository
    {
        private IGenericRepository<AssetType> _repository = null;
        public AssetTypeRepository()
        {
            _repository = new GenericRepository<AssetType>();
        }
        public AssetTypeRepository(IGenericRepository<AssetType> repository)
        {
            _repository = repository;
        }

        public IEnumerable<AssetType> GetAll()
        {
            return _repository.GetAll();
        }
        public AssetType GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(AssetType AssetType)
        {
            _repository.Insert(AssetType);
            _repository.Save();
        }
        public void Update(AssetType AssetType)
        {
            _repository.Update(AssetType);
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

        public IEnumerable<AssetType> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region Building
    public class BuildingRepository : IBuildingRepository
    {
        private IGenericRepository<Building> _repository = null;
        public BuildingRepository()
        {
            _repository = new GenericRepository<Building>();
        }
        public BuildingRepository(IGenericRepository<Building> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Building> GetAll()
        {
            return _repository.GetAll();
        }
        public Building GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(Building Building)
        {
            _repository.Insert(Building);
            _repository.Save();
        }
        public void Update(Building Building)
        {
            _repository.Update(Building);
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

        public IEnumerable<Building> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region Business
    public class BusinessRepository : IBusinessRepository
    {
        private IGenericRepository<Business> _repository = null;
        public BusinessRepository()
        {
            _repository = new GenericRepository<Business>();
        }
        public BusinessRepository(IGenericRepository<Business> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Business> GetAll()
        {
            return _repository.GetAll();
        }
        public Business GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(Business Business)
        {
            _repository.Insert(Business);
            _repository.Save();
        }
        public void Update(Business Business)
        {
            _repository.Update(Business);
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

        public IEnumerable<Business> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region BusinessCategory
    public class BusinessCategoryRepository : IBusinessCategoryRepository
    {
        private IGenericRepository<BusinessCategory> _repository = null;
        public BusinessCategoryRepository()
        {
            _repository = new GenericRepository<BusinessCategory>();
        }
        public BusinessCategoryRepository(IGenericRepository<BusinessCategory> repository)
        {
            _repository = repository;
        }

        public IEnumerable<BusinessCategory> GetAll()
        {
            return _repository.GetAll();
        }
        public BusinessCategory GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(BusinessCategory BusinessCategory)
        {
            _repository.Insert(BusinessCategory);
            _repository.Save();
        }
        public void Update(BusinessCategory BusinessCategory)
        {
            _repository.Update(BusinessCategory);
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

        public IEnumerable<BusinessCategory> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region BusinessesApi
    public class BusinessesApiRepository : IBusinessesApiRepository
    {
        private IGenericRepository<BusinessesApi> _repository = null;
        public BusinessesApiRepository()
        {
            _repository = new GenericRepository<BusinessesApi>();
        }
        public BusinessesApiRepository(IGenericRepository<BusinessesApi> repository)
        {
            _repository = repository;
        }

        public IEnumerable<BusinessesApi> GetAll()
        {
            return _repository.GetAll();
        }
        public BusinessesApi GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(BusinessesApi BusinessesApi)
        {
            _repository.Insert(BusinessesApi);
            _repository.Save();
        }
        public void Update(BusinessesApi BusinessesApi)
        {
            _repository.Update(BusinessesApi);
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

        public IEnumerable<BusinessesApi> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region BusinessesApiMain
    public class BusinessesApiMainRepository : IBusinessesApiMainRepository
    {
        private IGenericRepository<BusinessesApiMain> _repository = null;
        public BusinessesApiMainRepository()
        {
            _repository = new GenericRepository<BusinessesApiMain>();
        }
        public BusinessesApiMainRepository(IGenericRepository<BusinessesApiMain> repository)
        {
            _repository = repository;
        }

        public IEnumerable<BusinessesApiMain> GetAll()
        {
            return _repository.GetAll();
        }
        public BusinessesApiMain GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(BusinessesApiMain BusinessesApiMain)
        {
            _repository.Insert(BusinessesApiMain);
            _repository.Save();
        }
        public void Update(BusinessesApiMain BusinessesApiMain)
        {
            _repository.Update(BusinessesApiMain);
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

        public IEnumerable<BusinessesApiMain> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    //#region BusinessesBkApi
    //public class BusinessesBkApiRepository : IBusinessesBkApiRepository
    //{
    //    private IGenericRepository<BusinessesBkApi> _repository = null;
    //    public BusinessesBkApiRepository()
    //    {
    //        _repository = new GenericRepository<BusinessesBkApi>();
    //    }
    //    public BusinessesBkApiRepository(IGenericRepository<BusinessesBkApi> repository)
    //    {
    //        _repository = repository;
    //    }

    //    public IEnumerable<BusinessesBkApi> GetAll()
    //    {
    //        return _repository.GetAll();
    //    }
    //    public BusinessesBkApi GetById(int id)
    //    {
    //        return _repository.GetById(id);
    //    }
    //    public void Insert(BusinessesBkApi BusinessesBkApi)
    //    {
    //        _repository.Insert(BusinessesBkApi);
    //        _repository.Save();
    //    }
    //    public void Update(BusinessesBkApi BusinessesBkApi)
    //    {
    //        _repository.Update(BusinessesBkApi);
    //        _repository.Save();
    //    }
    //    public void Delete(int id)
    //    {
    //        _repository.Delete(id);
    //        _repository.Save();
    //    }

    //    public void Save()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public IEnumerable<BusinessesBkApi> GetById(string id)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //#endregion

    #region BusinessesFullApi
    public class BusinessesFullApiRepository : IBusinessesFullApiRepository
    {
        private IGenericRepository<BusinessesFullApi> _repository = null;
        public BusinessesFullApiRepository()
        {
            _repository = new GenericRepository<BusinessesFullApi>();
        }
        public BusinessesFullApiRepository(IGenericRepository<BusinessesFullApi> repository)
        {
            _repository = repository;
        }

        public IEnumerable<BusinessesFullApi> GetAll()
        {
            return _repository.GetAll();
        }
        public BusinessesFullApi GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(BusinessesFullApi BusinessesFullApi)
        {
            _repository.Insert(BusinessesFullApi);
            _repository.Save();
        }
        public void Update(BusinessesFullApi BusinessesFullApi)
        {
            _repository.Update(BusinessesFullApi);
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

        public IEnumerable<BusinessesFullApi> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region BusinessOperation
    public class BusinessOperationRepository : IBusinessOperationRepository
    {
        private IGenericRepository<BusinessOperation> _repository = null;
        public BusinessOperationRepository()
        {
            _repository = new GenericRepository<BusinessOperation>();
        }
        public BusinessOperationRepository(IGenericRepository<BusinessOperation> repository)
        {
            _repository = repository;
        }

        public IEnumerable<BusinessOperation> GetAll()
        {
            return _repository.GetAll();
        }
        public BusinessOperation GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(BusinessOperation BusinessOperation)
        {
            _repository.Insert(BusinessOperation);
            _repository.Save();
        }
        public void Update(BusinessOperation BusinessOperation)
        {
            _repository.Update(BusinessOperation);
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

        public IEnumerable<BusinessOperation> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region BusinessSector
    public class BusinessSectorRepository : IBusinessSectorRepository
    {
        private IGenericRepository<BusinessSector> _repository = null;
        public BusinessSectorRepository()
        {
            _repository = new GenericRepository<BusinessSector>();
        }
        public BusinessSectorRepository(IGenericRepository<BusinessSector> repository)
        {
            _repository = repository;
        }

        public IEnumerable<BusinessSector> GetAll()
        {
            return _repository.GetAll();
        }
        public BusinessSector GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(BusinessSector BusinessSector)
        {
            _repository.Insert(BusinessSector);
            _repository.Save();
        }
        public void Update(BusinessSector BusinessSector)
        {
            _repository.Update(BusinessSector);
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

        public IEnumerable<BusinessSector> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region BusinessStructure
    public class BusinessStructureRepository : IBusinessStructureRepository
    {
        private IGenericRepository<BusinessStructure> _repository = null;
        public BusinessStructureRepository()
        {
            _repository = new GenericRepository<BusinessStructure>();
        }
        public BusinessStructureRepository(IGenericRepository<BusinessStructure> repository)
        {
            _repository = repository;
        }

        public IEnumerable<BusinessStructure> GetAll()
        {
            return _repository.GetAll();
        }
        public BusinessStructure GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(BusinessStructure BusinessStructure)
        {
            _repository.Insert(BusinessStructure);
            _repository.Save();
        }
        public void Update(BusinessStructure BusinessStructure)
        {
            _repository.Update(BusinessStructure);
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

        public IEnumerable<BusinessStructure> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region BusinessSubSector
    public class BusinessSubSectorRepository : IBusinessSubSectorRepository
    {
        private IGenericRepository<BusinessSubSector> _repository = null;
        public BusinessSubSectorRepository()
        {
            _repository = new GenericRepository<BusinessSubSector>();
        }
        public BusinessSubSectorRepository(IGenericRepository<BusinessSubSector> repository)
        {
            _repository = repository;
        }

        public IEnumerable<BusinessSubSector> GetAll()
        {
            return _repository.GetAll();
        }
        public BusinessSubSector GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(BusinessSubSector BusinessSubSector)
        {
            _repository.Insert(BusinessSubSector);
            _repository.Save();
        }
        public void Update(BusinessSubSector BusinessSubSector)
        {
            _repository.Update(BusinessSubSector);
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

        public IEnumerable<BusinessSubSector> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region BusinessType
    public class BusinessTypeRepository : IBusinessTypeRepository
    {
        private IGenericRepository<BusinessType> _repository = null;
        public BusinessTypeRepository()
        {
            _repository = new GenericRepository<BusinessType>();
        }
        public BusinessTypeRepository(IGenericRepository<BusinessType> repository)
        {
            _repository = repository;
        }

        public IEnumerable<BusinessType> GetAll()
        {
            return _repository.GetAll();
        }
        public BusinessType GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(BusinessType BusinessType)
        {
            _repository.Insert(BusinessType);
            _repository.Save();
        }
        public void Update(BusinessType BusinessType)
        {
            _repository.Update(BusinessType);
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

        public IEnumerable<BusinessType> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region ClearanceCertificate
    public class ClearanceCertificateRepository : IClearanceCertificateRepository
    {
        private IGenericRepository<ClearanceCertificate> _repository = null;
        public ClearanceCertificateRepository()
        {
            _repository = new GenericRepository<ClearanceCertificate>();
        }
        public ClearanceCertificateRepository(IGenericRepository<ClearanceCertificate> repository)
        {
            _repository = repository;
        }

        public IEnumerable<ClearanceCertificate> GetAll()
        {
            return _repository.GetAll();
        }
        public ClearanceCertificate GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(ClearanceCertificate ClearanceCertificate)
        {
            _repository.Insert(ClearanceCertificate);
            _repository.Save();
        }
        public void Update(ClearanceCertificate ClearanceCertificate)
        {
            _repository.Update(ClearanceCertificate);
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

        public IEnumerable<ClearanceCertificate> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    //#region CompaniesApi
    //public class CompaniesApiRepository : ICompaniesApiRepository
    //{
    //    private IGenericRepository<CompaniesApi> _repository = null;
    //    public CompaniesApiRepository()
    //    {
    //        _repository = new GenericRepository<CompaniesApi>();
    //    }
    //    public CompaniesApiRepository(IGenericRepository<CompaniesApi> repository)
    //    {
    //        _repository = repository;
    //    }

    //    public IEnumerable<CompaniesApi> GetAll()
    //    {
    //        return _repository.GetAll();
    //    }
    //    public CompaniesApi GetById(int id)
    //    {
    //        return _repository.GetById(id);
    //    }
    //    public void Insert(CompaniesApi CompaniesApi)
    //    {
    //        _repository.Insert(CompaniesApi);
    //        _repository.Save();
    //    }
    //    public void Update(CompaniesApi CompaniesApi)
    //    {
    //        _repository.Update(CompaniesApi);
    //        _repository.Save();
    //    }
    //    public void Delete(int id)
    //    {
    //        _repository.Delete(id);
    //        _repository.Save();
    //    }

    //    public void Save()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public IEnumerable<CompaniesApi> GetById(string id)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //#endregion

    ////#region Company
    //public class CompanyRepository : ICompanyRepository
    //{
    //    private IGenericRepository<Company> _repository = null;
    //    public CompanyRepository()
    //    {
    //        _repository = new GenericRepository<Company>();
    //    }
    //    public CompanyRepository(IGenericRepository<Company> repository)
    //    {
    //        _repository = repository;
    //    }

    //    public IEnumerable<Company> GetAll()
    //    {
    //        return _repository.GetAll();
    //    }
    //    public Company GetById(int id)
    //    {
    //        return _repository.GetById(id);
    //    }
    //    public void Insert(Company Company)
    //    {
    //        _repository.Insert(Company);
    //        _repository.Save();
    //    }
    //    public void Update(Company Company)
    //    {
    //        _repository.Update(Company);
    //        _repository.Save();
    //    }
    //    public void Delete(int id)
    //    {
    //        _repository.Delete(id);
    //        _repository.Save();
    //    }

    //    public void Save()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public IEnumerable<Company> GetById(string id)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //#endregion

    //#region CompanyListBkApi
    //public class CompanyListBkApiRepository : ICompanyListBkApiRepository
    //{
    //    private IGenericRepository<CompanyListBkApi> _repository = null;
    //    public CompanyListBkApiRepository()
    //    {
    //        _repository = new GenericRepository<CompanyListBkApi>();
    //    }
    //    public CompanyListBkApiRepository(IGenericRepository<CompanyListBkApi> repository)
    //    {
    //        _repository = repository;
    //    }

    //    public IEnumerable<CompanyListBkApi> GetAll()
    //    {
    //        return _repository.GetAll();
    //    }
    //    public CompanyListBkApi GetById(int id)
    //    {
    //        return _repository.GetById(id);
    //    }
    //    public void Insert(CompanyListBkApi CompanyListBkApi)
    //    {
    //        _repository.Insert(CompanyListBkApi);
    //        _repository.Save();
    //    }
    //    public void Update(CompanyListBkApi CompanyListBkApi)
    //    {
    //        _repository.Update(CompanyListBkApi);
    //        _repository.Save();
    //    }
    //    public void Delete(int id)
    //    {
    //        _repository.Delete(id);
    //        _repository.Save();
    //    }

    //    public void Save()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public IEnumerable<CompanyListBkApi> GetById(string id)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //#endregion

    #region Directorate
    public class DirectorateRepository : IDirectorateRepository
    {
        private IGenericRepository<Directorate> _repository = null;
        public DirectorateRepository()
        {
            _repository = new GenericRepository<Directorate>();
        }
        public DirectorateRepository(IGenericRepository<Directorate> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Directorate> GetAll()
        {
            return _repository.GetAll();
        }
        public Directorate GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(Directorate Directorate)
        {
            _repository.Insert(Directorate);
            _repository.Save();
        }
        public void Update(Directorate Directorate)
        {
            _repository.Update(Directorate);
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

        public IEnumerable<Directorate> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region EconomicActivity
    public class EconomicActivityRepository : IEconomicActivityRepository
    {
        private IGenericRepository<EconomicActivity> _repository = null;
        public EconomicActivityRepository()
        {
            _repository = new GenericRepository<EconomicActivity>();
        }
        public EconomicActivityRepository(IGenericRepository<EconomicActivity> repository)
        {
            _repository = repository;
        }

        public IEnumerable<EconomicActivity> GetAll()
        {
            return _repository.GetAll();
        }
        public EconomicActivity GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(EconomicActivity EconomicActivity)
        {
            _repository.Insert(EconomicActivity);
            _repository.Save();
        }
        public void Update(EconomicActivity EconomicActivity)
        {
            _repository.Update(EconomicActivity);
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

        public IEnumerable<EconomicActivity> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region EirsUser
    public class EirsUserRepository : IEirsUserRepository
    {
        private IGenericRepository<EirsUser> _repository = null;
        public EirsUserRepository()
        {
            _repository = new GenericRepository<EirsUser>();
        }
        public EirsUserRepository(IGenericRepository<EirsUser> repository)
        {
            _repository = repository;
        }

        public IEnumerable<EirsUser> GetAll()
        {
            return _repository.GetAll();
        }
        public EirsUser GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(EirsUser EirsUser)
        {
            _repository.Insert(EirsUser);
            _repository.Save();
        }
        public void Update(EirsUser EirsUser)
        {
            _repository.Update(EirsUser);
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

        public IEnumerable<EirsUser> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region EmployeeAnnualTax
    public class EmployeeAnnualTaxRepository : IEmployeeAnnualTaxRepository
    {
        private IGenericRepository<EmployeeAnnualTax> _repository = null;
        public EmployeeAnnualTaxRepository()
        {
            _repository = new GenericRepository<EmployeeAnnualTax>();
        }
        public EmployeeAnnualTaxRepository(IGenericRepository<EmployeeAnnualTax> repository)
        {
            _repository = repository;
        }

        public IEnumerable<EmployeeAnnualTax> GetAll()
        {
            return _repository.GetAll();
        }
        public EmployeeAnnualTax GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(EmployeeAnnualTax EmployeeAnnualTax)
        {
            _repository.Insert(EmployeeAnnualTax);
            _repository.Save();
        }
        public void Update(EmployeeAnnualTax EmployeeAnnualTax)
        {
            _repository.Update(EmployeeAnnualTax);
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

        public IEnumerable<EmployeeAnnualTax> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region EmployeeContributionOutputFile
    public class EmployeeContributionOutputFileRepository : IEmployeeContributionOutputFileRepository
    {
        private IGenericRepository<EmployeeContributionOutputFile> _repository = null;
        public EmployeeContributionOutputFileRepository()
        {
            _repository = new GenericRepository<EmployeeContributionOutputFile>();
        }
        public EmployeeContributionOutputFileRepository(IGenericRepository<EmployeeContributionOutputFile> repository)
        {
            _repository = repository;
        }

        public IEnumerable<EmployeeContributionOutputFile> GetAll()
        {
            return _repository.GetAll();
        }
        public EmployeeContributionOutputFile GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(EmployeeContributionOutputFile EmployeeContributionOutputFile)
        {
            _repository.Insert(EmployeeContributionOutputFile);
            _repository.Save();
        }
        public void Update(EmployeeContributionOutputFile EmployeeContributionOutputFile)
        {
            _repository.Update(EmployeeContributionOutputFile);
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

        public IEnumerable<EmployeeContributionOutputFile> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region EmployerAssessmentOutputFile
    public class EmployerAssessmentOutputFileRepository : IEmployerAssessmentOutputFileRepository
    {
        private IGenericRepository<EmployerAssessmentOutputFile> _repository = null;
        public EmployerAssessmentOutputFileRepository()
        {
            _repository = new GenericRepository<EmployerAssessmentOutputFile>();
        }
        public EmployerAssessmentOutputFileRepository(IGenericRepository<EmployerAssessmentOutputFile> repository)
        {
            _repository = repository;
        }

        public IEnumerable<EmployerAssessmentOutputFile> GetAll()
        {
            return _repository.GetAll();
        }
        public EmployerAssessmentOutputFile GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(EmployerAssessmentOutputFile EmployerAssessmentOutputFile)
        {
            _repository.Insert(EmployerAssessmentOutputFile);
            _repository.Save();
        }
        public void Update(EmployerAssessmentOutputFile EmployerAssessmentOutputFile)
        {
            _repository.Update(EmployerAssessmentOutputFile);
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

        public IEnumerable<EmployerAssessmentOutputFile> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region ExceptionType
    public class ExceptionTypeRepository : IExceptionTypeRepository
    {
        private IGenericRepository<ExceptionType> _repository = null;
        public ExceptionTypeRepository()
        {
            _repository = new GenericRepository<ExceptionType>();
        }
        public ExceptionTypeRepository(IGenericRepository<ExceptionType> repository)
        {
            _repository = repository;
        }

        public IEnumerable<ExceptionType> GetAll()
        {
            return _repository.GetAll();
        }
        public ExceptionType GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(ExceptionType ExceptionType)
        {
            _repository.Insert(ExceptionType);
            _repository.Save();
        }
        public void Update(ExceptionType ExceptionType)
        {
            _repository.Update(ExceptionType);
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

        public IEnumerable<ExceptionType> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region FileStatus
    public class FileStatusRepository : IFileStatusRepository
    {
        private IGenericRepository<FileStatus> _repository = null;
        public FileStatusRepository()
        {
            _repository = new GenericRepository<FileStatus>();
        }
        public FileStatusRepository(IGenericRepository<FileStatus> repository)
        {
            _repository = repository;
        }

        public IEnumerable<FileStatus> GetAll()
        {
            return _repository.GetAll();
        }
        public FileStatus GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(FileStatus FileStatus)
        {
            _repository.Insert(FileStatus);
            _repository.Save();
        }
        public void Update(FileStatus FileStatus)
        {
            _repository.Update(FileStatus);
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

        public IEnumerable<FileStatus> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region FormMaster
    public class FormMasterRepository : IFormMasterRepository
    {
        private IGenericRepository<FormMaster> _repository = null;
        public FormMasterRepository()
        {
            _repository = new GenericRepository<FormMaster>();
        }
        public FormMasterRepository(IGenericRepository<FormMaster> repository)
        {
            _repository = repository;
        }

        public IEnumerable<FormMaster> GetAll()
        {
            return _repository.GetAll();
        }
        public FormMaster GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(FormMaster FormMaster)
        {
            _repository.Insert(FormMaster);
            _repository.Save();
        }
        public void Update(FormMaster FormMaster)
        {
            _repository.Update(FormMaster);
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

        public IEnumerable<FormMaster> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region GroupFormRelation
    public class GroupFormRelationRepository : IGroupFormRelationRepository
    {
        private IGenericRepository<GroupFormRelation> _repository = null;
        public GroupFormRelationRepository()
        {
            _repository = new GenericRepository<GroupFormRelation>();
        }
        public GroupFormRelationRepository(IGenericRepository<GroupFormRelation> repository)
        {
            _repository = repository;
        }

        public IEnumerable<GroupFormRelation> GetAll()
        {
            return _repository.GetAll();
        }
        public GroupFormRelation GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(GroupFormRelation GroupFormRelation)
        {
            _repository.Insert(GroupFormRelation);
            _repository.Save();
        }
        public void Update(GroupFormRelation GroupFormRelation)
        {
            _repository.Update(GroupFormRelation);
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

        public IEnumerable<GroupFormRelation> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region GroupMaster
    public class GroupMasterRepository : IGroupMasterRepository
    {
        private IGenericRepository<GroupMaster> _repository = null;
        public GroupMasterRepository()
        {
            _repository = new GenericRepository<GroupMaster>();
        }
        public GroupMasterRepository(IGenericRepository<GroupMaster> repository)
        {
            _repository = repository;
        }

        public IEnumerable<GroupMaster> GetAll()
        {
            return _repository.GetAll();
        }
        public GroupMaster GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(GroupMaster GroupMaster)
        {
            _repository.Insert(GroupMaster);
            _repository.Save();
        }
        public void Update(GroupMaster GroupMaster)
        {
            _repository.Update(GroupMaster);
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

        public IEnumerable<GroupMaster> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region Individual
    public class IndividualRepository : IIndividualRepository
    {
        private IGenericRepository<Individual> _repository = null;
        public IndividualRepository()
        {
            _repository = new GenericRepository<Individual>();
        }
        public IndividualRepository(IGenericRepository<Individual> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Individual> GetAll()
        {
            return _repository.GetAll();
        }
        public Individual GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(Individual Individual)
        {
            _repository.Insert(Individual);
            _repository.Save();
        }
        public void Update(Individual Individual)
        {
            _repository.Update(Individual);
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

        public IEnumerable<Individual> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region IndividualsApi
    public class IndividualsApiRepository : IIndividualsApiRepository
    {
        private IGenericRepository<IndividualsApi> _repository = null;
        public IndividualsApiRepository()
        {
            _repository = new GenericRepository<IndividualsApi>();
        }
        public IndividualsApiRepository(IGenericRepository<IndividualsApi> repository)
        {
            _repository = repository;
        }

        public IEnumerable<IndividualsApi> GetAll()
        {
            return _repository.GetAll();
        }
        public IndividualsApi GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(IndividualsApi IndividualsApi)
        {
            _repository.Insert(IndividualsApi);
            _repository.Save();
        }
        public void Update(IndividualsApi IndividualsApi)
        {
            _repository.Update(IndividualsApi);
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

        public IEnumerable<IndividualsApi> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region IndividualsApiInput
    public class IndividualsApiInputRepository : IIndividualsApiInputRepository
    {
        private IGenericRepository<IndividualsApiInput> _repository = null;
        public IndividualsApiInputRepository()
        {
            _repository = new GenericRepository<IndividualsApiInput>();
        }
        public IndividualsApiInputRepository(IGenericRepository<IndividualsApiInput> repository)
        {
            _repository = repository;
        }

        public IEnumerable<IndividualsApiInput> GetAll()
        {
            return _repository.GetAll();
        }
        public IndividualsApiInput GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(IndividualsApiInput IndividualsApiInput)
        {
            _repository.Insert(IndividualsApiInput);
            _repository.Save();
        }
        public void Update(IndividualsApiInput IndividualsApiInput)
        {
            _repository.Update(IndividualsApiInput);
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

        public IEnumerable<IndividualsApiInput> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region LegacySubmissionsPaye
    public class LegacySubmissionsPayeRepository : ILegacySubmissionsPayeRepository
    {
        private IGenericRepository<LegacySubmissionsPaye> _repository = null;
        public LegacySubmissionsPayeRepository()
        {
            _repository = new GenericRepository<LegacySubmissionsPaye>();
        }
        public LegacySubmissionsPayeRepository(IGenericRepository<LegacySubmissionsPaye> repository)
        {
            _repository = repository;
        }

        public IEnumerable<LegacySubmissionsPaye> GetAll()
        {
            return _repository.GetAll();
        }
        public LegacySubmissionsPaye GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(LegacySubmissionsPaye LegacySubmissionsPaye)
        {
            _repository.Insert(LegacySubmissionsPaye);
            _repository.Save();
        }
        public void Update(LegacySubmissionsPaye LegacySubmissionsPaye)
        {
            _repository.Update(LegacySubmissionsPaye);
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

        public IEnumerable<LegacySubmissionsPaye> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region LocalGovernmentArea
    public class LocalGovernmentAreaRepository : ILocalGovernmentAreaRepository
    {
        private IGenericRepository<LocalGovernmentArea> _repository = null;
        public LocalGovernmentAreaRepository()
        {
            _repository = new GenericRepository<LocalGovernmentArea>();
        }
        public LocalGovernmentAreaRepository(IGenericRepository<LocalGovernmentArea> repository)
        {
            _repository = repository;
        }

        public IEnumerable<LocalGovernmentArea> GetAll()
        {
            return _repository.GetAll();
        }
        public LocalGovernmentArea GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(LocalGovernmentArea LocalGovernmentArea)
        {
            _repository.Insert(LocalGovernmentArea);
            _repository.Save();
        }
        public void Update(LocalGovernmentArea LocalGovernmentArea)
        {
            _repository.Update(LocalGovernmentArea);
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

        public IEnumerable<LocalGovernmentArea> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region MyView1
    public class MyView1Repository : IMyView1Repository
    {
        private IGenericRepository<MyView1> _repository = null;
        public MyView1Repository()
        {
            _repository = new GenericRepository<MyView1>();
        }
        public MyView1Repository(IGenericRepository<MyView1> repository)
        {
            _repository = repository;
        }

        public IEnumerable<MyView1> GetAll()
        {
            return _repository.GetAll();
        }
        public MyView1 GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(MyView1 MyView1)
        {
            _repository.Insert(MyView1);
            _repository.Save();
        }
        public void Update(MyView1 MyView1)
        {
            _repository.Update(MyView1);
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

        public IEnumerable<MyView1> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region Nationality
    public class NationalityRepository : INationalityRepository
    {
        private IGenericRepository<Nationality> _repository = null;
        public NationalityRepository()
        {
            _repository = new GenericRepository<Nationality>();
        }
        public NationalityRepository(IGenericRepository<Nationality> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Nationality> GetAll()
        {
            return _repository.GetAll();
        }
        public Nationality GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(Nationality Nationality)
        {
            _repository.Insert(Nationality);
            _repository.Save();
        }
        public void Update(Nationality Nationality)
        {
            _repository.Update(Nationality);
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

        public IEnumerable<Nationality> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region Notification
    public class NotificationRepository : INotificationRepository
    {
        private IGenericRepository<Notification> _repository = null;
        public NotificationRepository()
        {
            _repository = new GenericRepository<Notification>();
        }
        public NotificationRepository(IGenericRepository<Notification> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Notification> GetAll()
        {
            return _repository.GetAll();
        }
        public Notification GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(Notification Notification)
        {
            _repository.Insert(Notification);
            _repository.Save();
        }
        public void Update(Notification Notification)
        {
            _repository.Update(Notification);
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

        public IEnumerable<Notification> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region NotificationMethod
    public class NotificationMethodRepository : INotificationMethodRepository
    {
        private IGenericRepository<NotificationMethod> _repository = null;
        public NotificationMethodRepository()
        {
            _repository = new GenericRepository<NotificationMethod>();
        }
        public NotificationMethodRepository(IGenericRepository<NotificationMethod> repository)
        {
            _repository = repository;
        }

        public IEnumerable<NotificationMethod> GetAll()
        {
            return _repository.GetAll();
        }
        public NotificationMethod GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(NotificationMethod NotificationMethod)
        {
            _repository.Insert(NotificationMethod);
            _repository.Save();
        }
        public void Update(NotificationMethod NotificationMethod)
        {
            _repository.Update(NotificationMethod);
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

        public IEnumerable<NotificationMethod> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region NotificationType
    public class NotificationTypeRepository : INotificationTypeRepository
    {
        private IGenericRepository<NotificationType> _repository = null;
        public NotificationTypeRepository()
        {
            _repository = new GenericRepository<NotificationType>();
        }
        public NotificationTypeRepository(IGenericRepository<NotificationType> repository)
        {
            _repository = repository;
        }

        public IEnumerable<NotificationType> GetAll()
        {
            return _repository.GetAll();
        }
        public NotificationType GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(NotificationType NotificationType)
        {
            _repository.Insert(NotificationType);
            _repository.Save();
        }
        public void Update(NotificationType NotificationType)
        {
            _repository.Update(NotificationType);
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

        public IEnumerable<NotificationType> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region PayeInputFile
    public class PayeInputFileRepository : IPayeInputFileRepository
    {
        private IGenericRepository<PayeInputFile> _repository = null;
        public PayeInputFileRepository()
        {
            _repository = new GenericRepository<PayeInputFile>();
        }
        public PayeInputFileRepository(IGenericRepository<PayeInputFile> repository)
        {
            _repository = repository;
        }

        public IEnumerable<PayeInputFile> GetAll()
        {
            return _repository.GetAll();
        }
        public PayeInputFile GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(PayeInputFile PayeInputFile)
        {
            _repository.Insert(PayeInputFile);
            _repository.Save();
        }
        public void Update(PayeInputFile PayeInputFile)
        {
            _repository.Update(PayeInputFile);
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

        public IEnumerable<PayeInputFile> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region PayeOuputFile
    public class PayeOuputFileRepository : IPayeOuputFileRepository
    {
        private IGenericRepository<PayeOuputFile> _repository = null;
        public PayeOuputFileRepository()
        {
            _repository = new GenericRepository<PayeOuputFile>();
        }
        public PayeOuputFileRepository(IGenericRepository<PayeOuputFile> repository)
        {
            _repository = repository;
        }

        public IEnumerable<PayeOuputFile> GetAll()
        {
            return _repository.GetAll();
        }
        public PayeOuputFile GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(PayeOuputFile PayeOuputFile)
        {
            _repository.Insert(PayeOuputFile);
            _repository.Save();
        }
        public void Update(PayeOuputFile PayeOuputFile)
        {
            _repository.Update(PayeOuputFile);
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

        public IEnumerable<PayeOuputFile> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region PayesubmissionAbhayLive
    public class PayesubmissionAbhayLiveRepository : IPayesubmissionAbhayLiveRepository
    {
        private IGenericRepository<PayesubmissionAbhayLive> _repository = null;
        public PayesubmissionAbhayLiveRepository()
        {
            _repository = new GenericRepository<PayesubmissionAbhayLive>();
        }
        public PayesubmissionAbhayLiveRepository(IGenericRepository<PayesubmissionAbhayLive> repository)
        {
            _repository = repository;
        }

        public IEnumerable<PayesubmissionAbhayLive> GetAll()
        {
            return _repository.GetAll();
        }
        public PayesubmissionAbhayLive GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(PayesubmissionAbhayLive PayesubmissionAbhayLive)
        {
            _repository.Insert(PayesubmissionAbhayLive);
            _repository.Save();
        }
        public void Update(PayesubmissionAbhayLive PayesubmissionAbhayLive)
        {
            _repository.Update(PayesubmissionAbhayLive);
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

        public IEnumerable<PayesubmissionAbhayLive> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region PaymentFrequency
    public class PaymentFrequencyRepository : IPaymentFrequencyRepository
    {
        private IGenericRepository<PaymentFrequency> _repository = null;
        public PaymentFrequencyRepository()
        {
            _repository = new GenericRepository<PaymentFrequency>();
        }
        public PaymentFrequencyRepository(IGenericRepository<PaymentFrequency> repository)
        {
            _repository = repository;
        }

        public IEnumerable<PaymentFrequency> GetAll()
        {
            return _repository.GetAll();
        }
        public PaymentFrequency GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(PaymentFrequency PaymentFrequency)
        {
            _repository.Insert(PaymentFrequency);
            _repository.Save();
        }
        public void Update(PaymentFrequency PaymentFrequency)
        {
            _repository.Update(PaymentFrequency);
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

        public IEnumerable<PaymentFrequency> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region PaymentOption
    public class PaymentOptionRepository : IPaymentOptionRepository
    {
        private IGenericRepository<PaymentOption> _repository = null;
        public PaymentOptionRepository()
        {
            _repository = new GenericRepository<PaymentOption>();
        }
        public PaymentOptionRepository(IGenericRepository<PaymentOption> repository)
        {
            _repository = repository;
        }

        public IEnumerable<PaymentOption> GetAll()
        {
            return _repository.GetAll();
        }
        public PaymentOption GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(PaymentOption PaymentOption)
        {
            _repository.Insert(PaymentOption);
            _repository.Save();
        }
        public void Update(PaymentOption PaymentOption)
        {
            _repository.Update(PaymentOption);
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

        public IEnumerable<PaymentOption> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region PreAsessmentTemp
    public class PreAsessmentTempRepository : IPreAsessmentTempRepository
    {
        private IGenericRepository<PreAsessmentTemp> _repository = null;
        public PreAsessmentTempRepository()
        {
            _repository = new GenericRepository<PreAsessmentTemp>();
        }
        public PreAsessmentTempRepository(IGenericRepository<PreAsessmentTemp> repository)
        {
            _repository = repository;
        }

        public IEnumerable<PreAsessmentTemp> GetAll()
        {
            return _repository.GetAll();
        }
        public PreAsessmentTemp GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(PreAsessmentTemp PreAsessmentTemp)
        {
            _repository.Insert(PreAsessmentTemp);
            _repository.Save();
        }
        public void Update(PreAsessmentTemp PreAsessmentTemp)
        {
            _repository.Update(PreAsessmentTemp);
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

        public IEnumerable<PreAsessmentTemp> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region PreAssessment
    public class PreAssessmentRepository : IPreAssessmentRepository
    {
        private IGenericRepository<PreAssessment> _repository = null;
        public PreAssessmentRepository()
        {
            _repository = new GenericRepository<PreAssessment>();
        }
        public PreAssessmentRepository(IGenericRepository<PreAssessment> repository)
        {
            _repository = repository;
        }

        public IEnumerable<PreAssessment> GetAll()
        {
            return _repository.GetAll();
        }
        public PreAssessment GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(PreAssessment PreAssessment)
        {
            _repository.Insert(PreAssessment);
            _repository.Save();
        }
        public void Update(PreAssessment PreAssessment)
        {
            _repository.Update(PreAssessment);
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

        public IEnumerable<PreAssessment> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region PreAssessment1
    public class PreAssessment1Repository : IPreAssessment1Repository
    {
        private IGenericRepository<PreAssessment1> _repository = null;
        public PreAssessment1Repository()
        {
            _repository = new GenericRepository<PreAssessment1>();
        }
        public PreAssessment1Repository(IGenericRepository<PreAssessment1> repository)
        {
            _repository = repository;
        }

        public IEnumerable<PreAssessment1> GetAll()
        {
            return _repository.GetAll();
        }
        public PreAssessment1 GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(PreAssessment1 PreAssessment1)
        {
            _repository.Insert(PreAssessment1);
            _repository.Save();
        }
        public void Update(PreAssessment1 PreAssessment1)
        {
            _repository.Update(PreAssessment1);
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

        public IEnumerable<PreAssessment1> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region PreAssessmentRdm
    public class PreAssessmentRdmRepository : IPreAssessmentRdmRepository
    {
        private IGenericRepository<PreAssessmentRdm> _repository = null;
        public PreAssessmentRdmRepository()
        {
            _repository = new GenericRepository<PreAssessmentRdm>();
        }
        public PreAssessmentRdmRepository(IGenericRepository<PreAssessmentRdm> repository)
        {
            _repository = repository;
        }

        public IEnumerable<PreAssessmentRdm> GetAll()
        {
            return _repository.GetAll();
        }
        public PreAssessmentRdm GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(PreAssessmentRdm PreAssessmentRdm)
        {
            _repository.Insert(PreAssessmentRdm);
            _repository.Save();
        }
        public void Update(PreAssessmentRdm PreAssessmentRdm)
        {
            _repository.Update(PreAssessmentRdm);
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

        public IEnumerable<PreAssessmentRdm> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region Profile
    public class ProfileRepository : IProfileRepository
    {
        private IGenericRepository<Profile> _repository = null;
        public ProfileRepository()
        {
            _repository = new GenericRepository<Profile>();
        }
        public ProfileRepository(IGenericRepository<Profile> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Profile> GetAll()
        {
            return _repository.GetAll();
        }
        public Profile GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(Profile Profile)
        {
            _repository.Insert(Profile);
            _repository.Save();
        }
        public void Update(Profile Profile)
        {
            _repository.Update(Profile);
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

        public IEnumerable<Profile> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region ProfilesApi
    public class ProfilesApiRepository : IProfilesApiRepository
    {
        private IGenericRepository<ProfilesApi> _repository = null;
        public ProfilesApiRepository()
        {
            _repository = new GenericRepository<ProfilesApi>();
        }
        public ProfilesApiRepository(IGenericRepository<ProfilesApi> repository)
        {
            _repository = repository;
        }

        public IEnumerable<ProfilesApi> GetAll()
        {
            return _repository.GetAll();
        }
        public ProfilesApi GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(ProfilesApi ProfilesApi)
        {
            _repository.Insert(ProfilesApi);
            _repository.Save();
        }
        public void Update(ProfilesApi ProfilesApi)
        {
            _repository.Update(ProfilesApi);
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

        public IEnumerable<ProfilesApi> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region RecordLink
    public class RecordLinkRepository : IRecordLinkRepository
    {
        private IGenericRepository<RecordLink> _repository = null;
        public RecordLinkRepository()
        {
            _repository = new GenericRepository<RecordLink>();
        }
        public RecordLinkRepository(IGenericRepository<RecordLink> repository)
        {
            _repository = repository;
        }

        public IEnumerable<RecordLink> GetAll()
        {
            return _repository.GetAll();
        }
        public RecordLink GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(RecordLink RecordLink)
        {
            _repository.Insert(RecordLink);
            _repository.Save();
        }
        public void Update(RecordLink RecordLink)
        {
            _repository.Update(RecordLink);
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

        public IEnumerable<RecordLink> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region RevenueStream
    public class RevenueStreamRepository : IRevenueStreamRepository
    {
        private IGenericRepository<RevenueStream> _repository = null;
        public RevenueStreamRepository()
        {
            _repository = new GenericRepository<RevenueStream>();
        }
        public RevenueStreamRepository(IGenericRepository<RevenueStream> repository)
        {
            _repository = repository;
        }

        public IEnumerable<RevenueStream> GetAll()
        {
            return _repository.GetAll();
        }
        public RevenueStream GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(RevenueStream RevenueStream)
        {
            _repository.Insert(RevenueStream);
            _repository.Save();
        }
        public void Update(RevenueStream RevenueStream)
        {
            _repository.Update(RevenueStream);
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

        public IEnumerable<RevenueStream> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region RevenueSubStream
    public class RevenueSubStreamRepository : IRevenueSubStreamRepository
    {
        private IGenericRepository<RevenueSubStream> _repository = null;
        public RevenueSubStreamRepository()
        {
            _repository = new GenericRepository<RevenueSubStream>();
        }
        public RevenueSubStreamRepository(IGenericRepository<RevenueSubStream> repository)
        {
            _repository = repository;
        }

        public IEnumerable<RevenueSubStream> GetAll()
        {
            return _repository.GetAll();
        }
        public RevenueSubStream GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(RevenueSubStream RevenueSubStream)
        {
            _repository.Insert(RevenueSubStream);
            _repository.Save();
        }
        public void Update(RevenueSubStream RevenueSubStream)
        {
            _repository.Update(RevenueSubStream);
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

        public IEnumerable<RevenueSubStream> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region RuleEngine
    public class RuleEngineRepository : IRuleEngineRepository
    {
        private IGenericRepository<RuleEngine> _repository = null;
        public RuleEngineRepository()
        {
            _repository = new GenericRepository<RuleEngine>();
        }
        public RuleEngineRepository(IGenericRepository<RuleEngine> repository)
        {
            _repository = repository;
        }

        public IEnumerable<RuleEngine> GetAll()
        {
            return _repository.GetAll();
        }
        public RuleEngine GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(RuleEngine RuleEngine)
        {
            _repository.Insert(RuleEngine);
            _repository.Save();
        }
        public void Update(RuleEngine RuleEngine)
        {
            _repository.Update(RuleEngine);
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

        public IEnumerable<RuleEngine> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region SalaryBreakup
    public class SalaryBreakupRepository : ISalaryBreakupRepository
    {
        private IGenericRepository<SalaryBreakup> _repository = null;
        public SalaryBreakupRepository()
        {
            _repository = new GenericRepository<SalaryBreakup>();
        }
        public SalaryBreakupRepository(IGenericRepository<SalaryBreakup> repository)
        {
            _repository = repository;
        }

        public IEnumerable<SalaryBreakup> GetAll()
        {
            return _repository.GetAll();
        }
        public SalaryBreakup GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(SalaryBreakup SalaryBreakup)
        {
            _repository.Insert(SalaryBreakup);
            _repository.Save();
        }
        public void Update(SalaryBreakup SalaryBreakup)
        {
            _repository.Update(SalaryBreakup);
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

        public IEnumerable<SalaryBreakup> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region SalaryTypeMaster
    public class SalaryTypeMasterRepository : ISalaryTypeMasterRepository
    {
        private IGenericRepository<SalaryTypeMaster> _repository = null;
        public SalaryTypeMasterRepository()
        {
            _repository = new GenericRepository<SalaryTypeMaster>();
        }
        public SalaryTypeMasterRepository(IGenericRepository<SalaryTypeMaster> repository)
        {
            _repository = repository;
        }

        public IEnumerable<SalaryTypeMaster> GetAll()
        {
            return _repository.GetAll();
        }
        public SalaryTypeMaster GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(SalaryTypeMaster SalaryTypeMaster)
        {
            _repository.Insert(SalaryTypeMaster);
            _repository.Save();
        }
        public void Update(SalaryTypeMaster SalaryTypeMaster)
        {
            _repository.Update(SalaryTypeMaster);
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

        public IEnumerable<SalaryTypeMaster> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region Settlement
    public class SettlementRepository : ISettlementRepository
    {
        private IGenericRepository<Settlement> _repository = null;
        public SettlementRepository()
        {
            _repository = new GenericRepository<Settlement>();
        }
        public SettlementRepository(IGenericRepository<Settlement> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Settlement> GetAll()
        {
            return _repository.GetAll();
        }
        public Settlement GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(Settlement Settlement)
        {
            _repository.Insert(Settlement);
            _repository.Save();
        }
        public void Update(Settlement Settlement)
        {
            _repository.Update(Settlement);
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

        public IEnumerable<Settlement> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region SettlementMethod
    public class SettlementMethodRepository : ISettlementMethodRepository
    {
        private IGenericRepository<SettlementMethod> _repository = null;
        public SettlementMethodRepository()
        {
            _repository = new GenericRepository<SettlementMethod>();
        }
        public SettlementMethodRepository(IGenericRepository<SettlementMethod> repository)
        {
            _repository = repository;
        }

        public IEnumerable<SettlementMethod> GetAll()
        {
            return _repository.GetAll();
        }
        public SettlementMethod GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(SettlementMethod SettlementMethod)
        {
            _repository.Insert(SettlementMethod);
            _repository.Save();
        }
        public void Update(SettlementMethod SettlementMethod)
        {
            _repository.Update(SettlementMethod);
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

        public IEnumerable<SettlementMethod> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region SettlementStatus
    public class SettlementStatusRepository : ISettlementStatusRepository
    {
        private IGenericRepository<SettlementStatus> _repository = null;
        public SettlementStatusRepository()
        {
            _repository = new GenericRepository<SettlementStatus>();
        }
        public SettlementStatusRepository(IGenericRepository<SettlementStatus> repository)
        {
            _repository = repository;
        }

        public IEnumerable<SettlementStatus> GetAll()
        {
            return _repository.GetAll();
        }
        public SettlementStatus GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(SettlementStatus SettlementStatus)
        {
            _repository.Insert(SettlementStatus);
            _repository.Save();
        }
        public void Update(SettlementStatus SettlementStatus)
        {
            _repository.Update(SettlementStatus);
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

        public IEnumerable<SettlementStatus> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region StateMaster
    public class StateMasterRepository : IStateMasterRepository
    {
        private IGenericRepository<StateMaster> _repository = null;
        public StateMasterRepository()
        {
            _repository = new GenericRepository<StateMaster>();
        }
        public StateMasterRepository(IGenericRepository<StateMaster> repository)
        {
            _repository = repository;
        }

        public IEnumerable<StateMaster> GetAll()
        {
            return _repository.GetAll();
        }
        public StateMaster GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(StateMaster StateMaster)
        {
            _repository.Insert(StateMaster);
            _repository.Save();
        }
        public void Update(StateMaster StateMaster)
        {
            _repository.Update(StateMaster);
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

        public IEnumerable<StateMaster> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region Submission
    public class SubmissionRepository : ISubmissionRepository
    {
        private IGenericRepository<Submission> _repository = null;
        public SubmissionRepository()
        {
            _repository = new GenericRepository<Submission>();
        }
        public SubmissionRepository(IGenericRepository<Submission> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Submission> GetAll()
        {
            return _repository.GetAll();
        }
        public Submission GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(Submission Submission)
        {
            _repository.Insert(Submission);
            _repository.Save();
        }
        public void Update(Submission Submission)
        {
            _repository.Update(Submission);
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

        public IEnumerable<Submission> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region SubmissionsBkpaa
    public class SubmissionsBkpaaRepository : ISubmissionsBkpaaRepository
    {
        private IGenericRepository<SubmissionsBkpaa> _repository = null;
        public SubmissionsBkpaaRepository()
        {
            _repository = new GenericRepository<SubmissionsBkpaa>();
        }
        public SubmissionsBkpaaRepository(IGenericRepository<SubmissionsBkpaa> repository)
        {
            _repository = repository;
        }

        public IEnumerable<SubmissionsBkpaa> GetAll()
        {
            return _repository.GetAll();
        }
        public SubmissionsBkpaa GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(SubmissionsBkpaa SubmissionsBkpaa)
        {
            _repository.Insert(SubmissionsBkpaa);
            _repository.Save();
        }
        public void Update(SubmissionsBkpaa SubmissionsBkpaa)
        {
            _repository.Update(SubmissionsBkpaa);
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

        public IEnumerable<SubmissionsBkpaa> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region SubmissionsDefault
    public class SubmissionsDefaultRepository : ISubmissionsDefaultRepository
    {
        private IGenericRepository<SubmissionsDefault> _repository = null;
        public SubmissionsDefaultRepository()
        {
            _repository = new GenericRepository<SubmissionsDefault>();
        }
        public SubmissionsDefaultRepository(IGenericRepository<SubmissionsDefault> repository)
        {
            _repository = repository;
        }

        public IEnumerable<SubmissionsDefault> GetAll()
        {
            return _repository.GetAll();
        }
        public SubmissionsDefault GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(SubmissionsDefault SubmissionsDefault)
        {
            _repository.Insert(SubmissionsDefault);
            _repository.Save();
        }
        public void Update(SubmissionsDefault SubmissionsDefault)
        {
            _repository.Update(SubmissionsDefault);
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

        public IEnumerable<SubmissionsDefault> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region TablesApiUpdated
    public class TablesApiUpdatedRepository : ITablesApiUpdatedRepository
    {
        private IGenericRepository<TablesApiUpdated> _repository = null;
        public TablesApiUpdatedRepository()
        {
            _repository = new GenericRepository<TablesApiUpdated>();
        }
        public TablesApiUpdatedRepository(IGenericRepository<TablesApiUpdated> repository)
        {
            _repository = repository;
        }

        public IEnumerable<TablesApiUpdated> GetAll()
        {
            return _repository.GetAll();
        }
        public TablesApiUpdated GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(TablesApiUpdated TablesApiUpdated)
        {
            _repository.Insert(TablesApiUpdated);
            _repository.Save();
        }
        public void Update(TablesApiUpdated TablesApiUpdated)
        {
            _repository.Update(TablesApiUpdated);
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

        public IEnumerable<TablesApiUpdated> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region TaxNewYear
    public class TaxNewYearRepository : ITaxNewYearRepository
    {
        private IGenericRepository<TaxNewYear> _repository = null;
        public TaxNewYearRepository()
        {
            _repository = new GenericRepository<TaxNewYear>();
        }
        public TaxNewYearRepository(IGenericRepository<TaxNewYear> repository)
        {
            _repository = repository;
        }

        public IEnumerable<TaxNewYear> GetAll()
        {
            return _repository.GetAll();
        }
        public TaxNewYear GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(TaxNewYear TaxNewYear)
        {
            _repository.Insert(TaxNewYear);
            _repository.Save();
        }
        public void Update(TaxNewYear TaxNewYear)
        {
            _repository.Update(TaxNewYear);
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

        public IEnumerable<TaxNewYear> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region TaxOffice
    public class TaxOfficeRepository : ITaxOfficeRepository
    {
        private IGenericRepository<TaxOffice> _repository = null;
        public TaxOfficeRepository()
        {
            _repository = new GenericRepository<TaxOffice>();
        }
        public TaxOfficeRepository(IGenericRepository<TaxOffice> repository)
        {
            _repository = repository;
        }

        public IEnumerable<TaxOffice> GetAll()
        {
            return _repository.GetAll();
        }
        public TaxOffice GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(TaxOffice TaxOffice)
        {
            _repository.Insert(TaxOffice);
            _repository.Save();
        }
        public void Update(TaxOffice TaxOffice)
        {
            _repository.Update(TaxOffice);
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

        public IEnumerable<TaxOffice> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region TaxPayerRole
    public class TaxPayerRoleRepository : ITaxPayerRoleRepository
    {
        private IGenericRepository<TaxPayerRole> _repository = null;
        public TaxPayerRoleRepository()
        {
            _repository = new GenericRepository<TaxPayerRole>();
        }
        public TaxPayerRoleRepository(IGenericRepository<TaxPayerRole> repository)
        {
            _repository = repository;
        }

        public IEnumerable<TaxPayerRole> GetAll()
        {
            return _repository.GetAll();
        }
        public TaxPayerRole GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(TaxPayerRole TaxPayerRole)
        {
            _repository.Insert(TaxPayerRole);
            _repository.Save();
        }
        public void Update(TaxPayerRole TaxPayerRole)
        {
            _repository.Update(TaxPayerRole);
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

        public IEnumerable<TaxPayerRole> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region TaxPayerType
    public class TaxPayerTypeRepository : ITaxPayerTypeRepository
    {
        private IGenericRepository<TaxPayerType> _repository = null;
        public TaxPayerTypeRepository()
        {
            _repository = new GenericRepository<TaxPayerType>();
        }
        public TaxPayerTypeRepository(IGenericRepository<TaxPayerType> repository)
        {
            _repository = repository;
        }

        public IEnumerable<TaxPayerType> GetAll()
        {
            return _repository.GetAll();
        }
        public TaxPayerType GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(TaxPayerType TaxPayerType)
        {
            _repository.Insert(TaxPayerType);
            _repository.Save();
        }
        public void Update(TaxPayerType TaxPayerType)
        {
            _repository.Update(TaxPayerType);
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

        public IEnumerable<TaxPayerType> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region Title
    public class TitleRepository : ITitleRepository
    {
        private IGenericRepository<Title> _repository = null;
        public TitleRepository()
        {
            _repository = new GenericRepository<Title>();
        }
        public TitleRepository(IGenericRepository<Title> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Title> GetAll()
        {
            return _repository.GetAll();
        }
        public Title GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(Title Title)
        {
            _repository.Insert(Title);
            _repository.Save();
        }
        public void Update(Title Title)
        {
            _repository.Update(Title);
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

        public IEnumerable<Title> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region TokenManagement
    public class TokenManagementRepository : ITokenManagementRepository
    {
        private IGenericRepository<TokenManagement> _repository = null;
        public TokenManagementRepository()
        {
            _repository = new GenericRepository<TokenManagement>();
        }
        public TokenManagementRepository(IGenericRepository<TokenManagement> repository)
        {
            _repository = repository;
        }

        public IEnumerable<TokenManagement> GetAll()
        {
            return _repository.GetAll();
        }
        public TokenManagement GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(TokenManagement TokenManagement)
        {
            _repository.Insert(TokenManagement);
            _repository.Save();
        }
        public void Update(TokenManagement TokenManagement)
        {
            _repository.Update(TokenManagement);
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

        public IEnumerable<TokenManagement> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region Town
    public class TownRepository : ITownRepository
    {
        private IGenericRepository<Town> _repository = null;
        public TownRepository()
        {
            _repository = new GenericRepository<Town>();
        }
        public TownRepository(IGenericRepository<Town> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Town> GetAll()
        {
            return _repository.GetAll();
        }
        public Town GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(Town Town)
        {
            _repository.Insert(Town);
            _repository.Save();
        }
        public void Update(Town Town)
        {
            _repository.Update(Town);
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

        public IEnumerable<Town> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwAssessIndSal
    public class VwAssessIndSalRepository : IVwAssessIndSalRepository
    {
        private IGenericRepository<VwAssessIndSal> _repository = null;
        public VwAssessIndSalRepository()
        {
            _repository = new GenericRepository<VwAssessIndSal>();
        }
        public VwAssessIndSalRepository(IGenericRepository<VwAssessIndSal> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwAssessIndSal> GetAll()
        {
            return _repository.GetAll();
        }
        public VwAssessIndSal GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwAssessIndSal VwAssessIndSal)
        {
            _repository.Insert(VwAssessIndSal);
            _repository.Save();
        }
        public void Update(VwAssessIndSal VwAssessIndSal)
        {
            _repository.Update(VwAssessIndSal);
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

        public IEnumerable<VwAssessIndSal> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwAssessIndSalRefund
    public class VwAssessIndSalRefundRepository : IVwAssessIndSalRefundRepository
    {
        private IGenericRepository<VwAssessIndSalRefund> _repository = null;
        public VwAssessIndSalRefundRepository()
        {
            _repository = new GenericRepository<VwAssessIndSalRefund>();
        }
        public VwAssessIndSalRefundRepository(IGenericRepository<VwAssessIndSalRefund> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwAssessIndSalRefund> GetAll()
        {
            return _repository.GetAll();
        }
        public VwAssessIndSalRefund GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwAssessIndSalRefund VwAssessIndSalRefund)
        {
            _repository.Insert(VwAssessIndSalRefund);
            _repository.Save();
        }
        public void Update(VwAssessIndSalRefund VwAssessIndSalRefund)
        {
            _repository.Update(VwAssessIndSalRefund);
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

        public IEnumerable<VwAssessIndSalRefund> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwAssessmentRule
    public class VwAssessmentRuleRepository : IVwAssessmentRuleRepository
    {
        private IGenericRepository<VwAssessmentRule> _repository = null;
        public VwAssessmentRuleRepository()
        {
            _repository = new GenericRepository<VwAssessmentRule>();
        }
        public VwAssessmentRuleRepository(IGenericRepository<VwAssessmentRule> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwAssessmentRule> GetAll()
        {
            return _repository.GetAll();
        }
        public VwAssessmentRule GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwAssessmentRule VwAssessmentRule)
        {
            _repository.Insert(VwAssessmentRule);
            _repository.Save();
        }
        public void Update(VwAssessmentRule VwAssessmentRule)
        {
            _repository.Update(VwAssessmentRule);
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

        public IEnumerable<VwAssessmentRule> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwAssessmentSearch
    public class VwAssessmentSearchRepository : IVwAssessmentSearchRepository
    {
        private IGenericRepository<VwAssessmentSearch> _repository = null;
        public VwAssessmentSearchRepository()
        {
            _repository = new GenericRepository<VwAssessmentSearch>();
        }
        public VwAssessmentSearchRepository(IGenericRepository<VwAssessmentSearch> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwAssessmentSearch> GetAll()
        {
            return _repository.GetAll();
        }
        public VwAssessmentSearch GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwAssessmentSearch VwAssessmentSearch)
        {
            _repository.Insert(VwAssessmentSearch);
            _repository.Save();
        }
        public void Update(VwAssessmentSearch VwAssessmentSearch)
        {
            _repository.Update(VwAssessmentSearch);
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

        public IEnumerable<VwAssessmentSearch> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwBusinessCompRelation
    public class VwBusinessCompRelationRepository : IVwBusinessCompRelationRepository
    {
        private IGenericRepository<VwBusinessCompRelation> _repository = null;
        public VwBusinessCompRelationRepository()
        {
            _repository = new GenericRepository<VwBusinessCompRelation>();
        }
        public VwBusinessCompRelationRepository(IGenericRepository<VwBusinessCompRelation> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwBusinessCompRelation> GetAll()
        {
            return _repository.GetAll();
        }
        public VwBusinessCompRelation GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwBusinessCompRelation VwBusinessCompRelation)
        {
            _repository.Insert(VwBusinessCompRelation);
            _repository.Save();
        }
        public void Update(VwBusinessCompRelation VwBusinessCompRelation)
        {
            _repository.Update(VwBusinessCompRelation);
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

        public IEnumerable<VwBusinessCompRelation> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwBusinessDetail
    public class VwBusinessDetailRepository : IVwBusinessDetailRepository
    {
        private IGenericRepository<VwBusinessDetail> _repository = null;
        public VwBusinessDetailRepository()
        {
            _repository = new GenericRepository<VwBusinessDetail>();
        }
        public VwBusinessDetailRepository(IGenericRepository<VwBusinessDetail> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwBusinessDetail> GetAll()
        {
            return _repository.GetAll();
        }
        public VwBusinessDetail GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwBusinessDetail VwBusinessDetail)
        {
            _repository.Insert(VwBusinessDetail);
            _repository.Save();
        }
        public void Update(VwBusinessDetail VwBusinessDetail)
        {
            _repository.Update(VwBusinessDetail);
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

        public IEnumerable<VwBusinessDetail> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwClearanceCertReq
    public class VwClearanceCertReqRepository : IVwClearanceCertReqRepository
    {
        private IGenericRepository<VwClearanceCertReq> _repository = null;
        public VwClearanceCertReqRepository()
        {
            _repository = new GenericRepository<VwClearanceCertReq>();
        }
        public VwClearanceCertReqRepository(IGenericRepository<VwClearanceCertReq> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwClearanceCertReq> GetAll()
        {
            return _repository.GetAll();
        }
        public VwClearanceCertReq GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwClearanceCertReq VwClearanceCertReq)
        {
            _repository.Insert(VwClearanceCertReq);
            _repository.Save();
        }
        public void Update(VwClearanceCertReq VwClearanceCertReq)
        {
            _repository.Update(VwClearanceCertReq);
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

        public IEnumerable<VwClearanceCertReq> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwCompany
    public class VwCompanyRepository : IVwCompanyRepository
    {
        private IGenericRepository<VwCompany> _repository = null;
        public VwCompanyRepository()
        {
            _repository = new GenericRepository<VwCompany>();
        }
        public VwCompanyRepository(IGenericRepository<VwCompany> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwCompany> GetAll()
        {
            return _repository.GetAll();
        }
        public VwCompany GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwCompany VwCompany)
        {
            _repository.Insert(VwCompany);
            _repository.Save();
        }
        public void Update(VwCompany VwCompany)
        {
            _repository.Update(VwCompany);
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

        public IEnumerable<VwCompany> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwCompIndSal
    public class VwCompIndSalRepository : IVwCompIndSalRepository
    {
        private IGenericRepository<VwCompIndSal> _repository = null;
        public VwCompIndSalRepository()
        {
            _repository = new GenericRepository<VwCompIndSal>();
        }
        public VwCompIndSalRepository(IGenericRepository<VwCompIndSal> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwCompIndSal> GetAll()
        {
            return _repository.GetAll();
        }
        public VwCompIndSal GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwCompIndSal VwCompIndSal)
        {
            _repository.Insert(VwCompIndSal);
            _repository.Save();
        }
        public void Update(VwCompIndSal VwCompIndSal)
        {
            _repository.Update(VwCompIndSal);
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

        public IEnumerable<VwCompIndSal> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwCorporatesAsset
    public class VwCorporatesAssetRepository : IVwCorporatesAssetRepository
    {
        private IGenericRepository<VwCorporatesAsset> _repository = null;
        public VwCorporatesAssetRepository()
        {
            _repository = new GenericRepository<VwCorporatesAsset>();
        }
        public VwCorporatesAssetRepository(IGenericRepository<VwCorporatesAsset> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwCorporatesAsset> GetAll()
        {
            return _repository.GetAll();
        }
        public VwCorporatesAsset GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwCorporatesAsset VwCorporatesAsset)
        {
            _repository.Insert(VwCorporatesAsset);
            _repository.Save();
        }
        public void Update(VwCorporatesAsset VwCorporatesAsset)
        {
            _repository.Update(VwCorporatesAsset);
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

        public IEnumerable<VwCorporatesAsset> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwDistinctIndividual
    public class VwDistinctIndividualRepository : IVwDistinctIndividualRepository
    {
        private IGenericRepository<VwDistinctIndividual> _repository = null;
        public VwDistinctIndividualRepository()
        {
            _repository = new GenericRepository<VwDistinctIndividual>();
        }
        public VwDistinctIndividualRepository(IGenericRepository<VwDistinctIndividual> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwDistinctIndividual> GetAll()
        {
            return _repository.GetAll();
        }
        public VwDistinctIndividual GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwDistinctIndividual VwDistinctIndividual)
        {
            _repository.Insert(VwDistinctIndividual);
            _repository.Save();
        }
        public void Update(VwDistinctIndividual VwDistinctIndividual)
        {
            _repository.Update(VwDistinctIndividual);
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

        public IEnumerable<VwDistinctIndividual> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwEmployeeContributionOutputFile
    public class VwEmployeeContributionOutputFileRepository : IVwEmployeeContributionOutputFileRepository
    {
        private IGenericRepository<VwEmployeeContributionOutputFile> _repository = null;
        public VwEmployeeContributionOutputFileRepository()
        {
            _repository = new GenericRepository<VwEmployeeContributionOutputFile>();
        }
        public VwEmployeeContributionOutputFileRepository(IGenericRepository<VwEmployeeContributionOutputFile> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwEmployeeContributionOutputFile> GetAll()
        {
            return _repository.GetAll();
        }
        public VwEmployeeContributionOutputFile GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwEmployeeContributionOutputFile VwEmployeeContributionOutputFile)
        {
            _repository.Insert(VwEmployeeContributionOutputFile);
            _repository.Save();
        }
        public void Update(VwEmployeeContributionOutputFile VwEmployeeContributionOutputFile)
        {
            _repository.Update(VwEmployeeContributionOutputFile);
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

        public IEnumerable<VwEmployeeContributionOutputFile> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwEmployerContribution
    public class VwEmployerContributionRepository : IVwEmployerContributionRepository
    {
        private IGenericRepository<VwEmployerContribution> _repository = null;
        public VwEmployerContributionRepository()
        {
            _repository = new GenericRepository<VwEmployerContribution>();
        }
        public VwEmployerContributionRepository(IGenericRepository<VwEmployerContribution> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwEmployerContribution> GetAll()
        {
            return _repository.GetAll();
        }
        public VwEmployerContribution GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwEmployerContribution VwEmployerContribution)
        {
            _repository.Insert(VwEmployerContribution);
            _repository.Save();
        }
        public void Update(VwEmployerContribution VwEmployerContribution)
        {
            _repository.Update(VwEmployerContribution);
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

        public IEnumerable<VwEmployerContribution> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwEmployerContributionOld
    public class VwEmployerContributionOldRepository : IVwEmployerContributionOldRepository
    {
        private IGenericRepository<VwEmployerContributionOld> _repository = null;
        public VwEmployerContributionOldRepository()
        {
            _repository = new GenericRepository<VwEmployerContributionOld>();
        }
        public VwEmployerContributionOldRepository(IGenericRepository<VwEmployerContributionOld> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwEmployerContributionOld> GetAll()
        {
            return _repository.GetAll();
        }
        public VwEmployerContributionOld GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwEmployerContributionOld VwEmployerContributionOld)
        {
            _repository.Insert(VwEmployerContributionOld);
            _repository.Save();
        }
        public void Update(VwEmployerContributionOld VwEmployerContributionOld)
        {
            _repository.Update(VwEmployerContributionOld);
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

        public IEnumerable<VwEmployerContributionOld> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwGetCollectorOutputFile
    public class VwGetCollectorOutputFileRepository : IVwGetCollectorOutputFileRepository
    {
        private IGenericRepository<VwGetCollectorOutputFile> _repository = null;
        public VwGetCollectorOutputFileRepository()
        {
            _repository = new GenericRepository<VwGetCollectorOutputFile>();
        }
        public VwGetCollectorOutputFileRepository(IGenericRepository<VwGetCollectorOutputFile> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwGetCollectorOutputFile> GetAll()
        {
            return _repository.GetAll();
        }
        public VwGetCollectorOutputFile GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwGetCollectorOutputFile VwGetCollectorOutputFile)
        {
            _repository.Insert(VwGetCollectorOutputFile);
            _repository.Save();
        }
        public void Update(VwGetCollectorOutputFile VwGetCollectorOutputFile)
        {
            _repository.Update(VwGetCollectorOutputFile);
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

        public IEnumerable<VwGetCollectorOutputFile> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwGetDistinctInputFile
    public class VwGetDistinctInputFileRepository : IVwGetDistinctInputFileRepository
    {
        private IGenericRepository<VwGetDistinctInputFile> _repository = null;
        public VwGetDistinctInputFileRepository()
        {
            _repository = new GenericRepository<VwGetDistinctInputFile>();
        }
        public VwGetDistinctInputFileRepository(IGenericRepository<VwGetDistinctInputFile> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwGetDistinctInputFile> GetAll()
        {
            return _repository.GetAll();
        }
        public VwGetDistinctInputFile GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwGetDistinctInputFile VwGetDistinctInputFile)
        {
            _repository.Insert(VwGetDistinctInputFile);
            _repository.Save();
        }
        public void Update(VwGetDistinctInputFile VwGetDistinctInputFile)
        {
            _repository.Update(VwGetDistinctInputFile);
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

        public IEnumerable<VwGetDistinctInputFile> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwGetPreAssessment
    public class VwGetPreAssessmentRepository : IVwGetPreAssessmentRepository
    {
        private IGenericRepository<VwGetPreAssessment> _repository = null;
        public VwGetPreAssessmentRepository()
        {
            _repository = new GenericRepository<VwGetPreAssessment>();
        }
        public VwGetPreAssessmentRepository(IGenericRepository<VwGetPreAssessment> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwGetPreAssessment> GetAll()
        {
            return _repository.GetAll();
        }
        public VwGetPreAssessment GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwGetPreAssessment VwGetPreAssessment)
        {
            _repository.Insert(VwGetPreAssessment);
            _repository.Save();
        }
        public void Update(VwGetPreAssessment VwGetPreAssessment)
        {
            _repository.Update(VwGetPreAssessment);
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

        public IEnumerable<VwGetPreAssessment> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwGetPreAssessment31Jan2020
    public class VwGetPreAssessment31Jan2020Repository : IVwGetPreAssessment31Jan2020Repository
    {
        private IGenericRepository<VwGetPreAssessment31Jan2020> _repository = null;
        public VwGetPreAssessment31Jan2020Repository()
        {
            _repository = new GenericRepository<VwGetPreAssessment31Jan2020>();
        }
        public VwGetPreAssessment31Jan2020Repository(IGenericRepository<VwGetPreAssessment31Jan2020> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwGetPreAssessment31Jan2020> GetAll()
        {
            return _repository.GetAll();
        }
        public VwGetPreAssessment31Jan2020 GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwGetPreAssessment31Jan2020 VwGetPreAssessment31Jan2020)
        {
            _repository.Insert(VwGetPreAssessment31Jan2020);
            _repository.Save();
        }
        public void Update(VwGetPreAssessment31Jan2020 VwGetPreAssessment31Jan2020)
        {
            _repository.Update(VwGetPreAssessment31Jan2020);
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

        public IEnumerable<VwGetPreAssessment31Jan2020> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwIndDetail
    public class VwIndDetailRepository : IVwIndDetailRepository
    {
        private IGenericRepository<VwIndDetail> _repository = null;
        public VwIndDetailRepository()
        {
            _repository = new GenericRepository<VwIndDetail>();
        }
        public VwIndDetailRepository(IGenericRepository<VwIndDetail> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwIndDetail> GetAll()
        {
            return _repository.GetAll();
        }
        public VwIndDetail GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwIndDetail VwIndDetail)
        {
            _repository.Insert(VwIndDetail);
            _repository.Save();
        }
        public void Update(VwIndDetail VwIndDetail)
        {
            _repository.Update(VwIndDetail);
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

        public IEnumerable<VwIndDetail> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwInputFile
    public class VwInputFileRepository : IVwInputFileRepository
    {
        private IGenericRepository<VwInputFile> _repository = null;
        public VwInputFileRepository()
        {
            _repository = new GenericRepository<VwInputFile>();
        }
        public VwInputFileRepository(IGenericRepository<VwInputFile> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwInputFile> GetAll()
        {
            return _repository.GetAll();
        }
        public VwInputFile GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwInputFile VwInputFile)
        {
            _repository.Insert(VwInputFile);
            _repository.Save();
        }
        public void Update(VwInputFile VwInputFile)
        {
            _repository.Update(VwInputFile);
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

        public IEnumerable<VwInputFile> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwInputFileMain
    public class VwInputFileMainRepository : IVwInputFileMainRepository
    {
        private IGenericRepository<VwInputFileMain> _repository = null;
        public VwInputFileMainRepository()
        {
            _repository = new GenericRepository<VwInputFileMain>();
        }
        public VwInputFileMainRepository(IGenericRepository<VwInputFileMain> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwInputFileMain> GetAll()
        {
            return _repository.GetAll();
        }
        public VwInputFileMain GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwInputFileMain VwInputFileMain)
        {
            _repository.Insert(VwInputFileMain);
            _repository.Save();
        }
        public void Update(VwInputFileMain VwInputFileMain)
        {
            _repository.Update(VwInputFileMain);
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

        public IEnumerable<VwInputFileMain> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwInputFileMainView
    public class VwInputFileMainViewRepository : IVwInputFileMainViewRepository
    {
        private IGenericRepository<VwInputFileMainView> _repository = null;
        public VwInputFileMainViewRepository()
        {
            _repository = new GenericRepository<VwInputFileMainView>();
        }
        public VwInputFileMainViewRepository(IGenericRepository<VwInputFileMainView> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwInputFileMainView> GetAll()
        {
            return _repository.GetAll();
        }
        public VwInputFileMainView GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwInputFileMainView VwInputFileMainView)
        {
            _repository.Insert(VwInputFileMainView);
            _repository.Save();
        }
        public void Update(VwInputFileMainView VwInputFileMainView)
        {
            _repository.Update(VwInputFileMainView);
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

        public IEnumerable<VwInputFileMainView> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwInt
    public class VwIntRepository : IVwIntRepository
    {
        private IGenericRepository<VwInt> _repository = null;
        public VwIntRepository()
        {
            _repository = new GenericRepository<VwInt>();
        }
        public VwIntRepository(IGenericRepository<VwInt> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwInt> GetAll()
        {
            return _repository.GetAll();
        }
        public VwInt GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwInt VwInt)
        {
            _repository.Insert(VwInt);
            _repository.Save();
        }
        public void Update(VwInt VwInt)
        {
            _repository.Update(VwInt);
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

        public IEnumerable<VwInt> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwLegacySubmission
    public class VwLegacySubmissionRepository : IVwLegacySubmissionRepository
    {
        private IGenericRepository<VwLegacySubmission> _repository = null;
        public VwLegacySubmissionRepository()
        {
            _repository = new GenericRepository<VwLegacySubmission>();
        }
        public VwLegacySubmissionRepository(IGenericRepository<VwLegacySubmission> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwLegacySubmission> GetAll()
        {
            return _repository.GetAll();
        }
        public VwLegacySubmission GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwLegacySubmission VwLegacySubmission)
        {
            _repository.Insert(VwLegacySubmission);
            _repository.Save();
        }
        public void Update(VwLegacySubmission VwLegacySubmission)
        {
            _repository.Update(VwLegacySubmission);
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

        public IEnumerable<VwLegacySubmission> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwMonthlyTaxCompanyWise
    public class VwMonthlyTaxCompanyWiseRepository : IVwMonthlyTaxCompanyWiseRepository
    {
        private IGenericRepository<VwMonthlyTaxCompanyWise> _repository = null;
        public VwMonthlyTaxCompanyWiseRepository()
        {
            _repository = new GenericRepository<VwMonthlyTaxCompanyWise>();
        }
        public VwMonthlyTaxCompanyWiseRepository(IGenericRepository<VwMonthlyTaxCompanyWise> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwMonthlyTaxCompanyWise> GetAll()
        {
            return _repository.GetAll();
        }
        public VwMonthlyTaxCompanyWise GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwMonthlyTaxCompanyWise VwMonthlyTaxCompanyWise)
        {
            _repository.Insert(VwMonthlyTaxCompanyWise);
            _repository.Save();
        }
        public void Update(VwMonthlyTaxCompanyWise VwMonthlyTaxCompanyWise)
        {
            _repository.Update(VwMonthlyTaxCompanyWise);
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

        public IEnumerable<VwMonthlyTaxCompanyWise> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwMonthlyTaxEmpWise
    public class VwMonthlyTaxEmpWiseRepository : IVwMonthlyTaxEmpWiseRepository
    {
        private IGenericRepository<VwMonthlyTaxEmpWise> _repository = null;
        public VwMonthlyTaxEmpWiseRepository()
        {
            _repository = new GenericRepository<VwMonthlyTaxEmpWise>();
        }
        public VwMonthlyTaxEmpWiseRepository(IGenericRepository<VwMonthlyTaxEmpWise> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwMonthlyTaxEmpWise> GetAll()
        {
            return _repository.GetAll();
        }
        public VwMonthlyTaxEmpWise GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwMonthlyTaxEmpWise VwMonthlyTaxEmpWise)
        {
            _repository.Insert(VwMonthlyTaxEmpWise);
            _repository.Save();
        }
        public void Update(VwMonthlyTaxEmpWise VwMonthlyTaxEmpWise)
        {
            _repository.Update(VwMonthlyTaxEmpWise);
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

        public IEnumerable<VwMonthlyTaxEmpWise> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwPateInputFile
    public class VwPateInputFileRepository : IVwPateInputFileRepository
    {
        private IGenericRepository<VwPateInputFile> _repository = null;
        public VwPateInputFileRepository()
        {
            _repository = new GenericRepository<VwPateInputFile>();
        }
        public VwPateInputFileRepository(IGenericRepository<VwPateInputFile> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwPateInputFile> GetAll()
        {
            return _repository.GetAll();
        }
        public VwPateInputFile GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwPateInputFile VwPateInputFile)
        {
            _repository.Insert(VwPateInputFile);
            _repository.Save();
        }
        public void Update(VwPateInputFile VwPateInputFile)
        {
            _repository.Update(VwPateInputFile);
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

        public IEnumerable<VwPateInputFile> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwPayeInputFile
    public class VwPayeInputFileRepository : IVwPayeInputFileRepository
    {
        private IGenericRepository<VwPayeInputFile> _repository = null;
        public VwPayeInputFileRepository()
        {
            _repository = new GenericRepository<VwPayeInputFile>();
        }
        public VwPayeInputFileRepository(IGenericRepository<VwPayeInputFile> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwPayeInputFile> GetAll()
        {
            return _repository.GetAll();
        }
        public VwPayeInputFile GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwPayeInputFile VwPayeInputFile)
        {
            _repository.Insert(VwPayeInputFile);
            _repository.Save();
        }
        public void Update(VwPayeInputFile VwPayeInputFile)
        {
            _repository.Update(VwPayeInputFile);
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

        public IEnumerable<VwPayeInputFile> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwPayeInputFileN
    public class VwPayeInputFileNRepository : IVwPayeInputFileNRepository
    {
        private IGenericRepository<VwPayeInputFileN> _repository = null;
        public VwPayeInputFileNRepository()
        {
            _repository = new GenericRepository<VwPayeInputFileN>();
        }
        public VwPayeInputFileNRepository(IGenericRepository<VwPayeInputFileN> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwPayeInputFileN> GetAll()
        {
            return _repository.GetAll();
        }
        public VwPayeInputFileN GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwPayeInputFileN VwPayeInputFileN)
        {
            _repository.Insert(VwPayeInputFileN);
            _repository.Save();
        }
        public void Update(VwPayeInputFileN VwPayeInputFileN)
        {
            _repository.Update(VwPayeInputFileN);
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

        public IEnumerable<VwPayeInputFileN> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwPayment
    public class VwPaymentRepository : IVwPaymentRepository
    {
        private IGenericRepository<VwPayment> _repository = null;
        public VwPaymentRepository()
        {
            _repository = new GenericRepository<VwPayment>();
        }
        public VwPaymentRepository(IGenericRepository<VwPayment> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwPayment> GetAll()
        {
            return _repository.GetAll();
        }
        public VwPayment GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwPayment VwPayment)
        {
            _repository.Insert(VwPayment);
            _repository.Save();
        }
        public void Update(VwPayment VwPayment)
        {
            _repository.Update(VwPayment);
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

        public IEnumerable<VwPayment> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwPerformanceReport
    public class VwPerformanceReportRepository : IVwPerformanceReportRepository
    {
        private IGenericRepository<VwPerformanceReport> _repository = null;
        public VwPerformanceReportRepository()
        {
            _repository = new GenericRepository<VwPerformanceReport>();
        }
        public VwPerformanceReportRepository(IGenericRepository<VwPerformanceReport> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwPerformanceReport> GetAll()
        {
            return _repository.GetAll();
        }
        public VwPerformanceReport GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwPerformanceReport VwPerformanceReport)
        {
            _repository.Insert(VwPerformanceReport);
            _repository.Save();
        }
        public void Update(VwPerformanceReport VwPerformanceReport)
        {
            _repository.Update(VwPerformanceReport);
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

        public IEnumerable<VwPerformanceReport> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwPreAssessmentRdm
    public class VwPreAssessmentRdmRepository : IVwPreAssessmentRdmRepository
    {
        private IGenericRepository<VwPreAssessmentRdm> _repository = null;
        public VwPreAssessmentRdmRepository()
        {
            _repository = new GenericRepository<VwPreAssessmentRdm>();
        }
        public VwPreAssessmentRdmRepository(IGenericRepository<VwPreAssessmentRdm> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwPreAssessmentRdm> GetAll()
        {
            return _repository.GetAll();
        }
        public VwPreAssessmentRdm GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwPreAssessmentRdm VwPreAssessmentRdm)
        {
            _repository.Insert(VwPreAssessmentRdm);
            _repository.Save();
        }
        public void Update(VwPreAssessmentRdm VwPreAssessmentRdm)
        {
            _repository.Update(VwPreAssessmentRdm);
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

        public IEnumerable<VwPreAssessmentRdm> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwRefundCase1
    public class VwRefundCase1Repository : IVwRefundCase1Repository
    {
        private IGenericRepository<VwRefundCase1> _repository = null;
        public VwRefundCase1Repository()
        {
            _repository = new GenericRepository<VwRefundCase1>();
        }
        public VwRefundCase1Repository(IGenericRepository<VwRefundCase1> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwRefundCase1> GetAll()
        {
            return _repository.GetAll();
        }
        public VwRefundCase1 GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwRefundCase1 VwRefundCase1)
        {
            _repository.Insert(VwRefundCase1);
            _repository.Save();
        }
        public void Update(VwRefundCase1 VwRefundCase1)
        {
            _repository.Update(VwRefundCase1);
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

        public IEnumerable<VwRefundCase1> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwRulesCheck
    public class VwRulesCheckRepository : IVwRulesCheckRepository
    {
        private IGenericRepository<VwRulesCheck> _repository = null;
        public VwRulesCheckRepository()
        {
            _repository = new GenericRepository<VwRulesCheck>();
        }
        public VwRulesCheckRepository(IGenericRepository<VwRulesCheck> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwRulesCheck> GetAll()
        {
            return _repository.GetAll();
        }
        public VwRulesCheck GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwRulesCheck VwRulesCheck)
        {
            _repository.Insert(VwRulesCheck);
            _repository.Save();
        }
        public void Update(VwRulesCheck VwRulesCheck)
        {
            _repository.Update(VwRulesCheck);
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

        public IEnumerable<VwRulesCheck> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwRulesCheck1
    public class VwRulesCheck1Repository : IVwRulesCheck1Repository
    {
        private IGenericRepository<VwRulesCheck1> _repository = null;
        public VwRulesCheck1Repository()
        {
            _repository = new GenericRepository<VwRulesCheck1>();
        }
        public VwRulesCheck1Repository(IGenericRepository<VwRulesCheck1> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwRulesCheck1> GetAll()
        {
            return _repository.GetAll();
        }
        public VwRulesCheck1 GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwRulesCheck1 VwRulesCheck1)
        {
            _repository.Insert(VwRulesCheck1);
            _repository.Save();
        }
        public void Update(VwRulesCheck1 VwRulesCheck1)
        {
            _repository.Update(VwRulesCheck1);
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

        public IEnumerable<VwRulesCheck1> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwRulesCheck11
    public class VwRulesCheck11Repository : IVwRulesCheck11Repository
    {
        private IGenericRepository<VwRulesCheck11> _repository = null;
        public VwRulesCheck11Repository()
        {
            _repository = new GenericRepository<VwRulesCheck11>();
        }
        public VwRulesCheck11Repository(IGenericRepository<VwRulesCheck11> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwRulesCheck11> GetAll()
        {
            return _repository.GetAll();
        }
        public VwRulesCheck11 GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwRulesCheck11 VwRulesCheck11)
        {
            _repository.Insert(VwRulesCheck11);
            _repository.Save();
        }
        public void Update(VwRulesCheck11 VwRulesCheck11)
        {
            _repository.Update(VwRulesCheck11);
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

        public IEnumerable<VwRulesCheck11> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwRulesCheckOld
    public class VwRulesCheckOldRepository : IVwRulesCheckOldRepository
    {
        private IGenericRepository<VwRulesCheckOld> _repository = null;
        public VwRulesCheckOldRepository()
        {
            _repository = new GenericRepository<VwRulesCheckOld>();
        }
        public VwRulesCheckOldRepository(IGenericRepository<VwRulesCheckOld> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwRulesCheckOld> GetAll()
        {
            return _repository.GetAll();
        }
        public VwRulesCheckOld GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwRulesCheckOld VwRulesCheckOld)
        {
            _repository.Insert(VwRulesCheckOld);
            _repository.Save();
        }
        public void Update(VwRulesCheckOld VwRulesCheckOld)
        {
            _repository.Update(VwRulesCheckOld);
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

        public IEnumerable<VwRulesCheckOld> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwSalBkupIncrementCase
    public class VwSalBkupIncrementCaseRepository : IVwSalBkupIncrementCaseRepository
    {
        private IGenericRepository<VwSalBkupIncrementCase> _repository = null;
        public VwSalBkupIncrementCaseRepository()
        {
            _repository = new GenericRepository<VwSalBkupIncrementCase>();
        }
        public VwSalBkupIncrementCaseRepository(IGenericRepository<VwSalBkupIncrementCase> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwSalBkupIncrementCase> GetAll()
        {
            return _repository.GetAll();
        }
        public VwSalBkupIncrementCase GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwSalBkupIncrementCase VwSalBkupIncrementCase)
        {
            _repository.Insert(VwSalBkupIncrementCase);
            _repository.Save();
        }
        public void Update(VwSalBkupIncrementCase VwSalBkupIncrementCase)
        {
            _repository.Update(VwSalBkupIncrementCase);
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

        public IEnumerable<VwSalBkupIncrementCase> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwSalBkupAfterJoinCase
    public class VwSalBkupAfterJoinCaseRepository : IVwSalBkupAfterJoinCaseRepository
    {
        private IGenericRepository<VwSalBkupAfterJoinCase> _repository = null;
        public VwSalBkupAfterJoinCaseRepository()
        {
            _repository = new GenericRepository<VwSalBkupAfterJoinCase>();
        }
        public VwSalBkupAfterJoinCaseRepository(IGenericRepository<VwSalBkupAfterJoinCase> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwSalBkupAfterJoinCase> GetAll()
        {
            return _repository.GetAll();
        }
        public VwSalBkupAfterJoinCase GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwSalBkupAfterJoinCase VwSalBkupAfterJoinCase)
        {
            _repository.Insert(VwSalBkupAfterJoinCase);
            _repository.Save();
        }
        public void Update(VwSalBkupAfterJoinCase VwSalBkupAfterJoinCase)
        {
            _repository.Update(VwSalBkupAfterJoinCase);
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

        public IEnumerable<VwSalBkupAfterJoinCase> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwSettlement
    public class VwSettlementRepository : IVwSettlementRepository
    {
        private IGenericRepository<VwSettlement> _repository = null;
        public VwSettlementRepository()
        {
            _repository = new GenericRepository<VwSettlement>();
        }
        public VwSettlementRepository(IGenericRepository<VwSettlement> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwSettlement> GetAll()
        {
            return _repository.GetAll();
        }
        public VwSettlement GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwSettlement VwSettlement)
        {
            _repository.Insert(VwSettlement);
            _repository.Save();
        }
        public void Update(VwSettlement VwSettlement)
        {
            _repository.Update(VwSettlement);
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

        public IEnumerable<VwSettlement> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion


    #region VwShowBusinessPayeInputFile
    public class VwShowBusinessPayeInputFileRepository : IVwShowBusinessPayeInputFileRepository
    {
        private IGenericRepository<VwShowBusinessPayeInputFile> _repository = null;
        public VwShowBusinessPayeInputFileRepository()
        {
            _repository = new GenericRepository<VwShowBusinessPayeInputFile>();
        }
        public VwShowBusinessPayeInputFileRepository(IGenericRepository<VwShowBusinessPayeInputFile> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwShowBusinessPayeInputFile> GetAll()
        {
            return _repository.GetAll();
        }
        public VwShowBusinessPayeInputFile GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwShowBusinessPayeInputFile VwShowBusinessPayeInputFile)
        {
            _repository.Insert(VwShowBusinessPayeInputFile);
            _repository.Save();
        }
        public void Update(VwShowBusinessPayeInputFile VwShowBusinessPayeInputFile)
        {
            _repository.Update(VwShowBusinessPayeInputFile);
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

        public IEnumerable<VwShowBusinessPayeInputFile> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwShowBusinessPayeInputFileAll
    public class VwShowBusinessPayeInputFileAllRepository : IVwShowBusinessPayeInputFileAllRepository
    {
        private IGenericRepository<VwShowBusinessPayeInputFileAll> _repository = null;
        public VwShowBusinessPayeInputFileAllRepository()
        {
            _repository = new GenericRepository<VwShowBusinessPayeInputFileAll>();
        }
        public VwShowBusinessPayeInputFileAllRepository(IGenericRepository<VwShowBusinessPayeInputFileAll> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwShowBusinessPayeInputFileAll> GetAll()
        {
            return _repository.GetAll();
        }
        public VwShowBusinessPayeInputFileAll GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwShowBusinessPayeInputFileAll VwShowBusinessPayeInputFileAll)
        {
            _repository.Insert(VwShowBusinessPayeInputFileAll);
            _repository.Save();
        }
        public void Update(VwShowBusinessPayeInputFileAll VwShowBusinessPayeInputFileAll)
        {
            _repository.Update(VwShowBusinessPayeInputFileAll);
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

        public IEnumerable<VwShowBusinessPayeInputFileAll> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwShowBusinessPayeInputFileAll1
    public class VwShowBusinessPayeInputFileAll1Repository : IVwShowBusinessPayeInputFileAll1Repository
    {
        private IGenericRepository<VwShowBusinessPayeInputFileAll1> _repository = null;
        public VwShowBusinessPayeInputFileAll1Repository()
        {
            _repository = new GenericRepository<VwShowBusinessPayeInputFileAll1>();
        }
        public VwShowBusinessPayeInputFileAll1Repository(IGenericRepository<VwShowBusinessPayeInputFileAll1> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwShowBusinessPayeInputFileAll1> GetAll()
        {
            return _repository.GetAll();
        }
        public VwShowBusinessPayeInputFileAll1 GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwShowBusinessPayeInputFileAll1 VwShowBusinessPayeInputFileAll1)
        {
            _repository.Insert(VwShowBusinessPayeInputFileAll1);
            _repository.Save();
        }
        public void Update(VwShowBusinessPayeInputFileAll1 VwShowBusinessPayeInputFileAll1)
        {
            _repository.Update(VwShowBusinessPayeInputFileAll1);
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

        public IEnumerable<VwShowBusinessPayeInputFileAll1> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwShowBusinessPayeInputFileAll2
    public class VwShowBusinessPayeInputFileAll2Repository : IVwShowBusinessPayeInputFileAll2Repository
    {
        private IGenericRepository<VwShowBusinessPayeInputFileAll2> _repository = null;
        public VwShowBusinessPayeInputFileAll2Repository()
        {
            _repository = new GenericRepository<VwShowBusinessPayeInputFileAll2>();
        }
        public VwShowBusinessPayeInputFileAll2Repository(IGenericRepository<VwShowBusinessPayeInputFileAll2> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwShowBusinessPayeInputFileAll2> GetAll()
        {
            return _repository.GetAll();
        }
        public VwShowBusinessPayeInputFileAll2 GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwShowBusinessPayeInputFileAll2 VwShowBusinessPayeInputFileAll2)
        {
            _repository.Insert(VwShowBusinessPayeInputFileAll2);
            _repository.Save();
        }
        public void Update(VwShowBusinessPayeInputFileAll2 VwShowBusinessPayeInputFileAll2)
        {
            _repository.Update(VwShowBusinessPayeInputFileAll2);
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

        public IEnumerable<VwShowBusinessPayeInputFileAll2> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwShowBusinessPayeInputFileAllA
    public class VwShowBusinessPayeInputFileAllARepository : IVwShowBusinessPayeInputFileAllARepository
    {
        private IGenericRepository<VwShowBusinessPayeInputFileAllA> _repository = null;
        public VwShowBusinessPayeInputFileAllARepository()
        {
            _repository = new GenericRepository<VwShowBusinessPayeInputFileAllA>();
        }
        public VwShowBusinessPayeInputFileAllARepository(IGenericRepository<VwShowBusinessPayeInputFileAllA> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwShowBusinessPayeInputFileAllA> GetAll()
        {
            return _repository.GetAll();
        }
        public VwShowBusinessPayeInputFileAllA GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwShowBusinessPayeInputFileAllA VwShowBusinessPayeInputFileAllA)
        {
            _repository.Insert(VwShowBusinessPayeInputFileAllA);
            _repository.Save();
        }
        public void Update(VwShowBusinessPayeInputFileAllA VwShowBusinessPayeInputFileAllA)
        {
            _repository.Update(VwShowBusinessPayeInputFileAllA);
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

        public IEnumerable<VwShowBusinessPayeInputFileAllA> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwShowBusinessPayeInputFileAllSelected
    public class VwShowBusinessPayeInputFileAllSelectedRepository : IVwShowBusinessPayeInputFileAllSelectedRepository
    {
        private IGenericRepository<VwShowBusinessPayeInputFileAllSelected> _repository = null;
        public VwShowBusinessPayeInputFileAllSelectedRepository()
        {
            _repository = new GenericRepository<VwShowBusinessPayeInputFileAllSelected>();
        }
        public VwShowBusinessPayeInputFileAllSelectedRepository(IGenericRepository<VwShowBusinessPayeInputFileAllSelected> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwShowBusinessPayeInputFileAllSelected> GetAll()
        {
            return _repository.GetAll();
        }
        public VwShowBusinessPayeInputFileAllSelected GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwShowBusinessPayeInputFileAllSelected VwShowBusinessPayeInputFileAllSelected)
        {
            _repository.Insert(VwShowBusinessPayeInputFileAllSelected);
            _repository.Save();
        }
        public void Update(VwShowBusinessPayeInputFileAllSelected VwShowBusinessPayeInputFileAllSelected)
        {
            _repository.Update(VwShowBusinessPayeInputFileAllSelected);
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

        public IEnumerable<VwShowBusinessPayeInputFileAllSelected> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwSubmission
    public class VwSubmissionRepository : IVwSubmissionRepository
    {
        private IGenericRepository<VwSubmission> _repository = null;
        public VwSubmissionRepository()
        {
            _repository = new GenericRepository<VwSubmission>();
        }
        public VwSubmissionRepository(IGenericRepository<VwSubmission> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwSubmission> GetAll()
        {
            return _repository.GetAll();
        }
        public VwSubmission GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwSubmission VwSubmission)
        {
            _repository.Insert(VwSubmission);
            _repository.Save();
        }
        public void Update(VwSubmission VwSubmission)
        {
            _repository.Update(VwSubmission);
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

        public IEnumerable<VwSubmission> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwSubmissions1
    public class VwSubmissions1Repository : IVwSubmissions1Repository
    {
        private IGenericRepository<VwSubmissions1> _repository = null;
        public VwSubmissions1Repository()
        {
            _repository = new GenericRepository<VwSubmissions1>();
        }
        public VwSubmissions1Repository(IGenericRepository<VwSubmissions1> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwSubmissions1> GetAll()
        {
            return _repository.GetAll();
        }
        public VwSubmissions1 GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwSubmissions1 VwSubmissions1)
        {
            _repository.Insert(VwSubmissions1);
            _repository.Save();
        }
        public void Update(VwSubmissions1 VwSubmissions1)
        {
            _repository.Update(VwSubmissions1);
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

        public IEnumerable<VwSubmissions1> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwSubmissionView
    public class VwSubmissionViewRepository : IVwSubmissionViewRepository
    {
        private IGenericRepository<VwSubmissionView> _repository = null;
        public VwSubmissionViewRepository()
        {
            _repository = new GenericRepository<VwSubmissionView>();
        }
        public VwSubmissionViewRepository(IGenericRepository<VwSubmissionView> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwSubmissionView> GetAll()
        {
            return _repository.GetAll();
        }
        public VwSubmissionView GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwSubmissionView VwSubmissionView)
        {
            _repository.Insert(VwSubmissionView);
            _repository.Save();
        }
        public void Update(VwSubmissionView VwSubmissionView)
        {
            _repository.Update(VwSubmissionView);
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

        public IEnumerable<VwSubmissionView> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwSubmissionViewOtherMonth
    public class VwSubmissionViewOtherMonthRepository : IVwSubmissionViewOtherMonthRepository
    {
        private IGenericRepository<VwSubmissionViewOtherMonth> _repository = null;
        public VwSubmissionViewOtherMonthRepository()
        {
            _repository = new GenericRepository<VwSubmissionViewOtherMonth>();
        }
        public VwSubmissionViewOtherMonthRepository(IGenericRepository<VwSubmissionViewOtherMonth> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwSubmissionViewOtherMonth> GetAll()
        {
            return _repository.GetAll();
        }
        public VwSubmissionViewOtherMonth GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwSubmissionViewOtherMonth VwSubmissionViewOtherMonth)
        {
            _repository.Insert(VwSubmissionViewOtherMonth);
            _repository.Save();
        }
        public void Update(VwSubmissionViewOtherMonth VwSubmissionViewOtherMonth)
        {
            _repository.Update(VwSubmissionViewOtherMonth);
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

        public IEnumerable<VwSubmissionViewOtherMonth> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwTaxAnalysis
    public class VwTaxAnalysisRepository : IVwTaxAnalysisRepository
    {
        private IGenericRepository<VwTaxAnalysis> _repository = null;
        public VwTaxAnalysisRepository()
        {
            _repository = new GenericRepository<VwTaxAnalysis>();
        }
        public VwTaxAnalysisRepository(IGenericRepository<VwTaxAnalysis> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwTaxAnalysis> GetAll()
        {
            return _repository.GetAll();
        }
        public VwTaxAnalysis GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwTaxAnalysis VwTaxAnalysis)
        {
            _repository.Insert(VwTaxAnalysis);
            _repository.Save();
        }
        public void Update(VwTaxAnalysis VwTaxAnalysis)
        {
            _repository.Update(VwTaxAnalysis);
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

        public IEnumerable<VwTaxAnalysis> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwTaxAnalysis24Oct2019
    public class VwTaxAnalysis24Oct2019Repository : IVwTaxAnalysis24Oct2019Repository
    {
        private IGenericRepository<VwTaxAnalysis24Oct2019> _repository = null;
        public VwTaxAnalysis24Oct2019Repository()
        {
            _repository = new GenericRepository<VwTaxAnalysis24Oct2019>();
        }
        public VwTaxAnalysis24Oct2019Repository(IGenericRepository<VwTaxAnalysis24Oct2019> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwTaxAnalysis24Oct2019> GetAll()
        {
            return _repository.GetAll();
        }
        public VwTaxAnalysis24Oct2019 GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwTaxAnalysis24Oct2019 VwTaxAnalysis24Oct2019)
        {
            _repository.Insert(VwTaxAnalysis24Oct2019);
            _repository.Save();
        }
        public void Update(VwTaxAnalysis24Oct2019 VwTaxAnalysis24Oct2019)
        {
            _repository.Update(VwTaxAnalysis24Oct2019);
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

        public IEnumerable<VwTaxAnalysis24Oct2019> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwTaxbaseComputationFinal
    public class VwTaxbaseComputationFinalRepository : IVwTaxbaseComputationFinalRepository
    {
        private IGenericRepository<VwTaxbaseComputationFinal> _repository = null;
        public VwTaxbaseComputationFinalRepository()
        {
            _repository = new GenericRepository<VwTaxbaseComputationFinal>();
        }
        public VwTaxbaseComputationFinalRepository(IGenericRepository<VwTaxbaseComputationFinal> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwTaxbaseComputationFinal> GetAll()
        {
            return _repository.GetAll();
        }
        public VwTaxbaseComputationFinal GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwTaxbaseComputationFinal VwTaxbaseComputationFinal)
        {
            _repository.Insert(VwTaxbaseComputationFinal);
            _repository.Save();
        }
        public void Update(VwTaxbaseComputationFinal VwTaxbaseComputationFinal)
        {
            _repository.Update(VwTaxbaseComputationFinal);
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

        public IEnumerable<VwTaxbaseComputationFinal> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwTaxComputation
    public class VwTaxComputationRepository : IVwTaxComputationRepository
    {
        private IGenericRepository<VwTaxComputation> _repository = null;
        public VwTaxComputationRepository()
        {
            _repository = new GenericRepository<VwTaxComputation>();
        }
        public VwTaxComputationRepository(IGenericRepository<VwTaxComputation> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwTaxComputation> GetAll()
        {
            return _repository.GetAll();
        }
        public VwTaxComputation GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwTaxComputation VwTaxComputation)
        {
            _repository.Insert(VwTaxComputation);
            _repository.Save();
        }
        public void Update(VwTaxComputation VwTaxComputation)
        {
            _repository.Update(VwTaxComputation);
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

        public IEnumerable<VwTaxComputation> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwTaxComputationEmployerCollection
    public class VwTaxComputationEmployerCollectionRepository : IVwTaxComputationEmployerCollectionRepository
    {
        private IGenericRepository<VwTaxComputationEmployerCollection> _repository = null;
        public VwTaxComputationEmployerCollectionRepository()
        {
            _repository = new GenericRepository<VwTaxComputationEmployerCollection>();
        }
        public VwTaxComputationEmployerCollectionRepository(IGenericRepository<VwTaxComputationEmployerCollection> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwTaxComputationEmployerCollection> GetAll()
        {
            return _repository.GetAll();
        }
        public VwTaxComputationEmployerCollection GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwTaxComputationEmployerCollection VwTaxComputationEmployerCollection)
        {
            _repository.Insert(VwTaxComputationEmployerCollection);
            _repository.Save();
        }
        public void Update(VwTaxComputationEmployerCollection VwTaxComputationEmployerCollection)
        {
            _repository.Update(VwTaxComputationEmployerCollection);
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

        public IEnumerable<VwTaxComputationEmployerCollection> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwTaxComputationFinal
    public class VwTaxComputationFinalRepository : IVwTaxComputationFinalRepository
    {
        private IGenericRepository<VwTaxComputationFinal> _repository = null;
        public VwTaxComputationFinalRepository()
        {
            _repository = new GenericRepository<VwTaxComputationFinal>();
        }
        public VwTaxComputationFinalRepository(IGenericRepository<VwTaxComputationFinal> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwTaxComputationFinal> GetAll()
        {
            return _repository.GetAll();
        }
        public VwTaxComputationFinal GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwTaxComputationFinal VwTaxComputationFinal)
        {
            _repository.Insert(VwTaxComputationFinal);
            _repository.Save();
        }
        public void Update(VwTaxComputationFinal VwTaxComputationFinal)
        {
            _repository.Update(VwTaxComputationFinal);
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

        public IEnumerable<VwTaxComputationFinal> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region VwTestKaushikView
    public class VwTestKaushikViewRepository : IVwTestKaushikViewRepository
    {
        private IGenericRepository<VwTestKaushikView> _repository = null;
        public VwTestKaushikViewRepository()
        {
            _repository = new GenericRepository<VwTestKaushikView>();
        }
        public VwTestKaushikViewRepository(IGenericRepository<VwTestKaushikView> repository)
        {
            _repository = repository;
        }

        public IEnumerable<VwTestKaushikView> GetAll()
        {
            return _repository.GetAll();
        }
        public VwTestKaushikView GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(VwTestKaushikView VwTestKaushikView)
        {
            _repository.Insert(VwTestKaushikView);
            _repository.Save();
        }
        public void Update(VwTestKaushikView VwTestKaushikView)
        {
            _repository.Update(VwTestKaushikView);
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

        public IEnumerable<VwTestKaushikView> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region Ward
    public class WardRepository : IWardRepository
    {
        private IGenericRepository<Ward> _repository = null;
        public WardRepository()
        {
            _repository = new GenericRepository<Ward>();
        }
        public WardRepository(IGenericRepository<Ward> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Ward> GetAll()
        {
            return _repository.GetAll();
        }
        public Ward GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(Ward Ward)
        {
            _repository.Insert(Ward);
            _repository.Save();
        }
        public void Update(Ward Ward)
        {
            _repository.Update(Ward);
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

        public IEnumerable<Ward> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region WinastAutoEmailDetail
    public class WinastAutoEmailDetailRepository : IWinastAutoEmailDetailRepository
    {
        private IGenericRepository<WinastAutoEmailDetail> _repository = null;
        public WinastAutoEmailDetailRepository()
        {
            _repository = new GenericRepository<WinastAutoEmailDetail>();
        }
        public WinastAutoEmailDetailRepository(IGenericRepository<WinastAutoEmailDetail> repository)
        {
            _repository = repository;
        }

        public IEnumerable<WinastAutoEmailDetail> GetAll()
        {
            return _repository.GetAll();
        }
        public WinastAutoEmailDetail GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(WinastAutoEmailDetail WinastAutoEmailDetail)
        {
            _repository.Insert(WinastAutoEmailDetail);
            _repository.Save();
        }
        public void Update(WinastAutoEmailDetail WinastAutoEmailDetail)
        {
            _repository.Update(WinastAutoEmailDetail);
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

        public IEnumerable<WinastAutoEmailDetail> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region WinastAutoSmsDetail
    public class WinastAutoSmsDetailRepository : IWinastAutoSmsDetailRepository
    {
        private IGenericRepository<WinastAutoSmsDetail> _repository = null;
        public WinastAutoSmsDetailRepository()
        {
            _repository = new GenericRepository<WinastAutoSmsDetail>();
        }
        public WinastAutoSmsDetailRepository(IGenericRepository<WinastAutoSmsDetail> repository)
        {
            _repository = repository;
        }

        public IEnumerable<WinastAutoSmsDetail> GetAll()
        {
            return _repository.GetAll();
        }
        public WinastAutoSmsDetail GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(WinastAutoSmsDetail WinastAutoSmsDetail)
        {
            _repository.Insert(WinastAutoSmsDetail);
            _repository.Save();
        }
        public void Update(WinastAutoSmsDetail WinastAutoSmsDetail)
        {
            _repository.Update(WinastAutoSmsDetail);
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

        public IEnumerable<WinastAutoSmsDetail> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region UserManagement
    public class UserManagementRepository : IUserManagementRepository
    {
        private IGenericRepository<UserManagement> _repository = null;
        public UserManagementRepository()
        {
            _repository = new GenericRepository<UserManagement>();
        }
        public UserManagementRepository(IGenericRepository<UserManagement> repository)
        {
            _repository = repository;
        }

        public IEnumerable<UserManagement> GetAll()
        {
            return _repository.GetAll();
        }
        public UserManagement GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(UserManagement UserManagement)
        {
            _repository.Insert(UserManagement);
            _repository.Save();
        }
        public void Update(UserManagement UserManagement)
        {
            _repository.Update(UserManagement);
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

        public IEnumerable<UserManagement> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region Business_Employee
    public class Business_EmployeeRepository : IBusinessEmployeeRepository
    {
        private IGenericRepository<BusinessEmployee> _repository = null;
        public Business_EmployeeRepository()
        {
            _repository = new GenericRepository<BusinessEmployee>();
        }
        public Business_EmployeeRepository(IGenericRepository<BusinessEmployee> repository)
        {
            _repository = repository;
        }

        public IEnumerable<BusinessEmployee> GetAll()
        {
            return _repository.GetAll();
        }
        public BusinessEmployee GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(BusinessEmployee Business_Employee)
        {
            _repository.Insert(Business_Employee);
            _repository.Save();
        }
        public void Update(BusinessEmployee Business_Employee)
        {
            _repository.Update(Business_Employee);
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

        public IEnumerable<BusinessEmployee> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region EmployeesMonthly_Income
    public class EmployeesMonthly_IncomeRepository : IEmployeesMonthlyIncomeRepository
    {
        private IGenericRepository<EmployeesMonthlyIncome> _repository = null;
        public EmployeesMonthly_IncomeRepository()
        {
            _repository = new GenericRepository<EmployeesMonthlyIncome>();
        }
        public EmployeesMonthly_IncomeRepository(IGenericRepository<EmployeesMonthlyIncome> repository)
        {
            _repository = repository;
        }

        public IEnumerable<EmployeesMonthlyIncome> GetAll()
        {
            return _repository.GetAll();
        }
        public EmployeesMonthlyIncome GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(EmployeesMonthlyIncome EmployeesMonthly_Income)
        {
            _repository.Insert(EmployeesMonthly_Income);
            _repository.Save();
        }
        public void Update(EmployeesMonthlyIncome EmployeesMonthly_Income)
        {
            _repository.Update(EmployeesMonthly_Income);
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

        public IEnumerable<EmployeesMonthlyIncome> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region EmployeesMonthlySchedule
    public class EmployeesMonthlyScheduleRepository : IEmployeesMonthlyScheduleRepository
    {
        private IGenericRepository<EmployeesMonthlySchedule> _repository = null;
        public EmployeesMonthlyScheduleRepository()
        {
            _repository = new GenericRepository<EmployeesMonthlySchedule>();
        }
        public EmployeesMonthlyScheduleRepository(IGenericRepository<EmployeesMonthlySchedule> repository)
        {
            _repository = repository;
        }

        public IEnumerable<EmployeesMonthlySchedule> GetAll()
        {
            return _repository.GetAll();
        }
        public EmployeesMonthlySchedule GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(EmployeesMonthlySchedule EmployeesMonthlySchedule)
        {
            _repository.Insert(EmployeesMonthlySchedule);
            _repository.Save();
        }
        public void Update(EmployeesMonthlySchedule EmployeesMonthlySchedule)
        {
            _repository.Update(EmployeesMonthlySchedule);
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

        public IEnumerable<EmployeesMonthlySchedule> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region ScheduleComment
    public class ScheduleCommentRepository : IScheduleCommentRepository
    {
        private IGenericRepository<ScheduleComment> _repository = null;
        public ScheduleCommentRepository()
        {
            _repository = new GenericRepository<ScheduleComment>();
        }
        public ScheduleCommentRepository(IGenericRepository<ScheduleComment> repository)
        {
            _repository = repository;
        }

        public IEnumerable<ScheduleComment> GetAll()
        {
            return _repository.GetAll();
        }
        public ScheduleComment GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(ScheduleComment ScheduleComment)
        {
            _repository.Insert(ScheduleComment);
            _repository.Save();
        }
        public void Update(ScheduleComment ScheduleComment)
        {
            _repository.Update(ScheduleComment);
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

        public IEnumerable<ScheduleComment> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region ScheduleStatus
    public class ScheduleStatusRepository : IScheduleStatusRepository
    {
        private IGenericRepository<ScheduleStatus> _repository = null;
        public ScheduleStatusRepository()
        {
            _repository = new GenericRepository<ScheduleStatus>();
        }
        public ScheduleStatusRepository(IGenericRepository<ScheduleStatus> repository)
        {
            _repository = repository;
        }

        public IEnumerable<ScheduleStatus> GetAll()
        {
            return _repository.GetAll();
        }
        public ScheduleStatus GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Insert(ScheduleStatus ScheduleStatus)
        {
            _repository.Insert(ScheduleStatus);
            _repository.Save();
        }
        public void Update(ScheduleStatus ScheduleStatus)
        {
            _repository.Update(ScheduleStatus);
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

        public IEnumerable<ScheduleStatus> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

}
