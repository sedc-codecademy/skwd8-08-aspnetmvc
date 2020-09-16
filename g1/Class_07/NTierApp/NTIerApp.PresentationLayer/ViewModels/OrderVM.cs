using System;
using System.Collections.Generic;
using System.Text;

namespace NTIerApp.PresentationLayer.ViewModels
{
    public class OrderVM
    {
        public UserVM User { get; set; }
        public List<MovieVM> Movies { get; set; }
    }
}
