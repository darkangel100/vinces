namespace Analisis2
{
    partial class Reporte_Compras
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(259, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 28);
            this.button2.TabIndex = 64;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(422, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 28);
            this.button1.TabIndex = 63;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CI,
            this.Genero,
            this.Column1,
            this.Nombre,
            this.Apellidos,
            this.Direccion,
            this.Telefono});
            this.dataGridView1.Location = new System.Drawing.Point(12, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(597, 224);
            this.dataGridView1.TabIndex = 65;
            // 
            // CI
            // 
            this.CI.HeaderText = "Nro_Fact";
            this.CI.Name = "CI";
            this.CI.Width = 80;
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Codg_Prod";
            this.Genero.Name = "Genero";
            this.Genero.Width = 80;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fecha";
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Cantidad";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 60;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Descripcion";
            this.Apellidos.Name = "Apellidos";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Precio_Unit";
            this.Direccion.Name = "Direccion";
            this.Direccion.Width = 80;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Precio_Tot";
            this.Telefono.Name = "Telefono";
            this.Telefono.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Hasta";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(95, 20);
            this.textBox1.TabIndex = 68;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(274, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(95, 20);
            this.textBox2.TabIndex = 69;
            // 
            // Reporte_Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(635, 371);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Reporte_Compras";
            this.Text = "Reporte_Compras";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}