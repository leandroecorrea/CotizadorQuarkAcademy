
namespace Punto1_Quark
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePrenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadesCotizadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCotizacion,
            this.IDVendedor,
            this.nombrePrenda,
            this.unidadesCotizadas,
            this.Cotizacion,
            this.FechaCotizacion});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(685, 422);
            this.dataGridView1.TabIndex = 0;
            // 
            // idCotizacion
            // 
            this.idCotizacion.HeaderText = "IDCotizacion";
            this.idCotizacion.Name = "idCotizacion";
            this.idCotizacion.Width = 99;
            // 
            // IDVendedor
            // 
            this.IDVendedor.HeaderText = "IDVendedor";
            this.IDVendedor.Name = "IDVendedor";
            this.IDVendedor.Width = 93;
            // 
            // nombrePrenda
            // 
            this.nombrePrenda.HeaderText = "Prenda";
            this.nombrePrenda.Name = "nombrePrenda";
            this.nombrePrenda.Width = 69;
            // 
            // unidadesCotizadas
            // 
            this.unidadesCotizadas.HeaderText = "Unidades";
            this.unidadesCotizadas.Name = "unidadesCotizadas";
            this.unidadesCotizadas.Width = 81;
            // 
            // Cotizacion
            // 
            this.Cotizacion.HeaderText = "Total";
            this.Cotizacion.Name = "Cotizacion";
            this.Cotizacion.Width = 57;
            // 
            // FechaCotizacion
            // 
            this.FechaCotizacion.HeaderText = "Fecha";
            this.FechaCotizacion.Name = "FechaCotizacion";
            this.FechaCotizacion.Width = 63;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(685, 422);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Historial de cotizaciones";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePrenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadesCotizadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCotizacion;
    }
}