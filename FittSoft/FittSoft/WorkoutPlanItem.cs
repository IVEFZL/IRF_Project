using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FittSoft
{
    class WorkoutPlanItem
    {
        public string Megnevezés { get; set; }
        public int Ismétlés { get; set; }
        public decimal Időtartam { get; set; }
        public decimal Súly { get; set; }
        public string Leírás { get; set; }
    }
}
