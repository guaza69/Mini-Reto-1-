using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncapacidadEPS.Models
{
    public abstract class Impairment
    {
        public string Diasease { get; }
        public double Days { get; set; }


        public Impairment(string _Diasease, double _Days)
        {
            Diasease = _Diasease;

            Days = _Days;
        }
    }
}

//Creación de modelos base para sistema de incapacidades médicas

// Aqui definimos lo que las propiedades de enfermadad y los dias creando asi una clase
//TypeDiasease  con metodo nombrado GetImpairments

