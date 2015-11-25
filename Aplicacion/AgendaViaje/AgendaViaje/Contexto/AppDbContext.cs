using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using AgendaViaje.Tablas;
using System.Data.Linq.Mapping;

namespace AgendaViaje.Contexto
{
    public class AppDbContext : DataContext
    {
        public AppDbContext(string cadenaDeConexion)
            : base(cadenaDeConexion) { }
         public Table<Viaje> Viajes
        {
            get { return this.GetTable<Viaje>(); }
        }
         public Table<Viaje> Dias
         {
             get { return this.GetTable<Viaje>(); }
         }
         //public Table<Gasto> Gastos
         //{
         //    get { return this.GetTable<Gasto>(); }
         //}
    }
    //[Association(Storage = "Dias", OtherKey = "ViajeId")]
    //public EntitySet<Dia> Dias { get; set; }

    //[Association(Storage = "Gastos", OtherKey = "ViajeId")]
    //public EntitySet<Gasto> Gastos { get; set; } 
    }