
namespace MiCalculadora
{
    partial class FormCalculadora
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
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnConvertirABinario = new System.Windows.Forms.Button();
            this.btnConvertirABDecimal = new System.Windows.Forms.Button();
            this.listOperaciones = new System.Windows.Forms.ListBox();
            this.txtNumeroUno = new System.Windows.Forms.TextBox();
            this.txtNumeroDos = new System.Windows.Forms.TextBox();
            this.BoxOperador = new System.Windows.Forms.ComboBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(12, 128);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(152, 44);
            this.btnOperar.TabIndex = 0;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(170, 128);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(152, 44);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(328, 128);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(152, 44);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnConvertirABinario
            // 
            this.btnConvertirABinario.Location = new System.Drawing.Point(12, 210);
            this.btnConvertirABinario.Name = "btnConvertirABinario";
            this.btnConvertirABinario.Size = new System.Drawing.Size(231, 44);
            this.btnConvertirABinario.TabIndex = 3;
            this.btnConvertirABinario.Text = "Convertir a Binario";
            this.btnConvertirABinario.UseVisualStyleBackColor = true;
            this.btnConvertirABinario.Click += new System.EventHandler(this.btnConvertirABinario_Click);
            // 
            // btnConvertirABDecimal
            // 
            this.btnConvertirABDecimal.Location = new System.Drawing.Point(249, 210);
            this.btnConvertirABDecimal.Name = "btnConvertirABDecimal";
            this.btnConvertirABDecimal.Size = new System.Drawing.Size(231, 44);
            this.btnConvertirABDecimal.TabIndex = 4;
            this.btnConvertirABDecimal.Text = "Convertir a Decimal";
            this.btnConvertirABDecimal.UseVisualStyleBackColor = true;
            this.btnConvertirABDecimal.Click += new System.EventHandler(this.btnConvertirABDecimal_Click);
            // 
            // listOperaciones
            // 
            this.listOperaciones.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listOperaciones.FormattingEnabled = true;
            this.listOperaciones.ItemHeight = 23;
            this.listOperaciones.Location = new System.Drawing.Point(486, 12);
            this.listOperaciones.Name = "listOperaciones";
            this.listOperaciones.Size = new System.Drawing.Size(228, 257);
            this.listOperaciones.TabIndex = 5;
            // 
            // txtNumeroUno
            // 
            this.txtNumeroUno.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumeroUno.Location = new System.Drawing.Point(12, 60);
            this.txtNumeroUno.Name = "txtNumeroUno";
            this.txtNumeroUno.Size = new System.Drawing.Size(131, 39);
            this.txtNumeroUno.TabIndex = 6;
            this.txtNumeroUno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumeroDos
            // 
            this.txtNumeroDos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumeroDos.Location = new System.Drawing.Point(349, 60);
            this.txtNumeroDos.Name = "txtNumeroDos";
            this.txtNumeroDos.Size = new System.Drawing.Size(131, 39);
            this.txtNumeroDos.TabIndex = 7;
            this.txtNumeroDos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BoxOperador
            // 
            this.BoxOperador.BackColor = System.Drawing.Color.White;
            this.BoxOperador.DisplayMember = "7";
            this.BoxOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxOperador.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BoxOperador.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BoxOperador.FormattingEnabled = true;
            this.BoxOperador.Items.AddRange(new object[] {
            "",
            "*",
            "/",
            "+",
            "-"});
            this.BoxOperador.Location = new System.Drawing.Point(192, 59);
            this.BoxOperador.Name = "BoxOperador";
            this.BoxOperador.Size = new System.Drawing.Size(110, 40);
            this.BoxOperador.TabIndex = 8;
            this.BoxOperador.ValueMember = "/";
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblResultado.Location = new System.Drawing.Point(12, 12);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(468, 42);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "0";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 280);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.BoxOperador);
            this.Controls.Add(this.txtNumeroDos);
            this.Controls.Add(this.txtNumeroUno);
            this.Controls.Add(this.listOperaciones);
            this.Controls.Add(this.btnConvertirABDecimal);
            this.Controls.Add(this.btnConvertirABinario);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOperar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Cesar Algañaras del curso 2°D";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCalculadora_FormClosing);
            this.Load += new System.EventHandler(this.FormCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnConvertirABinario;
        private System.Windows.Forms.Button btnConvertirABDecimal;
        private System.Windows.Forms.TextBox txtNumeroUno;
        private System.Windows.Forms.TextBox txtNumeroDos;
        private System.Windows.Forms.ListBox listOperaciones;
        private System.Windows.Forms.ComboBox BoxOperador;
        private System.Windows.Forms.Label lblResultado;
    }
}

