using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Punto1_Quark
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            AcceptButton = button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");

            }
            else
            {                
                try
                {
                    if(Form1.loginID != Convert.ToInt32(textBox1.Text))
                    {
                        Form1.loginID = Convert.ToInt32(textBox1.Text);
                        Form1.loginName = textBox2.Text;
                        Form1.loginLastName = textBox3.Text;
                        this.DialogResult = DialogResult.OK;                        
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("El vendedor con ID " + textBox1.Text + " ya se encuentra activo");
                    }                    
                }
                catch (FormatException)
                {
                    MessageBox.Show("El ID del vendedor debe ser un número entero");
                }
            }            
        }
        
    }
}
