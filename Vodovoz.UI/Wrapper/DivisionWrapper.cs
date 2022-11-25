using System.Windows.Input;
using VodovozTest.DAL.Model;
using VodovozTest.UI.ViewModel;
using VodovozTest.UI.ViewModel.Command;

namespace VodovozTest.UI.Wrapper {
    public class DivisionWrapper : Division {
        private readonly Division _division;
        public event SelectedItemDelegate ItemSelected;

        public DivisionWrapper(Division division) => _division = division;

        public Division GetDivision {
            get => _division;
        }
        public ICommand Selected {
            get => new ActionCommand((obj) => {
                ItemSelected?.Invoke(this, obj);
            });
        }
    }
}
