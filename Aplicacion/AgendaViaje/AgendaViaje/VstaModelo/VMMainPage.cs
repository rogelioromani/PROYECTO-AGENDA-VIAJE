using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaViaje.VstaModelo
{
    public class VMMainPage
    {
        private ICommand irPlanificacion;
        private ICommand irViajes;
        public List<Viaje> listaViajes { get; set; }

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
