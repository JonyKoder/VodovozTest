using System.Windows.Input;
using VodovozTest.DAL.Model;
using VodovozTest.UI.ViewModel;
using VodovozTest.UI.ViewModel.Command;

namespace VodovozTest.UI.Wrapper {
    public class EmployeeWrapper : Employee {
        private readonly Employee _employee;
        public event SelectedItemDelegate ItemSelected;

        public EmployeeWrapper(Employee employee) => _employee = employee;

        public Employee GetEmployee {
            get => _employee;
        }

        public ICommand Selected {
            get => new ActionCommand((obj) => {
                ItemSelected?.Invoke(this, obj);
            });
        }
    }
}
