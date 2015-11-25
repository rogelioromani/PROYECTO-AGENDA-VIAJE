using Microsoft.Phone.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;
using AgendaViaje.Vista;


namespace AgendaViaje.Controlador
{
   public class ControladorDeNavegacion
    {
       static ControladorDeNavegacion current;
       public static ControladorDeNavegacion Current
       {
           get
           {
               if (current == null)
               {
                   current = new ControladorDeNavegacion();
               }
               return current;
           }
       }
       static Dictionary<String, Uri> registeredVista = new Dictionary<String, Uri>();
       private ControladorDeNavegacion()
       {
           registeredVista.Add("Planificacion", new Uri(@"/Planificacion.xaml", UriKind.Relative));
           registeredVista.Add("Viajes", new Uri(@"/Viajes.xaml", UriKind.Relative));
       }
       public void NavigateTo(String destino)
       {
           PhoneApplicationFrame rootFrame = App.Current.RootVisual as PhoneApplicationFrame;
           rootFrame.Navigate(registeredVista[destino]);
       }
       void root_Navigated(object sender, NavigationEventArgs e)
       {
           NavigationMethod(e);
       }

       private void NavigationMethod(NavigationEventArgs e)
       {
           throw new NotImplementedException();
       }
       public void BackTo()
       {

           PhoneApplicationFrame rootFrame = Application.Current.RootVisual as PhoneApplicationFrame;
           rootFrame.GoBack();
       }
    }
}
