﻿using Web.BusinessLogicManager;

namespace Web.Factory
{
    public class EmployeeManagerFactory
    {
        public IEmployeeManager GetEmployeeManager(int employeeTypeId)
        {
            IEmployeeManager returnValue = null;

            if(employeeTypeId ==1)
                returnValue = new PermanentEmployeeManager();
            else if(employeeTypeId ==2)
                returnValue = new ContractEmployeeManager();

            return returnValue;
        }
    }
}