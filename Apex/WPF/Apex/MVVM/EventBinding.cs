﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Reflection;

namespace Apex.MVVM
{
    public class EventBinding : DependencyObject
    {        
        private static readonly DependencyProperty EventNameProperty =
          DependencyProperty.Register("EventName", typeof(string), typeof(EventBinding),
          new PropertyMetadata(null));

        public string EventName
        {
            get { return (string)GetValue(EventNameProperty); }
            set { SetValue(EventNameProperty, value); }
        }

        private static readonly DependencyProperty CommandProperty =
          DependencyProperty.Register("Command", typeof(ICommand), typeof(EventBinding),
          new PropertyMetadata(null));

        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }
        
        private static readonly DependencyProperty CommandParameterProperty =
          DependencyProperty.Register("CommandParameter", typeof(object), typeof(EventBinding),
          new PropertyMetadata(null));

        public object CommandParameter
        {
            get { return (object)GetValue(CommandParameterProperty); }
            set { SetValue(CommandParameterProperty, value); }
        }

        public void Bind(object o)
        {
            //  Get the event info from the event name.
            EventInfo eventInfo = o.GetType().GetEvent(EventName);

            //  Create a delegate for the event to the event proxy.
            Delegate del = Delegate.CreateDelegate(eventInfo.EventHandlerType, this, this.GetType().GetMethod("EventProxy"));

            //  Add the event handler.
            eventInfo.AddEventHandler(o, del);
        }

        private void EventProxy(object o, EventArgs e)
        {
            if (Command != null)
                Command.Execute(CommandParameter);
        }
    }
}
