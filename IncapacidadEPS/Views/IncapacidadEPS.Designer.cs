namespace IncapacidadEPS.Views
{
    partial class IncapacidadEPS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            DiasIncapcacidad = new Label();
            Enfermedad = new Label();
            PagoIncapacidad = new Label();
            PagoTotal = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // ComboBox
            // 
            ComboBox.FormattingEnabled = true;
            ComboBox.Location = new Point(60, 59);
            ComboBox.Margin = new Padding(3, 2, 3, 2);
            ComboBox.Name = "ComboBox";
            ComboBox.Size = new Size(133, 23);
            ComboBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 42);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 1;
            label1.Text = "Enfermedad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(144, 176);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 2;
            label2.Text = "Dias de Incapacidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(192, 209);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 3;
            label3.Text = "Enfermedad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(159, 241);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 4;
            label4.Text = "Pago Incapacidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(201, 272);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 5;
            label5.Text = "Pago Total";
            // 
            // DiasIncapcacidad
            // 
            DiasIncapcacidad.AutoSize = true;
            DiasIncapcacidad.Location = new Point(408, 176);
            DiasIncapcacidad.Name = "DiasIncapcacidad";
            DiasIncapcacidad.Size = new Size(0, 15);
            DiasIncapcacidad.TabIndex = 6;
            // 
            // Enfermedad
            // 
            Enfermedad.AutoSize = true;
            Enfermedad.Location = new Point(408, 209);
            Enfermedad.Name = "Enfermedad";
            Enfermedad.Size = new Size(0, 15);
            Enfermedad.TabIndex = 7;
            // 
            // PagoIncapacidad
            // 
            PagoIncapacidad.AutoSize = true;
            PagoIncapacidad.Location = new Point(408, 241);
            PagoIncapacidad.Name = "PagoIncapacidad";
            PagoIncapacidad.Size = new Size(0, 15);
            PagoIncapacidad.TabIndex = 8;
            // 
            // PagoTotal
            // 
            PagoTotal.AutoSize = true;
            PagoTotal.Location = new Point(408, 272);
            PagoTotal.Name = "PagoTotal";
            PagoTotal.Size = new Size(0, 15);
            PagoTotal.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(279, 127);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(129, 22);
            button1.TabIndex = 10;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(473, 60);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(129, 23);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(473, 42);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 12;
            label6.Text = "Salario";
            // 
            // IncapacidadEPS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 338);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(PagoTotal);
            Controls.Add(PagoIncapacidad);
            Controls.Add(Enfermedad);
            Controls.Add(DiasIncapcacidad);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ComboBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "IncapacidadEPS";
            Text = "IncapacidadEPS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ComboBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label DiasIncapcacidad;
        private Label Enfermedad;
        private Label PagoIncapacidad;
        private Label PagoTotal;
        private Button button1;
        private TextBox textBox1;
        private Label label6;
    }
}