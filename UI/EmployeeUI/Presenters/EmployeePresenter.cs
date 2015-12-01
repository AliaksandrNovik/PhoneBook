using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.AppController;
using UI.Basics;
using Services.Facade;

namespace UI.EmployeeUI
{
    class EmployeePresenter : BasePresener<IEmployeeView, Services.Facade.EntityId>
    {
        private readonly IReadOnlyDepartmentService _departmentService;
        private readonly IReadOnlyEmployeeService _employeeService;
        private readonly IReadOnlyPhoneService _phoneService;

        public EmployeePresenter(IApplicationController controller, IEmployeeView view, 
            IReadOnlyDepartmentService departmentService,
            IReadOnlyEmployeeService employeeService,
            IReadOnlyPhoneService phoneService
            ):
            base(controller, view)
        {
            _departmentService = departmentService;
            _employeeService = employeeService;
            _phoneService = phoneService;

            View.OwnStatisticCalled += () => OwnStatisticCalled();

            //just repeat request for a while
            _departmentService.DepartmentCreated += (arg) => { RefillView(); };
            _departmentService.DepartmentUpdated += (arg) => { RefillView(); };
            _departmentService.DepartmentDeleted += (arg) => { RefillView(); };

            _employeeService.EmployeeCreated += (arg) => { RefillView(); };
            _employeeService.EmployeeUpdated += (arg) => { RefillView(); };
            _employeeService.EmployeeDeleted+= (arg) => { RefillView(); };

            _phoneService.PhoneCreated+= (arg) => { RefillView(); };
            _phoneService.PhoneUpdated += (arg) => { RefillView(); };
            _phoneService.PhoneDeleted += (arg) => { RefillView(); };
        }

        //events
        //
        private void OwnStatisticCalled()
        {
            if (_employee == null)
            {
                View.ShowError("Вам не сопоставлен сотрудник. Обратитесь к администратору.");
            }
            else
            {
                //call other presenter
            }
        }      

        private Services.Facade.Employee _employee;
        private UI.Basics.Department _department;
        public override void Run(Services.Facade.EntityId userId)
        {
            if (userId != null)
            {
                _employee = _employeeService.GetByUserId(userId);
            }
            RefillView();
            View.Show();
        }

        private void RefillView()
        {
            _department = DepartmentCreator.CreateRootDepartment(_departmentService, _employeeService, _phoneService);
            View.CompanyStructure = _department;
        }
    }
}
