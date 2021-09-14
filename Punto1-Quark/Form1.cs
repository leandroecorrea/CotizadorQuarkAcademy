using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto1_Quark
{
    public partial class Form1 : Form
    {
        private Tienda tienda;        
        private Prenda prendaACotizar;
        public static string loginName;
        public static string loginLastName;
        public static int loginID;

        public Form1(Tienda tienda)
        {
            InitializeComponent();
            this.tienda = tienda;
            if (new Form3().ShowDialog() != DialogResult.OK)
            {
                Environment.Exit(0);
            }
            this.tienda.Vendedor = new Vendedor(loginID, loginName, loginLastName, tienda.AllCotizaciones());
            UpdatePrenda();
            lblNombreTienda.Text = this.tienda.Name;
            lblDireccionTienda.Text = this.tienda.Address;
            lblNombreVendedor.Text = tienda.Vendedor.NombreYApellido;
            lblIDVendedor.Text = "ID: " + Convert.ToString(tienda.Vendedor.IDVendedor);
            AcceptButton = btnCotizar;            
        }       

        private void UpdatePrenda()
        {
            if (CamisaButton.Checked)
            {
                prendaACotizar = new Camisa();
                ((Camisa)prendaACotizar).MangaCamisa = MangaCortaCheck.Checked ? Camisa.Manga.Corta : Camisa.Manga.Larga;
                ((Camisa)prendaACotizar).CuelloCamisa = CuelloMaoCheck.Checked ? Camisa.Cuello.Mao : Camisa.Cuello.Comun;
                ((Camisa)prendaACotizar).Quality = CalidadButton.Checked ? Prenda.Calidad.Standard : Prenda.Calidad.Premium;
            }
            else
            {
                prendaACotizar = new Pantalon();
                ((Pantalon)prendaACotizar).CortePantalon = ChupinCheck.Checked ? Pantalon.Corte.Chupin : Pantalon.Corte.Comun;
                ((Pantalon)prendaACotizar).Quality = CalidadButton.Checked ? Prenda.Calidad.Standard : Prenda.Calidad.Premium;
            }
            UpdateStock(prendaACotizar);
        }

        private void UpdateStock(Prenda prenda)
        {
            Stock.Text = Convert.ToString(tienda.StockChecker(prenda));
        }

        private void MangaCortaCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (prendaACotizar is Camisa)
            {
                ((Camisa)prendaACotizar).MangaCamisa = MangaCortaCheck.Checked ? Camisa.Manga.Corta : Camisa.Manga.Larga;
                UpdateStock(prendaACotizar);
            }
            else
            {
                CamisaButton.Checked = true;
            }
        }

        private void CuelloMaoCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (prendaACotizar is Camisa)
            {
                ((Camisa)prendaACotizar).CuelloCamisa = CuelloMaoCheck.Checked ? Camisa.Cuello.Mao : Camisa.Cuello.Comun;
                UpdateStock(prendaACotizar);
            }
            else
            {
                CamisaButton.Checked = true;
            }
        }

        private void PantalonButton_CheckedChanged(object sender, EventArgs e)
        {
            MangaCortaCheck.Checked = false;
            CuelloMaoCheck.Checked = false;
            ChupinCheck.Checked = false;
            UpdatePrenda();
        }

        private void ChupinCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (prendaACotizar is Pantalon)
            {
                ((Pantalon)prendaACotizar).CortePantalon = ChupinCheck.Checked ? Pantalon.Corte.Chupin : Pantalon.Corte.Comun;
                UpdateStock(prendaACotizar);
            }
            else
            {
                PantalonButton.Checked = true;
            }

        }

        private void CalidadButton_CheckedChanged(object sender, EventArgs e)
        {
            ResetFields();
            prendaACotizar.Quality = CalidadButton.Checked ? Prenda.Calidad.Standard : Prenda.Calidad.Premium;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(textBox1.Text + " + " + label6.Text);
            if (textBox1.Text != "" && textBox3.Text != "")
            {
                try
                {
                    if (Convert.ToInt32(textBox1.Text) > Convert.ToInt32(Stock.Text))
                    {
                        MessageBox.Show("El stock de la prenda es inferior a la cantidad que se intenta cotizar");
                    }
                    else
                    {
                        prendaACotizar.Price = Convert.ToInt32(textBox3.Text);
                        int unidades = Convert.ToInt32(textBox1.Text);
                        prendaACotizar.SetName();
                        Cotizacion cotizacion = tienda.Vendedor.CrearCotizacion(prendaACotizar, unidades, tienda.IDCotizacion());
                        label6.Text = cotizacion.TotalCotizacion.ToString("0.00");
                        MessageBox.Show($"Creada la cotización número: { Convert.ToString(cotizacion.IDCotizacion)}\n" +
                            $"Vendedor: {tienda.Vendedor.NombreYApellido}\n" +
                            $"Prenda: {cotizacion.PrendaCotizada.PrendaName()}\n" +
                            $"Precio unitario: {cotizacion.PrendaCotizada.Price}\n" +
                            $"Total: {cotizacion.TotalCotizacion}");
                        ResetFields();
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Debe ingresar números para que se lleve a cabo la cotización");
                }
            }
            else
            {
                MessageBox.Show("Debe indicar precio y cantidad a cotizar");
            }
        }        

        private void HistorialCotizaciones_Click(object sender, EventArgs e)
        {
            new Form2(tienda.AllCotizaciones()).ShowDialog();
        }

        private void NombreVendedor_Click(object sender, EventArgs e)
        {
            NewLogin();
        }

        private void CodigoVendedor_Click(object sender, EventArgs e)
        {
            NewLogin();
        }

        private void NewLogin()
        {            
            if (new Form3().ShowDialog() == DialogResult.OK)
            {
                tienda.Vendedor = new Vendedor(loginID, loginName, loginLastName, tienda.AllCotizaciones());
            }
            lblNombreVendedor.Text = tienda.Vendedor.NombreYApellido;
            lblIDVendedor.Text = "ID: " + Convert.ToString(tienda.Vendedor.IDVendedor);
        }

        private void MisCotizaciones_Click(object sender, EventArgs e)
        {
            new Form2(tienda.Vendedor.cotizacionList).ShowDialog();
        }

        private void ResetFields()
        {            
            label6.Text = "";
            textBox1.Text = "";
            textBox3.Text = "";
            ChupinCheck.Checked = false;
            CuelloMaoCheck.Checked = false;
            MangaCortaCheck.Checked = false;
        }        
    }
}
