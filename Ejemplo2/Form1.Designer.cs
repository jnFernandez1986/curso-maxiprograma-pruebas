namespace Ejemplo2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            calFecha = new MonthCalendar();
            btnPrueba1 = new Button();
            btnPrueba2 = new Button();
            dtpFecha2 = new DateTimePicker();
            cmbOpciones = new ComboBox();
            SuspendLayout();
            // 
            // calFecha
            // 
            calFecha.Location = new Point(72, 158);
            calFecha.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            calFecha.Name = "calFecha";
            calFecha.SelectionRange = new SelectionRange(new DateTime(2024, 2, 23, 0, 0, 0, 0), new DateTime(2024, 2, 29, 0, 0, 0, 0));
            calFecha.ShowWeekNumbers = true;
            calFecha.TabIndex = 0;
            // 
            // btnPrueba1
            // 
            btnPrueba1.Location = new Point(500, 138);
            btnPrueba1.Name = "btnPrueba1";
            btnPrueba1.Size = new Size(94, 29);
            btnPrueba1.TabIndex = 1;
            btnPrueba1.Text = "Prueba1";
            btnPrueba1.UseVisualStyleBackColor = true;
            btnPrueba1.Click += btnPrueba1_Click;
            // 
            // btnPrueba2
            // 
            btnPrueba2.Location = new Point(500, 206);
            btnPrueba2.Name = "btnPrueba2";
            btnPrueba2.Size = new Size(94, 29);
            btnPrueba2.TabIndex = 2;
            btnPrueba2.Text = "Prueba 2";
            btnPrueba2.UseVisualStyleBackColor = true;
            btnPrueba2.Click += btnPrueba2_Click;
            // 
            // dtpFecha2
            // 
            dtpFecha2.Location = new Point(112, 29);
            dtpFecha2.Name = "dtpFecha2";
            dtpFecha2.Size = new Size(250, 27);
            dtpFecha2.TabIndex = 3;
            // 
            // cmbOpciones
            // 
            cmbOpciones.FormattingEnabled = true;
            cmbOpciones.Location = new Point(458, 299);
            cmbOpciones.Name = "cmbOpciones";
            cmbOpciones.Size = new Size(208, 28);
            cmbOpciones.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbOpciones);
            Controls.Add(dtpFecha2);
            Controls.Add(btnPrueba2);
            Controls.Add(btnPrueba1);
            Controls.Add(calFecha);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private MonthCalendar calFecha;
        private Button btnPrueba1;
        private Button btnPrueba2;
        private DateTimePicker dtpFecha2;
        private ComboBox cmbOpciones;
    }
}
