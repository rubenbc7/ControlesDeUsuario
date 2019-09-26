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

namespace ControlesDeUsuario
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CbFigura_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            grdParametrosFigura.Children.Clear();
            switch (cbFigura.SelectedIndex)
            {
                case 0:
                    grdParametrosFigura.Children.Add(new ParametrosCirculo());
                    break;
                case 1:
                    grdParametrosFigura.Children.Add(new ParametrosTriangulo());
                    break;
                case 2:
                    grdParametrosFigura.Children.Add(new ParametrosRectangulo());
                    break;
                case 3:
                    grdParametrosFigura.Children.Add(new Pentagono());
                    break;
                case 4:
                    grdParametrosFigura.Children.Add(new ParametrosCuadrado());
                    break;
                case 5:
                    grdParametrosFigura.Children.Add(new ParametrosTrapecio());
                    break;
                default:
                    break;
            }
        }

        private void BtnCalcular_Click(object sender, RoutedEventArgs e)
        {
            double area = 0.0;
            switch (cbFigura.SelectedIndex)
            {
                case 0: double radio = double.Parse(((ParametrosCirculo)(grdParametrosFigura.Children[0])).txtRadio.Text);
                    area = (radio * radio) * Math.PI;
                    break;
                case 1:
                    double Base = double.Parse(((ParametrosTriangulo)(grdParametrosFigura.Children[0])).txtBasetri.Text);
                    double altura = double.Parse(((ParametrosTriangulo)(grdParametrosFigura.Children[0])).txtAlturatri.Text);
                    area = (Base * altura)/2;
                    break;
                case 2:
                    double Baserec = double.Parse(((ParametrosRectangulo)(grdParametrosFigura.Children[0])).txtBaserec.Text);
                    double alturarec = double.Parse(((ParametrosRectangulo)(grdParametrosFigura.Children[0])).txtAlturaRec.Text);
                    area = Baserec * alturarec;
                    break;
                case 3:
                    double Perimetro = double.Parse(((Pentagono)(grdParametrosFigura.Children[0])).txtPeri.Text);
                    double Apotema = double.Parse(((Pentagono)(grdParametrosFigura.Children[0])).txtApo.Text);
                    area = (Apotema * Perimetro)/2;
                    break;
                case 4:
                    double lateral = double.Parse(((ParametrosCuadrado)(grdParametrosFigura.Children[0])).txtLateral.Text);
                    area = (lateral * lateral) ;
                    break;
                case 5:
                    double BaseM = double.Parse(((ParametrosTrapecio)(grdParametrosFigura.Children[0])).txtBaseM.Text);
                    double Basem = double.Parse(((ParametrosTrapecio)(grdParametrosFigura.Children[0])).txtBasem.Text);
                    double Altutra = double.Parse(((ParametrosTrapecio)(grdParametrosFigura.Children[0])).txtAltutra.Text);
                    area = ((BaseM + Basem)*(Altutra))/ 2;
                    break;

                default:
                    break;
            }
            txtResultado.Text = area.ToString();
        }
    }
}
