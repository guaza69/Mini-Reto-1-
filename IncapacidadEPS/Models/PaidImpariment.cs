using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncapacidadEPS.Models
{
    public class PaidImpariment
    {
        public double Salary { get; set; }
        public required Diasease ImpairmentSelected { get; set; } 

        public double SalaryImpariment()
        {
            if (Salary < 750000)
            {       
                return (Salary / 30.0) * (ImpairmentSelected.Days);
            }
            else if (Salary >= 750000 && Salary <= 1500000 && ImpairmentSelected.Days > 3)
            {
                return (Salary / 30.0) * ImpairmentSelected.Days - ((Salary / 30) * 3) ;
            }
            else if (Salary >= 750000 && Salary <= 1500000 && ImpairmentSelected.Days <= 3)
            {
                return 0;
            }
            else
            {
                return (Salary / 30 * 65.0 / 100.0) * (ImpairmentSelected.Days);
            }
        }

        public double SalaryTotal()
        {
            if (Salary < 750000)
            {
                return Salary;
            }
            else if (Salary >= 750000 && Salary <= 1500000 && ImpairmentSelected.Days == 2)
            {
                return Salary - ((Salary / 30) * 2);
            }
            else
            {
                return Salary - SalaryImpariment();
            }
        }
    }

    // Añadimos la  lógica de cálculo diferenciada por niveles salariales
    // menor a 750,000, entre 750,000-1,500,000, y mayor
    // para calcular monto de compensación según normativ. 
}
