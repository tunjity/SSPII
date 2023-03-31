using SSP.Infrastructure;
using SSP.PayeModel;

namespace SSP.Repository
{
    public class CompanyListApiRepository
    {// private readonly EmployeeDbEntities _context;
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
        //public EmployeeRepository(EmployeeDbEntities context)
        //{
        //    _context = context;
        //}
        public IEnumerable<CompanyListApi> GetAll()
        {
            //return _context.Employees.ToList();
            return _repository.GetAll();
        }
        public CompanyListApi GetById(int EmployeeID)
        {
            //return _context.Employees.Find(EmployeeID);
            return _repository.GetById(EmployeeID);
        }
        public void Insert(CompanyListApi employee)
        {
            //employee.CreateDate = DateTime.Now;
            //_context.Employees.Add(employee);
            _repository.Insert(employee);
            _repository.Save();
        }
        public void Update(CompanyListApi employee)
        {
            //employee.ModifiedDate = DateTime.Now;
            //_context.Entry(employee).State = EntityState.Modified;
            _repository.Update(employee);
            _repository.Save();
        }
        public void Delete(int id)
        {
            //Employee employee = _context.Employees.Find(EmployeeID);
            //_context.Employees.Remove(employee);
            _repository.Delete(id);
            _repository.Save();
        }
       
    }
}
