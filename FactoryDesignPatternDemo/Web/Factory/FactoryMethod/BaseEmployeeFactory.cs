using Web.BusinessLogicManager;
using Web.Models;

namespace Web.Factory.FactoryMethod
{
    public abstract class BaseEmployeeFactory
    {
        protected Employee _emp;

        public BaseEmployeeFactory(Employee emp)
        {
            _emp = emp;
        }
        public abstract IEmployeeManager Create();

        public Employee ApplySalary()
        {
            IEmployeeManager manager = Create();
            _emp.Bonus = manager.GetBonus();
            _emp.HourlyPay = manager.GetPay();
            return _emp;
        }
    }
}