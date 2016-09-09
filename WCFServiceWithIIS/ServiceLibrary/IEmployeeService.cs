using System.ServiceModel;

namespace ServiceLibrary
{
    [ServiceContract]
    public interface IEmployeeService
    {

        [OperationContract]
        Employee GetEmployee(string id);

        [OperationContract]
        void SaveEmployee(Employee employee);
    }
}
