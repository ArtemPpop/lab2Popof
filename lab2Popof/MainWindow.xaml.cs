using lab2Popof.model;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab2Popof
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            double side1 = double.Parse(Firstside.Text);
            double side2 = double.Parse(Secondside.Text);
            double angle = double.Parse(AngleBetween.Text);

            Triangle triangle;

            if (RightTriangleRadioButton.IsChecked == true)
            {
                triangle = new Rightriangle(side1, side2, angle);
            }
            else if (IsoscelesTriangleRadioButton.IsChecked == true)
            {
                triangle = new IsoscelesTriangle(side1, side2, angle);
            }
            else
            {
                triangle = new EquilateralTriangle(side1);
            }

            Square.Text = "Square: " + triangle.Square().ToString();
            Perimetr.Text = "Perimetr: " + triangle.Perimetr().ToString();
        }
    }
}