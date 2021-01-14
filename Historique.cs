using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice2
{
    public class Historique : BaseNotifyPropertyChanged
    {

        public string CalculHisto
        {
            get { return (string)GetField(); }
            set { SetField(value); }
        }
        public string ResultatHisto
        {
            get { return (string)GetField(); }
            set { SetField(value); }
        }
    }
}
