using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IncapacidadEPS.Models;

namespace IncapacidadEPS.Controller
{
    public class ImpairmentController
    {
        public PaidImpariment paidImpariment = new PaidImpariment
        {
            ImpairmentSelected = new Diasease("DefaultDiasease", 0) 
        };

        public PaidImpariment _paidImpariment { get; set; }

        public ImpairmentController()
        {
            _paidImpariment = new PaidImpariment
            {
                ImpairmentSelected = new Diasease("DefaultDiasease", 0)  
            };
        }
        public List<Diasease> GetDiasease()
        {
            return TypeDiasease.GetImpairments();
        }

        public void SetImpairmentSelected(Diasease diasease)
        {
            _paidImpariment.ImpairmentSelected = diasease;
        }

        public double GetPaidImpairment()
        {
            return _paidImpariment.SalaryImpariment();
        }

        public double GetTotalSalary()
        {
            return _paidImpariment.SalaryTotal();
        }
    }
}
