using System;
using System.Windows;
using WpfEstudy.Domain.DTO;
using WpfEstudy.Domain.Interface.Service;

namespace WpfEstudy.App.Telas { 
    /// <summary>
    /// Interaction logic for PessoaInsertWindow.xaml
    /// </summary>
    public partial class PessoaInsertWindow : Window
    {
        private IPessoaService _service;

        public PessoaInsertWindow(IPessoaService service)
        {
            _service = service;
            InitializeComponent();
        }

        private void OKButtom_Click(object sender, RoutedEventArgs e)
        {
            PessoaDTO pessoa = (PessoaDTO)DataContext;
            try
            {
                if (pessoa.id != 0) { _service.Update(pessoa); } else { _service.Add(pessoa); }
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }            
        }

        private async void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            PessoaDTO pessoa = (PessoaDTO)DataContext;
            if (pessoa.id != 0)
            {
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
            }

            DialogResult = true;
        }
    }
}
