using System.Windows.Input;
using VodovozTest.DAL.Model;
using VodovozTest.UI.ViewModel;
using VodovozTest.UI.ViewModel.Command;

namespace VodovozTest.UI.Wrapper {
    public class OrdersWrapper : Orders {
        private readonly Orders _orders;
        public event SelectedItemDelegate ItemSelected;

        public OrdersWrapper(Orders orders) => _orders = orders;

        public Orders GetOrders {
            get => _orders;
        }

        public ICommand Selected {
            get => new ActionCommand((obj) => {
                ItemSelected?.Invoke(this, obj);
            });
        }
    }
}
