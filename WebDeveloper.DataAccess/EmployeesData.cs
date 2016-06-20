using WebDeveloper.Model;
using System.Linq;

namespace WebDeveloper.DataAccess
{
    public class EmployeesData : BaseDataAccess<Employees>
    {
        public Employees GetEmployeeById(int id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.Employees.FirstOrDefault(x => x.Id == id);
            }
        }
    }
}
