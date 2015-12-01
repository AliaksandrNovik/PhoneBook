using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.AppController;
using UI.Basics;

namespace UI.EmployeeUI.Presenters
{
    class EmployeePresenterArgs
    {
        public EmployeePresenterArgs(Department department, Employee employee)
        {
            this.Department = department;
            this.Employee = employee;
        }

        public Department Department
        { get; private set; }

        public Employee Employee
        { get; private set; }

    }
    class EmployeePresenter : BasePresener<IEmployeeView, EmployeePresenterArgs>
    {
        public EmployeePresenter(IApplicationController controller, IEmployeeView view):
            base(controller, view)
        {
            View.OwnStatisticCalled += () => OwnStatisticCalled();
        }

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

        private Employee _employee;
        private Department _department;
        public override void Run(EmployeePresenterArgs argument)
        {
            //[1]
            _employee = argument.Employee;
            _department = argument.Department;

            //[2]
            View.Show();
        }
    }
}
