
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
            this.btnConverBinario = new System.Windows.Forms.Button();
            this.btnConverDecimal = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtOperandoUno = new System.Windows.Forms.TextBox();
            this.txtOperandoDos = new System.Windows.Forms.TextBox();
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
            // btnConverBinario
            // 
            this.btnConverBinario.Location = new System.Drawing.Point(12, 224);
            this.btnConverBinario.Name = "btnConverBinario";
            this.btnConverBinario.Size = new System.Drawing.Size(231, 44);
            this.btnConverBinario.TabIndex = 3;
            this.btnConverBinario.Text = "Convertir a Binario";
            this.btnConverBinario.UseVisualStyleBackColor = true;
            // 
            // btnConverDecimal
            // 
            this.btnConverDecimal.Location = new System.Drawing.Point(249, 224);
            this.btnConverDecimal.Name = "btnConverDecimal";
            this.btnConverDecimal.Size = new System.Drawing.Size(231, 44);
            this.btnConverDecimal.TabIndex = 4;
            this.btnConverDecimal.Text = "Convertir a Decimal";
            this.btnConverDecimal.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(495, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 259);
            this.listBox1.TabIndex = 5;
            // 
            // txtOperandoUno
            // 
            this.txtOperandoUno.Location = new System.Drawing.Point(27, 47);
            this.txtOperandoUno.Name = "txtOperandoUno";
            this.txtOperandoUno.Size = new System.Drawing.Size(116, 23);
            this.txtOperandoUno.TabIndex = 6;
            // 
            // txtOperandoDos
            // 
            this.txtOperandoDos.Location = new System.Drawing.Point(349, 47);
            this.txtOperandoDos.Name = "txtOperandoDos";
            this.txtOperandoDos.Size = new System.Drawing.Size(116, 23);
            this.txtOperandoDos.TabIndex = 7;
            // 
            // BoxOperador
            // 
            this.BoxOperador.DisplayMember = "7";
            this.BoxOperador.FormattingEnabled = true;
            this.BoxOperador.Items.AddRange(new object[] {
            "/",
            "*",
            "-",
            "+"});
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
            this.Controls.Add(this.txtOperandoDos);
            this.Controls.Add(this.txtOperandoUno);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnConverDecimal);
            this.Controls.Add(this.btnConverBinario);
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
        private System.Windows.Forms.Button btnConverBinario;
        private System.Windows.Forms.Button btnConverDecimal;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtOperandoUno;
        private System.Windows.Forms.TextBox txtOperandoDos;
        private System.Windows.Forms.ComboBox BoxOperador;
    }
}

