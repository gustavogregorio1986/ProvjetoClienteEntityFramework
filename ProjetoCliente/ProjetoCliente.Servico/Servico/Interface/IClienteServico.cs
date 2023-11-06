using ProjetoCliente.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCliente.Servico.Servico.Interface
{
    public interface IClienteServico
    {
        void AdicionaarCliente(Cliente cliente);

        List<Cliente> ListarClientes();
    }
}
