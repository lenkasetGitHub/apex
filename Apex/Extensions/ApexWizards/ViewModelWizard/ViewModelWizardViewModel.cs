﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Apex.MVVM;

namespace ApexWizards.ViewModelWizard
{
    /// <summary>
    /// The View Model Wizard View Model.
    /// </summary>
    public class ViewModelWizardViewModel : ViewModel
    {
        public ViewModelWizardViewModel()
        {
            OKCommand = new Command(DoOKCommand);
            CancelCommand = new Command(DoCancelCommand);
        }

        /// <summary>
        /// Does the OK command.
        /// </summary>
        private void DoOKCommand()
        {
        }

        /// <summary>
        /// Does the cancel command.
        /// </summary>
        private void DoCancelCommand()
        {
        }

        
        private NotifyingProperty ViewModelNameProperty =
          new NotifyingProperty("ViewModelName", typeof(string), default(string));

        public string ViewModelName
        {
            get { return (string)GetValue(ViewModelNameProperty); }
            set { SetValue(ViewModelNameProperty, value); }
        }
                
        
        private NotifyingProperty CreateExampleNotifyingPropertyProperty =
          new NotifyingProperty("CreateExampleNotifyingProperty", typeof(bool), default(bool));

        public bool CreateExampleNotifyingProperty
        {
            get { return (bool)GetValue(CreateExampleNotifyingPropertyProperty); }
            set { SetValue(CreateExampleNotifyingPropertyProperty, value); }
        }

        
        private NotifyingProperty CreateExampleObservableCollectionProperty =
          new NotifyingProperty("CreateExampleObservableCollection", typeof(bool), default(bool));

        public bool CreateExampleObservableCollection
        {
            get { return (bool)GetValue(CreateExampleObservableCollectionProperty); }
            set { SetValue(CreateExampleObservableCollectionProperty, value); }
        }

        
        private NotifyingProperty CreateExampleCommandProperty =
          new NotifyingProperty("CreateExampleCommand", typeof(bool), default(bool));

        public bool CreateExampleCommand
        {
            get { return (bool)GetValue(CreateExampleCommandProperty); }
            set { SetValue(CreateExampleCommandProperty, value); }
        }

        /// <summary>
        /// Gets the OK command.
        /// </summary>
        public Command OKCommand { get; private set; }

        /// <summary>
        /// Gets the cancel command.
        /// </summary>
        public Command CancelCommand { get; private set; }
                
    }
}
