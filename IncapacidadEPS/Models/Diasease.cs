using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncapacidadEPS.Models
{
    public class Diasease : Impairment
    {
        public Diasease(string _Diasease, double _Days) : base(_Diasease, _Days)
        {
        }
    }
}
