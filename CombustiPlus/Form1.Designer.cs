namespace CombustiPlus
{
    partial class frmCombustiPlus
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
            lblPlaca = new Label();
            lblCombustible = new Label();
            lblGalones = new Label();
            lblPago = new Label();
            txtPlaca = new TextBox();
            cmbCombustible = new ComboBox();
            nudGalones = new NumericUpDown();
            cmbPago = new ComboBox();
            btnCotizar = new Button();
            btnDespachar = new Button();
            groupBox1 = new GroupBox();
            lstDetalle = new ListBox();
            gbDespachos = new GroupBox();
            btnPorCombustible = new Button();
            lstDespachos = new ListBox();
            lblResumen = new Label();
            ((System.ComponentModel.ISupportInitialize)nudGalones).BeginInit();
            groupBox1.SuspendLayout();
            gbDespachos.SuspendLayout();
            SuspendLayout();
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Location = new Point(12, 30);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(47, 20);
            lblPlaca.TabIndex = 0;
            lblPlaca.Text = "Placa:";
            // 
            // lblCombustible
            // 
            lblCombustible.AutoSize = true;
            lblCombustible.Location = new Point(12, 72);
            lblCombustible.Name = "lblCombustible";
            lblCombustible.Size = new Size(96, 20);
            lblCombustible.TabIndex = 1;
            lblCombustible.Text = "Combustible:";
            // 
            // lblGalones
            // 
            lblGalones.AutoSize = true;
            lblGalones.Location = new Point(12, 119);
            lblGalones.Name = "lblGalones";
            lblGalones.Size = new Size(65, 20);
            lblGalones.TabIndex = 2;
            lblGalones.Text = "Galones:";
            // 
            // lblPago
            // 
            lblPago.AutoSize = true;
            lblPago.Location = new Point(12, 169);
            lblPago.Name = "lblPago";
            lblPago.Size = new Size(49, 20);
            lblPago.TabIndex = 3;
            lblPago.Text = "Pago: ";
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(65, 27);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(125, 27);
            txtPlaca.TabIndex = 4;
            // 
            // cmbCombustible
            // 
            cmbCombustible.FormattingEnabled = true;
            cmbCombustible.Items.AddRange(new object[] { "Premium", "Regular", "Gasoil", "Efectivo", "Tarjeta" });
            cmbCombustible.Location = new Point(114, 72);
            cmbCombustible.Name = "cmbCombustible";
            cmbCombustible.Size = new Size(151, 28);
            cmbCombustible.TabIndex = 5;
            // 
            // nudGalones
            // 
            nudGalones.Location = new Point(83, 119);
            nudGalones.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudGalones.Name = "nudGalones";
            nudGalones.Size = new Size(150, 27);
            nudGalones.TabIndex = 6;
            // 
            // cmbPago
            // 
            cmbPago.FormattingEnabled = true;
            cmbPago.Location = new Point(65, 166);
            cmbPago.Name = "cmbPago";
            cmbPago.Size = new Size(151, 28);
            cmbPago.TabIndex = 7;
            // 
            // btnCotizar
            // 
            btnCotizar.Location = new Point(12, 214);
            btnCotizar.Name = "btnCotizar";
            btnCotizar.Size = new Size(94, 29);
            btnCotizar.TabIndex = 8;
            btnCotizar.Text = "Cotizar";
            btnCotizar.UseVisualStyleBackColor = true;
            btnCotizar.Click += btnCotizar_Click;
            // 
            // btnDespachar
            // 
            btnDespachar.Location = new Point(171, 214);
            btnDespachar.Name = "btnDespachar";
            btnDespachar.Size = new Size(94, 29);
            btnDespachar.TabIndex = 9;
            btnDespachar.Text = "Despachar";
            btnDespachar.UseVisualStyleBackColor = true;
            btnDespachar.Click += btnDespachar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstDetalle);
            groupBox1.Location = new Point(12, 267);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(687, 349);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle";
            // 
            // lstDetalle
            // 
            lstDetalle.FormattingEnabled = true;
            lstDetalle.Location = new Point(18, 26);
            lstDetalle.Name = "lstDetalle";
            lstDetalle.Size = new Size(654, 304);
            lstDetalle.TabIndex = 11;
            // 
            // gbDespachos
            // 
            gbDespachos.Controls.Add(btnPorCombustible);
            gbDespachos.Controls.Add(lstDespachos);
            gbDespachos.Location = new Point(835, 14);
            gbDespachos.Name = "gbDespachos";
            gbDespachos.Size = new Size(486, 616);
            gbDespachos.TabIndex = 11;
            gbDespachos.TabStop = false;
            gbDespachos.Text = "Despachos del dia";
            // 
            // btnPorCombustible
            // 
            btnPorCombustible.Location = new Point(17, 578);
            btnPorCombustible.Name = "btnPorCombustible";
            btnPorCombustible.Size = new Size(226, 29);
            btnPorCombustible.TabIndex = 12;
            btnPorCombustible.Text = "Galones por Combustible";
            btnPorCombustible.UseVisualStyleBackColor = true;
            btnPorCombustible.Click += btnPorCombustible_Click;
            // 
            // lstDespachos
            // 
            lstDespachos.FormattingEnabled = true;
            lstDespachos.Location = new Point(17, 28);
            lstDespachos.Name = "lstDespachos";
            lstDespachos.Size = new Size(452, 544);
            lstDespachos.TabIndex = 0;
            // 
            // lblResumen
            // 
            lblResumen.AutoSize = true;
            lblResumen.Location = new Point(852, 646);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(69, 20);
            lblResumen.TabIndex = 12;
            lblResumen.Text = "Resumen";
            // 
            // frmCombustiPlus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 693);
            Controls.Add(lblResumen);
            Controls.Add(gbDespachos);
            Controls.Add(groupBox1);
            Controls.Add(btnDespachar);
            Controls.Add(btnCotizar);
            Controls.Add(cmbPago);
            Controls.Add(nudGalones);
            Controls.Add(cmbCombustible);
            Controls.Add(txtPlaca);
            Controls.Add(lblPago);
            Controls.Add(lblGalones);
            Controls.Add(lblCombustible);
            Controls.Add(lblPlaca);
            Name = "frmCombustiPlus";
            Text = "CombustiPlus - Kimberly Ashley Theosmy, 2025-0505";
            ((System.ComponentModel.ISupportInitialize)nudGalones).EndInit();
            groupBox1.ResumeLayout(false);
            gbDespachos.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPlaca;
        private Label lblCombustible;
        private Label lblGalones;
        private Label lblPago;
        private TextBox txtPlaca;
        private ComboBox cmbCombustible;
        private NumericUpDown nudGalones;
        private ComboBox cmbPago;
        private Button btnCotizar;
        private Button btnDespachar;
        private GroupBox groupBox1;
        private ListBox lstDetalle;
        private GroupBox gbDespachos;
        private ListBox lstDespachos;
        private Button btnPorCombustible;
        private Label lblResumen;
    }
}
