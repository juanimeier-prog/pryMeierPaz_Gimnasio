namespace pryBravoGimnasioSiglo
{
    partial class FrmInscripcion
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
            grbDatosPersonales = new GroupBox();
            chkEstudiante = new CheckBox();
            txtEdad = new TextBox();
            txtNombre = new TextBox();
            lblEdad = new Label();
            lblNombre = new Label();
            grbPlan = new GroupBox();
            txtMes = new TextBox();
            chkCasillero = new CheckBox();
            cmbTurno = new ComboBox();
            cmbPlan = new ComboBox();
            lblMes = new Label();
            lblTurno = new Label();
            lblPlan = new Label();
            gbxPago = new GroupBox();
            cboCuotas = new ComboBox();
            rbtTarjeta = new RadioButton();
            rbtEfectivo = new RadioButton();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            grbDatosPersonales.SuspendLayout();
            grbPlan.SuspendLayout();
            gbxPago.SuspendLayout();
            SuspendLayout();
            // 
            // grbDatosPersonales
            // 
            grbDatosPersonales.Controls.Add(chkEstudiante);
            grbDatosPersonales.Controls.Add(txtEdad);
            grbDatosPersonales.Controls.Add(txtNombre);
            grbDatosPersonales.Controls.Add(lblEdad);
            grbDatosPersonales.Controls.Add(lblNombre);
            grbDatosPersonales.Location = new Point(25, 24);
            grbDatosPersonales.Name = "grbDatosPersonales";
            grbDatosPersonales.Size = new Size(213, 135);
            grbDatosPersonales.TabIndex = 0;
            grbDatosPersonales.TabStop = false;
            grbDatosPersonales.Text = "Datos Personales";
            // 
            // chkEstudiante
            // 
            chkEstudiante.AutoSize = true;
            chkEstudiante.Location = new Point(56, 100);
            chkEstudiante.Name = "chkEstudiante";
            chkEstudiante.Size = new Size(81, 19);
            chkEstudiante.TabIndex = 4;
            chkEstudiante.Text = "Estudiante";
            chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(78, 56);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(78, 27);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(21, 61);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(36, 15);
            lblEdad.TabIndex = 2;
            lblEdad.Text = "Edad:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(21, 27);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            lblNombre.Click += label1_Click;
            // 
            // grbPlan
            // 
            grbPlan.Controls.Add(txtMes);
            grbPlan.Controls.Add(chkCasillero);
            grbPlan.Controls.Add(cmbTurno);
            grbPlan.Controls.Add(cmbPlan);
            grbPlan.Controls.Add(lblMes);
            grbPlan.Controls.Add(lblTurno);
            grbPlan.Controls.Add(lblPlan);
            grbPlan.Location = new Point(25, 165);
            grbPlan.Name = "grbPlan";
            grbPlan.Size = new Size(213, 150);
            grbPlan.TabIndex = 1;
            grbPlan.TabStop = false;
            grbPlan.Text = "Plan";
            // 
            // txtMes
            // 
            txtMes.Location = new Point(86, 89);
            txtMes.MaxLength = 2;
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(29, 23);
            txtMes.TabIndex = 5;
            // 
            // chkCasillero
            // 
            chkCasillero.AutoSize = true;
            chkCasillero.Location = new Point(21, 125);
            chkCasillero.Name = "chkCasillero";
            chkCasillero.Size = new Size(145, 19);
            chkCasillero.TabIndex = 6;
            chkCasillero.Text = "Casillero ($ 3.000/mes)";
            chkCasillero.UseVisualStyleBackColor = true;
            // 
            // cmbTurno
            // 
            cmbTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTurno.FormattingEnabled = true;
            cmbTurno.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            cmbTurno.Location = new Point(86, 60);
            cmbTurno.Name = "cmbTurno";
            cmbTurno.Size = new Size(121, 23);
            cmbTurno.TabIndex = 3;
            // 
            // cmbPlan
            // 
            cmbPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlan.FormattingEnabled = true;
            cmbPlan.Items.AddRange(new object[] { "Musculación", "Funcional", "Natación" });
            cmbPlan.Location = new Point(86, 25);
            cmbPlan.Name = "cmbPlan";
            cmbPlan.Size = new Size(121, 23);
            cmbPlan.TabIndex = 1;
            // 
            // lblMes
            // 
            lblMes.AutoSize = true;
            lblMes.Location = new Point(21, 91);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(43, 15);
            lblMes.TabIndex = 4;
            lblMes.Text = "Meses:";
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(21, 60);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(42, 15);
            lblTurno.TabIndex = 2;
            lblTurno.Text = "Turno:";
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(21, 28);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(33, 15);
            lblPlan.TabIndex = 0;
            lblPlan.Text = "Plan:";
            // 
            // gbxPago
            // 
            gbxPago.Controls.Add(cboCuotas);
            gbxPago.Controls.Add(rbtTarjeta);
            gbxPago.Controls.Add(rbtEfectivo);
            gbxPago.Location = new Point(25, 321);
            gbxPago.Name = "gbxPago";
            gbxPago.Size = new Size(213, 107);
            gbxPago.TabIndex = 2;
            gbxPago.TabStop = false;
            gbxPago.Text = "Formas de pago";
            // 
            // cboCuotas
            // 
            cboCuotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCuotas.FormattingEnabled = true;
            cboCuotas.Items.AddRange(new object[] { "1", "3", "6" });
            cboCuotas.Location = new Point(45, 64);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new Size(121, 23);
            cboCuotas.TabIndex = 2;
            // 
            // rbtTarjeta
            // 
            rbtTarjeta.AutoSize = true;
            rbtTarjeta.Location = new Point(118, 39);
            rbtTarjeta.Name = "rbtTarjeta";
            rbtTarjeta.Size = new Size(60, 19);
            rbtTarjeta.TabIndex = 1;
            rbtTarjeta.TabStop = true;
            rbtTarjeta.Text = "Tarjeta";
            rbtTarjeta.UseVisualStyleBackColor = true;
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Location = new Point(30, 39);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(67, 19);
            rbtEfectivo.TabIndex = 0;
            rbtEfectivo.TabStop = true;
            rbtEfectivo.Text = "Efectivo";
            rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.AccessibleRole = AccessibleRole.TitleBar;
            btnCalcular.Location = new Point(47, 451);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(143, 451);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // FrmInscripcion
            // 
            AcceptButton = btnCalcular;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 501);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(gbxPago);
            Controls.Add(grbPlan);
            Controls.Add(grbDatosPersonales);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmInscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gimnasio Siglo — Inscripción";
            Load += FrmInscripcion_Load;
            grbDatosPersonales.ResumeLayout(false);
            grbDatosPersonales.PerformLayout();
            grbPlan.ResumeLayout(false);
            grbPlan.PerformLayout();
            gbxPago.ResumeLayout(false);
            gbxPago.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbDatosPersonales;
        private CheckBox chkEstudiante;
        private TextBox txtEdad;
        private TextBox txtNombre;
        private Label lblEdad;
        private Label lblNombre;
        private GroupBox grbPlan;
        private Label lblMes;
        private Label lblTurno;
        private Label lblPlan;
        private TextBox txtMes;
        private CheckBox chkCasillero;
        private ComboBox cmbTurno;
        private ComboBox cmbPlan;
        private GroupBox gbxPago;
        private ComboBox cboCuotas;
        private RadioButton rbtTarjeta;
        private RadioButton rbtEfectivo;
        private Button btnCalcular;
        private Button btnLimpiar;
    }
}
