using System.Collections.ObjectModel;
using System.Linq;
using VodovozTest.DAL.Model;
using VodovozTest.UI.Manager;
using VodovozTest.UI.ViewModel.Abstract;

namespace VodovozTest.UI.ViewModel {
    public class NavigationViewModel: BindableObject {
        public ObservableCollection<NavigationModel> Navigations { get; set; }
        private NavigationModel m_SelectedModel;

        public NavigationModel SelectedItem {
            get => m_SelectedModel;
            set {
                m_SelectedModel = value;
                NavigationService.GetInstance.RaiseNavigationEven(this, value);
            }
        }

        public NavigationViewModel() {
            Navigations = new (NavigationService.GetInstance.NavigationNameToUserControl.Keys.ToList());
            NavigationService.GetInstance.ValuesChangedNotification += GetInstance_ValuesChangedNotification;
        }

        private void GetInstance_ValuesChangedNotification(object _sender) {
            Navigations = new (NavigationService.GetInstance.NavigationNameToUserControl.Keys.ToList());
            OnPropertyChanged(nameof(Navigations));
        }
    }
}
