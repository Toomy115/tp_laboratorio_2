namespace CalculadoraFormulario
{
    partial class LaCalculadora
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
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnABinario = new System.Windows.Forms.Button();
            this.btnADecimal = new System.Windows.Forms.Button();
            this.cmbOperacion = new System.Windows.Forms.ComboBox();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblConvertido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(12, 68);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(75, 23);
            this.btnOperar.TabIndex = 0;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(93, 68);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(174, 68);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnABinario
            // 
            this.btnABinario.Location = new System.Drawing.Point(12, 97);
            this.btnABinario.Name = "btnABinario";
            this.btnABinario.Size = new System.Drawing.Size(116, 23);
            this.btnABinario.TabIndex = 3;
            this.btnABinario.Text = "Convertir a Binario";
            this.btnABinario.UseVisualStyleBackColor = true;
            this.btnABinario.Click += new System.EventHandler(this.btnABinario_Click);
            // 
            // btnADecimal
            // 
            this.btnADecimal.Location = new System.Drawing.Point(134, 97);
            this.btnADecimal.Name = "btnADecimal";
            this.btnADecimal.Size = new System.Drawing.Size(115, 23);
            this.btnADecimal.TabIndex = 4;
            this.btnADecimal.Text = "Convertir a Decimal";
            this.btnADecimal.UseVisualStyleBackColor = true;
            this.btnADecimal.Click += new System.EventHandler(this.btnADecimal_Click);
            // 
            // cmbOperacion
            // 
            this.cmbOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperacion.FormattingEnabled = true;
            this.cmbOperacion.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmbOperacion.Location = new System.Drawing.Point(107, 30);
            this.cmbOperacion.Name = "cmbOperacion";
            this.cmbOperacion.Size = new System.Drawing.Size(47, 21);
            this.cmbOperacion.TabIndex = 5;
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(12, 31);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(89, 20);
            this.txtNumero1.TabIndex = 6;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(160, 30);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(89, 20);
            this.txtNumero2.TabIndex = 7;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Enabled = false;
            this.lblResultado.Location = new System.Drawing.Point(9, 9);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "Resultado";
            // 
            // lblConvertido
            // 
            this.lblConvertido.AutoSize = true;
            this.lblConvertido.Enabled = false;
            this.lblConvertido.Location = new System.Drawing.Point(70, 9);
            this.lblConvertido.Name = "lblConvertido";
            this.lblConvertido.Size = new System.Drawing.Size(0, 13);
            this.lblConvertido.TabIndex = 9;
            // 
            // LaCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 132);
            this.Controls.Add(this.lblConvertido);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.cmbOperacion);
            this.Controls.Add(this.btnADecimal);
            this.Controls.Add(this.btnABinario);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOperar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LaCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Tomas Cicenia 2ºA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnABinario;
        private System.Windows.Forms.Button btnADecimal;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblConvertido;
        private System.Windows.Forms.ComboBox cmbOperacion;
    }
}

