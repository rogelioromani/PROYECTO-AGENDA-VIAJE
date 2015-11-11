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
    [Table(Name = "Viajes")]
    public class Dia : INotifyPropertyChanging
    {
        private int viajeId;
        private String nombre;
        private DateTime fechaIni;
        private DateTime fechaFin;
        private int duracion;
        private String presupuesto;

        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int ViajeId
        {
            get
            {
                return viajeId;
            }
            set
            {
                viajeId = value;
                this.OnPropertyChanging("ViajeId");
                NotificarCambio("ViajeId");
            }
        }
        [Column(CanBeNull = false)]
        public String Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
                this.OnPropertyChanging("Nombre");
                NotificarCambio("Nombre");

            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotificarCambio(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public void OnPropertyChanging(string propertyName)
        {
            if (PropertyChanging != null)
                PropertyChanging.Invoke(this, new PropertyChangingEventArgs(propertyName));
        }
    }
}
