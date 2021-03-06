﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace HEC.Models
{
    public class ToolbarAction : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public String Source { set; get; }
        public String Title { set; get; }

        public ToolbarAction(Buttons button, String title)
        {
            this.Title = title;
            this.Source = Icon.IconForButton(button);
        }

        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

    }
}