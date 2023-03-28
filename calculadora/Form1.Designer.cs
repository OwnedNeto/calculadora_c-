namespace calculadora
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
            this.cmbOpcciones = new System.Windows.Forms.ComboBox();
            this.txtresolver = new System.Windows.Forms.Button();
            this.txtvalor2 = new System.Windows.Forms.TextBox();
            this.txtres = new System.Windows.Forms.TextBox();
            this.txtvalor1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.valor2 = new System.Windows.Forms.Label();
            this.valor1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbOpcciones
            // 
            this.cmbOpcciones.FormattingEnabled = true;
            this.cmbOpcciones.Items.AddRange(new object[] {
            "suma",
            "resta",
            "multiplicacion",
            "division"});
            this.cmbOpcciones.Location = new System.Drawing.Point(336, 83);
            this.cmbOpcciones.Name = "cmbOpcciones";
            this.cmbOpcciones.Size = new System.Drawing.Size(121, 23);
            this.cmbOpcciones.TabIndex = 15;
            // 
            // txtresolver
            // 
            this.txtresolver.Location = new System.Drawing.Point(336, 283);
            this.txtresolver.Name = "txtresolver";
            this.txtresolver.Size = new System.Drawing.Size(138, 75);
            this.txtresolver.TabIndex = 14;
            this.txtresolver.Text = "resultado";
            this.txtresolver.UseVisualStyleBackColor = true;
            this.txtresolver.Click += new System.EventHandler(this.txtresolver_Click);
            // 
            // txtvalor2
            // 
            this.txtvalor2.Location = new System.Drawing.Point(344, 170);
            this.txtvalor2.Name = "txtvalor2";
            this.txtvalor2.Size = new System.Drawing.Size(100, 23);
            this.txtvalor2.TabIndex = 13;
            // 
            // txtres
            // 
            this.txtres.Location = new System.Drawing.Point(344, 230);
            this.txtres.Name = "txtres";
            this.txtres.ReadOnly = true;
            this.txtres.Size = new System.Drawing.Size(100, 23);
            this.txtres.TabIndex = 12;
            // 
            // txtvalor1
            // 
            this.txtvalor1.Location = new System.Drawing.Point(344, 127);
            this.txtvalor1.Name = "txtvalor1";
            this.txtvalor1.Size = new System.Drawing.Size(100, 23);
            this.txtvalor1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Suma de numeros";
            // 
            // valor2
            // 
            this.valor2.AutoSize = true;
            this.valor2.Location = new System.Drawing.Point(281, 173);
            this.valor2.Name = "valor2";
            this.valor2.Size = new System.Drawing.Size(39, 15);
            this.valor2.TabIndex = 9;
            this.valor2.Text = "valor2";
            // 
            // valor1
            // 
            this.valor1.AutoSize = true;
            this.valor1.Location = new System.Drawing.Point(281, 130);
            this.valor1.Name = "valor1";
            this.valor1.Size = new System.Drawing.Size(39, 15);
            this.valor1.TabIndex = 8;
            this.valor1.Text = "valor1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbOpcciones);
            this.Controls.Add(this.txtresolver);
            this.Controls.Add(this.txtvalor2);
            this.Controls.Add(this.txtres);
            this.Controls.Add(this.txtvalor1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.valor2);
            this.Controls.Add(this.valor1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbOpcciones;
        private Button txtresolver;
        private TextBox txtvalor2;
        private TextBox txtres;
        private TextBox txtvalor1;
        private Label label3;
        private Label valor2;
        private Label valor1;
    }
}