namespace Ejemplo1
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
            btnAgregar = new Button();
            txtNombre = new TextBox();
            lwElementos = new ListView();
            lblNombre = new Label();
            lblFechaNacimiento = new Label();
            cbkChocolate = new CheckBox();
            dtpFechaNac = new DateTimePicker();
            rbtSoltero = new RadioButton();
            rbtCasado = new RadioButton();
            rbtDivorciado = new RadioButton();
            groupBox1 = new GroupBox();
            cboColorFavorito = new ComboBox();
            lblNumeroFavorito = new Label();
            btnVerPerfil = new Button();
            numNumeroFavorito = new NumericUpDown();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numNumeroFavorito).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(308, 562);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 33);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnSaludar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(203, 68);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 1;
            // 
            // lwElementos
            // 
            lwElementos.Location = new Point(37, 441);
            lwElementos.Name = "lwElementos";
            lwElementos.Size = new Size(255, 145);
            lwElementos.TabIndex = 2;
            lwElementos.UseCompatibleStateImageBehavior = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(37, 75);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(37, 117);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(149, 20);
            lblFechaNacimiento.TabIndex = 4;
            lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // cbkChocolate
            // 
            cbkChocolate.AutoSize = true;
            cbkChocolate.Location = new Point(205, 153);
            cbkChocolate.Name = "cbkChocolate";
            cbkChocolate.Size = new Size(173, 24);
            cbkChocolate.TabIndex = 6;
            cbkChocolate.Text = "Te gusta el Chocolate";
            cbkChocolate.UseVisualStyleBackColor = true;
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Location = new Point(204, 114);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(308, 27);
            dtpFechaNac.TabIndex = 7;
            // 
            // rbtSoltero
            // 
            rbtSoltero.AutoSize = true;
            rbtSoltero.Location = new Point(32, 45);
            rbtSoltero.Name = "rbtSoltero";
            rbtSoltero.Size = new Size(78, 24);
            rbtSoltero.TabIndex = 8;
            rbtSoltero.TabStop = true;
            rbtSoltero.Text = "Soltero";
            rbtSoltero.UseVisualStyleBackColor = true;
            // 
            // rbtCasado
            // 
            rbtCasado.AutoSize = true;
            rbtCasado.Location = new Point(186, 45);
            rbtCasado.Name = "rbtCasado";
            rbtCasado.Size = new Size(79, 24);
            rbtCasado.TabIndex = 9;
            rbtCasado.TabStop = true;
            rbtCasado.Text = "Casado";
            rbtCasado.UseVisualStyleBackColor = true;
            // 
            // rbtDivorciado
            // 
            rbtDivorciado.AutoSize = true;
            rbtDivorciado.Location = new Point(354, 45);
            rbtDivorciado.Name = "rbtDivorciado";
            rbtDivorciado.Size = new Size(103, 24);
            rbtDivorciado.TabIndex = 10;
            rbtDivorciado.TabStop = true;
            rbtDivorciado.Text = "Divorciado";
            rbtDivorciado.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtSoltero);
            groupBox1.Controls.Add(rbtDivorciado);
            groupBox1.Controls.Add(rbtCasado);
            groupBox1.Location = new Point(37, 183);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(496, 125);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estado Civil";
            // 
            // cboColorFavorito
            // 
            cboColorFavorito.FormattingEnabled = true;
            cboColorFavorito.Location = new Point(161, 324);
            cboColorFavorito.Name = "cboColorFavorito";
            cboColorFavorito.Size = new Size(151, 28);
            cboColorFavorito.TabIndex = 12;
            cboColorFavorito.SelectedIndexChanged += cboColorFavorito_SelectedIndexChanged;
            // 
            // lblNumeroFavorito
            // 
            lblNumeroFavorito.AutoSize = true;
            lblNumeroFavorito.Location = new Point(46, 327);
            lblNumeroFavorito.Name = "lblNumeroFavorito";
            lblNumeroFavorito.Size = new Size(109, 20);
            lblNumeroFavorito.TabIndex = 13;
            lblNumeroFavorito.Text = "Color Favorito: ";
            // 
            // btnVerPerfil
            // 
            btnVerPerfil.Location = new Point(46, 402);
            btnVerPerfil.Name = "btnVerPerfil";
            btnVerPerfil.Size = new Size(100, 33);
            btnVerPerfil.TabIndex = 14;
            btnVerPerfil.Text = "Ver Perfil";
            btnVerPerfil.UseVisualStyleBackColor = true;
            btnVerPerfil.Click += button1_Click;
            // 
            // numNumeroFavorito
            // 
            numNumeroFavorito.Location = new Point(163, 363);
            numNumeroFavorito.Name = "numNumeroFavorito";
            numNumeroFavorito.Size = new Size(150, 27);
            numNumeroFavorito.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 365);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 16;
            label1.Text = "Número Favorito: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 620);
            Controls.Add(label1);
            Controls.Add(numNumeroFavorito);
            Controls.Add(btnVerPerfil);
            Controls.Add(lblNumeroFavorito);
            Controls.Add(cboColorFavorito);
            Controls.Add(groupBox1);
            Controls.Add(dtpFechaNac);
            Controls.Add(cbkChocolate);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(lblNombre);
            Controls.Add(lwElementos);
            Controls.Add(txtNombre);
            Controls.Add(btnAgregar);
            MinimumSize = new Size(597, 667);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numNumeroFavorito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private TextBox txtNombre;
        private ListView lwElementos;
        private Label lblNombre;
        private Label lblFechaNacimiento;
        private CheckBox cbkChocolate;
        private DateTimePicker dtpFechaNac;
        private RadioButton rbtSoltero;
        private RadioButton rbtCasado;
        private RadioButton rbtDivorciado;
        private GroupBox groupBox1;
        private ComboBox cboColorFavorito;
        private Label lblNumeroFavorito;
        private Button btnVerPerfil;
        private NumericUpDown numNumeroFavorito;
        private Label label1;
    }
}
