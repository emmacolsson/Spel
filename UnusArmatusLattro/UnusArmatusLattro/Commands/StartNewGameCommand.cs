using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using UnusArmatusLattro.ViewModels;

namespace UnusArmatusLattro.Commands
{
    public class StartNewGameCommand : ICommand
    {
        private readonly SpinGameViewModel spinGameViewModel;

        public StartNewGameCommand(SpinGameViewModel spinGameViewModel)
        {
            this.spinGameViewModel = spinGameViewModel;
        }

        public event EventHandler CanExecuteChanged { add { } remove { } }

        public bool CanExecute(object parameter) => true;
        

        public void Execute(object parameter)
        {
            spinGameViewModel.StartGame((Data.Difficulties)parameter);
        }
    }
}
