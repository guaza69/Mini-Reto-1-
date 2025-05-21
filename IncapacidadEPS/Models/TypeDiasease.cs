using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncapacidadEPS.Models //Me ayudan a evitar conflictos de nombres. 
{
    public static class TypeDiasease
    {
        public static List<Diasease> GetImpairments()
        {
            return new List<Diasease> //Diasease esta implicita  entonces  se infiere que existe una clase Diasease con un constructor.
            {
                new Diasease("Viral", 2),
                new Diasease("Bacterial", 5),
                new Diasease("Cirugia menor", 7),
                new Diasease("Cirugia Mayor", 15),
                new Diasease("Gripa", 0)
            };
        }
    }
}
