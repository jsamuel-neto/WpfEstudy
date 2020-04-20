using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using WpfEstudy.Domain.DTO;
using WpfEstudy.Domain.Interface.Service;

namespace WpfEstudy.Service.ViewModel
{
    public class PessoaViewModel : BaseNotifyPropertyChanged
    {
        public ObservableCollection<PessoaDTO> Pessoas { get; private set; }

        public PessoaViewModel(IPessoaService service)
        {
            Task.Run(() => RetornaTodasPessoas(service));
        }

        private async Task RetornaTodasPessoas(IPessoaService service)
        {
            Pessoas = new ObservableCollection<PessoaDTO>(await service.FindAll());
        }
        
    }
}
