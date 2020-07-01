using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dan_XLII_Bojana_Backo
{
    public class Service
    {
        // Method that reads all employees from database
        public List<tblEmployee> GetAllEmployees()
        {
            try
            {
                using(EmployeeEntities context = new EmployeeEntities())
                {
                    List<tblEmployee> list = new List<tblEmployee>();
                    list = (from x in context.tblEmployees select x).ToList();
                    return list;
                }
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }

        // Method that adds employee to database
        public tblEmployee AddEmployee(tblEmployee employee)
        {
            try
            {
                using(EmployeeEntities context = new EmployeeEntities())
                {
                    tblEmployee newEmployee = new tblEmployee();
                    newEmployee.NameSurname = employee.NameSurname;
                    newEmployee.DateOfBirth = employee.DateOfBirth;
                    newEmployee.CardID = employee.CardID;
                    newEmployee.JMBG = employee.JMBG;
                    newEmployee.Gender = employee.Gender;
                    newEmployee.Phone = employee.Phone;
                    newEmployee.Sector = employee.Sector;
                    newEmployee.Location = employee.Location;
                    newEmployee.Manager = employee.Manager;

                    context.tblEmployees.Add(newEmployee);
                    context.SaveChanges();

                    return employee;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }

        // Method that deletes employee from database based on forwared idCard
        public void DeleteEmployee(int idCard)
        {
            try
            {
                using(EmployeeEntities context = new EmployeeEntities())
                {
                    tblEmployee employeeToDelete = (from p in context.tblEmployees where p.CardID == idCard select p).First();
                    context.tblEmployees.Remove(employeeToDelete);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception" + ex.Message.ToString());
            }
        }
    }
}
