using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celsius_Fahrenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtOriginal_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.cboTipoConversao.SelectedIndex == 0)
            {
                float celsius = 0;
                if (float.TryParse(txtOriginal.Text, out celsius))
                {
                    float fahrenheit = (float)(celsius * 1.8 + 32);
                    txtConvertido.Text = $"{fahrenheit:N2}";
                }
                else
                {
                    MessageBox.Show("Valor inválido");
                    txtConvertido.Text = "";
                }
            }
            else if (this.cboTipoConversao.SelectedIndex == 1)
            {
                {
                    float fahrenheit = 0;
                    if (float.TryParse(txtOriginal.Text, out fahrenheit))
                    {
                        //TC/5 = (TF – 32)/9
                        float celsius = (float)((fahrenheit - 32) / 9) * 5;
                        txtConvertido.Text = $"{celsius:N2}";
                    }
                    else
                    {
                        MessageBox.Show("Valor inválido");
                        txtConvertido.Text = " ";
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione o tipo de conversão");
            }
            }

            }
        }
    