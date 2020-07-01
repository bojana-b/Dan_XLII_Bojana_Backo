using Dan_XLII_Bojana_Backo.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Dan_XLII_Bojana_Backo.ViewModel
{
    class MainWindowViewModel : ViewModelBase
    {
        MainWindow main;

        Service service = new Service();

        public MainWindowViewModel(MainWindow mainOpen)
        {
            main = mainOpen;
            EmployeeList = service.GetAllEmployees();
        }

        #region Properties
        private tblEmployee employee;
        public tblEmployee Employee
        {
            get
            {
                return employee;
            }
            set
            {
                employee = value;
                OnPropertyChanged("Employee");
            }
        }

        private List<tblEmployee> employeeList;
        public List<tblEmployee> EmployeeList
        {
            get
            {
                return employeeList;
            }
            set
            {
                employeeList = value;
                OnPropertyChanged("EmployeeList");
            }
        }
        #endregion

        #region Commands
        private ICommand addNewEmployee;
        public ICommand AddNewEmployee
        {
            get
            {
                if(addNewEmployee == null)
                {
                    //addNewEmployee = new RelayCommand(param => A)
                }
                return addNewEmployee;
            }
        }

        private void AddNewEmployeeExecute()
        {
            // dodati ovde svasta
        }
        #endregion
    }
}
