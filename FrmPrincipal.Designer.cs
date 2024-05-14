namespace PryMendozaEtapa6
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.BtnGenrarVehiculos = new System.Windows.Forms.Button();
            this.nud = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnMoverVehiculos = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nud)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnGenrarVehiculos
            // 
            this.BtnGenrarVehiculos.Location = new System.Drawing.Point(6, 19);
            this.BtnGenrarVehiculos.Name = "BtnGenrarVehiculos";
            this.BtnGenrarVehiculos.Size = new System.Drawing.Size(121, 47);
            this.BtnGenrarVehiculos.TabIndex = 0;
            this.BtnGenrarVehiculos.Text = "Crear";
            this.BtnGenrarVehiculos.UseVisualStyleBackColor = true;
            this.BtnGenrarVehiculos.Click += new System.EventHandler(this.BtnGenrarVehiculos_Click);
            // 
            // nud
            // 
            this.nud.Location = new System.Drawing.Point(133, 34);
            this.nud.Name = "nud";
            this.nud.Size = new System.Drawing.Size(70, 20);
            this.nud.TabIndex = 1;
            this.nud.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnGenrarVehiculos);
            this.groupBox1.Controls.Add(this.nud);
            this.groupBox1.Location = new System.Drawing.Point(12, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 74);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generara Vehiculos ";
            // 
            // BtnMoverVehiculos
            // 
            this.BtnMoverVehiculos.Location = new System.Drawing.Point(232, 181);
            this.BtnMoverVehiculos.Name = "BtnMoverVehiculos";
            this.BtnMoverVehiculos.Size = new System.Drawing.Size(121, 47);
            this.BtnMoverVehiculos.TabIndex = 3;
            this.BtnMoverVehiculos.Text = "Mover";
            this.BtnMoverVehiculos.UseVisualStyleBackColor = true;
            this.BtnMoverVehiculos.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 5;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(371, 251);
            this.Controls.Add(this.BtnMoverVehiculos);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Etapa 6 - COLISIONES DE OBJETOS.";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGenrarVehiculos;
        private System.Windows.Forms.NumericUpDown nud;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnMoverVehiculos;
        private System.Windows.Forms.Timer timer;
    }
}