using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ATVD01E02
{
    /// <summary>
    /// Lógica interna para WinCalcImc.xaml
    /// </summary>
    public partial class WinCalcImc : Window
    {
        public WinCalcImc()
        {
            InitializeComponent();
        }

        private void btnCalcImc_Click(object sender, RoutedEventArgs e)
        {
            double altura, peso, imc;

            altura = Convert.ToDouble(txtbAltura.Text);
            peso = Convert.ToDouble(txtbPeso.Text);
            imc = peso / (altura*altura);

           if (imc > 40) 
            {
                    MessageBox.Show("Obesidade grau 3!");
            }
            else 
            {
                if (imc >= 35 && imc <= 40)
                {
                    MessageBox.Show("Obesidade grau 2!");
                }
                else 
                {
                    if (imc >= 30 && imc <= 34.9)
                    {
                        MessageBox.Show("Obesidade grau 1!");
                    }
                    else 
                    { 
                        if (imc >=25 && imc <= 29.9) 
                        {
                            MessageBox.Show("Você esta acima do peso!");
                        }
                        else
                        {
                            if (imc >= 18.5 && imc<=24.9)
                            {
                                MessageBox.Show("Seu peso está normal!");
                            }
                            else 
                            { 
                                if(imc >= 17 && imc <= 18.4) 
                                {
                                    MessageBox.Show("Você esta abaixo do peso!");
                                }
                                else
                                {
                                    if (imc <= 16.9) { MessageBox.Show("Você está muito abaixo do peso!");}
                                }
                            }
                        }
                    }
                }
            }


            
        }

        private void btnLimpar_Click(object sender, RoutedEventArgs e)
        {
            txtbAltura.Clear();
            txtbPeso.Clear();
        }
    }
}
