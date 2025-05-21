using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IncapacidadEPS.Controller;
using IncapacidadEPS.Models;

namespace IncapacidadEPS.Views
{
    public partial class IncapacidadEPS : Form
    {
        ImpairmentController ImpairmentController = new ImpairmentController();
        private void GetData()
        {
            List<Diasease> diaseases = ImpairmentController.GetDiasease();
            ComboBox.DataSource = diaseases;
            ComboBox.DisplayMember = "Diasease";
            ComboBox.ValueMember = "Days";
        }

        public IncapacidadEPS()
        {
            InitializeComponent();
            GetData();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double salary))
            {
                ImpairmentController._paidImpariment.Salary = salary;
            }
            else
            {
                ImpairmentController._paidImpariment.Salary = 0;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var selectedDiasease = ComboBox.SelectedItem as Diasease;
            if (selectedDiasease != null)
            {
                ImpairmentController.SetImpairmentSelected(selectedDiasease);

                DiasIncapcacidad.Text = selectedDiasease.Days.ToString();
                Enfermedad.Text = selectedDiasease.Diasease;
                PagoIncapacidad.Text = ImpairmentController.GetPaidImpairment().ToString("N2");
                PagoTotal.Text = ImpairmentController.GetTotalSalary().ToString("N2");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una enfermedad válida.");
            }
        }
    }
}
