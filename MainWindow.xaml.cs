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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace ATVD01E02
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btnEntrar_Click(object sender, RoutedEventArgs e)
        {
            
            if (txtbId.Text != "") 
            {
                if (pbSenha.Password != "")
                {
                    WinCalcImc win = new WinCalcImc();
                    win.Show();
                }
                else { MessageBox.Show("Por favor Insire a Senha"); }

            }
            else { MessageBox.Show("Por favor Insira o ID"); }
        }
    }
}
