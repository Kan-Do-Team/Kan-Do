using Kan_Do.WPF.Commands;
using Kan_Do.WPF.Models;
using Kan_Do.WPF.ViewModels;
using Kan_Do.WPF.ViewModels.Factories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Kan_Do.WPF.State.Navigators
{
    public class Navigator : ObservableObject, INavigator
    {
        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel 
        {
            get
            {
                return _currentViewModel;
            }
            set
            {
                _currentViewModel = value;
                OnPropertyChanged(nameof(CurrentViewModel));
            }
        }

        private ViewModelBase _currentHomeViewModel;
        public ViewModelBase CurrentHomeViewModel
        {
            get
            {
                return _currentHomeViewModel;
            }
            set
            {
                _currentHomeViewModel = value;
                OnPropertyChanged(nameof(CurrentHomeViewModel));
            }
        }

        private ViewModelBase _currentBoardViewModel;
        public ViewModelBase CurrentBoardViewModel
        {
            get
            {
                return _currentBoardViewModel;
            }
            set
            {
                _currentBoardViewModel = value;
                OnPropertyChanged(nameof(CurrentBoardViewModel));
            }
        }



    }
}
