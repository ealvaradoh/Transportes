using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Transportes.BusinessLayer
{
    public class Cat_BusesBL
    {
        Context _context;
        public BindingList<Cat_Buses> ListaDeBuses { get; set; }

        public Cat_BusesBL()
        {
            _context = new Context();
            ListaDeBuses = new BindingList<Cat_Buses>();
        }

        public BindingList<Cat_Buses> ObtenerBuses()
        {
            _context.Buses.Load();
            ListaDeBuses = _context.Buses.Local.ToBindingList();
            return ListaDeBuses;
        }

        public void AgregarBus()
        {
            var NuevoBus = new Cat_Buses();
            ListaDeBuses.Add(NuevoBus);
        }
    }

    public class Cat_Buses
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Color { get; set; }
        public int CantAsientos { get; set; }
    }
}
