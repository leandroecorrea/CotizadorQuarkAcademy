using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Punto1_Quark
{
    public partial class Form2 : Form
    {
        private List<Cotizacion> cotizaciones;
        public Form2(List<Cotizacion> cotizaciones)
        {
            this.cotizaciones = cotizaciones;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {        
            if (cotizaciones != null)
            {
                for (int i = 0; i < cotizaciones.Count; i++)
                {                                    
                    dataGridView1.Rows.Add();                    
                    dataGridView1.Rows[i].Cells[0].Value = cotizaciones[i].IDCotizacion;                    
                    dataGridView1.Rows[i].Cells[1].Value = cotizaciones[i].IDVendedor;
                    dataGridView1.Rows[i].Cells[2].Value = cotizaciones[i].PrendaName;
                    dataGridView1.Rows[i].Cells[3].Value = cotizaciones[i].Units;
                    dataGridView1.Rows[i].Cells[4].Value = cotizaciones[i].TotalCotizacion;
                    dataGridView1.Rows[i].Cells[5].Value = cotizaciones[i].CotizacionDate;
                }
            }            
        }
    }
}
