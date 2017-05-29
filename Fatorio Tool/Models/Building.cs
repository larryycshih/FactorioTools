using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fatorio_Tool.Models
{
    public class Building
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public double EnergyConsumption { get; set; }
        public double HP { get; set; }
        public int ModuleSlot { get; set; }
    }
}