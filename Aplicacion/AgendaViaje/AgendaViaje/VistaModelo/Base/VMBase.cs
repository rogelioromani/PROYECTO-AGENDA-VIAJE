using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaViaje.VistaModelo.Base
{

    class Base : INotifyPropertyChanged
    {

        public Base()
        {

        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        public void NotificarCambio(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                            new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}