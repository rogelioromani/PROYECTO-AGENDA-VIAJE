using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Data.Linq.Mapping;
using System.Data.Linq;
using System.ComponentModel;
using AgendaViaje.VistaModelo.Base;

namespace AgendaViaje.Tablas
{
    [Table (Name = "Dias")]
    public class Dia: INotifyPropertyChanging
    {
    }
}
