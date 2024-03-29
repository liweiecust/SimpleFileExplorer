﻿using System;
using System.Windows;

namespace SimpleFileExplorer.Commands
{
    public class RelayCommand : RelayCommandBase
    {
        private readonly Action _execute;
        private readonly Func<bool> _canExecute;

        public RelayCommand(Action execute, Func<bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        protected override bool CanExecute(object parameter)
        {
            //return CanExecute();
            return true;
        }
        protected override void Execute(object parameter)
        {
            //Execute();
        }

        //public bool CanExecute()
        //{
        //    return _canExecute?.Invoke() ?? true;
        //}
        //public void Execute()
        //{
        //    _execute?.Invoke();
        //}
    }
}
