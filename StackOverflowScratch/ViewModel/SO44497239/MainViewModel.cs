using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Prism.Commands;
using Prism.Mvvm;

namespace StackOverflowScratch.ViewModel.SO44497239
{
    public class MainViewModel : BindableBase
    {
        private int _tabSuffix;
        public ObservableCollection<TextViewModel> TextTabs { get; set; } = new ObservableCollection<TextViewModel>();

        public DelegateCommand AddNewTabCommand { get; set; }

        public MainViewModel()
        {
            AddNewTabCommand = new DelegateCommand(OnAddNewTabCommand);
        }

        private void OnAddNewTabCommand()
        {
            TextTabs.Add(new TextViewModel()
            {
                Header = $"Tab #{_tabSuffix++}"
            });
        }
    }
}
