namespace LibroDiario
{
    partial class Vista
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnDebe = new System.Windows.Forms.Button();
            this.cmbDebe = new System.Windows.Forms.ComboBox();
            this.cmbHaber = new System.Windows.Forms.ComboBox();
            this.btnHaber = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMontoDebe = new System.Windows.Forms.TextBox();
            this.txtMontoHaber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lboxCuentas = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lboxMontos = new System.Windows.Forms.ListBox();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(164, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "LIBRO DIARIO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDebe
            // 
            this.btnDebe.Location = new System.Drawing.Point(487, 87);
            this.btnDebe.Name = "btnDebe";
            this.btnDebe.Size = new System.Drawing.Size(75, 21);
            this.btnDebe.TabIndex = 1;
            this.btnDebe.Text = "Agregar";
            this.btnDebe.UseVisualStyleBackColor = true;
            this.btnDebe.Click += new System.EventHandler(this.BtnDebe_Click);
            // 
            // cmbDebe
            // 
            this.cmbDebe.FormattingEnabled = true;
            this.cmbDebe.Location = new System.Drawing.Point(12, 87);
            this.cmbDebe.Name = "cmbDebe";
            this.cmbDebe.Size = new System.Drawing.Size(352, 21);
            this.cmbDebe.TabIndex = 2;
            // 
            // cmbHaber
            // 
            this.cmbHaber.FormattingEnabled = true;
            this.cmbHaber.Location = new System.Drawing.Point(12, 148);
            this.cmbHaber.Name = "cmbHaber";
            this.cmbHaber.Size = new System.Drawing.Size(352, 21);
            this.cmbHaber.TabIndex = 3;
            // 
            // btnHaber
            // 
            this.btnHaber.Location = new System.Drawing.Point(487, 149);
            this.btnHaber.Name = "btnHaber";
            this.btnHaber.Size = new System.Drawing.Size(75, 21);
            this.btnHaber.TabIndex = 4;
            this.btnHaber.Text = "Agregar";
            this.btnHaber.UseVisualStyleBackColor = true;
            this.btnHaber.Click += new System.EventHandler(this.BtnHaber_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "DEBE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "HABER";
            // 
            // txtMontoDebe
            // 
            this.txtMontoDebe.Location = new System.Drawing.Point(383, 87);
            this.txtMontoDebe.Name = "txtMontoDebe";
            this.txtMontoDebe.Size = new System.Drawing.Size(82, 20);
            this.txtMontoDebe.TabIndex = 6;
            this.txtMontoDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMontoHaber
            // 
            this.txtMontoHaber.Location = new System.Drawing.Point(383, 149);
            this.txtMontoHaber.Name = "txtMontoHaber";
            this.txtMontoHaber.Size = new System.Drawing.Size(82, 20);
            this.txtMontoHaber.TabIndex = 6;
            this.txtMontoHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(466, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(466, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "$";
            // 
            // lboxCuentas
            // 
            this.lboxCuentas.FormattingEnabled = true;
            this.lboxCuentas.Location = new System.Drawing.Point(18, 209);
            this.lboxCuentas.Name = "lboxCuentas";
            this.lboxCuentas.Size = new System.Drawing.Size(346, 95);
            this.lboxCuentas.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Vista Previa";
            // 
            // lboxMontos
            // 
            this.lboxMontos.FormattingEnabled = true;
            this.lboxMontos.Location = new System.Drawing.Point(370, 209);
            this.lboxMontos.Name = "lboxMontos";
            this.lboxMontos.Size = new System.Drawing.Size(120, 95);
            this.lboxMontos.TabIndex = 8;
            // 
            // textDescripcion
            // 
            this.textDescripcion.Location = new System.Drawing.Point(132, 314);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(358, 20);
            this.textDescripcion.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Descripción";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(497, 209);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(65, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(497, 265);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(65, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(497, 236);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(65, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // Vista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.textDescripcion);
            this.Controls.Add(this.lboxMontos);
            this.Controls.Add(this.lboxCuentas);
            this.Controls.Add(this.txtMontoHaber);
            this.Controls.Add(this.txtMontoDebe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHaber);
            this.Controls.Add(this.cmbHaber);
            this.Controls.Add(this.cmbDebe);
            this.Controls.Add(this.btnDebe);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Vista";
            this.Text = "Libro Diario ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDebe;
        private System.Windows.Forms.ComboBox cmbDebe;
        private System.Windows.Forms.ComboBox cmbHaber;
        private System.Windows.Forms.Button btnHaber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMontoDebe;
        private System.Windows.Forms.TextBox txtMontoHaber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lboxCuentas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lboxMontos;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEliminar;
    }
}

