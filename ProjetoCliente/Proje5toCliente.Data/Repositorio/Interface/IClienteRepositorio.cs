using ProjetoCliente.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCliente.Data.Repositorio.Interface
{
    public interface IClienteRepositorio
    {
        void Adicionar(Cliente cliente);

        List<Cliente> ListarClientes();
    }
}
