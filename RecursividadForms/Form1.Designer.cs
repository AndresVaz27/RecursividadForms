namespace RecursividadForms
{
    partial class Form1
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
            this.btnSeleccionarUSB = new System.Windows.Forms.Button();
            this.textBoxRutaUSB = new System.Windows.Forms.TextBox();
            this.listBoxContenido = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSeleccionarUSB
            // 
            this.btnSeleccionarUSB.Location = new System.Drawing.Point(12, 26);
            this.btnSeleccionarUSB.Name = "btnSeleccionarUSB";
            this.btnSeleccionarUSB.Size = new System.Drawing.Size(123, 37);
            this.btnSeleccionarUSB.TabIndex = 0;
            this.btnSeleccionarUSB.Text = "Seleccionar Carpeta";
            this.btnSeleccionarUSB.UseVisualStyleBackColor = true;
            this.btnSeleccionarUSB.Click += new System.EventHandler(this.btnSeleccionarUSB_Click);
            // 
            // textBoxRutaUSB
            // 
            this.textBoxRutaUSB.Location = new System.Drawing.Point(167, 33);
            this.textBoxRutaUSB.Name = "textBoxRutaUSB";
            this.textBoxRutaUSB.Size = new System.Drawing.Size(498, 22);
            this.textBoxRutaUSB.TabIndex = 1;
            // 
            // listBoxContenido
            // 
            this.listBoxContenido.FormattingEnabled = true;
            this.listBoxContenido.ItemHeight = 16;
            this.listBoxContenido.Location = new System.Drawing.Point(12, 69);
            this.listBoxContenido.Name = "listBoxContenido";
            this.listBoxContenido.Size = new System.Drawing.Size(653, 628);
            this.listBoxContenido.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 708);
            this.Controls.Add(this.listBoxContenido);
            this.Controls.Add(this.textBoxRutaUSB);
            this.Controls.Add(this.btnSeleccionarUSB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeleccionarUSB;
        private System.Windows.Forms.TextBox textBoxRutaUSB;
        private System.Windows.Forms.ListBox listBoxContenido;
    }
}

