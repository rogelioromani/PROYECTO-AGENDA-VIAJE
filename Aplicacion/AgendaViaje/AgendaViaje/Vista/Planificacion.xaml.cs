using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace AgendaViaje.Vista
{
    public partial class Planificacion : PhoneApplicationPage
    {
        public Planificacion()
        {
            InitializeComponent();
        }
        private void NuevaPlanificacion(object sender, EventArgs e)
        {
            Contexto.IrNuevoPlan.Execute("{Binding IrNuevoPlan}");
        }

    }
}