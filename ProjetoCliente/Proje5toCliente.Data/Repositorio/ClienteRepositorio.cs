using ProjetoCliente.Data.Contexto;
using ProjetoCliente.Data.Repositorio.Interface;
using ProjetoCliente.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCliente.Data.Repositorio
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly BancoContexto _db;

        public ClienteRepositorio(BancoContexto db)
        {
            _db = db;
        }

        public void Adicionar(Cliente cliente)
        {
            _db.Set<Cliente>().Add(cliente);
            _db.SaveChanges();
        }

        public List<Cliente> ListarClientes()
        {
            return _db.Set<Cliente>().ToList();
        }
    }
}
