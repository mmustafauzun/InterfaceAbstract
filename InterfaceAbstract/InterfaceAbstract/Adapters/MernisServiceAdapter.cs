using InterfaceAbstract.Abstract;
using InterfaceAbstract.Entities;
using MernisServiceReference;

namespace InterfaceAbstract.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(),customer.LastName.ToUpper(), customer.DateOfBirth.Year);
        }
    }
}
