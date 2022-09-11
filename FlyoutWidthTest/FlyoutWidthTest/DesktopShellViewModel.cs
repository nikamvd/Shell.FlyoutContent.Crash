using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FlyoutWidthTest
{
    public class DesktopShellViewModel : ExtendedBindableObject
    {
        public ICommand SelectedHourCommand => new Command<string>(async (string selectedHour) => await NavigateToView(selectedHour));
        private async Task NavigateToView(string selectedHour)
        {
            
        }

        private string _selectedHour;
        public string SelectedHour
        {
            get => _selectedHour;
            set { SetProperty(ref _selectedHour, value); }
        }
    }
}
