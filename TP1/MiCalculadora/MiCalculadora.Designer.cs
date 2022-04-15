
namespace MiCalculadora
{
    partial class S
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
            this.BoxLista = new System.Windows.Forms.ListBox();
            this.txtNumeroUno = new System.Windows.Forms.TextBox();
            this.txtNumeroDos = new System.Windows.Forms.TextBox();
            this.BoxOperador = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(12, 142);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(131, 44);
            this.btnOperar.TabIndex = 0;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(179, 142);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(131, 44);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(349, 142);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(131, 44);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnConvertirABinario
            // 
            this.btnConvertirABinario.Location = new System.Drawing.Point(12, 224);
            this.btnConvertirABinario.Name = "btnConvertirABinario";
            this.btnConvertirABinario.Size = new System.Drawing.Size(231, 44);
            this.btnConvertirABinario.TabIndex = 3;
            this.btnConvertirABinario.Text = "Convertir a Binario";
            this.btnConvertirABinario.UseVisualStyleBackColor = true;
            // 
            // btnConvertirABDecimal
            // 
            this.btnConvertirABDecimal.Location = new System.Drawing.Point(249, 224);
            this.btnConvertirABDecimal.Name = "btnConvertirABDecimal";
            this.btnConvertirABDecimal.Size = new System.Drawing.Size(231, 44);
            this.btnConvertirABDecimal.TabIndex = 4;
            this.btnConvertirABDecimal.Text = "Convertir a Decimal";
            this.btnConvertirABDecimal.UseVisualStyleBackColor = true;
            // 
            // BoxLista
            // 
            this.BoxLista.FormattingEnabled = true;
            this.BoxLista.ItemHeight = 15;
            this.BoxLista.Location = new System.Drawing.Point(495, 12);
            this.BoxLista.Name = "BoxLista";
            this.BoxLista.Size = new System.Drawing.Size(211, 259);
            this.BoxLista.TabIndex = 5;
            // 
            // txtNumeroUno
            // 
            this.txtNumeroUno.Location = new System.Drawing.Point(27, 47);
            this.txtNumeroUno.Name = "txtNumeroUno";
            this.txtNumeroUno.Size = new System.Drawing.Size(116, 23);
            this.txtNumeroUno.TabIndex = 6;
            // 
            // txtNumeroDos
            // 
            this.txtNumeroDos.Location = new System.Drawing.Point(349, 47);
            this.txtNumeroDos.Name = "txtNumeroDos";
            this.txtNumeroDos.Size = new System.Drawing.Size(116, 23);
            this.txtNumeroDos.TabIndex = 7;
            // 
            // BoxOperador
            // 
            this.BoxOperador.DisplayMember = "7";
            this.BoxOperador.FormattingEnabled = true;
            this.BoxOperador.Items.AddRange(new object[] {
            "",
            "*",
            "/",
            "+",
            "-"});
            this.BoxOperador.Location = new System.Drawing.Point(179, 47);
            this.BoxOperador.Name = "BoxOperador";
            this.BoxOperador.Size = new System.Drawing.Size(131, 23);
            this.BoxOperador.TabIndex = 8;
            this.BoxOperador.ValueMember = "/";
            // 
            // S
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 280);
            this.Controls.Add(this.BoxOperador);
            this.Controls.Add(this.txtNumeroDos);
            this.Controls.Add(this.txtNumeroUno);
            this.Controls.Add(this.BoxLista);
            this.Controls.Add(this.btnConvertirABDecimal);
            this.Controls.Add(this.btnConvertirABinario);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOperar);
            this.Name = "S";
            this.Text = "Calculadora de Cesar Algañaras del curso 2°D";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnConvertirABinario;
        private System.Windows.Forms.Button btnConvertirABDecimal;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtNumeroUno;
        private System.Windows.Forms.TextBox txtNumeroDos;
        private System.Windows.Forms.ComboBox BoxOperador;
        private System.Windows.Forms.ListBox BoxLista;
    }
}

