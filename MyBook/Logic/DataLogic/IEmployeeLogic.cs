﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.DataLogic
{
    interface IEmployeeLogic
    {
        OperationStatus<Pracownik> GetEmployee(int id);
        OperationStatus<Pracownik> GetAllEmployees();
        OperationStatus<Pracownik> CreateEmployee(string name, string surname, string email, string password);
        OperationStatus<bool> DeleteEmployee(Pracownik employee);
    }
}