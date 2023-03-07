using InterfaceAbstract.Abstract;
using InterfaceAbstract.Adapters;
using InterfaceAbstract.Concrete;
using InterfaceAbstract.Entities;

namespace InterfaceAbstract
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer{DateOfBirth=new DateTime(1993,4,18),FirstName="ismim girin",LastName="soyisim girin",NationalityId="Kimlik no girin"});
            
        }
    }
}