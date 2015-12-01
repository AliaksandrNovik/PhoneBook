using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Facade;
using UI.AppController;
using UI.Basics;

namespace UI.ManagerUI
{
    public class ManagerPresenter : BasePresener<IManagerPassiveView, Services.Facade.EntityId>
    {
        private DepartmentEditForm _departmentEditView = new DepartmentEditForm();
        private EmployeeEditForm _employeeEditView = new EmployeeEditForm();
        private PhoneEditForm _phoneEditView = new PhoneEditForm();

        public ManagerPresenter(IApplicationController controller, IManagerPassiveView view) : base(controller, view)
        {
            View.DepartmentCreateCalled += (args) => DepartmentCreateCalled(args);
            View.DepartmentUpdateCalled += (args) => DepartmentUpdateCalled(args);
            View.DepartmentDeleteCalled += (args) => DepartmentDeleteCalled(args);

            View.EmployeeCreateCalled += (args) => EmployeeCreateCalled(args);
            View.EmployeeUpdateCalled += (args) => EmployeeUpdateCalled(args);
            View.EmployeeDeleteCalled += (args) => EmployeeDeleteCalled(args);

            View.PhoneCreateCalled += (args) => PhoneCreateCalled(args);
            View.PhoneUpdateCalled += (args) => PhoneUpdateCalled(args);
            View.PhoneDeleteCalled += (args) => PhoneDeleteCalled(args);
        }

        private void DepartmentCreateCalled(DepartmentCreateArgs args)
        {
            _departmentEditView.ShowDialog();
        }

        private void DepartmentUpdateCalled(DepartmentUpdateArgs args)
        {

        }

        private void DepartmentDeleteCalled(DepartmentUpdateArgs args)
        {

        }


        private void EmployeeCreateCalled(EmployeeCreateArgs args)
        {

        }

        private void EmployeeUpdateCalled(EmployeeUpdateArgs args)
        {

        }

        private void EmployeeDeleteCalled(EmployeeUpdateArgs args)
        {

        }

        private void PhoneCreateCalled(PhoneCreateArgs args)
        {

        }

        private void PhoneUpdateCalled(PhoneUpdateArgs args)
        {

        }

        private void PhoneDeleteCalled(PhoneUpdateArgs args)
        {

        }

        public override void Run(EntityId argument)
        {
            View.Show();
        }
    }
}
