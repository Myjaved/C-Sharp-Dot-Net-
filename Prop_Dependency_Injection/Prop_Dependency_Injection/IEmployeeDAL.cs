using System.Collections.Generic;

namespace Prop_Dependency_Injection
{
    internal interface IEmployeeDAL
    {
        List<Employee> SelectAllEmployees();
    }
}