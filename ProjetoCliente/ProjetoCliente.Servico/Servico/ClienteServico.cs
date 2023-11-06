using ProjetoCliente.Data.Repositorio.Interface;
using ProjetoCliente.Dominio.Dominio;
using ProjetoCliente.Servico.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCliente.Servico.Servico
{
    public class ClienteServico : IClienteServico
    {
        private readonly IClienteRepositorio _clienteRepoositorio;

        public ClienteServico(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepoositorio = clienteRepositorio;
        }

        public void AdicionaarCliente(Cliente cliente)
        {
            _clienteRepoositorio.Adicionar(cliente);
        }

        public List<Cliente> ListarClientes()
        {
            return _clienteRepoositorio.ListarClientes();
        }
    }
}
