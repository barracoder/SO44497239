using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Media;
using Prism.Mvvm;

namespace StackOverflowScratch.ViewModel.SO44497239
{
    public class TextViewModel : BindableBase
    {
        public string Header { get; set; }
        public Brush BackgroundBrush { get; set; }
        public Brush ForegroundBrush { get; set; }

        public string Document { get; set; }
    }
}
