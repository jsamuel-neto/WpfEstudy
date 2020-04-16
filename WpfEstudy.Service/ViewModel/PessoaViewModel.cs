using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using WpfEstudy.Domain.Entity;
using WpfEstudy.Domain.Interface.Service;

namespace WpfEstudy.Service.ViewModel
{
    public class PessoaViewModel : BaseNotifyPropertyChanged
    {
        public ObservableCollection<Pessoa> Pessoas { get; private set; }

        public PessoaViewModel(IPessoaService service)
        {
            Task.Run(() => RetornaTodasPessoas(service));
        }

        private async Task RetornaTodasPessoas(IPessoaService service)
        {
            var dados = await service.FindAll();
            Pessoas = new ObservableCollection<Pessoa>(dados);
        }
        
    }
}
