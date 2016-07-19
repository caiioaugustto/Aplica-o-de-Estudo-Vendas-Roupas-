using EstudosVendasRoupas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstudosVendasRoupas.DAO
{
    public class ClienteDAO
    {
        private Context context;

        public ClienteDAO(Context context)
        {
            this.context = context;
        }

        public void AdicionarCliente(Cliente cliente)
        {
            context.Cliente.Add(cliente);
            context.SaveChanges();
        }

        public bool VerificarCPFExistente(Cliente cliente)
        {
            Cliente clientes = context.Cliente
                .Where(a => a.CPF == cliente.CPF)
                .FirstOrDefault();

            if (clientes == null)
                return false;
            else
                return true;
        }
        public bool VerificarEmailExistente(Cliente cliente)
        {
            Cliente clientes = context.Cliente
                .Where(a => a.Email == cliente.Email)
                .FirstOrDefault();

            if (clientes == null)
                return false;
            else
                return true;
        }
    }
}