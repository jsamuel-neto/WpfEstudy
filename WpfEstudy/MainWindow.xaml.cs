using System.Windows;
using WpfEstudy.Domain.Interface.Service;

namespace WpfEstudy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IPessoaService _service;

        public MainWindow(IPessoaService pessoaService)
        {
            _service = pessoaService;
            InitializeComponent();            
        }       

        private void Cadastro_click(object sender, RoutedEventArgs e)
        {
            Main.Content = new WpfEstudy.App.Telas.PessoaListaPage(_service);
        }
        
    }
}
