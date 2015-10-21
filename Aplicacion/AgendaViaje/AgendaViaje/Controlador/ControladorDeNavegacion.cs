using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
       static Dictionary<String, Uri> registeredViews = new Dictionary<String, Uri>();
       private ControladorDeNavegacion()
       {
           registeredViews.Add("Planificacion",
       new Uri(@"/Planificacion.xaml", UriKind.Relative));
           registeredViews.Add("Viajes",
                                       new Uri(@"/Viajes.xaml", UriKind.Relative));
       }
       public void NavigateTo(String destino)
       {
           PhoneApplicationFrame rootFrame = App.Current.RootVisual as PhoneApplicationFrame;
           rootFrame.Navigate(registeredViews[destino]);
       }
       void root_Navigated(object sender, NavigationEventArgs e)
       {
           NavigationMethod(e);
       }
       public void BackTo()
       {

           PhoneApplicationFrame rootFrame = Application.Current.RootVisual as PhoneApplicationFrame;
           rootFrame.GoBack();
       }
    }
}
