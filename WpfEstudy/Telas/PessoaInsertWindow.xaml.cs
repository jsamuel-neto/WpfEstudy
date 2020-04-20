using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
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

            DialogResult = true;
        }
    }
}
