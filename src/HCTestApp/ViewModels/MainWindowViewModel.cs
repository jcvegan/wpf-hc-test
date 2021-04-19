using HCTestApp.Models;
using HCTestApp.Services;
using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;

namespace HCTestApp.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IPersonDataService _dataService;

        private ObservableCollection<PersonModel> _people;

        public ObservableCollection<PersonModel> People
        {
            get => _people;
            set => SetProperty(ref _people, value);
        }

        public MainWindowViewModel(IPersonDataService dataService)
        {
            _dataService = dataService;

            InitializeViewModel();
        }

        private void InitializeViewModel()
        {
            People = new ObservableCollection<PersonModel>(_dataService.GetPeople());
        }
    }
}
