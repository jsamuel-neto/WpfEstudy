using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using WpfEstudy.Domain.DTO;
using WpfEstudy.Domain.Interface.Service;

namespace WpfEstudy.App.Telas
{
    /// <summary>
    /// Interaction logic for PessoaListaPage.xaml
    /// </summary>
    public partial class PessoaListaPage : Page
    {
        private IPessoaService _service;
        public PessoaListaPage(IPessoaService service)
        {
            _service = service;
            DataContext = new PessoaDTO();
            InitializeComponent();
        }

        private void NovoButton_Click(object sender, RoutedEventArgs e)
        {
            var pcw = new WpfEstudy.App.Telas.PessoaInsertWindow(_service);
            pcw.DataContext = new PessoaDTO();
            pcw.ShowDialog();
        }

        private async void ListaButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataContext = new { Pessoas = new ObservableCollection<PessoaDTO>(await _service.FindAll()) };
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private async void BuscaButton_Click(object sender, RoutedEventArgs e)
        {
            PessoaDTO pessoa = (PessoaDTO)DataContext;
            try
            {
                DataContext = new
                {
                    Pessoas = new ObservableCollection<PessoaDTO>
                    (await _service.Find(p => p.nome.Contains(pessoa.nome)))
                };
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void Pessoas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var pcw = new WpfEstudy.App.Telas.PessoaInsertWindow(_service);
            pcw.DataContext = (PessoaDTO)Pessoas.SelectedItem;
            pcw.ShowDialog();
        }

        private void ExitButton_Click(Object sender, RoutedEventArgs e)
        {
            NavigationService.Content = null;
            NavigationService.RemoveBackEntry();
        }
    }
}
