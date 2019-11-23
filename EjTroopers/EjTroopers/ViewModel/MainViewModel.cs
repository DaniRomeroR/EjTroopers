using EjTroopers.Model;
using EjTroopers.Services;
using EjTroopers.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace EjTroopers.ViewModel
{
    class MainViewModel : BaseViewModel
    {
        private RelayCommand<String> _searchCommand;
        public ICommand SearchCommand => _searchCommand;

        public MainViewModel()
        {
            _searchCommand = new RelayCommand<String>(searchTroopers);
            loadTroopers();
        }

        private List<Trooper> _ltrooper = new List<Trooper>();

        public List<Trooper> ListTrooper
        {
            get => _ltrooper;
            set
            {
                _ltrooper = value;
                RaiseProperty();
            }
        }

        private String name;

        public String nameTrooper
        {
            get => name;
            set
            {
                name = value;
                RaiseProperty();
            }
        }

        public void loadTroopers() {
            ListTrooper = JsonService.lectura();
        }
        public void searchTroopers(String name)
        {
            _ltrooper=SearchService.searchTroopers(ListTrooper,nameTrooper);
        }
    }
}
