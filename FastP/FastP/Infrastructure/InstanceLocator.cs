using System;
using System.Collections.Generic;
using System.Text;
using FastP.ViewModels;

namespace FastP.Infrastructure
{
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }
        
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
    }
}
