using AgendaViaje.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AgendaViaje.VistaModelo.Base
{
    public class VMMainPage
    {
        private ICommand irPlanificacion; //el ICommand cone el uso de herramienta::: using System.Windows.Input
        private ICommand irViajes;
        public List<Dia> listaViajes { get; set; }

        public ICommand IrPlanificacion
        {
            get
            {
                if (irPlanificacion == null)
                    irPlanificacion = new DelegateCommand(irPlanificacionExecute, PuedeEjecutarIrPlanificacionExecute);

                return irPlanificacion;
            }
        }
        void irPlanificacionExecute()
        {
            Controlador.ControladorDeNavegacion.Current.NavigateTo("Planificacion");
        }
        bool PuedeEjecutarIrPlanificacionExecute()
        {
            return true;
        }

    }
}
