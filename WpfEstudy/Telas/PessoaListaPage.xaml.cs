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
            DataContext = new { Pessoas = new ObservableCollection<PessoaDTO>(await _service.FindAll()) };
        }

        private void EditarButton_Click(object sender, RoutedEventArgs e)
        {
            if (Pessoas.SelectedItem != null)
            {
                var pcw = new WpfEstudy.App.Telas.PessoaInsertWindow(_service);
                pcw.DataContext = (PessoaDTO)Pessoas.SelectedItem;
                pcw.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma Pessoa Primeiro!", "Alerta");
            }
        }

        private async void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (Pessoas.SelectedItem != null)
            {
                PessoaDTO pessoa = (PessoaDTO)Pessoas.SelectedItem;
                var msg = "Deseja Realmente Excluir " + pessoa.nome + " ?";
                MessageBoxResult result = MessageBox.Show(msg, "Deletar", MessageBoxButton.YesNo);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        try
                        {
                            await _service.Remove(pessoa.id);
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                        break;
                    case MessageBoxResult.No:
                        break;
                }

                DataContext = new { Pessoas = new ObservableCollection<PessoaDTO>(await _service.FindAll()) };
            }
            else
            {
                MessageBox.Show("Selecione uma Pessoa Primeiro!", "Alerta");
            }
        }
    }
}
