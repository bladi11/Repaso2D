
namespace Repaso2D
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
            this.textBoxplaca = new System.Windows.Forms.TextBox();
            this.textBoxmarca = new System.Windows.Forms.TextBox();
            this.textBoxmodelo = new System.Windows.Forms.TextBox();
            this.textBoxcolor = new System.Windows.Forms.TextBox();
            this.textBoxprecioxkm = new System.Windows.Forms.TextBox();
            this.buttonIngreso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAlquiler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxplaca
            // 
            this.textBoxplaca.Location = new System.Drawing.Point(131, 73);
            this.textBoxplaca.Name = "textBoxplaca";
            this.textBoxplaca.Size = new System.Drawing.Size(100, 23);
            this.textBoxplaca.TabIndex = 0;
            // 
            // textBoxmarca
            // 
            this.textBoxmarca.Location = new System.Drawing.Point(131, 132);
            this.textBoxmarca.Name = "textBoxmarca";
            this.textBoxmarca.Size = new System.Drawing.Size(100, 23);
            this.textBoxmarca.TabIndex = 1;
            // 
            // textBoxmodelo
            // 
            this.textBoxmodelo.Location = new System.Drawing.Point(131, 193);
            this.textBoxmodelo.Name = "textBoxmodelo";
            this.textBoxmodelo.Size = new System.Drawing.Size(100, 23);
            this.textBoxmodelo.TabIndex = 2;
            // 
            // textBoxcolor
            // 
            this.textBoxcolor.Location = new System.Drawing.Point(131, 253);
            this.textBoxcolor.Name = "textBoxcolor";
            this.textBoxcolor.Size = new System.Drawing.Size(100, 23);
            this.textBoxcolor.TabIndex = 3;
            // 
            // textBoxprecioxkm
            // 
            this.textBoxprecioxkm.Location = new System.Drawing.Point(131, 309);
            this.textBoxprecioxkm.Name = "textBoxprecioxkm";
            this.textBoxprecioxkm.Size = new System.Drawing.Size(100, 23);
            this.textBoxprecioxkm.TabIndex = 4;
            // 
            // buttonIngreso
            // 
            this.buttonIngreso.Location = new System.Drawing.Point(131, 375);
            this.buttonIngreso.Name = "buttonIngreso";
            this.buttonIngreso.Size = new System.Drawing.Size(100, 54);
            this.buttonIngreso.TabIndex = 5;
            this.buttonIngreso.Text = "Ingreso";
            this.buttonIngreso.UseVisualStyleBackColor = true;
            this.buttonIngreso.Click += new System.EventHandler(this.buttonIngreso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Placa";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(30, 140);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(40, 15);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Precio por km";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Control de Vehiculos";
            // 
            // buttonAlquiler
            // 
            this.buttonAlquiler.Location = new System.Drawing.Point(287, 375);
            this.buttonAlquiler.Name = "buttonAlquiler";
            this.buttonAlquiler.Size = new System.Drawing.Size(96, 54);
            this.buttonAlquiler.TabIndex = 12;
            this.buttonAlquiler.Text = "Ir a Alquiler";
            this.buttonAlquiler.UseVisualStyleBackColor = true;
            this.buttonAlquiler.Click += new System.EventHandler(this.buttonAlquiler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 488);
            this.Controls.Add(this.buttonAlquiler);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonIngreso);
            this.Controls.Add(this.textBoxprecioxkm);
            this.Controls.Add(this.textBoxcolor);
            this.Controls.Add(this.textBoxmodelo);
            this.Controls.Add(this.textBoxmarca);
            this.Controls.Add(this.textBoxplaca);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxplaca;
        private System.Windows.Forms.TextBox textBoxmarca;
        private System.Windows.Forms.TextBox textBoxmodelo;
        private System.Windows.Forms.TextBox textBoxcolor;
        private System.Windows.Forms.TextBox textBoxprecioxkm;
        private System.Windows.Forms.Button buttonIngreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAlquiler;
    }
}

