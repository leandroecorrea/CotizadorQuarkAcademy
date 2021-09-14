
namespace Punto1_Quark
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
            this.CamisaButton = new System.Windows.Forms.RadioButton();
            this.PantalonButton = new System.Windows.Forms.RadioButton();
            this.MangaCortaCheck = new System.Windows.Forms.CheckBox();
            this.CuelloMaoCheck = new System.Windows.Forms.CheckBox();
            this.ChupinCheck = new System.Windows.Forms.CheckBox();
            this.CalidadButton = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.gbSpecsPrenda = new System.Windows.Forms.GroupBox();
            this.gbPrenda = new System.Windows.Forms.GroupBox();
            this.gbQuality = new System.Windows.Forms.GroupBox();
            this.Stock = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNombreTienda = new System.Windows.Forms.Label();
            this.lblDireccionTienda = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.lblNombreVendedor = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.MisCotizaciones = new System.Windows.Forms.Label();
            this.lblIDVendedor = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gbStock = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbPriceQuantity = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gbSpecsPrenda.SuspendLayout();
            this.gbPrenda.SuspendLayout();
            this.gbQuality.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.gbStock.SuspendLayout();
            this.gbPriceQuantity.SuspendLayout();
            this.SuspendLayout();
            // 
            // CamisaButton
            // 
            this.CamisaButton.AutoSize = true;
            this.CamisaButton.Checked = true;
            this.CamisaButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CamisaButton.Location = new System.Drawing.Point(3, 21);
            this.CamisaButton.Name = "CamisaButton";
            this.CamisaButton.Padding = new System.Windows.Forms.Padding(50, 0, 0, 20);
            this.CamisaButton.Size = new System.Drawing.Size(194, 39);
            this.CamisaButton.TabIndex = 1;
            this.CamisaButton.TabStop = true;
            this.CamisaButton.Text = "Camisa";
            this.CamisaButton.UseVisualStyleBackColor = true;
            // 
            // PantalonButton
            // 
            this.PantalonButton.AutoSize = true;
            this.PantalonButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PantalonButton.Location = new System.Drawing.Point(3, 60);
            this.PantalonButton.Name = "PantalonButton";
            this.PantalonButton.Padding = new System.Windows.Forms.Padding(50, 0, 0, 20);
            this.PantalonButton.Size = new System.Drawing.Size(194, 39);
            this.PantalonButton.TabIndex = 2;
            this.PantalonButton.Text = "Pantalon";
            this.PantalonButton.UseVisualStyleBackColor = true;
            this.PantalonButton.CheckedChanged += new System.EventHandler(this.PantalonButton_CheckedChanged);
            // 
            // MangaCortaCheck
            // 
            this.MangaCortaCheck.AutoSize = true;
            this.MangaCortaCheck.Location = new System.Drawing.Point(15, 22);
            this.MangaCortaCheck.Name = "MangaCortaCheck";
            this.MangaCortaCheck.Size = new System.Drawing.Size(93, 19);
            this.MangaCortaCheck.TabIndex = 3;
            this.MangaCortaCheck.Text = "Manga corta";
            this.MangaCortaCheck.UseVisualStyleBackColor = true;
            this.MangaCortaCheck.CheckedChanged += new System.EventHandler(this.MangaCortaCheck_CheckedChanged);
            // 
            // CuelloMaoCheck
            // 
            this.CuelloMaoCheck.AutoSize = true;
            this.CuelloMaoCheck.Location = new System.Drawing.Point(114, 22);
            this.CuelloMaoCheck.Name = "CuelloMaoCheck";
            this.CuelloMaoCheck.Size = new System.Drawing.Size(87, 19);
            this.CuelloMaoCheck.TabIndex = 4;
            this.CuelloMaoCheck.Text = "Cuello mao";
            this.CuelloMaoCheck.UseVisualStyleBackColor = true;
            this.CuelloMaoCheck.CheckedChanged += new System.EventHandler(this.CuelloMaoCheck_CheckedChanged);
            // 
            // ChupinCheck
            // 
            this.ChupinCheck.AutoSize = true;
            this.ChupinCheck.Location = new System.Drawing.Point(15, 60);
            this.ChupinCheck.Name = "ChupinCheck";
            this.ChupinCheck.Size = new System.Drawing.Size(65, 19);
            this.ChupinCheck.TabIndex = 5;
            this.ChupinCheck.Text = "Chupin";
            this.ChupinCheck.UseVisualStyleBackColor = true;
            this.ChupinCheck.CheckedChanged += new System.EventHandler(this.ChupinCheck_CheckedChanged);
            // 
            // CalidadButton
            // 
            this.CalidadButton.AutoSize = true;
            this.CalidadButton.Checked = true;
            this.CalidadButton.Location = new System.Drawing.Point(19, 40);
            this.CalidadButton.Name = "CalidadButton";
            this.CalidadButton.Size = new System.Drawing.Size(72, 19);
            this.CalidadButton.TabIndex = 7;
            this.CalidadButton.TabStop = true;
            this.CalidadButton.Text = "Standard";
            this.CalidadButton.UseVisualStyleBackColor = true;
            this.CalidadButton.CheckedChanged += new System.EventHandler(this.CalidadButton_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(97, 40);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(74, 19);
            this.radioButton4.TabIndex = 8;
            this.radioButton4.Text = "Premium";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(31, 36);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(53, 29);
            this.textBox3.TabIndex = 9;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Prenda";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(167, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(46, 29);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "$";
            // 
            // btnCotizar
            // 
            this.btnCotizar.BackColor = System.Drawing.Color.Indigo;
            this.btnCotizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCotizar.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCotizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCotizar.Location = new System.Drawing.Point(9, 501);
            this.btnCotizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(143, 71);
            this.btnCotizar.TabIndex = 16;
            this.btnCotizar.Text = "Cotizar";
            this.btnCotizar.UseVisualStyleBackColor = false;
            this.btnCotizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(195, 520);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 32);
            this.label6.TabIndex = 17;
            // 
            // gbSpecsPrenda
            // 
            this.gbSpecsPrenda.Controls.Add(this.ChupinCheck);
            this.gbSpecsPrenda.Controls.Add(this.CuelloMaoCheck);
            this.gbSpecsPrenda.Controls.Add(this.MangaCortaCheck);
            this.gbSpecsPrenda.Location = new System.Drawing.Point(227, 207);
            this.gbSpecsPrenda.Name = "gbSpecsPrenda";
            this.gbSpecsPrenda.Size = new System.Drawing.Size(219, 102);
            this.gbSpecsPrenda.TabIndex = 18;
            this.gbSpecsPrenda.TabStop = false;
            // 
            // gbPrenda
            // 
            this.gbPrenda.Controls.Add(this.CamisaButton);
            this.gbPrenda.Controls.Add(this.PantalonButton);
            this.gbPrenda.Controls.Add(this.label2);
            this.gbPrenda.Location = new System.Drawing.Point(14, 207);
            this.gbPrenda.Name = "gbPrenda";
            this.gbPrenda.Size = new System.Drawing.Size(200, 102);
            this.gbPrenda.TabIndex = 5;
            this.gbPrenda.TabStop = false;
            // 
            // gbQuality
            // 
            this.gbQuality.Controls.Add(this.CalidadButton);
            this.gbQuality.Controls.Add(this.radioButton4);
            this.gbQuality.Location = new System.Drawing.Point(14, 373);
            this.gbQuality.Name = "gbQuality";
            this.gbQuality.Size = new System.Drawing.Size(200, 89);
            this.gbQuality.TabIndex = 20;
            this.gbQuality.TabStop = false;
            this.gbQuality.Text = "Calidad de prenda";
            // 
            // Stock
            // 
            this.Stock.AutoSize = true;
            this.Stock.Dock = System.Windows.Forms.DockStyle.Right;
            this.Stock.Location = new System.Drawing.Point(174, 19);
            this.Stock.Name = "Stock";
            this.Stock.Padding = new System.Windows.Forms.Padding(0, 0, 220, 0);
            this.Stock.Size = new System.Drawing.Size(255, 15);
            this.Stock.TabIndex = 22;
            this.Stock.Text = "stock";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(471, 100);
            this.panel1.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(110, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cotizador Express";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombreTienda
            // 
            this.lblNombreTienda.AutoSize = true;
            this.lblNombreTienda.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNombreTienda.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombreTienda.ForeColor = System.Drawing.Color.Indigo;
            this.lblNombreTienda.Location = new System.Drawing.Point(0, 100);
            this.lblNombreTienda.Name = "lblNombreTienda";
            this.lblNombreTienda.Padding = new System.Windows.Forms.Padding(25, 16, 0, 0);
            this.lblNombreTienda.Size = new System.Drawing.Size(112, 31);
            this.lblNombreTienda.TabIndex = 25;
            this.lblNombreTienda.Text = "NombreTienda";
            // 
            // lblDireccionTienda
            // 
            this.lblDireccionTienda.AutoSize = true;
            this.lblDireccionTienda.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDireccionTienda.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDireccionTienda.ForeColor = System.Drawing.Color.Indigo;
            this.lblDireccionTienda.Location = new System.Drawing.Point(352, 100);
            this.lblDireccionTienda.Name = "lblDireccionTienda";
            this.lblDireccionTienda.Padding = new System.Windows.Forms.Padding(0, 16, 25, 0);
            this.lblDireccionTienda.Size = new System.Drawing.Size(119, 31);
            this.lblDireccionTienda.TabIndex = 26;
            this.lblDireccionTienda.Text = "DireccionTienda";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.ForeColor = System.Drawing.Color.Indigo;
            this.panel2.Location = new System.Drawing.Point(0, 581);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(470, 2);
            this.panel2.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.ForeColor = System.Drawing.Color.Indigo;
            this.panel3.Location = new System.Drawing.Point(0, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(470, 2);
            this.panel3.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.ForeColor = System.Drawing.Color.Indigo;
            this.panel4.Location = new System.Drawing.Point(0, 493);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(470, 2);
            this.panel4.TabIndex = 28;
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHistorial.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblHistorial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblHistorial.ForeColor = System.Drawing.Color.Navy;
            this.lblHistorial.Location = new System.Drawing.Point(324, 16);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.lblHistorial.Size = new System.Drawing.Size(146, 15);
            this.lblHistorial.TabIndex = 30;
            this.lblHistorial.Text = "Historial Cotizaciones";
            this.lblHistorial.Click += new System.EventHandler(this.HistorialCotizaciones_Click);
            // 
            // lblNombreVendedor
            // 
            this.lblNombreVendedor.AutoSize = true;
            this.lblNombreVendedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNombreVendedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNombreVendedor.ForeColor = System.Drawing.Color.Navy;
            this.lblNombreVendedor.Location = new System.Drawing.Point(0, 16);
            this.lblNombreVendedor.Margin = new System.Windows.Forms.Padding(0);
            this.lblNombreVendedor.Name = "lblNombreVendedor";
            this.lblNombreVendedor.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.lblNombreVendedor.Size = new System.Drawing.Size(126, 15);
            this.lblNombreVendedor.TabIndex = 31;
            this.lblNombreVendedor.Text = "NombreVendedor";
            this.lblNombreVendedor.Click += new System.EventHandler(this.NombreVendedor_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.MisCotizaciones);
            this.groupBox5.Controls.Add(this.lblIDVendedor);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.lblNombreVendedor);
            this.groupBox5.Controls.Add(this.lblHistorial);
            this.groupBox5.Location = new System.Drawing.Point(0, 133);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox5.Size = new System.Drawing.Size(470, 39);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            // 
            // MisCotizaciones
            // 
            this.MisCotizaciones.AutoSize = true;
            this.MisCotizaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MisCotizaciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.MisCotizaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MisCotizaciones.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.MisCotizaciones.ForeColor = System.Drawing.Color.Navy;
            this.MisCotizaciones.Location = new System.Drawing.Point(203, 16);
            this.MisCotizaciones.Name = "MisCotizaciones";
            this.MisCotizaciones.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.MisCotizaciones.Size = new System.Drawing.Size(121, 15);
            this.MisCotizaciones.TabIndex = 35;
            this.MisCotizaciones.Text = "Mis Cotizaciones";
            this.MisCotizaciones.Click += new System.EventHandler(this.MisCotizaciones_Click);
            // 
            // lblIDVendedor
            // 
            this.lblIDVendedor.AutoSize = true;
            this.lblIDVendedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblIDVendedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblIDVendedor.ForeColor = System.Drawing.Color.Navy;
            this.lblIDVendedor.Location = new System.Drawing.Point(151, 16);
            this.lblIDVendedor.Margin = new System.Windows.Forms.Padding(0);
            this.lblIDVendedor.Name = "lblIDVendedor";
            this.lblIDVendedor.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblIDVendedor.Size = new System.Drawing.Size(33, 15);
            this.lblIDVendedor.TabIndex = 34;
            this.lblIDVendedor.Text = "ID";
            this.lblIDVendedor.Click += new System.EventHandler(this.CodigoVendedor_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.Location = new System.Drawing.Point(126, 16);
            this.label10.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(15, 0, 0, 3);
            this.label10.Size = new System.Drawing.Size(25, 18);
            this.label10.TabIndex = 32;
            this.label10.Text = "|";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbStock
            // 
            this.gbStock.Controls.Add(this.label7);
            this.gbStock.Controls.Add(this.Stock);
            this.gbStock.Location = new System.Drawing.Point(14, 312);
            this.gbStock.Name = "gbStock";
            this.gbStock.Size = new System.Drawing.Size(432, 45);
            this.gbStock.TabIndex = 33;
            this.gbStock.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Unidades de stock disponibles: ";
            // 
            // gbPriceQuantity
            // 
            this.gbPriceQuantity.Controls.Add(this.textBox1);
            this.gbPriceQuantity.Controls.Add(this.label5);
            this.gbPriceQuantity.Controls.Add(this.label4);
            this.gbPriceQuantity.Controls.Add(this.textBox3);
            this.gbPriceQuantity.Location = new System.Drawing.Point(227, 373);
            this.gbPriceQuantity.Name = "gbPriceQuantity";
            this.gbPriceQuantity.Size = new System.Drawing.Size(219, 89);
            this.gbPriceQuantity.TabIndex = 9;
            this.gbPriceQuantity.TabStop = false;
            this.gbPriceQuantity.Text = "Precio unitario y cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(162, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 32);
            this.label1.TabIndex = 34;
            this.label1.Text = "$";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.ForeColor = System.Drawing.Color.Indigo;
            this.panel5.Location = new System.Drawing.Point(195, 555);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(167, 2);
            this.panel5.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(471, 582);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbPriceQuantity);
            this.Controls.Add(this.gbStock);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblDireccionTienda);
            this.Controls.Add(this.lblNombreTienda);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbQuality);
            this.Controls.Add(this.gbPrenda);
            this.Controls.Add(this.gbSpecsPrenda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCotizar);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Cotizador Express";
            this.gbSpecsPrenda.ResumeLayout(false);
            this.gbSpecsPrenda.PerformLayout();
            this.gbPrenda.ResumeLayout(false);
            this.gbPrenda.PerformLayout();
            this.gbQuality.ResumeLayout(false);
            this.gbQuality.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.gbStock.ResumeLayout(false);
            this.gbStock.PerformLayout();
            this.gbPriceQuantity.ResumeLayout(false);
            this.gbPriceQuantity.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton CamisaButton;
        private System.Windows.Forms.RadioButton PantalonButton;
        private System.Windows.Forms.CheckBox MangaCortaCheck;
        private System.Windows.Forms.CheckBox CuelloMaoCheck;
        private System.Windows.Forms.CheckBox ChupinCheck;
        private System.Windows.Forms.RadioButton CalidadButton;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCotizar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbSpecsPrenda;
        private System.Windows.Forms.GroupBox gbPrenda;
        private System.Windows.Forms.GroupBox gbQuality;
        private System.Windows.Forms.Label Stock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNombreTienda;
        private System.Windows.Forms.Label lblDireccionTienda;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.Label lblNombreVendedor;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblIDVendedor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbPriceQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label MisCotizaciones;
    }
}

