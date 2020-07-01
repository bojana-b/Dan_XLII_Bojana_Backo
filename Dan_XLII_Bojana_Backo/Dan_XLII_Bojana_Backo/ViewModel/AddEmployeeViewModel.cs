using Dan_XLII_Bojana_Backo.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dan_XLII_Bojana_Backo.ViewModel
{
    class AddEmployeeViewModel : ViewModelBase
    {
        AddEmployee addEmployee;
        Service service = new Service();

        public AddEmployeeViewModel(AddEmployee addEmployeeOpen)
        {
            addEmployee = addEmployeeOpen;
            
        }

        //#region Properties
        //private 
    }
}
