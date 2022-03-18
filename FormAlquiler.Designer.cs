
namespace Repaso2D
{
    partial class FormAlquiler
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
            this.textBoxnit = new System.Windows.Forms.TextBox();
            this.textBoxplaca = new System.Windows.Forms.TextBox();
            this.textBoxkilometros = new System.Windows.Forms.TextBox();
            this.dateTimePickerfechaPrestamo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDevolucion = new System.Windows.Forms.DateTimePicker();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewResumen = new System.Windows.Forms.DataGridView();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.dataGridViewAutomoviles = new System.Windows.Forms.DataGridView();
            this.dataGridViewAlquileres = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAutomoviles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlquileres)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxnit
            // 
            this.textBoxnit.Location = new System.Drawing.Point(199, 65);
            this.textBoxnit.Name = "textBoxnit";
            this.textBoxnit.Size = new System.Drawing.Size(100, 23);
            this.textBoxnit.TabIndex = 0;
            // 
            // textBoxplaca
            // 
            this.textBoxplaca.Location = new System.Drawing.Point(199, 136);
            this.textBoxplaca.Name = "textBoxplaca";
            this.textBoxplaca.Size = new System.Drawing.Size(100, 23);
            this.textBoxplaca.TabIndex = 1;
            // 
            // textBoxkilometros
            // 
            this.textBoxkilometros.Location = new System.Drawing.Point(199, 337);
            this.textBoxkilometros.Name = "textBoxkilometros";
            this.textBoxkilometros.Size = new System.Drawing.Size(100, 23);
            this.textBoxkilometros.TabIndex = 2;
            // 
            // dateTimePickerfechaPrestamo
            // 
            this.dateTimePickerfechaPrestamo.Location = new System.Drawing.Point(199, 216);
            this.dateTimePickerfechaPrestamo.Name = "dateTimePickerfechaPrestamo";
            this.dateTimePickerfechaPrestamo.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerfechaPrestamo.TabIndex = 3;
            // 
            // dateTimePickerDevolucion
            // 
            this.dateTimePickerDevolucion.Location = new System.Drawing.Point(199, 278);
            this.dateTimePickerDevolucion.Name = "dateTimePickerDevolucion";
            this.dateTimePickerDevolucion.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerDevolucion.TabIndex = 4;
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Location = new System.Drawing.Point(224, 393);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(111, 45);
            this.buttonIngresar.TabIndex = 5;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Placa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha de Alquiler";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha de Devolucion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kilometros Recorridos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Control de Alquiler";
            // 
            // dataGridViewResumen
            // 
            this.dataGridViewResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResumen.Location = new System.Drawing.Point(1100, 65);
            this.dataGridViewResumen.Name = "dataGridViewResumen";
            this.dataGridViewResumen.RowTemplate.Height = 25;
            this.dataGridViewResumen.Size = new System.Drawing.Size(274, 279);
            this.dataGridViewResumen.TabIndex = 12;
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.Cursor = System.Windows.Forms.Cursors.No;
            this.buttonMostrar.Location = new System.Drawing.Point(1166, 393);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(125, 45);
            this.buttonMostrar.TabIndex = 13;
            this.buttonMostrar.Text = "Mostrar Resumen";
            this.buttonMostrar.UseVisualStyleBackColor = true;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // dataGridViewAutomoviles
            // 
            this.dataGridViewAutomoviles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAutomoviles.Location = new System.Drawing.Point(448, 65);
            this.dataGridViewAutomoviles.Name = "dataGridViewAutomoviles";
            this.dataGridViewAutomoviles.RowTemplate.Height = 25;
            this.dataGridViewAutomoviles.Size = new System.Drawing.Size(275, 279);
            this.dataGridViewAutomoviles.TabIndex = 14;
            // 
            // dataGridViewAlquileres
            // 
            this.dataGridViewAlquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlquileres.Location = new System.Drawing.Point(749, 65);
            this.dataGridViewAlquileres.Name = "dataGridViewAlquileres";
            this.dataGridViewAlquileres.RowTemplate.Height = 25;
            this.dataGridViewAlquileres.Size = new System.Drawing.Size(324, 279);
            this.dataGridViewAlquileres.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(448, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Automoviles";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(749, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Alquileres";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1100, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Resumen";
            // 
            // FormAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 536);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridViewAlquileres);
            this.Controls.Add(this.dataGridViewAutomoviles);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.dataGridViewResumen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.dateTimePickerDevolucion);
            this.Controls.Add(this.dateTimePickerfechaPrestamo);
            this.Controls.Add(this.textBoxkilometros);
            this.Controls.Add(this.textBoxplaca);
            this.Controls.Add(this.textBoxnit);
            this.Name = "FormAlquiler";
            this.Text = "FormAlquiler";
            this.Load += new System.EventHandler(this.FormAlquiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAutomoviles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlquileres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxnit;
        private System.Windows.Forms.TextBox textBoxplaca;
        private System.Windows.Forms.TextBox textBoxkilometros;
        private System.Windows.Forms.DateTimePicker dateTimePickerfechaPrestamo;
        private System.Windows.Forms.DateTimePicker dateTimePickerDevolucion;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewResumen;
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.DataGridView dataGridViewAutomoviles;
        private System.Windows.Forms.DataGridView dataGridViewAlquileres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}