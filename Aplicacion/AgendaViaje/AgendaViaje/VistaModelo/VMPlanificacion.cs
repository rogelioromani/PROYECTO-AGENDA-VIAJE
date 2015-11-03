using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaViaje.Contexto;

namespace AgendaViaje.VistaModelo
{
    public  VMPlanificacion()
    { 
    using (AppDbContext contextDb = new AppDbContext("Data Source='isostore:/MiViajeDb.sdf'")) 
    {
        if (!contextDb.DatabaseExists())
        {
            contextDb.CreateDatabase();
        }
        else
        {
            Lista = (from Viaje viaje in contextDb.Viajes select viaje).ToList();
        }
    }

    public  bool PuedeEjecutarEditar()
    {
    bool dev = true;           
    if (listaViajes == null) 
    {
        dev = false;
    }
    else if (itemSelecionado == null)
    {
        dev = false;
    }
    return dev;             
    } 
} 
