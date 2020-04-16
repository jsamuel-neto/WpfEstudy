﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WpfEstudy.Domain.Entity;
using WpfEstudy.Domain.Interface.Service;
using WpfEstudy.Service.ViewModel;

namespace WpfEstudy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IPessoaService service;

        public MainWindow(IPessoaService pessoaService)
        {
            InitializeComponent();
            service = pessoaService;

            DataContext = new PessoaViewModel(service);
        }

    }
}
